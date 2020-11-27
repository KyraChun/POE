using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20204162___Task_1
{
      //Qu 2.1 : Create the Weapon abstract class that inherits from Item.
      //It contains the following protected member variables and relevant public accessors: 
           //• Damage 
           //• Range(the accessor for this should be virtual to be overridden by the subclasses)
           //• Durability 
           //• Cost 
           //• Weapon Type

      //It also contains a constructor that receives a symbol as well as optional X and Y positions (because a weapon can either be equipped to a Character or exists on the Map). 
      //This data is delegated to the Tile superclass via a constructor initializer.
      //All weapon‐specific data is set in the subclasses.

    abstract class Weapon : Item
    {
        public Weapon(int positionX, int positionY) : base(positionX, positionY)
        {

        }

        protected double damage
        { get; set; }
        protected double durability
        { get; set; }
        protected double cost
        { get; set; }
        protected string weaponType
        { get; set; }
        public virtual double range
        { get; set; }
    }

    abstract class MeleeWeapon : Weapon
    {
        //Qu 2.2 : Create the MeleeWeapon subclass.
        //           The constructor switches on the type of weapon based on the parameter provided.

        public MeleeWeapon(string a, int positionX, int positionY) : base(positionX, positionY)
        {
            //A constructor that merely receives an enum variable that defines the type of Weapon to be created

            a = Dagger();
        }

        public MeleeWeapon(int b, int positionX, int positionY) : base(positionX, positionY)
        {
            string longSwordWeapon = Convert.ToString(b);
            longSwordWeapon = Longsword();
        }

        public string Longsword(int longSDamage = 4, int longSDurability = 6, int longSCost = 5)
        {
            damage = longSDamage;
            durability = longSDurability;
            cost = longSCost;
            return weaponType = "Longsword";
        }

        public string Dagger(int daggerDamage = 3, int daggerDurability = 3, int daggerCost = 3)
        {
            damage = daggerDamage;
            durability = daggerDurability;
            cost = daggerCost;
            return weaponType = "Dagger";
        }

        public enum Types
        {
            //A public enum called Types which defines two types of MeleeWeapon.

            Longsword,
            Dagger
        }       

        public override double range
        {
            //A public overridden Range accessor that returns 1 for MeleeWeapons.

            get
            {
                return range;
            }
            set
            {
                range = 1;
            }
        }

        public abstract override string ToString();
    }

    abstract class RangedWeapon : Weapon
    {
        //Qu 2.3 : Create the RangedWeapon class.
        //           The constructor switches on the type of weapon based on the parameter provided.


        public RangedWeapon(string a, int positionX, int positionY) : base(positionX, positionY)
        {
            //A constructor that merely receives an enum variable that defines the type of Weapon to be created

            a = Rifle();
        }

        public RangedWeapon(int b, int positionX, int positionY) : base(positionX, positionY)
        {
            string longBowWeapon = Convert.ToString(b);
            longBowWeapon = Longbow();
        }

        public enum Types
        {
            //A public enum called Types which defines two types of RangedWeapon.

            Rifle,
            Longbow
        }

        public string Rifle(int rifleDamage = 5, int rifleDurability = 3, int rifleCost = 7, int rifleRange = 3)
        {
            damage = rifleDamage;
            durability = rifleDurability;
            cost = rifleCost;
            range = rifleRange;
            return weaponType = "Rifle";
        }

        public string Longbow(int bowDamage = 4, int bowDurability = 4, int bowCost = 6, int bowRange = 2)
        {
            damage = bowDamage;
            durability = bowDurability;
            cost = bowCost;
            range = bowRange;
            return weaponType = "Longbow";
        }

        public override double range
        {
            //A public overridden Range accessor that returns base.Range.

            get
            {
                return base.range;
            }
            set
            {
                range = value;
            }

        }

        public abstract override string ToString();
    }
}
