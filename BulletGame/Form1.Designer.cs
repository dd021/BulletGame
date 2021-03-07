namespace BulletGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureGame = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSpin = new System.Windows.Forms.Button();
            this.buttonSkipFire = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(437, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roulette";
            // 
            // pictureGame
            // 
            this.pictureGame.Image = global::BulletGame.Properties.Resources.empty;
            this.pictureGame.Location = new System.Drawing.Point(37, 85);
            this.pictureGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureGame.Name = "pictureGame";
            this.pictureGame.Size = new System.Drawing.Size(829, 400);
            this.pictureGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGame.TabIndex = 1;
            this.pictureGame.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.Maroon;
            this.buttonLoad.Location = new System.Drawing.Point(888, 85);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(327, 64);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load Bullet";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSpin
            // 
            this.buttonSpin.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpin.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSpin.Location = new System.Drawing.Point(888, 201);
            this.buttonSpin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSpin.Name = "buttonSpin";
            this.buttonSpin.Size = new System.Drawing.Size(327, 64);
            this.buttonSpin.TabIndex = 3;
            this.buttonSpin.Text = "Spin Chamber";
            this.buttonSpin.UseVisualStyleBackColor = true;
            this.buttonSpin.Click += new System.EventHandler(this.buttonSpin_Click);
            // 
            // buttonSkipFire
            // 
            this.buttonSkipFire.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSkipFire.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSkipFire.Location = new System.Drawing.Point(888, 422);
            this.buttonSkipFire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSkipFire.Name = "buttonSkipFire";
            this.buttonSkipFire.Size = new System.Drawing.Size(327, 63);
            this.buttonSkipFire.TabIndex = 4;
            this.buttonSkipFire.Text = "Skip The Fire";
            this.buttonSkipFire.UseVisualStyleBackColor = true;
            this.buttonSkipFire.Click += new System.EventHandler(this.buttonSkipFire_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFire.ForeColor = System.Drawing.Color.Maroon;
            this.buttonFire.Location = new System.Drawing.Point(888, 308);
            this.buttonFire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(327, 64);
            this.buttonFire.TabIndex = 5;
            this.buttonFire.Text = "Fire!!!";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayGame.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPlayGame.Location = new System.Drawing.Point(540, 535);
            this.buttonPlayGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(327, 63);
            this.buttonPlayGame.TabIndex = 6;
            this.buttonPlayGame.Text = "Play Game";
            this.buttonPlayGame.UseVisualStyleBackColor = true;
            this.buttonPlayGame.Click += new System.EventHandler(this.buttonPlayGame_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonExit.Location = new System.Drawing.Point(888, 535);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(327, 63);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(41, 538);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(358, 51);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "WIN: 0 LOSE: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 613);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayGame);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.buttonSkipFire);
            this.Controls.Add(this.buttonSpin);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureGame);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Russian Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.pictureGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureGame;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSpin;
        private System.Windows.Forms.Button buttonSkipFire;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonPlayGame;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label lblResult;
    }
}

