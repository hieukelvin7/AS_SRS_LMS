using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUserRegister _userRegister;
        public UserController(IUserRegister userRegister, DataContext context)
        {
            _userRegister = userRegister;
            _context = context;
        }
        [HttpGet("get-all-user")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userRegister.GetAllUser();        
            return Ok(users);
        }
        [HttpPost("register")]
        public IActionResult Register(UserRegisterRequest request)
        {
            _userRegister.AddUser(request);
            return Ok(new { message = "User created" });
        }
        [HttpPost("verify")]
        public IActionResult Verify(string token)
        {
            _userRegister.Verify(token);
            return Ok(new { message = "Verify Successful !" });
        }
        [HttpPost("login")]
        public IActionResult Login(UserLoginRequest request)
        {           

            _userRegister.Login(request);         
            return Ok(new { message = "Login Successful !" });
        }
        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword(string email)
        {
            _userRegister.ForgotPassword(email);
            return Ok(new { message = "You may now reset your password.." });
        }
        [HttpPost("reset-password")]
        public IActionResult ResettPassword(ResetPasswordRequest request)
        {
            _userRegister.ResetPassword(request);
            return Ok(new { message = "Reset Successful !!!" });
        }
    }
}
