using ArzTiServer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ArzTiServer.Api.Controllers.impl
{
    public class ApothekeApiImpl : ApothekeApiController
    {
        private IArzTiVerwaltungService _arzTiVerwaltungService;

        public ApothekeApiImpl(IArzTiVerwaltungService arzTiVerwaltungService)
        {
            _arzTiVerwaltungService = arzTiVerwaltungService;
        }
        private IActionResult Check(Object thing)
        {
            if (thing == null)
                return NotFound();
            return Ok(thing); // T
        }

        #region GET Apo

        public async override Task<IActionResult> GetApothekeByIK([FromRoute(Name = "apoik"), Required] string apoik)
        {
            try
            {
                var thing = await _arzTiVerwaltungService.GetApothekeByIKAsync(apoik);
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }

        public async override Task<IActionResult> GetApothekenList()
        {
            try
            {
                var thing = await _arzTiVerwaltungService.GetApothekenListAsync();
                return Check(thing); // T
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return Problem(e.Message);
            }
        }


        #endregion GET Apo
    }
}