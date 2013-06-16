using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using sdo_wcf.InteractionModels;

namespace sdo_wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public VectorClock service1VC = new VectorClock("logService1VectorClock.log");

        public string GetData(int id, bool mod)
        {
            //return string.Format("You entered: {0}", id);
            //TODO zwracanie obiektu zawierajacego dane

            SDOModelMethods sdomm = new SDOModelMethods();
            Person p = new Person();
            if (mod == false)
            {
            try
            {
                p = sdomm.getPerson(id);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            //return string.Format("{0} {1}, {2}, student: {3}", p.Name, p.Surname, p.Email, p.Student);
            }
            else
            {
                try
                {
                    p = sdomm.getPersonByGLID(id);
                }
                catch (Exception e)
                {
                    return e.Message;
                }
                //return p.pssl.ToString();
            }
            return string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}%%%{5}", p.Name, p.Surname, p.Email, p.pssl, p.Student, p.Id);
        }

        public string GetDataBySurname(string surname)
        {
            //return string.Format("You entered: {0}", id);
            //TODO zwracanie obiektu zawierajacego dane

            SDOModelMethods sdomm = new SDOModelMethods();
            Person p = new Person();
            try
            {
                p = sdomm.getPersonBySurname(surname);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}%%%{5}", p.Name, p.Surname, p.Email, p.pssl, p.Student, p.Id);
        }

        public List<String> GetEntriesByName(string surname)
        {
            SDOModelMethods sdomm = new SDOModelMethods();
            var lstst = new List<String>();
            return lstst = sdomm.GetMatchingSurnames(surname);
            
        }

        public string GetDataByEmail(string email)
        {
            //return string.Format("You entered: {0}", id);
            //TODO zwracanie obiektu zawierajacego dane

            SDOModelMethods sdomm = new SDOModelMethods();
            Person p = new Person();
            try
            {
                p = sdomm.getPersonByEmail(email);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            //return string.Format("{0} {1}, {2}, student: {3}", p.Name, p.Surname, p.Email, p.Student);
            if (p != null)
            {
                return string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}", p.Name, p.Surname, p.Email, p.pssl, p.Student);
            }
            else
            {
                return "";
            }
        }

        public string AddNewStudentLame(string _name, string _surn, bool batman, string plid, string _mail)
        {
            //InteractionModels.SDOLocalMethods1 sdolm = new InteractionModels.SDOLocalMethods1();
            //sdolm.addPerson(_name, _surn, batman, _mail);

            service1VC.incrementVersion("Adding new Student...");
            SDOModelMethods sdomm = new SDOModelMethods();
            Person O = new Person();
            O = sdomm.getPersonByGLID(Convert.ToInt32(plid));
            if (O != null)
            {
                service1VC.incrementVersion("ERR: Student already exists!");
                return "Już jest ktoś taki. Aborting.";
            }
            else
            {
                try
                {
                    sdomm.addPerson(_name, _surn, batman, plid, _mail);
                }
                catch (Exception e)
                {
                    service1VC.incrementVersion("ERR: Unknown error while saving new Student data!");
                    return e.Message;
                }

                service1VC.incrementVersion("Student successfully added.");
                return "Done";
            }
        }

        public string TerriblyRetrieveDatabase()
        {
            SDOModelMethods sdolm = new SDOModelMethods();
            List<InteractionModels.Person> pp = new List<InteractionModels.Person>();
            pp = sdolm.GetListOfPeople();
            string sp = pp.ToString(); // Istnieje specjalne miejsce w piekle dla ludzi, którzy robią coś takiego.
            return sp;
        }

        public List<String> OutrageousDatabaseLeak()
        {
            SDOModelMethods sdolm = new SDOModelMethods();
            var zwr = new List<String>();
            zwr = sdolm.LeakMe();
            return zwr;
        }

        public string SetData(string data)
        {
            return "OK";
            //TODO zapisywanie danych do bazy
            //Są już metody do tego, trzeba się zabawić w SDOLocalMethods1.cs
        }

        public string NukeStudent(int _id)
        {
            service1VC.incrementVersion("Deleting Student with ID =" + _id.ToString() + "...");
            SDOModelMethods sdolm = new SDOModelMethods();
            try
            {
                sdolm.deletePerson(_id);
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
            service1VC.incrementVersion("Student with ID = " + _id.ToString() + " successfully deleted.");
            return "Done";
        }
    }
}
