using DoctorFlow_Business.DoctorBusiness;
using DoctorFlow_Data.Data;
using DoctorFlow_Data.Entities;
using DTOSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;



namespace DoctorFlow_UI.Controllers
{
    public class DoctorController : ApiController
    {
        IDoctorManager doctorManager = new DoctorManager();
        


        [HttpGet]
        [Route("api/doctors")]
        public IHttpActionResult GetDoctors()
        {
            var doctors = doctorManager.GetDoctors();
            if (doctors == null) return NotFound();



            else
            {
                return Ok(doctors);
            }
        }


        [HttpGet]
        [Route("api/doctors/{id}")]
        public IHttpActionResult GetDoctorById(int id)
        {
            var doctor = doctorManager.GetDoctorById(id);
            if (doctor == null) return NotFound();
            else
            {
                return Ok(doctor);
            }
        }

        [HttpGet]

        [Route("api/doctors/name/{name}")]
        public IHttpActionResult GetDoctorByName(string name)
        {
            var data = from d in doctorManager.GetDoctors() where d.DoctorName == name select d;
            if (data == null) return NotFound();
            return Ok(data);
        }

        [HttpPost]
        [Route("api/doctors")]
        
        public IHttpActionResult Post(DoctorDto doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Input");
            }
            else
            {
                doctorManager.Add(doctor);
            }
            return Ok();
        }


        [HttpDelete]
        [Route("api/doctors/{id}")]
        public IHttpActionResult Delete(int id)
        {
       

            doctorManager.Delete(id);
            return Ok();

        }



        [HttpPut]
       // [Route("api/doctors/{doctor}")]
        public IHttpActionResult Edit(Doctor doctor)
        {
            if (doctor == null)
            {
                return BadRequest("Invalid data");
            }

            doctorManager.Update(doctor);
            return Ok();

        }






    }
}