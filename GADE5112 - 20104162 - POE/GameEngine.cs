using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
// Making sure we don't have to worry
using static GADE5112___20104162___Task_1.Character;

namespace GADE5112___20104162___Task_1
{
    class GameEngine
    {
        //Create the GameEngine class.

        public GameEngine(Map map)
        {
            this.map = map;
        }

        protected Map localMap;
        private const string fileName = "Map.binary";

        public Map map
        {
            get
            {
                return localMap;
            }
            set
            {
                localMap = value;
            }
        }

        public bool MovePlayer(Character.Movement direction)
        {
            int x, y;
            x = 0;
            y = 0;
            Character.Movement selectedMove = direction;
            switch (selectedMove)
            {
                case Movement.NoMovement:
                    selectedMove = Movement.NoMovement;
                    break;

                case Movement.Up:
                    x = 0;
                    y = 1;
                    break;

                case Movement.Down:
                    x = 0;
                    y = -1;
                    break;

                case Movement.Left:
                    x = -1;
                    y = 0;
                    break;

                case Movement.Right:
                    x = 1;
                    y = 0;
                    break;

                default:
                    selectedMove = Movement.NoMovement;
                    break;
            }
            if (localMap.GetItemAtPosition(x, y) == null)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return null;
        }

        public void EnemyAttacks()
        {

        }

        public void MoveEnemies()
        {

        }

        public void Save()
        {
            FileStream outputFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(outputFile, localMap);
            outputFile.Close();

        }
        public void Load()
        {
            FileStream inputFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Map fromFile = (Map)binaryFormatter.Deserialize(inputFile);
            inputFile.Close();
        }
    }
}
