using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using sdo_wcf.InteractionModels;

namespace sdo_wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int id, bool mod);
        [OperationContract]
        string GetDataByEmail(string email);
        [OperationContract]
        string GetDataBySurname(string surname);
        [OperationContract]
        string AddNewStudentLame(string _name, string _surn, bool batman, string plid, string _mail);
        [OperationContract]
        string TerriblyRetrieveDatabase();
        [OperationContract]
        List<String> OutrageousDatabaseLeak();
        [OperationContract]
        string NukeStudent(int id);
        [OperationContract]
        List<String> GetEntriesByName(string surname);
        //string[] GetEntriesByName(string surname);
        [OperationContract]
        string SetData(string data);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "sdo_wcf.ContractType".
    
}
