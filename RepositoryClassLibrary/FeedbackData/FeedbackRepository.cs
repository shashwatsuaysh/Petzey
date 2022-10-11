using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Data.Data.FeedbackData
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private static FeedbackRepository Instance = null;
        private FeedbackRepository()
        {

        }

        public static FeedbackRepository GetInstance
        {

            get
            {

                if(Instance == null)
                {
                    Instance = new FeedbackRepository();
                }
                return Instance;
            }
        }
        DoctorFlowDbContext _db = new DoctorFlowDbContext();
        public bool Add(Feedback feedback)
        {
            Feedback fd = _db.Feedbacks.Add(feedback);
            _db.SaveChanges();
            if (fd != null) return true;
            return false;
        }

        public Feedback GetById(long id)
        {
            return _db.Feedbacks.Find(id);
        }

        public IEnumerable<Feedback> GetFeedbacks()
        {
            return _db.Feedbacks;
        }

        public void Remove(int id)
        {
            Feedback feedback = _db.Feedbacks.Find(id);
          _db.Feedbacks.Remove(feedback);
            _db.SaveChanges();
            return;
        }

    }
}
