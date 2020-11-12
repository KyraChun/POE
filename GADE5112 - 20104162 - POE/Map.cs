using GADE5112___20204162___Task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE5112___20104162___Task_1
{
    [Serializable]
    class Map
    {
        //This is my Map class that contains : 
        //      A 2D Tile array to represent the map.
        //      A Hero object to represent the player character.
        //      An Enemy array for the enemies.
        //      Variables for storing the map’s width and height.
        //      A Random object for randomising numbers.

        protected Tile[,] mapArray;
        protected Enemy[] numEnemies;

        //You must create a new Item array that stores items that exist on the map.
        protected Item[] itemArray;
        protected Hero newHero;
        protected int mapWidth;
        protected int mapHeight;
        protected Random random = new Random();

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numberEnemies, int gold)
        {
            //A constructor that receives a minimum and maximum width, minimum and maximum height and number of enemies.

            //You should also tweak your Map constructor to take an additional parameter: 
            //      the amount of gold drops on the map, which is then used as your initial size for your items array.

            int mapWidth = random.Next(minWidth, maxWidth);
            int mapHeight = random.Next(minHeight, maxHeight);

            mapArray = new Tile[mapWidth, mapHeight];
            numEnemies = new Enemy[(mapWidth + mapHeight) / 3];

            for (int i = 0; i < numEnemies.Count(); i++)
            {
                numEnemies[i] = (Enemy)Create(Tile.TileType.Enemy);
            }

            UpdateVision();
            newHero = (Hero)Create(type: Tile.TileType.Hero);
        }

        public void UpdateVision()
        {
            //Updates the vision array for each Character.

            Tile[,] tempTile;
            tempTile = new Tile[mapWidth, mapHeight];

            foreach (Enemy temp in numEnemies)
            {
                for (int i = -1; i < 2; i++)
                {
                    if (i + temp.X > mapHeight || i + temp.X < 0) { continue; }
                    for (int k = -1; k < 2; k++)
                    {
                        if (k + temp.Y > mapHeight || k + temp.Y < 0) { continue; }
                        tempTile[temp.X + i, temp.Y + k] = mapArray[temp.X + i, temp.Y + k];
                        temp.characterVision = tempTile;
                    }
                }
            }
        }

        private Tile Create(Tile.TileType type)
        {
            //This method is used to create objects and also place them on the map.

            Tile tempTile = null;
            int randomX = random.Next(1, mapWidth);
            int randomY = random.Next(1, mapHeight);
            int gold = random.Next(1, 6);
            int heroHP = 0;
            char heroSymbol = 'H';
            while (mapArray[randomX, randomY] != null)
            {
                randomX = random.Next(1, mapWidth);
                randomY = random.Next(1, mapHeight);
            }

            switch (type)
            {
                case Tile.TileType.Hero:
                    tempTile = new Hero(randomX, randomY, heroHP, heroSymbol);
                    break;
                case Tile.TileType.Enemy:
                    //Q.3.1. Integrate the Gold and Mage classes into your existing GameEngine and Map classes.

                    //Your Enemy array in map should now randomize between Goblins and Mages.
                    int typeEnemy = random.Next(3);
                    if (typeEnemy <= 1)
                    {
                        tempTile = new Goblin(randomX, randomY);
                    }
                    else
                    {
                        tempTile = new Mage(randomX, randomY);
                    }

                    break;
                case Tile.TileType.Gold:
                    tempTile = new Gold(randomX, randomY);
                    break;
                case Tile.TileType.Weapon:
                    break;
                default:
                    break;
            }
            mapArray[randomX, randomY] = tempTile;
            return tempTile;
        }

        public Item GetItemAtPosition(int x, int y)
        {
            return 0;
        }
    }
}
