namespace BattleshipGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblBattleshipSize = new System.Windows.Forms.Label();
            this.btnAddShip = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.xcoor = new System.Windows.Forms.NumericUpDown();
            this.ycoor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOrientation = new System.Windows.Forms.ComboBox();
            this.battleShipSize = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xcoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ycoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleShipSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(271, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(35, 139);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(51, 13);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target At";
            // 
            // lblBattleshipSize
            // 
            this.lblBattleshipSize.AutoSize = true;
            this.lblBattleshipSize.Location = new System.Drawing.Point(35, 102);
            this.lblBattleshipSize.Name = "lblBattleshipSize";
            this.lblBattleshipSize.Size = new System.Drawing.Size(76, 13);
            this.lblBattleshipSize.TabIndex = 4;
            this.lblBattleshipSize.Text = "Battleship Size";
            // 
            // btnAddShip
            // 
            this.btnAddShip.Location = new System.Drawing.Point(271, 94);
            this.btnAddShip.Name = "btnAddShip";
            this.btnAddShip.Size = new System.Drawing.Size(121, 28);
            this.btnAddShip.TabIndex = 6;
            this.btnAddShip.Text = "Add Battleship";
            this.btnAddShip.UseVisualStyleBackColor = true;
            this.btnAddShip.Click += new System.EventHandler(this.AddShip_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(271, 131);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(121, 28);
            this.btnShoot.TabIndex = 7;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // xcoor
            // 
            this.xcoor.Location = new System.Drawing.Point(150, 135);
            this.xcoor.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.xcoor.Name = "xcoor";
            this.xcoor.Size = new System.Drawing.Size(34, 20);
            this.xcoor.TabIndex = 8;
            // 
            // ycoor
            // 
            this.ycoor.Location = new System.Drawing.Point(190, 135);
            this.ycoor.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.ycoor.Name = "ycoor";
            this.ycoor.Size = new System.Drawing.Size(38, 20);
            this.ycoor.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ship Orientation";
            // 
            // cbOrientation
            // 
            this.cbOrientation.FormattingEnabled = true;
            this.cbOrientation.Items.AddRange(new object[] {
            "Horizontal",
            "Verticle"});
            this.cbOrientation.Location = new System.Drawing.Point(150, 61);
            this.cbOrientation.Name = "cbOrientation";
            this.cbOrientation.Size = new System.Drawing.Size(78, 21);
            this.cbOrientation.TabIndex = 11;
            this.cbOrientation.Text = "Horizontal";
            // 
            // battleShipSize
            // 
            this.battleShipSize.Location = new System.Drawing.Point(150, 98);
            this.battleShipSize.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.battleShipSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.battleShipSize.Name = "battleShipSize";
            this.battleShipSize.Size = new System.Drawing.Size(78, 20);
            this.battleShipSize.TabIndex = 12;
            this.battleShipSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(564, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 232);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(930, 345);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 624);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.battleShipSize);
            this.Controls.Add(this.cbOrientation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ycoor);
            this.Controls.Add(this.xcoor);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnAddShip);
            this.Controls.Add(this.lblBattleshipSize);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleship Game";
            ((System.ComponentModel.ISupportInitialize)(this.xcoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ycoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleShipSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblBattleshipSize;
        private System.Windows.Forms.Button btnAddShip;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.NumericUpDown xcoor;
        private System.Windows.Forms.NumericUpDown ycoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOrientation;
        private System.Windows.Forms.NumericUpDown battleShipSize;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

