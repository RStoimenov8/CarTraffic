namespace Brichka
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Put = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.Game = new System.Windows.Forms.Timer(this.components);
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(75, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Road";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Location = new System.Drawing.Point(203, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 96);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Road";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Location = new System.Drawing.Point(202, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 96);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Road";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Location = new System.Drawing.Point(74, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 96);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Road";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox5.Location = new System.Drawing.Point(202, 390);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 96);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Road";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox6.Location = new System.Drawing.Point(74, 390);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 96);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Road";
            // 
            // Put
            // 
            this.Put.Interval = 10;
            this.Put.Tick += new System.EventHandler(this.Put_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Red;
            this.Player.Location = new System.Drawing.Point(111, 390);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(67, 96);
            this.Player.TabIndex = 6;
            this.Player.TabStop = false;
            // 
            // Game
            // 
            this.Game.Interval = 10;
            this.Game.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Yellow;
            this.Enemy1.Location = new System.Drawing.Point(18, 64);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(67, 96);
            this.Enemy1.TabIndex = 7;
            this.Enemy1.TabStop = false;
            this.Enemy1.Tag = "Car";
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Lime;
            this.Enemy2.Location = new System.Drawing.Point(111, 64);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(67, 96);
            this.Enemy2.TabIndex = 8;
            this.Enemy2.TabStop = false;
            this.Enemy2.Tag = "Car";
            // 
            // Enemy3
            // 
            this.Enemy3.BackColor = System.Drawing.Color.Blue;
            this.Enemy3.Location = new System.Drawing.Point(207, 64);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(67, 96);
            this.Enemy3.TabIndex = 9;
            this.Enemy3.TabStop = false;
            this.Enemy3.Tag = "Car";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(29, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(286, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Бричка.бг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer Put;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer Game;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

