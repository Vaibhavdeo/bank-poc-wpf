

using System.Collections.Generic;
using AutoMapper;
using BankPocWPF.model;

namespace BankPocWPF.viewmodel
{
    class BankViewModel
    {
        private List<Bank> _BankList = new List<Bank>();

        public BankViewModel()
        {
            ServiceReference1.BankServiceClient client = new ServiceReference1.BankServiceClient();
            var list = client.GetListBank();
          foreach(var bank in list)
            {
                Bank bankObj = new Bank();
                bankObj.AccountId = bank.AccountId;
                bankObj.BankName = bank.BankName;
                bankObj.City = bank.City;
                _BankList.Add(bankObj);
            }


        }
        public List<Bank> BankList
        {
            get
            {
                return _BankList;
            }
            set
            {
                _BankList = value;
            }
        }
    }
}

