﻿using System.Collections.Generic;
using System.Linq;

namespace Notify.Models
{
    public class ConstructorModel
    {
        public string ConstructorId { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public double Points { get; set; }
        public int Wins { get; set; }
        public string Color { get; set; }
        public List<DriverModel> Drivers { get; set; }
        public string DriversName
        {
            get
            {
                return string.Join(" | ", Drivers.Select(d => string.Format("{0}. {1}", d.GivenName.Substring(0, 1), d.FamilyName)));
            }
        }
    }
}
