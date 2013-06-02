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
    public class Service1 : ISecondServer
    {
        public string GetData(int id)
        {
            Server2ModelMethods sdomm = new Server2ModelMethods();
            Patient p = new Patient();
            try
            {
                p = sdomm.getPatient(id);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return string.Format("{0} {1}, {2}, student: {3}", p.Name, p.Surname, p.Email, p.Student);
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
    }
}
