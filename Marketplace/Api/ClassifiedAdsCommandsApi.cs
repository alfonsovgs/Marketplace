using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Api
{
    [ApiController]
    [Route("/ad")]
    public class ClassifiedAdsCommandsApi : Controller
    {
        private readonly ClassifiedAdApplicationService _applicationService;

        public ClassifiedAdsCommandsApi(ClassifiedAdApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost]
        public IActionResult Post(Contracts.ClassifiedAds.V1.Create request)
        {
            _applicationService.Handle(request);
            return Ok();
        }
    }
}
