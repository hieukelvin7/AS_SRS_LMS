using AS_SRS_LMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Service
{
    public interface IUserRegister
    {
        List<User> GetAllUser();
        void AddUser(UserRegisterRequest request);
        void Login(UserLoginRequest request);
        void Verify(string token);
        Task ForgotPassword(MailRequest request);
        void ResetPassword(ResetPasswordRequest request);
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        string CreateRandomToken();
        void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
    }
}