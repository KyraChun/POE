using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    class Goblin : Enemy
    {
        //Concrete Goblin class which inherits from Enemy.
        public Goblin(int positionY, int positionX, int enemyHP = 10, int enemyDamage = 1) : base(enemyHP, enemyDamage, positionY, positionX, 'G')
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement)
        {
            throw new NotImplementedException();
        }
    }
}
