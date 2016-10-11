namespace PruebaForm
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
            this.pruebaTextBox3 = new PruebaControles.PruebaTextBox();
            this.pruebaTextBox2 = new PruebaControles.PruebaTextBox();
            this.pruebaTextBox1 = new PruebaControles.PruebaTextBox();
            this.pruebaBtn1 = new PruebaControles.PruebaBtn();
            this.pruebaUserControl1 = new PruebaForm.PruebaUserControl();
            this.SuspendLayout();
            // 
            // pruebaTextBox3
            // 
            this.pruebaTextBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.pruebaTextBox3.Location = new System.Drawing.Point(429, 167);
            this.pruebaTextBox3.Name = "pruebaTextBox3";
            this.pruebaTextBox3.Size = new System.Drawing.Size(100, 20);
            this.pruebaTextBox3.TabIndex = 2;
            // 
            // pruebaTextBox2
            // 
            this.pruebaTextBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.pruebaTextBox2.Location = new System.Drawing.Point(330, 45);
            this.pruebaTextBox2.Name = "pruebaTextBox2";
            this.pruebaTextBox2.Size = new System.Drawing.Size(100, 20);
            this.pruebaTextBox2.TabIndex = 1;
            // 
            // pruebaTextBox1
            // 
            this.pruebaTextBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pruebaTextBox1.Location = new System.Drawing.Point(265, 97);
            this.pruebaTextBox1.Name = "pruebaTextBox1";
            this.pruebaTextBox1.Size = new System.Drawing.Size(100, 20);
            this.pruebaTextBox1.TabIndex = 0;
            // 
            // pruebaBtn1
            // 
            this.pruebaBtn1.Location = new System.Drawing.Point(275, 167);
            this.pruebaBtn1.Name = "pruebaBtn1";
            this.pruebaBtn1.Size = new System.Drawing.Size(75, 24);
            this.pruebaBtn1.TabIndex = 3;
            this.pruebaBtn1.Text = "pruebaBtn1";
            this.pruebaBtn1.UseVisualStyleBackColor = true;
            // 
            // pruebaUserControl1
            // 
            this.pruebaUserControl1.Location = new System.Drawing.Point(1, 12);
            this.pruebaUserControl1.Name = "pruebaUserControl1";
            this.pruebaUserControl1.Size = new System.Drawing.Size(289, 150);
            this.pruebaUserControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 262);
            this.Controls.Add(this.pruebaUserControl1);
            this.Controls.Add(this.pruebaBtn1);
            this.Controls.Add(this.pruebaTextBox3);
            this.Controls.Add(this.pruebaTextBox2);
            this.Controls.Add(this.pruebaTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PruebaControles.PruebaTextBox pruebaTextBox1;
        private PruebaControles.PruebaTextBox pruebaTextBox2;
        private PruebaControles.PruebaTextBox pruebaTextBox3;
        private PruebaControles.PruebaBtn pruebaBtn1;
        private PruebaUserControl pruebaUserControl1;
    }
}

