using DoctorFlow_Data.Data;
using DoctorFlow_Data.Entities;
using DTOSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.DoctorBusiness
{
    public class DoctorManager : IDoctorManager
    {
        //IDoctorRepository repository = new DoctorRepository();
        IDoctorRepository repository = DoctorRepository.GetRepository;
        public void Delete(int id)
        {
            repository.Remove(id);
        }

        public void Add(DoctorDto doc)
        {
            repository.Add(new Doctor
            {
                DoctorName = doc.DoctorName,
                Clinic = doc.Clinic,
                Mobile = doc.Mobile,
                Email = doc.Email,
                NPI = doc.NPI,
                Image = doc.Image,
                Speciality = doc.Speciality
            });
            return;
        }

        public DoctorDto GetDoctorById(long id)
        {
            Doctor doc = repository.GetById(id);
            return new DoctorDto
            {
                DoctorName = doc.DoctorName,
                Clinic = doc.Clinic,
                Mobile = doc.Mobile,
                Email = doc.Email,
                NPI = doc.NPI,
                Image = doc.Image,
                Speciality = doc.Speciality
            };
        }

      

        public List<Doctor> GetDoctors()
        {
            List<Doctor> dtos = new List<Doctor>();
            return repository.GetDoctors().ToList();

        }

        public void Update(Doctor doctor)
        {
            repository.Edit(doctor);
        }
    }
}
