
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
        IArzTiDatenService _arzTiDatenService;
        IArzTiVerwaltungService _arzTiVerwaltungService;
        public ApothekeApiImpl(IArzTiDatenService arzTiDatenService, IArzTiVerwaltungService arzTiVerwaltungService)
        {
            _arzTiDatenService = arzTiDatenService;
            _arzTiVerwaltungService = arzTiVerwaltungService;
        }

        public override Task<IActionResult> GetApothekeByIK([FromRoute(Name = "apoik"), Required] string apoik)
        {
            throw new System.NotImplementedException();
        }

        public async override Task<IActionResult> GetApothekenList()
        {
            //return await _arzTiVerwaltungService.GetApothekenListAsync();
            return StatusCode(200, await _arzTiVerwaltungService.GetApothekenListAsync());

        }


        #region GET Apo
        /*
        public IActionResult GetApothekenList()
        {
            return StatusCode(200, _arzTiVerwaltungService.GetApothekenListAsync());

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
