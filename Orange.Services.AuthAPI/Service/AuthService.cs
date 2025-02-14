using Microsoft.AspNetCore.Identity;
using Orange.Services.AuthAPI.Data;
using Orange.Services.AuthAPI.Models;
using Orange.Services.AuthAPI.Models.Dto;
using Orange.Services.AuthAPI.Service.IService;

namespace Orange.Services.AuthAPI.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(AppDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Register(RegisterationRequestDto registerationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
