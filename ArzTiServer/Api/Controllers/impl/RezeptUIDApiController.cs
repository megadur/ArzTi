using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Api.Controllers.impl
{
    public class RezeptUIDApiControllerImpl : RezeptUIDApiController
    {
        private IArzTiDatenService _arzTiDatenService;

        public RezeptUIDApiControllerImpl(IArzTiDatenService arzTiDatenService)
        {
            _arzTiDatenService = arzTiDatenService;
        }
        private IActionResult Check(Object thing)
        {
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }
        public async override Task<IActionResult> DeleteRezeptUId([FromRoute(Name = "ruid"), Required] string ruid)
        {
            try
            {
                var thing = await _arzTiDatenService.DeleteRezeptUIdAsync(ruid);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> GetRezeptUId([FromRoute(Name = "ruid"), Required] string ruid)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptUIdAsync(ruid);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> GetRezeptUIdStatus([FromRoute(Name = "ruid"), Required] string ruid)
        {
            try
            {
                var thing = await _arzTiDatenService.GetRezeptUIdStatusAsync(ruid);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> PatchRezeptUIdStatus([FromRoute(Name = "ruid"), Required] string ruid, [FromQuery(Name = "status"), Required] string status)
        {
            try
            {
                var thing = await _arzTiDatenService.PatchRezeptUIdStatusAsync(ruid, status);
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