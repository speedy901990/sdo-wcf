﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace sdo_wcf2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISecondServer
    {
        [OperationContract]
        string TerriblyRetrieveDatabase();
       
        //string[] GetEntriesByName(string surname);

        // TODO: Add your service operations here


        // TODO: Add your service operations here
    }

    [ServiceContract]
    public interface IRemotingDB
    {
        [OperationContract]
        string MakeDatabasesSynced();
    }

    [ServiceContract]
    public interface IInternalServices
    {
        [OperationContract]
        string GetData(int id, bool mod);
        [OperationContract]
        string GetDataByEmail(string email);
        [OperationContract]
        string GetDataBySurname(string surname);
        [OperationContract]
        string AddNewStudent(string _name, string _surn, bool batman, string _mail, float height, float weight);
        [OperationContract]
        string NukeStudent(int id);
        [OperationContract]
        List<String> GetEntriesByName(string surname);
        [OperationContract]
        string SetData(string data);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "sdo_wcf2.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
