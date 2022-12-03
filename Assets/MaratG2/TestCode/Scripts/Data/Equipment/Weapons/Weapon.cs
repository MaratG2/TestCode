using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaratG2.TestCode.Data
{
    public abstract class Weapon : Equipment
    {
        public ulong WeaponValue { get; protected set; }
    }
}