﻿namespace Hanoi_Towers
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.GameSize = new System.Windows.Forms.TrackBar();
            this.GameSizelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartGamebtn = new System.Windows.Forms.Button();
            this.Translatebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.Calculatebtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculatebtn.Location = new System.Drawing.Point(239, 541);
            this.Calculatebtn.Name = "button1";
            this.Calculatebtn.Size = new System.Drawing.Size(168, 58);
            this.Calculatebtn.TabIndex = 24;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.AutoCalculatebtn_Click);
            // 
            // trackBar1
            // 
            this.GameSize.Location = new System.Drawing.Point(15, 490);
            this.GameSize.Maximum = 8;
            this.GameSize.Minimum = 1;
            this.GameSize.Name = "trackBar1";
            this.GameSize.Size = new System.Drawing.Size(162, 45);
            this.GameSize.TabIndex = 26;
            this.GameSize.Value = 8;
            this.GameSize.Scroll += new System.EventHandler(this.GameSizeBar_Scroll);
            // 
            // label1
            // 
            this.GameSizelbl.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameSizelbl.Location = new System.Drawing.Point(30, 441);
            this.GameSizelbl.Name = "label1";
            this.GameSizelbl.Size = new System.Drawing.Size(133, 36);
            this.GameSizelbl.TabIndex = 27;
            this.GameSizelbl.Text = "Game Size: 8";
            this.GameSizelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Step});
            this.dataGridView1.Location = new System.Drawing.Point(413, 449);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Num.Frozen = true;
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.Width = 50;
            // 
            // Step
            // 
            this.Step.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Step.Frozen = true;
            this.Step.HeaderText = "Steps";
            this.Step.Name = "Step";
            this.Step.Width = 197;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackgroundImage = global::Hanoi_Towers.Properties.Resources.victory;
            this.pictureBox12.Location = new System.Drawing.Point(0, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(983, 426);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 34;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Hanoi_Towers.Properties.Resources.Tower;
            this.pictureBox11.Location = new System.Drawing.Point(681, 40);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(270, 359);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 33;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Hanoi_Towers.Properties.Resources.Tower;
            this.pictureBox10.Location = new System.Drawing.Point(355, 40);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(270, 359);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 32;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Hanoi_Towers.Properties.Resources.Tower;
            this.pictureBox9.Location = new System.Drawing.Point(15, 40);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(270, 359);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 31;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Hanoi_Towers.Properties.Resources._1;
            this.pictureBox8.Location = new System.Drawing.Point(120, 60);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(60, 40);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "1";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Hanoi_Towers.Properties.Resources._2;
            this.pictureBox7.Location = new System.Drawing.Point(105, 100);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(90, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Hanoi_Towers.Properties.Resources._3;
            this.pictureBox6.Location = new System.Drawing.Point(90, 140);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(120, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "3";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Hanoi_Towers.Properties.Resources._4;
            this.pictureBox5.Location = new System.Drawing.Point(75, 180);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "4";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Hanoi_Towers.Properties.Resources._5;
            this.pictureBox4.Location = new System.Drawing.Point(60, 220);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(180, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hanoi_Towers.Properties.Resources._6;
            this.pictureBox3.Location = new System.Drawing.Point(45, 260);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "6";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hanoi_Towers.Properties.Resources._7;
            this.pictureBox2.Location = new System.Drawing.Point(30, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hanoi_Towers.Properties.Resources._8;
            this.pictureBox1.Location = new System.Drawing.Point(15, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "8";
            // 
            // button2
            // 
            this.StartGamebtn.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGamebtn.Location = new System.Drawing.Point(12, 541);
            this.StartGamebtn.Name = "button2";
            this.StartGamebtn.Size = new System.Drawing.Size(165, 58);
            this.StartGamebtn.TabIndex = 25;
            this.StartGamebtn.Text = "Start New Game";
            this.StartGamebtn.UseVisualStyleBackColor = true;
            this.StartGamebtn.Click += new System.EventHandler(this.PlayerModebtn_Click);
            // 
            // button4
            // 
            this.Translatebtn.Image = global::Hanoi_Towers.Properties.Resources.english_flag;
            this.Translatebtn.Location = new System.Drawing.Point(908, 543);
            this.Translatebtn.Name = "button4";
            this.Translatebtn.Size = new System.Drawing.Size(64, 58);
            this.Translatebtn.TabIndex = 35;
            this.Translatebtn.UseVisualStyleBackColor = true;
            this.Translatebtn.Click += new System.EventHandler(this.ChangeLanguagebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.Translatebtn);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GameSizelbl);
            this.Controls.Add(this.GameSize);
            this.Controls.Add(this.StartGamebtn);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanoi Towers";
            ((System.ComponentModel.ISupportInitialize)(this.GameSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region UI Properties definition
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.TrackBar GameSize;
        private System.Windows.Forms.Label GameSizelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button StartGamebtn;
        private System.Windows.Forms.Button Translatebtn;
        #endregion
    }
}

