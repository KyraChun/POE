using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    class Hero : Character
    {
        //Concrete Hero subclass, which inherits from Character.

        public Hero(int positionX, int positionY, int heroHP, char symbol) : base(positionX, positionY, symbol)
        {
            //The Hero constructor receives X and Y position and HP.
            //It should then set the HP and max HP of the hero based on the parameter.
            //Additionally, a Hero’s damage is always 2.

            base.characterDamage = 2;
            base.characterMaxHP = heroHP;
        }

        public override string ToString()
        {
            //An overridden ToString() method: This returns the formatted Player Stats as shown below:
            //      Player Stats:
            //      HP: HP / Max HP
            //      Damage: 2
            //      [X, Y]

            return $"Player Stats: \n HP: {base.characterHP} / {base.characterMaxHP} \n Damage: {base.characterDamage} \n Gold: {base.goldPurse} \n ({base.X} , {base.Y})";
        }

        public override Movement ReturnMove(Movement move)
        {
            throw new NotImplementedException();
        }
    }
}
