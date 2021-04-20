using System;
using System.Collections.Generic;
using FootballProject.Entities;

namespace FootballersTeam.MvcClient.Data
{
    public static class FootballersData
    {
        public static List<Footballer> GetFootballersData()
        {
            //initialisation with default constructor
            var defaultRole = new Role();
            //initialisation with constructor with argument
            var firstFootballer = new Footballer(firstName: "Ivan", "Ivanovich", "Ukrainian",
                new DateTime(1993, 4, 2), placeOfBirth: "Kiev", height: 170, weight: 50, role: defaultRole);
            var secondFootballer = new Footballer(firstName: "Petya", "Kirilovich", "Ukrainian",
                new DateTime(1993, 2, 2), placeOfBirth: "Kiev", height: 180, weight: 60, role: defaultRole);
            var thirdFootballer = new Footballer(firstName: "Vasya", "Dovbush", "Ukrainian",
                new DateTime(1993, 2, 2), placeOfBirth: "Kiev", height: 190, weight: 60, role: defaultRole);
            var fourthFootballer = new Footballer(firstName: "Konstantin", "Pupkin", "Ukrainian",
                new DateTime(1993, 6, 2), placeOfBirth: "Kiev", height: 180, weight: 70, role: defaultRole);
            var fifthFootballer = new Footballer(firstName: "Valeriy", "Gmirya", "Ukrainian",
                new DateTime(1990, 9, 2), placeOfBirth: "Kiev", height: 170, weight: 80, role: defaultRole);
            var sixthFootballer = new Footballer(firstName: "Ivan", "Bogda", "Ukrainian",
                new DateTime(1995, 12, 2), placeOfBirth: "Kiev", height: 180, weight: 90, role: defaultRole);
            var seventhFootballer = new Footballer(firstName: "Kiril", "Dmit", "Ukrainian",
                new DateTime(1983, 8, 12), placeOfBirth: "Kiev", height: 190, weight: 100, role: defaultRole);
            var eighthFootballer = new Footballer(firstName: "Hrihoriy", "Kovalich", "Ukrainian",
                new DateTime(1993, 7, 22), placeOfBirth: "Kiev", height: 190, weight: 70, role: defaultRole);
            var ninthFootballer = new Footballer(firstName: "Kolya", "Boshko", "Ukrainian",
                new DateTime(1973, 12, 22), placeOfBirth: "Kiev", height: 190, weight: 70, role: defaultRole);
            var tenthFootballer = new Footballer(firstName: "Dima", "Popugay", "Ukrainian",
                new DateTime(1994, 8, 8), placeOfBirth: "Kiev", height: 170, weight: 77, role: defaultRole);
            //initialisation with copy constructor 
            var eleventhFootballer = new Footballer(firstFootballer);
            var twelfthFootballer = new Footballer(secondFootballer);
            var thirteenthFootballer = new Footballer(thirdFootballer);
            var fourteenthFootballer = new Footballer(fourthFootballer);
            var fifteenthFootballer = new Footballer(fifthFootballer);
            //setting data with properties
            var goalkeeperRole = new Role(2, "goalkeeper");
            eleventhFootballer.Role = goalkeeperRole;
            twelfthFootballer.Role = goalkeeperRole;
            var defenderRole = new Role(2, "defender");
            thirteenthFootballer.Role = defaultRole;
            fourteenthFootballer.Role = defenderRole;
            fifteenthFootballer.Role = defenderRole;

            return new List<Footballer>()
            {
                firstFootballer,
                secondFootballer,
                thirdFootballer,
                fourthFootballer,
                fifthFootballer,
                sixthFootballer,
                secondFootballer,
                eighthFootballer,
                ninthFootballer,
                tenthFootballer,
                eleventhFootballer,
                twelfthFootballer,
                thirteenthFootballer,
                fourteenthFootballer,
                fifteenthFootballer
            };

        }

    }
}