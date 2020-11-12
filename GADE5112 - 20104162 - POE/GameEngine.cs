using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    class GameEngine
    {
        //Create the GameEngine class.

        public GameEngine(Map map)
        {
            this.map = map;
        }

        protected Map Map = new Map();

        public Map map
        {
            get
            {
                return Map;
            }
            set
            {
                map = value;
            }
        }

        public bool MovePlayer(Character.Movement direction)
        {
            return true;
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
            FileStream outputFile = new FileStream("Map.binary", FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(outputFile, Map);
            outputFile.Close();

        }
        public void Load()
        {
            FileStream inputFile = new FileStream("Map.binary", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Map fromFile= (Map)binaryFormatter.Deserialize(inputFile);
            inputFile.Close();
        }
    }
}
