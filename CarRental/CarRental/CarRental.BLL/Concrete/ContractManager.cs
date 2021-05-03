using CarRental.BLL.Abstract;
using CarRental.DAL.Abstract;
using CarRental.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Concrete
{
   public class ContractManager : IContractService
    {
        IContractDal _contractDal;
        public ContractManager(IContractDal contractDal)
        {
            _contractDal = contractDal;
        }
        public void Add(Contract contract)
        {
            _contractDal.Add(contract);
        }

        public void Delete(Contract contract)
        {
            _contractDal.Delete(contract);
        }

        public void DeleteById(int contractID)
        {
             _contractDal.Get(x => x.ContractID == contractID);
        }

        public List<Contract> GetAll()
        {
           return  _contractDal.GetAll();
        }

        public Contract GetById(int contractID)
        {
            return _contractDal.Get(x => x.ContractID== contractID);
        }

        public void Update(Contract contract)
        {
            _contractDal.Update(contract);
        }
    }
}
