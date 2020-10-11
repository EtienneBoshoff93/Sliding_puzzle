namespace Practical_3
{
    partial class frmPuzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzle));
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lblMoves = new System.Windows.Forms.Label();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.gbPuzzle = new System.Windows.Forms.GroupBox();
            this.picbx1 = new System.Windows.Forms.PictureBox();
            this.picbx2 = new System.Windows.Forms.PictureBox();
            this.picbx3 = new System.Windows.Forms.PictureBox();
            this.picbx4 = new System.Windows.Forms.PictureBox();
            this.picbx5 = new System.Windows.Forms.PictureBox();
            this.picbx6 = new System.Windows.Forms.PictureBox();
            this.picbx7 = new System.Windows.Forms.PictureBox();
            this.picbx8 = new System.Windows.Forms.PictureBox();
            this.picbx9 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPuzzle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoad.Location = new System.Drawing.Point(194, 377);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(133, 60);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load a CSV board state";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShuffle.Location = new System.Drawing.Point(38, 377);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(134, 60);
            this.btnShuffle.TabIndex = 11;
            this.btnShuffle.Text = "Random Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoves.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMoves.Location = new System.Drawing.Point(623, 479);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(0, 25);
            this.lblMoves.TabIndex = 10;
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.Location = new System.Drawing.Point(531, 458);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(214, 21);
            this.lblMovesMade.TabIndex = 9;
            this.lblMovesMade.Text = "No of moves made:";
            // 
            // gbPuzzle
            // 
            this.gbPuzzle.Controls.Add(this.picbx1);
            this.gbPuzzle.Controls.Add(this.picbx2);
            this.gbPuzzle.Controls.Add(this.picbx3);
            this.gbPuzzle.Controls.Add(this.picbx4);
            this.gbPuzzle.Controls.Add(this.picbx5);
            this.gbPuzzle.Controls.Add(this.picbx6);
            this.gbPuzzle.Controls.Add(this.picbx7);
            this.gbPuzzle.Controls.Add(this.picbx8);
            this.gbPuzzle.Controls.Add(this.picbx9);
            this.gbPuzzle.Location = new System.Drawing.Point(416, 12);
            this.gbPuzzle.Name = "gbPuzzle";
            this.gbPuzzle.Size = new System.Drawing.Size(427, 433);
            this.gbPuzzle.TabIndex = 0;
            this.gbPuzzle.TabStop = false;
            this.gbPuzzle.Text = "9 way puzzle";
            // 
            // picbx1
            // 
            this.picbx1.Location = new System.Drawing.Point(15, 19);
            this.picbx1.Name = "picbx1";
            this.picbx1.Size = new System.Drawing.Size(130, 130);
            this.picbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx1.TabIndex = 1;
            this.picbx1.TabStop = false;
            this.picbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx2
            // 
            this.picbx2.Location = new System.Drawing.Point(151, 19);
            this.picbx2.Name = "picbx2";
            this.picbx2.Size = new System.Drawing.Size(130, 130);
            this.picbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx2.TabIndex = 2;
            this.picbx2.TabStop = false;
            this.picbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx3
            // 
            this.picbx3.Location = new System.Drawing.Point(287, 19);
            this.picbx3.Name = "picbx3";
            this.picbx3.Size = new System.Drawing.Size(130, 130);
            this.picbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx3.TabIndex = 3;
            this.picbx3.TabStop = false;
            this.picbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx4
            // 
            this.picbx4.Location = new System.Drawing.Point(15, 155);
            this.picbx4.Name = "picbx4";
            this.picbx4.Size = new System.Drawing.Size(130, 130);
            this.picbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx4.TabIndex = 4;
            this.picbx4.TabStop = false;
            this.picbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx5
            // 
            this.picbx5.Location = new System.Drawing.Point(151, 155);
            this.picbx5.Name = "picbx5";
            this.picbx5.Size = new System.Drawing.Size(130, 130);
            this.picbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx5.TabIndex = 5;
            this.picbx5.TabStop = false;
            this.picbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx6
            // 
            this.picbx6.Location = new System.Drawing.Point(287, 155);
            this.picbx6.Name = "picbx6";
            this.picbx6.Size = new System.Drawing.Size(130, 130);
            this.picbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx6.TabIndex = 6;
            this.picbx6.TabStop = false;
            this.picbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx7
            // 
            this.picbx7.Location = new System.Drawing.Point(15, 291);
            this.picbx7.Name = "picbx7";
            this.picbx7.Size = new System.Drawing.Size(130, 130);
            this.picbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx7.TabIndex = 7;
            this.picbx7.TabStop = false;
            this.picbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx8
            // 
            this.picbx8.Location = new System.Drawing.Point(151, 291);
            this.picbx8.Name = "picbx8";
            this.picbx8.Size = new System.Drawing.Size(130, 130);
            this.picbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx8.TabIndex = 8;
            this.picbx8.TabStop = false;
            this.picbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // picbx9
            // 
            this.picbx9.Location = new System.Drawing.Point(287, 291);
            this.picbx9.Name = "picbx9";
            this.picbx9.Size = new System.Drawing.Size(130, 130);
            this.picbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx9.TabIndex = 9;
            this.picbx9.TabStop = false;
            this.picbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practical_3.Properties.Resources.original;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 48);
            this.label1.TabIndex = 14;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // frmPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(929, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.gbPuzzle);
            this.Name = "frmPuzzle";
            this.Text = "Complete the Elephant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.GroupBox gbPuzzle;
        private System.Windows.Forms.PictureBox picbx9;
        private System.Windows.Forms.PictureBox picbx8;
        private System.Windows.Forms.PictureBox picbx7;
        private System.Windows.Forms.PictureBox picbx6;
        private System.Windows.Forms.PictureBox picbx5;
        private System.Windows.Forms.PictureBox picbx4;
        private System.Windows.Forms.PictureBox picbx3;
        private System.Windows.Forms.PictureBox picbx2;
        private System.Windows.Forms.PictureBox picbx1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

