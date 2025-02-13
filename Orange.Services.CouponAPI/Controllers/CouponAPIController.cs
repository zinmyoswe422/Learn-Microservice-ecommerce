using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Orange.Services.CouponAPI.Data;
using Orange.Services.CouponAPI.Models;
using Orange.Services.CouponAPI.Models.Dto;


namespace Orange.Services.CouponAPI.Controllers
{
	//[Route("api/[controller]")]
	[Route("api/coupon")]
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
				Coupon obj2 = _db.Coupons.First(u => u.CouponId == id);
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

		[HttpGet]
		[Route("GetZinByCode/{code}")]
		public ResponseDto GetZinByCode(string code)
		{
			try
			{
				Coupon zinobj2 = _db.Coupons.First(u => u.CouponCode.ToLower() == code.ToLower());
				_response.Result = _mapper.Map<CouponDto>(zinobj2);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}


		[HttpPost]
		//[Route("AddCoupon")]
		public ResponseDto Post([FromBody] CouponDto couponDto)
		{
			try
			{
				Coupon zinobj2 = _mapper.Map<Coupon>(couponDto);
				_db.Coupons.Add(zinobj2);
				_db.SaveChanges();


				_response.Result = _mapper.Map<CouponDto>(zinobj2);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpPut]
		//[Route("UpdateCoupon")]
		public ResponseDto Put([FromBody] CouponDto couponDto)
		{
			try
			{
				Coupon zinobj2 = _mapper.Map<Coupon>(couponDto);
				_db.Coupons.Update(zinobj2);
				_db.SaveChanges();


				_response.Result = _mapper.Map<CouponDto>(zinobj2);
			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;
		}

		[HttpDelete]
		//[Route("DeleteCoupon")]
		public ResponseDto Delete(int id)
		{
			try
			{
				Coupon zinobj2 = _db.Coupons.First(u => u.CouponId == id);
				_db.Coupons.Remove(zinobj2);
				_db.SaveChanges();



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
