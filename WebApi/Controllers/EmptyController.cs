using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/staticName")] // api/empty
    [ApiController]
    public class EmptyController : ControllerBase
    {
    }
}