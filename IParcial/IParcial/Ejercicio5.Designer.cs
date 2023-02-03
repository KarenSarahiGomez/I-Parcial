namespace IParcial
{
    partial class Ejercicio5
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
            this.button1 = new System.Windows.Forms.Button();
            this.HornearAsincronobutton = new System.Windows.Forms.Button();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero12textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hornear Pizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HornearAsincronobutton
            // 
            this.HornearAsincronobutton.Location = new System.Drawing.Point(295, 61);
            this.HornearAsincronobutton.Name = "HornearAsincronobutton";
            this.HornearAsincronobutton.Size = new System.Drawing.Size(133, 32);
            this.HornearAsincronobutton.TabIndex = 1;
            this.HornearAsincronobutton.Text = "Hornear Pizza";
            this.HornearAsincronobutton.UseVisualStyleBackColor = true;
            this.HornearAsincronobutton.Click += new System.EventHandler(this.HornearAsincronobutton_Click);
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(375, 155);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(95, 41);
            this.Calcularbutton.TabIndex = 2;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2: ";
            // 
            // Numero12textBox
            // 
            this.Numero12textBox.Location = new System.Drawing.Point(229, 136);
            this.Numero12textBox.Name = "Numero12textBox";
            this.Numero12textBox.Size = new System.Drawing.Size(100, 26);
            this.Numero12textBox.TabIndex = 5;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(229, 194);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(100, 26);
            this.Numero2textBox.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 414);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero12textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.HornearAsincronobutton);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HornearAsincronobutton;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero12textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
    }
}