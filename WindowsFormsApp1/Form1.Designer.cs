namespace WindowsFormsApp1
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
            this.WLcommand_textBox = new System.Windows.Forms.TextBox();
            this.Run_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Output_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WLcommand_textBox
            // 
            this.WLcommand_textBox.Location = new System.Drawing.Point(157, 46);
            this.WLcommand_textBox.Multiline = true;
            this.WLcommand_textBox.Name = "WLcommand_textBox";
            this.WLcommand_textBox.Size = new System.Drawing.Size(833, 124);
            this.WLcommand_textBox.TabIndex = 0;
            // 
            // Run_button
            // 
            this.Run_button.Location = new System.Drawing.Point(1184, 61);
            this.Run_button.Name = "Run_button";
            this.Run_button.Size = new System.Drawing.Size(273, 88);
            this.Run_button.TabIndex = 1;
            this.Run_button.Text = "Run!";
            this.Run_button.UseVisualStyleBackColor = true;
            this.Run_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1129, 646);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Output_textBox
            // 
            this.Output_textBox.Location = new System.Drawing.Point(157, 218);
            this.Output_textBox.Multiline = true;
            this.Output_textBox.Name = "Output_textBox";
            this.Output_textBox.Size = new System.Drawing.Size(833, 138);
            this.Output_textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1238);
            this.Controls.Add(this.Output_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Run_button);
            this.Controls.Add(this.WLcommand_textBox);
            this.Name = "Form1";
            this.Text = "calling WL from .Net";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WLcommand_textBox;
        private System.Windows.Forms.Button Run_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Output_textBox;
    }
}