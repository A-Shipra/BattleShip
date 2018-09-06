using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipGame
{
    public partial class Form1 : Form
    {
        Player Player1;

        public Form1()
        {
            InitializeComponent();
            Shoot.Visible = false;
            addShip.Visible = false;
            xcoor.Visible = false;
            ycoor.Visible = false;
            battleShipSize.Visible = false;
            lblBattleshipSize.Visible = false;
            lblTarget.Visible = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string orient = orientation.SelectedItem.ToString();
            Player1 = new Player(orient);
            Start.Visible = false;
            orientation.Enabled = false;
            addShip.Visible = true;
            battleShipSize.Visible = true;
            lblBattleshipSize.Visible = true;
            status.Text = "";
            lblGameResult.Text = "New Game Started";
            richTextBox1.Text=Player1.DebugMessages();
        }

        private void AddShip_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(battleShipSize.Value);

            Player1.Addship(size);
            xcoor.Visible = true;
            ycoor.Visible = true;
            lblTarget.Visible = true;
            Shoot.Visible = true;
            status.Text = "Add more ship or start shooting";
            richTextBox1.Text = Player1.DebugMessages();

        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(xcoor.Value);
            int y = Convert.ToInt32(ycoor.Value);
            status.Text = Player1.ShootTile(x, y);
         //   Player1.ShowDebugMessages();
            richTextBox1.Text = Player1.DebugMessages();
            if (Player1.IsGameFinished())
            {
                Start.Visible = true;
                Shoot.Visible = false;
                addShip.Visible = false;
                xcoor.Visible = false;
                ycoor.Visible = false;
                battleShipSize.Visible = false;
                lblBattleshipSize.Visible = false;
                lblTarget.Visible = false;
                orientation.Enabled = true;
                lblGameResult.Text = "You Won the Game.";
            }
        }
    }
}
