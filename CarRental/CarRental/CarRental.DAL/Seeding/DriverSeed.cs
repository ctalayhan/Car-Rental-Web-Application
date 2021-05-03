using CarRental.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.DAL.Seeding {
    public static class DriverSeed {
        public static void DriverSeedData(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Driver>().HasData(
                new Driver {
                    DriverID = 1,
                    FirstName = "Serdar",
                    LastName = "Er",
                    BirthDate = DateTime.ParseExact("1992/12/03", "yyyy/MM/dd", null),
                    Email = "serdarer@gmail.com",
                    PhoneNumber = "05327651832",
                    Address = "Cevizlik, Kartopu Sk. No:10, 34142 Bakirköy/Istanbul",
                    ClassID = 4,
                    TCKNO = "31188634536",
                    Approval = true,
                },
                new Driver {
                    DriverID = 2,
                    FirstName = "Çaglar",
                    LastName = "Öksüzoglu",
                    BirthDate = DateTime.ParseExact("1993/03/15", "yyyy/MM/dd", null),
                    Email = "caglaroksuzoglu@gmail.com",
                    PhoneNumber = "05327653882",
                    Address = "Darülaeceze Cad. Perpa Ticaret Merkezi A Blok Kat:13 No:2041 Okmeydani",
                    ClassID = 4,
                    TCKNO = "52188034576",
                    Approval = true,
                },
                new Driver {
                    DriverID = 3,
                    FirstName = "Murtaza",
                    LastName = "Yükselen",
                    BirthDate = DateTime.ParseExact("1990/03/10", "yyyy/MM/dd", null),
                    Email = "murtazayukselen@gmail.com",
                    PhoneNumber = "05327151831",
                    Address = "Eyüp sultan mah. Kaptan sok. No:22 Imam hatip lisesi cad.",
                    ClassID = 4,
                    TCKNO = "72140634539",
                    Approval = true,
                },
                new Driver {
                    DriverID = 4,
                    FirstName = "Ali",
                    LastName = "Simsek",
                    BirthDate = DateTime.ParseExact("1990/11/19", "yyyy/MM/dd", null),
                    Email = "alisimsek@gmail.com",
                    PhoneNumber = "05357651038",
                    Address = "Baglarbasi mah. Aksu sk. 5/5 Üsküdar",
                    ClassID = 4,
                    TCKNO = "44188634559",
                    Approval = true,
                },
                new Driver {
                    DriverID = 5,
                    FirstName = "Sevinç",
                    LastName = "Eryaman",
                    BirthDate = DateTime.ParseExact("1972/03/15", "yyyy/MM/dd", null),
                    Email = "sevinceryaman@gmail.com",
                    PhoneNumber = "05387651839",
                    Address = "Eskisehir mah. Kurtulus cd. 4/221 Sisli",
                    ClassID = 4,
                    TCKNO = "12188634567",
                    Approval = true,
                },
                new Driver {
                    DriverID = 6,
                    FirstName = "Osman",
                    LastName = "Kizil",
                    BirthDate = DateTime.ParseExact("1979/08/08", "yyyy/MM/dd", null),
                    Email = "osmankizil@gmail.com",
                    PhoneNumber = "05397251837",
                    Address = "ÇILEK SOKAK, NO.1 AKEL ISHANI KAT.3 D.63 ALTIYOL KADIKÖY,",
                    ClassID = 4,
                    TCKNO = "22188634593",
                    Approval = true,
                },
                new Driver {
                    DriverID = 7,
                    FirstName = "Ahmet",
                    LastName = "Karabulut",
                    BirthDate = DateTime.ParseExact("1968/03/08", "yyyy/MM/dd", null),
                    Email = "ahmetkarabulut@gmail.com",
                    PhoneNumber = "05387051822",
                    Address = "Eren apt. Daire 5 Suadiye Istanbul",
                    ClassID = 4,
                    TCKNO = "82188634512",
                    Approval = true,
                },
                new Driver {
                    DriverID = 8,
                    FirstName = "Mehmet",
                    LastName = "Suna",
                    BirthDate = DateTime.ParseExact("1980/07/03", "yyyy/MM/dd", null),
                    Email = "mehmetsuna@gmail.com",
                    PhoneNumber = "05387851889",
                    Address = "Bozkurt mah. Aksu sk. 2/5 Zeytinburnu",
                    ClassID = 4,
                    TCKNO = "92188634522",
                    Approval = true,
                },
                new Driver {
                    DriverID = 9,
                    FirstName = "Hülya",
                    LastName = "Erbudak",
                    BirthDate = DateTime.ParseExact("1975/03/02", "yyyy/MM/dd", null),
                    Email = "hulyaerbudak@gmail.com",
                    PhoneNumber = "05337621835",
                    Address = "Beyoglu mah. Kizilcik sk. 15/5 Beyoglu",
                    ClassID = 4,
                    TCKNO = "12188634573",
                    Approval = true,
                });
        }
    }
}
