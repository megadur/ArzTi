using ArzTiServer.Api.Model;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArzTiServer.Api.Controllers.impl
{
    public class RezeptUIDListApiControllerImpl : RezeptUIDListApiController
    {
        private IArzTiDatenService _arzTiDatenService;

        public RezeptUIDListApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }

        private IActionResult Check(Object thing)
        {
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }
        public async override Task<IActionResult> PatchRezeptUIdListAbholstatus([FromBody] List<RezeptUId> rezeptUId)
        {
            try
            {
                var thing = await _arzTiDatenService.PatchRezeptUIdListStatusAsync((IEnumerable<RezeptStatus>)rezeptUId);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> PatchRezeptUIdListStatus([FromBody] List<RezeptStatus> rezeptStatus)
        {
            try
            {
                await _arzTiDatenService.PatchRezeptUIdListStatusAsync(rezeptStatus);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> PutRezeptUidListPruefung([FromBody] List<RezeptUId> rezeptUId)
        {
            try
            {
                await _arzTiDatenService.PutRezeptUidListPruefungAsync(rezeptUId);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }
    }
}