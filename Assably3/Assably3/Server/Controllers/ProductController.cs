using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assably3.Server.Service;

namespace Assably3.Server.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class ProductController : Controller
    {
        private ProductServices service;

    }
}
