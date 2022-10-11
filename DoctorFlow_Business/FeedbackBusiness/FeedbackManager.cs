using DoctorFlow_Data.Data;
using DoctorFlow_Data.Data.FeedbackData;
using DoctorFlow_Data.Entities;
using DTOSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.FeedbackBusiness
{
    public class FeedbackManager : IFeedbackManager
    {
        //IFeedbackRepository repository= new FeedbackRepository();
        IFeedbackRepository repository = FeedbackRepository.GetInstance;
        public void Add(FeedbackDto feedback)
        {

            repository.Add(
                new Feedback
                {

                    App_ID = feedback.App_ID,
                    Comp_level = feedback.Comp_level,
                    Doctor_Rating = feedback.Doctor_Rating,
                    Booking_Process = feedback.Booking_Process,
                    Outcome = feedback.Outcome
                }) ; 
            return;
        }

        public FeedbackDto GetById(long id)
        {
            Feedback feedback = repository.GetById(id);
            return new FeedbackDto
            {
                App_ID = (long)feedback.App_ID,
                Comp_level = (int)feedback.Comp_level,
                Doctor_Rating = (int)feedback.Doctor_Rating,
                Booking_Process =(int) feedback.Booking_Process,
                Outcome = (int)feedback.Outcome
            };
        }

        public IEnumerable<Feedback> GetFeedbacks()
        {
            return repository.GetFeedbacks();
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }
    }
}
