using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //.../api/user
    public class UserController : Controller
    {
        private readonly DataContext _context;
       
        public UserController(DataContext context)
        {
            _context = context;
            
        }
    }
}