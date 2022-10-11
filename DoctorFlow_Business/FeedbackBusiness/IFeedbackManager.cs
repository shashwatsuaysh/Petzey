using DoctorFlow_Data.Entities;
using DTOSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.FeedbackBusiness
{
    public interface IFeedbackManager
    {
        IEnumerable<Feedback> GetFeedbacks();
        FeedbackDto GetById(long id);

        void Add(FeedbackDto feedback);
        void Remove(int id);
    }
}
