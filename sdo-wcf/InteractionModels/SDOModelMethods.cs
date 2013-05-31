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

        public Person getPerson(int id)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                        where rr.Id == id
                        select rr).First();

            return r;
        }

        public Person getPersonBySurname(string surname)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                 where rr.Surname == surname
                 select rr).First();

            return r;
        }

        public Person getPersonByEmail(string email)
        {
            DBEntities db = new DBEntities();
            Person r = new Person();

            r = (from rr in db.People
                 where rr.Email == email
                 select rr).First();

            return r;
        }

        public void addPerson(string name, string surname, bool student, string email)
        {
            DBEntities db = new DBEntities();

            Person p = new Person();

            p.Name = name;
            p.Surname = surname;
            p.Student = student;
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
