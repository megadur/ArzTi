using ArzTiServer.Api.Model;
using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Api.Controllers.impl
{
    public class RezeptIDApiControllerImpl : RezeptIDApiController
    {
        private IArzTiDatenService _arzTiDatenService;

        public RezeptIDApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }
        private IActionResult Check(Object thing)
        {
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }
        public async override Task<IActionResult> DeleteRezeptId([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid)
        {
            try
            {
                var thing = await _arzTiDatenService.DeleteRezeptIdAsync(apoik, reztyp, rezid);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> GetRezeptId([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptIdAsync(apoik, reztyp, rezid);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> GetRezeptIdStatus([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptIdStatusAsync(apoik, reztyp, rezid);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> PatchRezeptIdStatus([FromRoute(Name = "apoik"), Required] string apoik, [FromRoute(Name = "reztyp"), Required] RezeptTyp reztyp, [FromRoute(Name = "rezid"), Required] string rezid, [FromQuery(Name = "status"), Required] string status)
        {
            try
            {
                var thing = await _arzTiDatenService.PatchRezeptIdStatusAsync(apoik, reztyp, rezid, status);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }
    }
}