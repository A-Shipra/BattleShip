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
            btnShoot.Visible = false;
            btnAddShip.Visible = false;
            xcoor.Visible = false;
            ycoor.Visible = false;
            battleShipSize.Visible = false;
            lblBattleshipSize.Visible = false;
            lblTarget.Visible = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string orient = cbOrientation.SelectedItem.ToString();
            Player1 = new Player(orient);
            btnStart.Visible = false;
            cbOrientation.Enabled = false;
            btnAddShip.Visible = true;
            battleShipSize.Visible = true;
            lblBattleshipSize.Visible = true;
            lblStatus.Text = "";
            lblStatus.Text = "New Game Started";
            richTextBox1.Text=Player1.DebugMessages();
        }

        private void AddShip_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(battleShipSize.Value);

            Player1.Addship(size);
            xcoor.Visible = true;
            ycoor.Visible = true;
            lblTarget.Visible = true;
            btnShoot.Visible = true;
            lblStatus.Text = "Add more ship or start shooting";
            richTextBox1.Text = Player1.DebugMessages();

        }

        private void Shoot_Click(object sender, EventArgs e)
        {
            btnAddShip.Enabled = false;
            battleShipSize.Enabled = false;

            int x = Convert.ToInt32(xcoor.Value);
            int y = Convert.ToInt32(ycoor.Value);
            lblStatus.Text = Player1.ShootTile(x, y);
            lblStatus.Text += "\n\n"+Player1.ShootingSummary();
         //   Player1.ShowDebugMessages();
            richTextBox1.Text = Player1.DebugMessages();
            if (Player1.IsGameFinished())
            {
                btnStart.Visible = true;
                btnShoot.Visible = false;
                btnAddShip.Visible = false;
                xcoor.Visible = false;
                ycoor.Visible = false;
                battleShipSize.Visible = false;
                lblBattleshipSize.Visible = false;
                lblTarget.Visible = false;
                cbOrientation.Enabled = true;
                lblStatus.Text += "\n\n" + "You Won the Game.";
                //lblGameResult.Text = "You Won the Game.";
            }
        }
    }
}
