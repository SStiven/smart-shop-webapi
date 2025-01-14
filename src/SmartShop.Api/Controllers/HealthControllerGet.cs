﻿using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace SmartShop.Api.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
