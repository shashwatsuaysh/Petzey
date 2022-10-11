using DoctorFlow_Business.FeedbackBusiness;
using DoctorFlow_Data.Data;
using DoctorFlow_Data.Data.FeedbackData;
using DoctorFlow_Data.Entities;
using DTOSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public class FeedbackController : ApiController
    {



        IFeedbackManager feedbackManager = new FeedbackManager();
        // GET: Feedback
        [HttpGet]

        [Route("api/feedbacks")]

        public IHttpActionResult GetFeedbacks()
        {
            var feedbacks = feedbackManager.GetFeedbacks();
            if (feedbacks == null) return NotFound();



            else
            {
                return Ok(feedbacks);
            }
        }



        [HttpGet]
        [Route("api/feedbacks/{id}")]
        public IHttpActionResult GetFeedbackById(int id)
        {
            var feedback = feedbackManager.GetById(id);
            if (feedback == null) return NotFound();
            else
            {
                return Ok(feedback);
            }
        }




        [HttpPost]
        [Route("api/feedbacks")]
        public IHttpActionResult Post(FeedbackDto feedback)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Input");
            }
            else
            {
                feedbackManager.Add(feedback);
            }
            return Ok();
        }


        [HttpDelete]
        [Route("api/feedbacks/{id}")]
        public IHttpActionResult Delete(int id)
        {
            FeedbackDto feedback = feedbackManager.GetById(id);
            if (feedback == null)
            {
                return NotFound();
            }

            feedbackManager.Remove(id);
            return Ok();



        }









    }
}