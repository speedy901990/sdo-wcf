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

        public Patient getPersonByGLID(int pss)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();
            Patient r = new Patient();

            r = (from rr in db.Patients
                 where rr.pssl == pss
                 select rr).FirstOrDefault();

            return r;
        }

        public Patient getPersonBySurname(string surname)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();
            Patient r = new Patient();

            r = (from rr in db.Patients
                 where rr.Surname == surname
                 select rr).First();
            //if(r.Any())

            return r;
        }

        public List<String> GetMatchingSurnames(string __surname)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();
            Patient p = new Patient();
            var query = from r in db.Patients
                        where r.Surname == __surname
                        select r;
            var qry = query.ToList();
            var qrarr = new List<String>();
            foreach (Patient pp in qry)
            {
                // Don't make me ever do this again.
                qrarr.Add(string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}%%%{5}%%%{6}", pp.Name, pp.Surname, pp.Email, pp.pssl, pp.Student, pp.Height, pp.Weight));
            }
            return qrarr;
        }

        public Patient getPersonByEmail(string email)
        {
            Server2DatabaseEntities db = new Server2DatabaseEntities();
            Patient r = new Patient();

            r = (from rr in db.Patients
                 where rr.Email == email
                 select rr).FirstOrDefault();

            return r;
        }
    }
}
