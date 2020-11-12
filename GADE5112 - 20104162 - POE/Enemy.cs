using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    abstract class Enemy : Character
    {
        //The abstract Enemy class which inherits from Character.

        protected Random random = new Random();

        public Enemy(int enemyHP, int enemyDamage, int positionX, int positionY, char symbol = 'E') : base(positionX, positionY, symbol)
        {
            //Enemy constructor that receives X and Y positions, an enemy’s damage and it is starting HP(and thus also max HP) and its symbol.
            //It delegates its X and Y position to the Character subclass via a constructor initialiser.
            //It then sets all the relevant member variables.

            characterHP = enemyHP;
            characterDamage = enemyDamage;
            characterMaxHP = characterHP;
        }

        public override string ToString()
        {
            //An overridden ToString method that, using the enemy’s class, outputs a string that looks as follows:  
            //     EnemyClassName at[X, Y] (Amount DMG)

            return $"Enemy Class:  { this.GetType().FullName }  at [  { X } , { Y } ] (  { characterDamage } )";
        }
    }
}
