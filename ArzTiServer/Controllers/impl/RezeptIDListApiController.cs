using ArzTiServer.Models;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers.impl
{
    public class RezeptIDListApiControllerImpl : RezeptIDListApiController
    {
        IArzTiDatenService _arzTiDatenService;
        public RezeptIDListApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }
        public async override Task<IActionResult> GetRezeptIdList([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "maxnum")] int? maxnum, [FromQuery(Name = "zeitraum")] string zeitraum, [FromQuery(Name = "status")] List<string> status)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptIdListAsync(apoik, reztyp, maxnum, zeitraum);
                if (thing == null)
                    return NotFound();
                return Ok(thing); // T

            }
            catch (Exception e)
            {
                return UnprocessableEntity();
            }

        }

        public async override Task<IActionResult> GetRezeptIdListAbholstatus([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "zeitraum")] string zeitraum)
        {
            var thing = await _arzTiDatenService.GetRezeptIdListByTransferAsync(apoik, reztyp, zeitraum);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> GetRezeptIdListPruefRes([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "zeitraum")] string zeitraum, [FromQuery(Name = "status")] List<string> status)
        {
            var thing = await _arzTiDatenService.GetRezeptIdListPruefResAsync(apoik, reztyp, zeitraum, status);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> GetRezeptIdStatusList([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "zeitraum")] string zeitraum)
        {
            var thing = await _arzTiDatenService.GetRezeptIdStatusListAsync(apoik, reztyp, zeitraum);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> PatchRezeptIdListAbholstatus([FromRoute(Name = "apoik"), Required] string apoik, [FromBody] List<RezeptId> rezeptId)
        {
            var thing = await _arzTiDatenService.PatchRezeptIdListAbholstatusAsync(apoik, rezeptId);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> PatchRezeptIdListStatus([FromRoute(Name = "apoik"), Required] string apoik, [FromBody] List<RezeptStatus> rezeptStatus)
        {
            var thing = await _arzTiDatenService.PatchRezeptIdListStatusAsync(apoik, rezeptStatus);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> PutRezeptIdListPruefung([FromRoute(Name = "apoik"), Required] string apoik, [FromBody] List<RezeptId> rezeptId)
        {
            await _arzTiDatenService.PutRezeptIdListPruefungAsync(apoik, rezeptId);
            return StatusCode(200);
        }
    }
}
