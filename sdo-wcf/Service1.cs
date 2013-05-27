using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace sdo_wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int id)
        {
            return string.Format("You entered: {0}", id);
            //TODO zwracanie obiektu zawierajacego dane
        }

        public string AddNewStudentLame(string _name, string _surn, bool batman, string _mail)
        {
            InteractionModels.SDOLocalMethods1 sdolm = new InteractionModels.SDOLocalMethods1();
            sdolm.addPerson(_name, _surn, batman, _mail);
            return "Done.";
        }

        public string TerriblyRetrieveDatabase()
        {
            InteractionModels.SDOLocalMethods1 sdolm = new InteractionModels.SDOLocalMethods1();
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
