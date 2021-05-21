
using ArzTiServer.Controllers;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers.impl
{
    public class ApothekeApiImpl : ApothekeApiController
    {
        IArzTiVerwaltungService _arzTiVerwaltungService;
        public ApothekeApiImpl(IArzTiVerwaltungService arzTiVerwaltungService)
        {
            _arzTiVerwaltungService = arzTiVerwaltungService;
        }

        public async override Task<IActionResult> GetApothekeByIK([FromRoute(Name = "apoik"), Required] string apoik)
        {
            var thing = await _arzTiVerwaltungService.GetApothekeByIKAsync(apoik);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> GetApothekenList()
        {
            var thing = await _arzTiVerwaltungService.GetApothekenListAsync();
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }


        #region GET Apo
        /*
        public IActionResult GetApothekenList()
        {
            var thing = _arzTiVerwaltungService.GetApothekenListAsync());

        }
        
        public override IActionResult GetApothekeByIK(string apoik)
        {
            var x = _arzTiVerwaltungService.GetApothekeByIKAsync(apoik);
            return Ok(x);

        }
         */
        /*
*/
        #endregion


    }
}
