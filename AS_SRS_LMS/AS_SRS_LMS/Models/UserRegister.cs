using AS_SRS_LMS.Data;
using System.Net;
using System.Security.Cryptography;

namespace AS_SRS_LMS.Models
{
    public class UserRegister : IUserRegister
    {
        private readonly DataContext _context;
        public UserRegister(DataContext context)
        {
            _context = context;
        }

        public void AddUser(UserRegisterRequest request)
        {
        
            CreatePasswordHash(request.Password,
                 out byte[] passwordHash,
                 out byte[] passwordSalt);
            var user = new User
            {
                Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleId = request.RoleId,
                VerificationToken = CreateRandomToken()
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void ForgotPassword(string email)
        {
            var user =  _context.Users.FirstOrDefault(u => u.Email == email);
            //Error not found user
            //-------------//
            //
            user.PasswordResetToken = CreateRandomToken();
            user.ResetTokenExpires = DateTime.Now.AddDays(1);
            _context.SaveChanges();       
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public void Login(UserLoginRequest request)
        {
            
            var user =  _context.Users.FirstOrDefault(u => u.Email == request.Email);
            if (user == null)
            {
               //User not found chua lam
            }

            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                //
            }

            if (user.VerifiedAt == null)
            {
                //Chua verify
            }
        }

        public void ResetPassword(ResetPasswordRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.PasswordResetToken == request.Token);
            if (user == null || user.ResetTokenExpires < DateTime.Now)
            {
                //invalid token
            }

            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.PasswordResetToken = null;
            user.ResetTokenExpires = null;

            _context.SaveChanges();

        }

        public void Verify(string token)
        {
            var user = _context.Users.FirstOrDefault(u => u.VerificationToken == token);
            if (user == null)
            {
               //invalid token
            }

            user.VerifiedAt = DateTime.Now;
             _context.SaveChangesAsync();
        
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }   
}
