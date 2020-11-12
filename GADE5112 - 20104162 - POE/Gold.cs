using GADE5112___20104162___Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
    class Gold : Item
    {
        //Qu 2.2 : This is the concrete class Gold which inherits from Item.


        private int amountOfGold;
        //A private member variable for the amount of gold represented by a gold drop and a public accessor that can return that amount.

        public int gold_Drop
        {
            get
            {
                return amountOfGold;
            }
            set
            {
                amountOfGold = value;
            }
        }

        Random rnd = new Random();
        //A private Random object to randomize gold amounts.

        public Gold(int positionX, int positionY) : base(positionX, positionY)
        {
            //A constructor that receives an X and Y position. It delegates the X and Y position to the Item constructor via a constructor initialiser. 
            //It then sets the amount to a random amount between 1 and 5 (inclusive).

            amountOfGold = rnd.Next(1, 6);

            positionX = amountOfGold;
            positionY = amountOfGold;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
