using System;
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
    public partial class Form1 : Form
    {
        Map map = new Map();

        public Form1()
        {
            InitializeComponent();
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
            GameEngine gameEngine = new GameEngine(map);
            gameEngine.Load();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            GameEngine gameEngine = new GameEngine(map);
            gameEngine.Save();
        }
    }
}
