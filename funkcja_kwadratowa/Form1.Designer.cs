namespace funkcja_kwadratowa
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.calc = new System.Windows.Forms.Button();
            this.VarA = new System.Windows.Forms.TextBox();
            this.VarB = new System.Windows.Forms.TextBox();
            this.VarC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delta = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.wynik_D = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(179, 358);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 0;
            this.calc.Text = "Oblicz";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.Calc);
            // 
            // VarA
            // 
            this.VarA.Location = new System.Drawing.Point(12, 415);
            this.VarA.Name = "VarA";
            this.VarA.Size = new System.Drawing.Size(100, 23);
            this.VarA.TabIndex = 1;
            this.VarA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // VarB
            // 
            this.VarB.Location = new System.Drawing.Point(165, 415);
            this.VarB.Name = "VarB";
            this.VarB.Size = new System.Drawing.Size(100, 23);
            this.VarB.TabIndex = 2;
            // 
            // VarC
            // 
            this.VarC.Location = new System.Drawing.Point(320, 415);
            this.VarC.Name = "VarC";
            this.VarC.Size = new System.Drawing.Size(100, 23);
            this.VarC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj kolejno A, B i C";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Delta
            // 
            this.Delta.AutoSize = true;
            this.Delta.Location = new System.Drawing.Point(637, 150);
            this.Delta.Name = "Delta";
            this.Delta.Size = new System.Drawing.Size(37, 15);
            this.Delta.TabIndex = 7;
            this.Delta.Text = "Delta:";
            this.Delta.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(640, 208);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(22, 15);
            this.x1.TabIndex = 8;
            this.x1.Text = "x1:";
            this.x1.Click += new System.EventHandler(this.label3_Click);
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(640, 252);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(19, 15);
            this.x2.TabIndex = 9;
            this.x2.Text = "x2";
            this.x2.Click += new System.EventHandler(this.label4_Click);
            // 
            // wynik_D
            // 
            this.wynik_D.AutoSize = true;
            this.wynik_D.Location = new System.Drawing.Point(201, 252);
            this.wynik_D.Name = "wynik_D";
            this.wynik_D.Size = new System.Drawing.Size(0, 15);
            this.wynik_D.TabIndex = 10;
            this.wynik_D.Click += new System.EventHandler(this.wynik_D_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wynik_D);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.Delta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VarC);
            this.Controls.Add(this.VarB);
            this.Controls.Add(this.VarA);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Button calc;
		private TextBox VarA;
		private TextBox VarB;
		private TextBox VarC;
		private Label label1;
		private Label Delta;
		private Label x1;
		private Label x2;
        private Label wynik_D;
    }
}