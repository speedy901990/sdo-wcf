using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using sdo_wcf2.Models;

namespace sdo_wcf2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : ISecondServer, IInternalServices
    {

        public string GetData(int id, bool mod)
        {

            Server2ModelMethods s2mm = new Server2ModelMethods();
            Patient p = new Patient();
            if (mod == false)
            {
                try
                {
                    p = s2mm.getPatient(id);
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }
            else
            {
                try
                {
                    p = s2mm.getPersonByGLID(id);
                }
                catch (Exception e)
                {
                    return e.Message;
                }
                //return p.pssl.ToString();
            }
            return string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}%%%{5}%%%{6}%%%{7}", p.Name, p.Surname, p.Email, p.pssl, p.Student, p.Id, p.Height, p.Weight);
        }

        public string GetDataBySurname(string surname)
        {
            //return string.Format("You entered: {0}", id);
            //TODO zwracanie obiektu zawierajacego dane

            Server2ModelMethods s2mm = new Server2ModelMethods();
            Patient p = new Patient();
            try
            {
                p = s2mm.getPersonBySurname(surname);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}%%%{5}%%%{6}%%%{7}", p.Name, p.Surname, p.Email, p.pssl, p.Student, p.Id, p.Height, p.Weight);
        }

        public List<String> GetEntriesByName(string surname)
        {
            Server2ModelMethods s2mm = new Server2ModelMethods();
            var lstst = new List<String>();
            return lstst = s2mm.GetMatchingSurnames(surname);

        }

        public string GetDataByEmail(string email)
        {
            //return string.Format("You entered: {0}", id);
            //TODO zwracanie obiektu zawierajacego dane

            Server2ModelMethods s2mm = new Server2ModelMethods();
            Patient p = new Patient();
            try
            {
                p = s2mm.getPersonByEmail(email);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            //return string.Format("{0} {1}, {2}, student: {3}", p.Name, p.Surname, p.Email, p.Student);
            if (p != null)
            {
                return string.Format("{0}%%%{1}%%%{2}%%%{3}%%%{4}%%%{5}%%%{6}", p.Name, p.Surname, p.Email, p.pssl, p.Student, p.Height, p.Weight);
            }
            else
            {
                return "";
            }
        }

        public string NukeStudent(int _id)
        {
            Server2ModelMethods s2mm = new Server2ModelMethods();
            try
            {
                s2mm.deletePatient(_id);
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
            return "Done";
        }

        public string AddNewStudent(string _name, string _surn, bool batman, string _mail, float height, float weight)
        {
            //sdolm.addPerson(_name, _surn, batman, _mail);

            Server2ModelMethods sdomm = new Server2ModelMethods();

            try
            {
                sdomm.addPatient(_name, _surn, batman, _mail, height, weight);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "Done";
        }

        public string SetData(string data)
        {
            return "OK";
            //TODO zapisywanie danych do bazy
            //Są już metody do tego, trzeba się zabawić w SDOLocalMethods1.cs
        }

        public string TerriblyRetrieveDatabase()
        {
            Server2ModelMethods sdomm = new Server2ModelMethods();
            List<Patient> pp = new List<Patient>();
            pp = sdomm.GetListOfPatients();
            string sp = pp.ToString(); // Istnieje specjalne miejsce w piekle dla ludzi, którzy robią coś takiego.
            return sp;
        }
    }
}
