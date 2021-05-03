using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class UserSeed {
        public static void UserSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(
                new User {
                    UserID = 1,
                    FirstName = "Çaglar",
                    LastName = "Öksüzoglu",
                    BirthDate = DateTime.ParseExact("1993/03/15", "yyyy/MM/dd", null),
                    Email = "caglaroksuzuglu@gmail.com",
                    Phone = "05382013784",
                    Username = "caglar1",
                    Password = "123456789123456",
                    Role=true, //true=musteri
                },
                new User {
                    UserID = 2,
                    FirstName = "Murtaza",
                    LastName = "Yükselen",
                    BirthDate = DateTime.ParseExact("1990/03/10", "yyyy/MM/dd", null),
                    Email = "murtazayukselen@gmail.com",
                    Phone = "05322413789",
                    Username = "murtazayukselen",
                    Password = "232023229282093",
                    Role = true,
                },
                new User {
                    UserID = 3,
                    FirstName = "Ali",
                    LastName = "Simsek",
                    BirthDate = DateTime.ParseExact("1990/11/19", "yyyy/MM/dd", null),
                    Email = "alisimsek@gmail.com",
                    Phone = "05422013784",
                    Username = "alisimsek",
                    Password = "123432098322309",
                    Role = true,
                },
                new User {
                    UserID = 4,
                    FirstName = "Sevinç",
                    LastName = "Eryaman",
                    BirthDate = DateTime.ParseExact("1972/03/15", "yyyy/MM/dd", null),
                    Email = "sevinceryaman@gmail.com",
                    Phone = "05384013281",
                    Username = "sevincabla",
                    Password = "398309843048309",
                    Role = true,
                },
                new User {
                    UserID = 5,
                    FirstName = "Osman",
                    LastName = "Kizil",
                    BirthDate = DateTime.ParseExact("1979/08/08", "yyyy/MM/dd", null),
                    Email = "osmankizil@gmail.com",
                    Phone = "05422013784",
                    Username = "osmankizil21",
                    Password = "343309830983098",
                    Role = true,
                },
                new User {
                    UserID = 6,
                    FirstName = "Yasemin",
                    LastName = "Albayrak",
                    BirthDate = DateTime.ParseExact("1984/03/08", "yyyy/MM/dd", null),
                    Email = "yaseminalbayrak@gmail.com",
                    Phone = "05332323784",
                    Username = "yaseminalb123",
                    Password = "304938092382309",
                    Role = true,
                });
        }
    }
}
