﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE5112___20104162___Task_1
{
    public partial class GameForm : Form
    {
        private Map localmap;
        private int border;
        private GameEngine gameEng;

        public GameForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                if (gameEng.MovePlayer(Character.Movement.Up) == false) { };
                updateMap();
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                if (gameEng.MovePlayer(Character.Movement.Down) == false) { };
                updateMap();
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                if (gameEng.MovePlayer(Character.Movement.Left) == false) { };
                updateMap();
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                if (gameEng.MovePlayer(Character.Movement.Right) == false) { };
                updateMap();
                return true;
            }
            if (keyData == Keys.Space)
            {
                attack_BTN.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void heroName_LB_Click(object sender, EventArgs e)
        {
            
        }

        private void heroAttack_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void attack_BTN_Click(object sender, EventArgs e)
        {

        }

        private void map_LB_Click(object sender, EventArgs e)
        {
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            localmap = new Map(10, 20, 10, 20, 5, 10);
            gameEng = new GameEngine(localmap);
            border = gameEng.map.MapWidthGrab - 1;
            updateMap();
            heroName_LB.Text = Convert.ToString(heroName_TB.Text);
        }

        private void updateMap()
        {
            map.Clear();
            string newLine;
            heroStats_LB.Text = gameEng.map.hero.ToString();

            // This updates the map every time we move 
            for (int y = 0; y < gameEng.map.MapHeightGrab; y++)
            {
                if (y != 0) { map.Text += "\n"; };
                for (int x = 0; x < gameEng.map.MapWidthGrab; x++)
                {
                    switch (gameEng.map.MapGrab[x, y])
                    {
                        case EmptyTile _:
                            map.Text += "_";
                            break;

                        case Obstacle _:
                            map.Text += "X";
                            break;
                        case Hero _:
                            map.Text += "H";
                            break;
                        case GADE5112___20204162___Task_1.Gold _:
                            map.Text += "G";
                            break;
                        case Goblin _:
                            map.Text += "K";
                            break;
                        case GADE5112___20204162___Task_1.Mage _:
                            map.Text += "M";
                            break;
                        case Leader _:
                            map.Text += "L";
                            break;

                    }

                }

            }

        }

        private void heroName_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
