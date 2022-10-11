using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Data.Data
{
    public class DoctorRepository : IDoctorRepository
    {
        private DoctorRepository() { }

        private static DoctorRepository Instance = null;
        public static DoctorRepository GetRepository
        {

            get
            {
                if(Instance == null)
                {
                    Instance = new DoctorRepository();
                }
                return Instance;
            }
        }
        
        private DoctorFlowDbContext _db = new DoctorFlowDbContext();
        public bool Add(Doctor doctor)
        {
           Doctor doc = _db.Doctors.Add(doctor);
            _db.SaveChanges();
            if (doc != null) return true;
            return false;
        }

        public void Edit(Doctor doctor)
        {

            _db.Doctors.AddOrUpdate(doctor);
            _db.SaveChanges();


        }

       

        public Doctor GetById(long id)
        {
            return _db.Doctors.FirstOrDefault(d => d.DoctorID == id);

        }

        public Doctor GetByName(string name)
        {
            return _db.Doctors.FirstOrDefault(d => d.DoctorName == name);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _db.Doctors;
        }

        public void Remove(int id)
        {
            Doctor doctor = _db.Doctors.FirstOrDefault(d => d.DoctorID == id);
             _db.Doctors.Remove(doctor);
            _db.SaveChanges();
            return;
        }
    }
}
