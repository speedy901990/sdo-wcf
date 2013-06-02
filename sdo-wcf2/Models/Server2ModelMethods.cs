using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdo_wcf2.Models
{
    class Server2ModelMethods
    {
        public List<Patient> GetListOfPatients()
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();

            var query = from p in db.Patients
                        select p;

            return query.ToList();
        }

        public Patient getPatient(int id)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();
            Patient p = new Patient();

            p = (from rr in db.Patients
                 where rr.Id == id
                 select rr).First();

            return p;
        }

        public void addPatient(string name, string surname, bool student, string email, float height, float weight)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();

            Patient p = new Patient();

            p.Name = name;
            p.Surname = surname;
            p.Student = student;
            p.Email = email;
            p.Weight = weight;
            p.Height = height;

            db.Patients.Add(p);
            db.SaveChanges();
        }

        public void deletePatient(int id)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();
            Patient p = new Patient();

            p = (from rr in db.Patients
                 where rr.Id == id
                 select rr).First();

            db.Patients.Remove(p);
            db.SaveChanges();
        }

        public void updatePatient(int id, string imie, string nazwisko, bool etat, string email, float height, float weight)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();

            Patient p = (from rr in db.Patients
                        where rr.Id == id
                        select rr).First();

            p.Name = imie;
            p.Surname = nazwisko;
            p.Student = etat;
            p.Email = email;
            p.Weight = weight;
            p.Height = height;

            db.SaveChanges();
        }
    }
}
