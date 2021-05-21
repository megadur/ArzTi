using ArzTiServer.Models;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArzTiServer.Controllers.impl
{
    public class RezeptUIDListApiControllerImpl : RezeptUIDListApiController
    {
        IArzTiDatenService _arzTiDatenService;
        public RezeptUIDListApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }

        public async override Task<IActionResult> PatchRezeptUIdListAbholstatus([FromBody] List<RezeptUId> rezeptUId)
        {
            var thing = await _arzTiDatenService.PatchRezeptUIdListStatusAsync((IEnumerable<RezeptStatus>)rezeptUId);
            if (thing == null)
                return NotFound();
            return Ok(thing); // T

        }

        public async override Task<IActionResult> PatchRezeptUIdListStatus([FromBody] List<RezeptStatus> rezeptStatus)
        {
            await _arzTiDatenService.PatchRezeptUIdListStatusAsync(rezeptStatus);
            return StatusCode(200);
        }

        public async override Task<IActionResult> PutRezeptUidListPruefung([FromBody] List<RezeptUId> rezeptUId)
        {
            await _arzTiDatenService.PutRezeptUidListPruefungAsync(rezeptUId);
            return StatusCode(200);
        }
    }
}
