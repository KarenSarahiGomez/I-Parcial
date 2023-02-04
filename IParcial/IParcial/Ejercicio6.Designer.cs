namespace IParcial
{
    partial class Ejercicio6
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Arreglosbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(51, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 137);
            this.listBox1.TabIndex = 0;
            // 
            // Arreglosbutton
            // 
            this.Arreglosbutton.Location = new System.Drawing.Point(223, 32);
            this.Arreglosbutton.Name = "Arreglosbutton";
            this.Arreglosbutton.Size = new System.Drawing.Size(90, 29);
            this.Arreglosbutton.TabIndex = 1;
            this.Arreglosbutton.Text = "Arreglos";
            this.Arreglosbutton.UseVisualStyleBackColor = true;
            this.Arreglosbutton.Click += new System.EventHandler(this.Arreglosbutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 324);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Arreglosbutton);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Arreglosbutton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}