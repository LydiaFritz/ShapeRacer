namespace ShapeRacer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.harePic = new System.Windows.Forms.PictureBox();
            this.tortPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.harePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortPic)).BeginInit();
            this.SuspendLayout();
            // 
            // harePic
            // 
            this.harePic.InitialImage = null;
            this.harePic.Location = new System.Drawing.Point(30, 30);
            this.harePic.Name = "harePic";
            this.harePic.Size = new System.Drawing.Size(150, 150);
            this.harePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.harePic.TabIndex = 0;
            this.harePic.TabStop = false;
            this.harePic.Paint += new System.Windows.Forms.PaintEventHandler(this.harePic_Paint);
            // 
            // tortPic
            // 
            this.tortPic.InitialImage = null;
            this.tortPic.Location = new System.Drawing.Point(30, 250);
            this.tortPic.Name = "tortPic";
            this.tortPic.Size = new System.Drawing.Size(150, 150);
            this.tortPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tortPic.TabIndex = 1;
            this.tortPic.TabStop = false;
            this.tortPic.Paint += new System.Windows.Forms.PaintEventHandler(this.tortPic_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tortPic);
            this.Controls.Add(this.harePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shape Racer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.harePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox harePic;
        private System.Windows.Forms.PictureBox tortPic;
    }
}

