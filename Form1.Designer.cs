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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.harePic = new System.Windows.Forms.PictureBox();
            this.tortPic = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
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
            // moveTimer
            // 
            this.moveTimer.Interval = 250;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tortPic);
            this.Controls.Add(this.harePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shape Racer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.harePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox harePic;
        private System.Windows.Forms.PictureBox tortPic;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Button button1;
    }
}

