using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    class Shop
    {
        //Qu 2.5 : Create the Shop class.
        //      •	A Weapon array of size 3 for the 3 random Weapons that appear in the shop 
        //      •	A Random object to randomise numbers 
        //      •	A Character object to denote the buyer(who to deduct gold from when buying)

        private Weapon[] weaponType = new Weapon[3];
        private Random random = new Random();
        int character;

        public Shop(int character) 
        {

        }

        public Shop()
        {

        }

        private Weapon RandomWeapon()
        {
            return null;
        }

        public bool CanBuy(int canBuyObject)
        {
            return false;
        }

        public void Buy(int buyObject)
        {

        }

        public string DisplayWeapon(int num)
        {
            return null;
        }

    }
}
