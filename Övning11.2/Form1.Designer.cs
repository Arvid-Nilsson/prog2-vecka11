namespace Övning11._2
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
            this.tbxRadius = new System.Windows.Forms.TextBox();
            this.btnChangeRadius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRadius
            // 
            this.tbxRadius.Location = new System.Drawing.Point(340, 405);
            this.tbxRadius.Name = "tbxRadius";
            this.tbxRadius.Size = new System.Drawing.Size(100, 26);
            this.tbxRadius.TabIndex = 0;
            // 
            // btnChangeRadius
            // 
            this.btnChangeRadius.Location = new System.Drawing.Point(469, 402);
            this.btnChangeRadius.Name = "btnChangeRadius";
            this.btnChangeRadius.Size = new System.Drawing.Size(126, 33);
            this.btnChangeRadius.TabIndex = 1;
            this.btnChangeRadius.Text = "Ändra radie";
            this.btnChangeRadius.UseVisualStyleBackColor = true;
            this.btnChangeRadius.Click += new System.EventHandler(this.btnChangeRadius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeRadius);
            this.Controls.Add(this.tbxRadius);
            this.Name = "Form1";
            this.Text = "Övning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRadius;
        private System.Windows.Forms.Button btnChangeRadius;
    }
}

