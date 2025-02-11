using Orange.Web.Models;

namespace Orange.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendSync(RequestDto requestDto);
    }
}
