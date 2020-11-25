using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    abstract class Weapon : Item
    {
        public Weapon(char symbol, int positionX, int positionY) : base(positionX, positionY)
        {

        }
    }

    //class MeleeWeapon : Weapon
    //{

    //}

    //class RangedWeapon : Weapon
    //{

    //}
}
