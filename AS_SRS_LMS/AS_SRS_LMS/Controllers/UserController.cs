using AS_SRS_LMS.Data;
using AS_SRS_LMS.Models;
using AS_SRS_LMS.Service;
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
            if (_context.Users.Any(u => u.Email == request.Email))
            {
                return BadRequest("User already exists.");
            }
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
            
            var user = _context.Users.FirstOrDefault(u => u.Email == request.Email);
            var pass = _userRegister.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt);
            if (user == null)
            {
                return BadRequest("User not found.");
            }
            if (!pass)
            {
                return BadRequest("Password is incorrect.");
            }

            if (user.VerifiedAt == null)
            {
                return BadRequest("Not verified!");
            }
            _userRegister.Login(request);         
            return Ok(new { message = "Welcome " + user.FirstName +" "+  user.LastName });
        }
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromForm] MailRequest request)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == request.ToEmail && u.PhoneNumber == request.PhoneNumber);
            if(user == null)
            {
                return BadRequest("Email or Phone not found");
            }
            await _userRegister.ForgotPassword(request);
            return Ok(new { message = "Please check your email to get OTP " });
        }
        [HttpPost("reset-password")]
        public IActionResult ResettPassword(ResetPasswordRequest request)
        {
            _userRegister.ResetPassword(request);
            return Ok(new { message = "Reset Successful !!!" });
        }
    }
}
