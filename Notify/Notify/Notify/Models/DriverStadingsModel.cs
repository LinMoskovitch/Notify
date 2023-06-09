﻿using System.Collections.Generic;

namespace Notify.Models
{
    public class DriverStadingsModel
    {
        public int Position { get; set; }
        public double Points { get; set; }
        public DriverModel Driver { get; set; }
        public List<ConstructorModel> Constructors { get; set; }
    }
}
