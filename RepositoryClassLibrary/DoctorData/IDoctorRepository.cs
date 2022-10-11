using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Data.Data
{
    public interface IDoctorRepository
    {

        IEnumerable<Doctor> GetDoctors();
        Doctor GetById(long id);

        bool Add(Doctor doctor);
        Doctor GetByName(string name);

        void Remove(int id);

        void Edit(Doctor doctor);


    }
}
