using CarRental.Entity.Models;
using System;
using System.Collections.Generic;

using System.Text;

namespace CarRental.BLL.Abstract
{
    public interface IContractService
    {
        void Add(Contract contract);
        void Update(Contract contract);
        void Delete(Contract contract);
        void DeleteById(int contractID);
        Contract GetById(int contractID);
        List<Contract> GetAll();
    }
}
