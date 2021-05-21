using ArzTiServer.Models;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers.impl
{
    public class RezeptIDApiControllerImpl : RezeptIDApiController
    {
        IArzTiDatenService _arzTiDatenService;
        public RezeptIDApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }
        public async override Task<IActionResult> DeleteRezeptId([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid)
        {
            var thing = await _arzTiDatenService.DeleteRezeptIdAsync(apoik, reztyp, rezid);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> GetRezeptId([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid)
        {
            var thing = await _arzTiDatenService.GetRezeptIdAsync(apoik, reztyp, rezid);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }

        public async override Task<IActionResult> GetRezeptIdStatus([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid)
        {
            var thing = await _arzTiDatenService.GetRezeptIdStatusAsync(apoik, reztyp, rezid);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }

        public async override Task<IActionResult> PatchRezeptIdStatus([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid, [FromQuery(Name = "status"), Required] string status)
        {
            var thing = await _arzTiDatenService.PatchRezeptIdStatusAsync(apoik, reztyp, rezid, status);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }
    }
}
