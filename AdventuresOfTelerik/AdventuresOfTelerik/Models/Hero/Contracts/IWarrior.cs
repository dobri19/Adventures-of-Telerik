﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventuresOfTelerik.Contracts.HeroInterfaces
{
    public interface IWarrior : IHero
    {
        int Strength { get; set; }
    }
}