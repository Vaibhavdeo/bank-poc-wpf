using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankDemoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BankService : IBankService
    {
        public List<Bank> GetListBank()
        {
            List<Bank> bakList = new List<Bank>();
            Bank bank = new Bank();
            bank.AccountId = 1;
            bank.BankName = "hdfc";
            bank.City = "Pune";

            Bank bank2 = new Bank();
            bank2.AccountId = 2;
            bank2.BankName = "Axis";
            bank2.City = "Nasik";

            bakList.Add(bank);
            bakList.Add(bank2);

            return bakList;
        }
    }
}
