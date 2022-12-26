﻿using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
  [Route("")]
  public IActionResult Index()
  {
    //Health check
    return Ok();
  }
}