﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventuresOfTelerik.Contracts.WeaponInterfaces
{
    public interface IWeapon
    {
        int Dmg { get; }
        int SpecialDmg { get; }
        string ToString();
        string Additionalinfo();
    }
}