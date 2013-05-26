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
        public string SetData(string data)
        {
            return "OK";
            //TODO zapisywanie danych do bazy
        }
    }
}
