﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Application.Interfaces.Services;
using OnionArcExample.Domain.Entities;
using OnionArcExample.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArcExample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SH_UserController : ControllerBase
    {
        readonly IUserRepository _sh_userRepository;
        readonly IEmailService _emailService;
        
        public SH_UserController(IUserRepository sh_userRepository, IEmailService emailService)
        {
            _sh_userRepository = sh_userRepository;
            _emailService = emailService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<SH_User> users = await _sh_userRepository.GetAsync();
            var cnm = users.FirstOrDefault().City.Name;
            return Ok(users);
        }

        
    }
}