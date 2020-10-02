using System;
using System.Collections.Generic;
using System.Linq;
using Exercise.Requests;
using Exercise.Responses;
using Exercise.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Exercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DividerController : ControllerBase
    {
        private readonly IDividerService _dividerPoco;

        public DividerController(IDividerService dividerPoco)
        {
            _dividerPoco = dividerPoco;
        }

        [HttpPost]
        [Route("GetDivider")]
        public GetDividerResponse GetDivider(GetDividerRequest request)
        {
            return _dividerPoco.GetDividerNumbers(request);
        }

        [HttpPost]
        [Route("GetDividerV2")]
        public GetDividerResponse GetDividerV2(GetDividerRequest request)
        {
            return _dividerPoco.GetDividerNumbersV2(request);
        }

        [HttpPost]
        [Route("GetDividerV3")]
        public GetDividerResponse GetDividerV3(GetDividerRequest request)
        {
            return _dividerPoco.GetDividerNumbersV3(request);
        }
    }
}
