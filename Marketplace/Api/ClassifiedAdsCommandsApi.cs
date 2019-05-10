using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Api
{
    [Route("/ad")]
    public class ClassifiedAdsCommandsApi : Controller
    {
        public async Task<IActionResult> Post(Contracts.ClassifiedAds.V1.Create request)
        {
            //Handle the request here
            return Ok();
        }
    }
}
