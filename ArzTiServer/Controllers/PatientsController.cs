using Microsoft.AspNetCore.Mvc;
using ArzTiServer.DataAccess;
using ArzTiServer.Models;
using System;
using System.Collections.Generic;

namespace ArzTiServer.Controllers
{
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IHospitalAccessProvider _dataAccessProvider;

        public PatientsController(IHospitalAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public ActionResult< IEnumerable<Patient>> Get()
        {
            var items = _dataAccessProvider.GetPatientRecords();
            return Ok(items);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Patient patient)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                patient.Id = obj.ToString();
                _dataAccessProvider.AddPatientRecord(patient);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Patient Details(string id)
        {
            return _dataAccessProvider.GetPatientSingleRecord(id);
        }

        [HttpPut]
        public IActionResult Edit([FromBody]Patient patient)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdatePatientRecord(patient);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(string id)
        {
            var data = _dataAccessProvider.GetPatientSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeletePatientRecord(id);
            return Ok();
        }
    }
}
