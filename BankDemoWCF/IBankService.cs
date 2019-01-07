using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankDemoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBankService
    {
        [OperationContract]
        List<Bank> GetListBank();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "BankDemoWCF.ContractType".
    [DataContract]
    public class Bank
    {


        [DataMember]
        public int AccountId { get; set; }
        [DataMember]
        public string BankName { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}