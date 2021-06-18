using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using FootballProject.Entities;

namespace FootballersTeam.ConsoleClient.Exceptions
{
    public class GeneratedExceptions
    {
        private static void ValidateWeight(Footballer footballer)
        {

            if (footballer.Weight < 30 || footballer.Weight > 240)
            {
                throw new InvalidFootballerHeightException(footballer.Weight.ToString(CultureInfo.InvariantCulture));
            }
        }
        
        private static void ValidateHeight(Footballer footballer)
        {

            if (footballer.Height < 140 || footballer.Height > 240)
            {
                throw new InvalidFootballerHeightException(footballer.Height.ToString(CultureInfo.InvariantCulture));
            }
        }

        public static void ConstructFootballerWithValidation()
        {
            var defaultRole = new Role();
            var firstFootballer = new Footballer(firstName: "Ivan", "Ivanovich", "Ukrainian",
                new DateTime(1993, 4, 2), placeOfBirth: "Kiev", height: 170, weight: 00, role: defaultRole);
            ValidateHeight(firstFootballer);
            ValidateWeight(firstFootballer);
            ConsoleTables.ConsoleTable
                .From<Footballer>(new List<Footballer>() {firstFootballer})
                .Write();
        }
    }
}