using ArzTiServer.Models;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers.impl
{
    public class RezeptUIDApiControllerImpl : RezeptUIDApiController
    {
        IArzTiDatenService _arzTiDatenService;
        public RezeptUIDApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }

        public async override Task<IActionResult> DeleteRezeptUId([FromRoute(Name = "ruid"), Required] string ruid)
        {
            var thing = await _arzTiDatenService.DeleteRezeptUIdAsync(ruid);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> GetRezeptUId([FromRoute(Name = "ruid"), Required] string ruid)
        {
            var thing = await _arzTiDatenService.GetRezeptUIdAsync(ruid);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> GetRezeptUIdStatus([FromRoute(Name = "ruid"), Required] string ruid)
        {
            var thing = await _arzTiDatenService.GetRezeptUIdStatusAsync(ruid);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> PatchRezeptUIdStatus([FromRoute(Name = "ruid"), Required] string ruid, [FromQuery(Name = "status"), Required] string status)
        {
            var thing = await _arzTiDatenService.PatchRezeptUIdStatusAsync(ruid, status);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }
    }
}
