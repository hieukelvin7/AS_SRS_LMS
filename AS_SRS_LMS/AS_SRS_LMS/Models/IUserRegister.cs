using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Models
{
    public interface IUserRegister
    {
        List<User> GetAllUser();
        void AddUser(UserRegisterRequest request);
        void Login(UserLoginRequest request);
        void Verify(string token);
        void ForgotPassword(string email);
        void ResetPassword(ResetPasswordRequest request);
    }
}