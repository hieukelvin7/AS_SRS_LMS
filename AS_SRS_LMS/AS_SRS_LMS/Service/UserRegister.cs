using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using System.Net.Mail;
using System.Security.Cryptography;

using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Security;

namespace AS_SRS_LMS.Service
{
    public class UserRegister : IUserRegister
    {
        private readonly DataContext _context;
        private readonly IMailService _mailService;
        private readonly MailSettings _mailSettings;
        public UserRegister(DataContext context, IOptions<MailSettings> mailSettings)
        {
            _context = context;
            _mailSettings = mailSettings.Value;
        }
        public void AddUser(UserRegisterRequest request)
        {
            CreatePasswordHash(request.Password,
                 out byte[] passwordHash,
                 out byte[] passwordSalt);
            var user = new User
            {
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                RoleId = request.RoleId,
                VerificationToken = CreateRandomToken()
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public async Task ForgotPassword(MailRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == request.ToEmail && u.PhoneNumber == request.PhoneNumber);      
            user.PasswordResetToken = CreateRandomToken();
            user.ResetTokenExpires = DateTime.Now.AddDays(1);
            _context.SaveChanges();

            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(request.ToEmail));
            email.Subject = "Mã OTP";

            var builder = new BodyBuilder();
            builder.HtmlBody = $"Mã OTP của bạn là: <b>{user.PasswordResetToken}</b>";
            email.Body = builder.ToMessageBody();
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public void Login(UserLoginRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == request.Email);
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

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        public string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
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
