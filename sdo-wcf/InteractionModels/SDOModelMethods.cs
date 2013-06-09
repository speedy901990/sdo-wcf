using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ten plik wykorzystuje metody łączenia z bazą lokalną DODANĄ DO PROJEKTU.
// W przeciwieństwie do tego drugiego, ścieżka nie jest ustalona na sztywno, a sam projekt 
// staje się przenośny. Tylko trzeba pamiętać, że w ten sposób zmiany się nie zapisują ;)
// To jest dobre do debugowania, ale można się nieźle zdziwić.
//          -- Kamil

// Powyższy komentarz to bzdura
//          -- Też Kamil

namespace sdo_wcf.InteractionModels
{
    class SDOModelMethods
    {
        public List<Person> GetListOfPeople()
        {
            DBEntities db = new DBEntities();

            var query = from p in db.People
                        select p;

            return query.ToList();
        }

        public List<String> GetMatchingSurnames(string __surname)
        {
            DBEntities db = new DBEntities();
            Person p = new Person();
            var query = from r in db.People
                        where r.Surname == __surname
                        select r;
            var qry = query.ToList();
            var qrarr = new List<String>();
            foreach (Person pp in qry)
            {
                // Don't make me ever do this again.
                qrarr.Add(string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}", pp.Name, pp.Surname, pp.Email, pp.pssl, pp.Student));
            }
            return qrarr;           
        }

        public List<String> LeakMe()
        {
            DBEntities db = new DBEntities();
            Person p = new Person();
            var query = from r in db.People
                        select r;
            var qry = query.ToList();
            var qrarr = new List<String>();
            foreach (Person pp in qry)
            {
                // Don't make me ever do this again.
                qrarr.Add(string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}%%%{5}", pp.Id, pp.Name, pp.Surname, pp.Email, pp.pssl, pp.Student));
            }
            return qrarr;
        }

        public Person getPerson(int id)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                 where rr.Id == id
                 select rr).First();

            return r;
        }

        public Person getPersonByGLID(int pss)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                        where rr.pssl == pss
                        select rr).FirstOrDefault();

            return r;
        }

        public Person getPersonBySurname(string surname)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                 where rr.Surname == surname
                 select rr).First();
            //if(r.Any())

            return r;
        }

        public Person getPersonByEmail(string email)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                 where rr.Email == email
                 select rr).FirstOrDefault();

            return r;
        }

        public void addPerson(string name, string surname, bool student, string pld, string email)
        {
            DBEntities db = new DBEntities();

            Person p = new Person();

            p.Name = name;
            p.Surname = surname;
            p.Student = student;
            p.pssl = Convert.ToInt32(pld);
            p.Email = email;

            db.People.Add(p);
            db.SaveChanges();
        }

        public void deletePerson(int id)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                 where rr.Id == id
                 select rr).First();

            db.People.Remove(r);
            db.SaveChanges();
        }

        public void updatePerson(int id, string imie, string nazwisko, bool etat, string email)
        {
            DBEntities db = new DBEntities();

            Person r = (from rr in db.People
                        where rr.Id == id
                        select rr).First();

            r.Name = imie;
            r.Surname = nazwisko;
            r.Student = etat;
            r.Email = email;

            db.SaveChanges();
        }
    }
}
