using Orange.Services.AuthAPI.Models.Dto;

namespace Orange.Services.AuthAPI.Service.IService
{
    public interface IAuthService
    {
        Task<UserDto> Register(RegisterationRequestDto registerationRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
