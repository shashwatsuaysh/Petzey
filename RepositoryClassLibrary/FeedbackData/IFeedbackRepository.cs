using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Data.Data.FeedbackData
{
    public interface IFeedbackRepository
    {
        IEnumerable<Feedback> GetFeedbacks();
        Feedback GetById(long id);

        bool Add(Feedback feedback);
        void Remove(int id);

    }
}
