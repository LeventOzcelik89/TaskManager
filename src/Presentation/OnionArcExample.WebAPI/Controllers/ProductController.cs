using Microsoft.AspNetCore.Http;
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
    public class ProductController : ControllerBase
    {
        readonly IProductRepository _productRepository;
        readonly IEmailService _emailService;
        public ProductController(IProductRepository productRepository, IEmailService emailService)
        {
            _productRepository = productRepository;
            _emailService = emailService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> allProducts = await _productRepository.GetAsync();
            return Ok(allProducts);
        }
        [HttpGet("sendemail")]
        public IActionResult SendEmail()
        {
            bool result = _emailService.Send("gncy@gencayyildiz.com", "laylaylom galiba sana göre sevmeler...");
            return Ok(result);
        }
    }
}
