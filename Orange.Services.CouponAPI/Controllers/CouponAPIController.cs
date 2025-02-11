using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Orange.Services.CouponAPI.Data;
using Orange.Services.CouponAPI.Models;
using Orange.Services.CouponAPI.Models.Dto;


namespace Orange.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _response;
        private IMapper _mapper;

        public CouponAPIController(AppDbContext db, IMapper mapper) 
        {
           _db = db;
           _mapper = mapper;
           _response = new ResponseDto();
        }

        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                IEnumerable<Coupon> objList2 = _db.Coupons.ToList();
                _response.Result = objList2;
                _response.Result = _mapper.Map<IEnumerable<CouponDto>>(objList2);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto Get(int id)
        {
            try
            {
                Coupon obj2 = _db.Coupons.First(u=>u.CouponId==id);
                _response.Result = obj2;
                _response.Result = _mapper.Map<CouponDto>(obj2);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
