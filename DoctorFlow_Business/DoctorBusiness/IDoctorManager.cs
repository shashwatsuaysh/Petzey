using DoctorFlow_Data.Entities;
using DTOSLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.DoctorBusiness
{
    public interface IDoctorManager
    {

        List<Doctor> GetDoctors();
        DoctorDto GetDoctorById(long id);
        void Delete(int id);
        void Update(Doctor doctor);

        void Add(DoctorDto doctor);


    }
}
