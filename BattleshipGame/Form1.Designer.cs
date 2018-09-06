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
            this.Start = new System.Windows.Forms.Button();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblBattleshipSize = new System.Windows.Forms.Label();
            this.addShip = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.xcoor = new System.Windows.Forms.NumericUpDown();
            this.ycoor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.orientation = new System.Windows.Forms.ComboBox();
            this.battleShipSize = new System.Windows.Forms.NumericUpDown();
            this.status = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xcoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ycoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleShipSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(271, 65);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(121, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start Game";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(35, 132);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(51, 13);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target At";
            // 
            // lblBattleshipSize
            // 
            this.lblBattleshipSize.AutoSize = true;
            this.lblBattleshipSize.Location = new System.Drawing.Point(35, 99);
            this.lblBattleshipSize.Name = "lblBattleshipSize";
            this.lblBattleshipSize.Size = new System.Drawing.Size(76, 13);
            this.lblBattleshipSize.TabIndex = 4;
            this.lblBattleshipSize.Text = "Battleship Size";
            // 
            // addShip
            // 
            this.addShip.Location = new System.Drawing.Point(271, 93);
            this.addShip.Name = "addShip";
            this.addShip.Size = new System.Drawing.Size(121, 23);
            this.addShip.TabIndex = 6;
            this.addShip.Text = "Add Battleship";
            this.addShip.UseVisualStyleBackColor = true;
            this.addShip.Click += new System.EventHandler(this.AddShip_Click);
            // 
            // Shoot
            // 
            this.Shoot.Location = new System.Drawing.Point(271, 124);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(121, 28);
            this.Shoot.TabIndex = 7;
            this.Shoot.Text = "shoot";
            this.Shoot.UseVisualStyleBackColor = true;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // xcoor
            // 
            this.xcoor.Location = new System.Drawing.Point(150, 129);
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
            this.ycoor.Location = new System.Drawing.Point(190, 129);
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
            this.label3.Location = new System.Drawing.Point(35, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ship Orientation";
            // 
            // orientation
            // 
            this.orientation.FormattingEnabled = true;
            this.orientation.Items.AddRange(new object[] {
            "Horizontal",
            "Verticle"});
            this.orientation.Location = new System.Drawing.Point(150, 69);
            this.orientation.Name = "orientation";
            this.orientation.Size = new System.Drawing.Size(78, 21);
            this.orientation.TabIndex = 11;
            this.orientation.Text = "Horizontal";
            // 
            // battleShipSize
            // 
            this.battleShipSize.Location = new System.Drawing.Point(150, 96);
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
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(564, 72);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 20);
            this.status.TabIndex = 13;
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameResult.Location = new System.Drawing.Point(568, 124);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(0, 20);
            this.lblGameResult.TabIndex = 14;
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
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.status);
            this.Controls.Add(this.battleShipSize);
            this.Controls.Add(this.orientation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ycoor);
            this.Controls.Add(this.xcoor);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.addShip);
            this.Controls.Add(this.lblBattleshipSize);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.Start);
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

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblBattleshipSize;
        private System.Windows.Forms.Button addShip;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.NumericUpDown xcoor;
        private System.Windows.Forms.NumericUpDown ycoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orientation;
        private System.Windows.Forms.NumericUpDown battleShipSize;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

