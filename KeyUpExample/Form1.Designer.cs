namespace KeyUpExample
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
            this.lblOne = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(103, 129);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(234, 47);
            this.lblOne.TabIndex = 0;
            this.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(162, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Press \"Enter\" Key For  KeyDown";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(22, 40);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(127, 13);
            this.lblTwo.TabIndex = 2;
            this.lblTwo.Text = "Press \"K\"  Key for KeyUp";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Location = new System.Drawing.Point(22, 70);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(150, 13);
            this.lblThree.TabIndex = 3;
            this.lblThree.Text = "Press \"Esc\"  Key for KeyPress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(476, 259);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblOne);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
    }
}

