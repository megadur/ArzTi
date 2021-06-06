using ArzTiServer.Api.Model;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Api.Controllers.impl
{
    public class RezeptIDListApiControllerImpl : RezeptIDListApiController
    {
        private IArzTiDatenService _arzTiDatenService;

        public RezeptIDListApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }

        private IActionResult Check(Object thing)
        {
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }

        public async override Task<IActionResult> GetRezeptIdList([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "maxnum")] int? maxnum, [FromQuery(Name = "zeitraum")] string zeitraum, [FromQuery(Name = "status")] List<string> status)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptIdListAsync(apoik, reztyp, maxnum, zeitraum);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }


        public async override Task<IActionResult> GetRezeptIdListAbholstatus([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "zeitraum")] string zeitraum)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptIdListByTransferAsync(apoik, reztyp, zeitraum);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> GetRezeptIdListPruefRes([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "zeitraum")] string zeitraum, [FromQuery(Name = "status")] List<string> status)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptIdListPruefResAsync(apoik, reztyp, zeitraum, status);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> GetRezeptIdStatusList([FromRoute(Name = "apoik"), Required] string apoik, [FromQuery(Name = "reztyp")] RezeptTyp? reztyp, [FromQuery(Name = "zeitraum")] string zeitraum, [FromQuery(Name = "abgeholt")] bool? abgeholt)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptIdStatusListAsync(apoik, reztyp, zeitraum, abgeholt);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> PatchRezeptIdListAbholstatus([FromRoute(Name = "apoik"), Required] string apoik, [FromBody] List<RezeptId> rezeptId)
        {
            try
            {
                var thing = await _arzTiDatenService.PatchRezeptIdListAbholstatusAsync(apoik, rezeptId);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> PatchRezeptIdListStatus([FromRoute(Name = "apoik"), Required] string apoik, [FromBody] List<RezeptStatus> rezeptStatus)
        {
            try
            {
                var thing = await _arzTiDatenService.PatchRezeptIdListStatusAsync(apoik, rezeptStatus);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> PutRezeptIdListPruefung([FromRoute(Name = "apoik"), Required] string apoik, [FromBody] List<RezeptId> rezeptId)
        {
            try
            {
                await _arzTiDatenService.PutRezeptIdListPruefungAsync(apoik, rezeptId);
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