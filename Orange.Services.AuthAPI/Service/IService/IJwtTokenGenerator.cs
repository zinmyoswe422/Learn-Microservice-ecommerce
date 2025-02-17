﻿using Orange.Services.AuthAPI.Models;

namespace Orange.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
