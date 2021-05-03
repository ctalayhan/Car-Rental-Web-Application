using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding
{
    public static class ContractSeed
    {

        public static void ContractSeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>().HasData(
               new Contract
               {
                   ContractID = 1
               },
               new Contract
               {
                   ContractID = 2
               },
               new Contract
               {
                   ContractID = 3
               },
               new Contract
               {
                   ContractID = 4
               },
               new Contract
               {
                   ContractID = 5
               },
               new Contract
               {
                   ContractID = 6
               },
               new Contract
               {
                   ContractID = 7
               },
               new Contract
               {
                   ContractID = 8
               },
               new Contract
               {
                   ContractID = 9
               }
               );
        }


    }
}
