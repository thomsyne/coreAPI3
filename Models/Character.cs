﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 10;
        public int Strength { get; set; } = 100;
        public int Defense { get; set; } = 80;
        public int Intelligence { get; set; } = 92;
        public RpgClass Class { get; set; } = RpgClass.Knight;

    }
}
