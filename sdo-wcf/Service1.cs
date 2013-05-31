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
        public string GetData(int id)
        {
            //return string.Format("You entered: {0}", id);
            //TODO zwracanie obiektu zawierajacego dane

            SDOModelMethods sdomm = new SDOModelMethods();
            Person p = new Person();
            try
            {
                p = sdomm.getPerson(id);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Format("{0} {1}, {2}, student: {3}", p.Name, p.Surname, p.Email, p.Student);
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
            return string.Format("{0} {1}, {2}, student: {3}", p.Name, p.Surname, p.Email, p.Student);
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
            return string.Format("{0} {1}, {2}, student: {3}", p.Name, p.Surname, p.Email, p.Student);
        }

        public string AddNewStudentLame(string _name, string _surn, bool batman, string _mail)
        {
            //InteractionModels.SDOLocalMethods1 sdolm = new InteractionModels.SDOLocalMethods1();
            //sdolm.addPerson(_name, _surn, batman, _mail);

            SDOModelMethods sdomm = new SDOModelMethods();

            try
            {
                sdomm.addPerson(_name, _surn, batman, _mail);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "Done";
        }

        public string TerriblyRetrieveDatabase()
        {
            SDOModelMethods sdolm = new SDOModelMethods();
            List<InteractionModels.Person> pp = new List<InteractionModels.Person>();
            pp = sdolm.GetListOfPeople();
            string sp = pp.ToString(); // Istnieje specjalne miejsce w piekle dla ludzi, którzy robią coś takiego.
            return sp;
        }

        public string SetData(string data)
        {
            return "OK";
            //TODO zapisywanie danych do bazy
            //Są już metody do tego, trzeba się zabawić w SDOLocalMethods1.cs
        }
    }
}
