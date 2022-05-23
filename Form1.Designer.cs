
namespace WindowsFormsApp3
{
    partial class VehicleGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleGame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.start = new System.Windows.Forms.Button();
            this.txtscore = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.Label();
            this.txtKmh = new System.Windows.Forms.Label();
            this.txtRealese = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emergency = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.medal = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.medal);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.car1);
            this.panel1.Controls.Add(this.car2);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(18, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 799);
            this.panel1.TabIndex = 0;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.start.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.start.Location = new System.Drawing.Point(196, 884);
            this.start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(242, 74);
            this.start.TabIndex = 1;
            this.start.Text = "press to start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.restartGame);
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtscore.Location = new System.Drawing.Point(275, 853);
            this.txtscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(75, 26);
            this.txtscore.TabIndex = 2;
            this.txtscore.Text = "Score:";
            this.txtscore.Click += new System.EventHandler(this.txtscore_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrice.Font = new System.Drawing.Font("Aharoni", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(43, 728);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(147, 32);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "FixPrice:";
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtContent.Location = new System.Drawing.Point(54, 400);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(120, 28);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "Content:";
            // 
            // txtKmh
            // 
            this.txtKmh.AutoSize = true;
            this.txtKmh.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKmh.Location = new System.Drawing.Point(54, 336);
            this.txtKmh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtKmh.Name = "txtKmh";
            this.txtKmh.Size = new System.Drawing.Size(87, 28);
            this.txtKmh.TabIndex = 5;
            this.txtKmh.Text = "Km\'h:";
            // 
            // txtRealese
            // 
            this.txtRealese.AutoSize = true;
            this.txtRealese.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtRealese.Location = new System.Drawing.Point(54, 269);
            this.txtRealese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRealese.Name = "txtRealese";
            this.txtRealese.Size = new System.Drawing.Size(187, 28);
            this.txtRealese.TabIndex = 6;
            this.txtRealese.Text = "RealeseYear:";
            // 
            // txtBrand
            // 
            this.txtBrand.AutoSize = true;
            this.txtBrand.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBrand.Location = new System.Drawing.Point(54, 199);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(99, 28);
            this.txtBrand.TabIndex = 7;
            this.txtBrand.Text = "Brand:";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtId.Location = new System.Drawing.Point(54, 135);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 28);
            this.txtId.TabIndex = 8;
            this.txtId.Text = "ID:";
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // txtRecord
            // 
            this.txtRecord.AutoSize = true;
            this.txtRecord.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtRecord.Location = new System.Drawing.Point(260, 963);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(112, 28);
            this.txtRecord.TabIndex = 9;
            this.txtRecord.Text = "Record:";
            this.txtRecord.Click += new System.EventHandler(this.txtRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(894, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Details:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.emergency);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtBrand);
            this.panel2.Controls.Add(this.txtContent);
            this.panel2.Controls.Add(this.txtKmh);
            this.panel2.Controls.Add(this.txtRealese);
            this.panel2.Location = new System.Drawing.Point(754, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 799);
            this.panel2.TabIndex = 11;
            // 
            // emergency
            // 
            this.emergency.AutoSize = true;
            this.emergency.Font = new System.Drawing.Font("Aharoni", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergency.ForeColor = System.Drawing.Color.Red;
            this.emergency.Location = new System.Drawing.Point(106, 531);
            this.emergency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emergency.Name = "emergency";
            this.emergency.Size = new System.Drawing.Size(263, 44);
            this.emergency.TabIndex = 9;
            this.emergency.Text = "Emergency!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.Upload_PNG_Image;
            this.pictureBox2.Location = new System.Drawing.Point(1189, 941);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // medal
            // 
            this.medal.Image = global::WindowsFormsApp3.Properties.Resources.gold;
            this.medal.Location = new System.Drawing.Point(208, 325);
            this.medal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medal.Name = "medal";
            this.medal.Size = new System.Drawing.Size(250, 100);
            this.medal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.medal.TabIndex = 6;
            this.medal.TabStop = false;
            this.medal.Click += new System.EventHandler(this.medal_Click);
            // 
            // explosion
            // 
            this.explosion.Image = global::WindowsFormsApp3.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(112, 531);
            this.explosion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::WindowsFormsApp3.Properties.Resources.carPink;
            this.car1.Location = new System.Drawing.Point(168, 86);
            this.car1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(50, 100);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car1.TabIndex = 4;
            this.car1.TabStop = false;
            this.car1.Tag = "moveLeft";
            // 
            // car2
            // 
            this.car2.Image = global::WindowsFormsApp3.Properties.Resources.CarRed;
            this.car2.Location = new System.Drawing.Point(496, 150);
            this.car2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(50, 100);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car2.TabIndex = 3;
            this.car2.TabStop = false;
            this.car2.Tag = "moveRight";
            this.car2.Click += new System.EventHandler(this.car2_Click);
            // 
            // player
            // 
            this.player.Image = global::WindowsFormsApp3.Properties.Resources.carGrey;
            this.player.Location = new System.Drawing.Point(325, 638);
            this.player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::WindowsFormsApp3.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, -799);
            this.roadTrack2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(712, 799);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::WindowsFormsApp3.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, 0);
            this.roadTrack1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(712, 799);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            this.roadTrack1.Click += new System.EventHandler(this.roadTrack1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1189, 872);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // VehicleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 1050);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecord);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VehicleGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VehicleGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.PictureBox medal;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.Label txtKmh;
        private System.Windows.Forms.Label txtRealese;
        private System.Windows.Forms.Label txtBrand;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label emergency;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

