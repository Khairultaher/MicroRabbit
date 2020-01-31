using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MicroRabbit.Tranfer.API.Models;
using MicroRabbit.Transfer.Domain.Models;
using System.Runtime.CompilerServices;
using MicroRabbit.Transfer.Services.Interfaces;

namespace MicroRabbit.Tranfer.API.Controllers
{
    [Route("transfer")]
    [ApiController]
    public class TranferController : ControllerBase
    {

        private readonly ITransferService _transferService;
        public TranferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
