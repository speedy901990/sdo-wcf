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
    class SDOLocalMethods1
    {
        public List<Person> GetListOfPeople()
        {
            Database01EntitiesLocal db = new Database01EntitiesLocal();

            var query = from p in db.Person
                        select p;

            return query.ToList();
        }

        public Person getPerson(int id)
        {
            Database01EntitiesLocal db = new Database01EntitiesLocal();

            Person r = (from rr in db.Person
                        where rr.Id == id
                        select rr).First();

            return r;
        }

        public void addPerson(string name, string surname, bool student, string email)
        {
            Database01EntitiesLocal db = new Database01EntitiesLocal();

            Person p = new Person();

            p.Name = name;
            p.Surname = surname;
            p.Student = student;
            p.Email = email;

            db.Person.Add(p);
            db.SaveChanges();
        }

        public void deletePerson(int id)
        {
            Database01EntitiesLocal db = new Database01EntitiesLocal();
            Person r = new Person();

            r = (from rr in db.Person
                 where rr.Id == id
                 select rr).First();

            db.Person.Remove(r);
            db.SaveChanges();
        }

        public void updatePerson(int id, string imie, string nazwisko, bool etat, string email)
        {
            Database01EntitiesLocal db = new Database01EntitiesLocal();

            Person r = (from rr in db.Person
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
