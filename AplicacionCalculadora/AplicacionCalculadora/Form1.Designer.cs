namespace AplicacionCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btnIgual = new System.Windows.Forms.Button();
			this.btnMas = new System.Windows.Forms.Button();
			this.btnMenos = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnPor = new System.Windows.Forms.Button();
			this.btnCe = new System.Windows.Forms.Button();
			this.btnPow = new System.Windows.Forms.Button();
			this.btnRaiz = new System.Windows.Forms.Button();
			this.btnSobreX = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnDot = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labOperacion = new System.Windows.Forms.Label();
			this.labIngresado = new System.Windows.Forms.Label();
			this.btnC = new System.Windows.Forms.Button();
			this.btnErase = new System.Windows.Forms.Button();
			this.btnAns = new System.Windows.Forms.Button();
			this.btnTriple0 = new System.Windows.Forms.Button();
			this.btnPowY = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(13, 339);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(73, 73);
			this.btn1.TabIndex = 0;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(92, 339);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(73, 73);
			this.btn2.TabIndex = 1;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(171, 339);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(73, 73);
			this.btn3.TabIndex = 2;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(12, 260);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(73, 73);
			this.btn4.TabIndex = 3;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(91, 260);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(73, 73);
			this.btn5.TabIndex = 4;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(170, 260);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(73, 73);
			this.btn6.TabIndex = 5;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(12, 177);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(73, 73);
			this.btn7.TabIndex = 6;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btn7_Click);
			this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(91, 177);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(73, 73);
			this.btn8.TabIndex = 7;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btn8_Click);
			this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(170, 177);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(73, 73);
			this.btn9.TabIndex = 8;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btn9_Click);
			this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnIgual
			// 
			this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIgual.Location = new System.Drawing.Point(329, 418);
			this.btnIgual.Name = "btnIgual";
			this.btnIgual.Size = new System.Drawing.Size(73, 73);
			this.btnIgual.TabIndex = 9;
			this.btnIgual.Text = "=";
			this.btnIgual.UseVisualStyleBackColor = true;
			this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
			this.btnIgual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnMas
			// 
			this.btnMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMas.Location = new System.Drawing.Point(250, 418);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(73, 73);
			this.btnMas.TabIndex = 10;
			this.btnMas.Text = "+";
			this.btnMas.UseVisualStyleBackColor = true;
			this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
			this.btnMas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnMenos
			// 
			this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenos.Location = new System.Drawing.Point(250, 339);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(73, 73);
			this.btnMenos.TabIndex = 11;
			this.btnMenos.Text = "-";
			this.btnMenos.UseVisualStyleBackColor = true;
			this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
			this.btnMenos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnDiv
			// 
			this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.Location = new System.Drawing.Point(250, 177);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(73, 73);
			this.btnDiv.TabIndex = 12;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
			this.btnDiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnPor
			// 
			this.btnPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPor.Location = new System.Drawing.Point(250, 260);
			this.btnPor.Name = "btnPor";
			this.btnPor.Size = new System.Drawing.Size(73, 73);
			this.btnPor.TabIndex = 13;
			this.btnPor.Text = "*";
			this.btnPor.UseVisualStyleBackColor = true;
			this.btnPor.Click += new System.EventHandler(this.btnPor_Click);
			this.btnPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnCe
			// 
			this.btnCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCe.Location = new System.Drawing.Point(90, 98);
			this.btnCe.Name = "btnCe";
			this.btnCe.Size = new System.Drawing.Size(73, 73);
			this.btnCe.TabIndex = 14;
			this.btnCe.Text = "CE";
			this.btnCe.UseVisualStyleBackColor = true;
			this.btnCe.Click += new System.EventHandler(this.btnCe_Click);
			this.btnCe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnPow
			// 
			this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPow.Location = new System.Drawing.Point(328, 177);
			this.btnPow.Name = "btnPow";
			this.btnPow.Size = new System.Drawing.Size(73, 73);
			this.btnPow.TabIndex = 15;
			this.btnPow.Text = "x²";
			this.btnPow.UseVisualStyleBackColor = true;
			this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
			this.btnPow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnRaiz
			// 
			this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRaiz.Location = new System.Drawing.Point(328, 98);
			this.btnRaiz.Name = "btnRaiz";
			this.btnRaiz.Size = new System.Drawing.Size(73, 73);
			this.btnRaiz.TabIndex = 16;
			this.btnRaiz.Text = "√";
			this.btnRaiz.UseVisualStyleBackColor = true;
			this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
			this.btnRaiz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnSobreX
			// 
			this.btnSobreX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSobreX.Location = new System.Drawing.Point(329, 260);
			this.btnSobreX.Name = "btnSobreX";
			this.btnSobreX.Size = new System.Drawing.Size(73, 73);
			this.btnSobreX.TabIndex = 17;
			this.btnSobreX.Text = "1/x";
			this.btnSobreX.UseVisualStyleBackColor = true;
			this.btnSobreX.Click += new System.EventHandler(this.btnSobreX_Click);
			this.btnSobreX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(91, 418);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(74, 73);
			this.btn0.TabIndex = 18;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btn0_Click);
			this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnDot
			// 
			this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDot.Location = new System.Drawing.Point(12, 418);
			this.btnDot.Name = "btnDot";
			this.btnDot.Size = new System.Drawing.Size(73, 73);
			this.btnDot.TabIndex = 19;
			this.btnDot.Text = ".";
			this.btnDot.UseVisualStyleBackColor = true;
			this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
			this.btnDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.pictureBox1.Location = new System.Drawing.Point(13, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(389, 80);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// labOperacion
			// 
			this.labOperacion.AutoSize = true;
			this.labOperacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labOperacion.Location = new System.Drawing.Point(26, 32);
			this.labOperacion.Name = "labOperacion";
			this.labOperacion.Size = new System.Drawing.Size(16, 17);
			this.labOperacion.TabIndex = 21;
			this.labOperacion.Text = "0";
			this.labOperacion.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.labOperacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// labIngresado
			// 
			this.labIngresado.AutoSize = true;
			this.labIngresado.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.labIngresado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labIngresado.Location = new System.Drawing.Point(23, 49);
			this.labIngresado.Name = "labIngresado";
			this.labIngresado.Size = new System.Drawing.Size(29, 31);
			this.labIngresado.TabIndex = 22;
			this.labIngresado.Text = "0";
			this.labIngresado.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.labIngresado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnC
			// 
			this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnC.Location = new System.Drawing.Point(169, 98);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(74, 73);
			this.btnC.TabIndex = 23;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.btnC_Click);
			this.btnC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnErase
			// 
			this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnErase.Location = new System.Drawing.Point(13, 98);
			this.btnErase.Name = "btnErase";
			this.btnErase.Size = new System.Drawing.Size(73, 73);
			this.btnErase.TabIndex = 24;
			this.btnErase.Text = "<-";
			this.btnErase.UseVisualStyleBackColor = true;
			this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
			this.btnErase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnAns
			// 
			this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAns.Location = new System.Drawing.Point(249, 98);
			this.btnAns.Name = "btnAns";
			this.btnAns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnAns.Size = new System.Drawing.Size(73, 73);
			this.btnAns.TabIndex = 25;
			this.btnAns.Text = "ANS";
			this.btnAns.UseVisualStyleBackColor = true;
			this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
			this.btnAns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnTriple0
			// 
			this.btnTriple0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTriple0.Location = new System.Drawing.Point(171, 418);
			this.btnTriple0.Name = "btnTriple0";
			this.btnTriple0.Size = new System.Drawing.Size(74, 73);
			this.btnTriple0.TabIndex = 26;
			this.btnTriple0.Text = "000";
			this.btnTriple0.UseVisualStyleBackColor = true;
			this.btnTriple0.Click += new System.EventHandler(this.btnTriple0_Click);
			this.btnTriple0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleKey);
			// 
			// btnPowY
			// 
			this.btnPowY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPowY.Location = new System.Drawing.Point(328, 339);
			this.btnPowY.Name = "btnPowY";
			this.btnPowY.Size = new System.Drawing.Size(73, 73);
			this.btnPowY.TabIndex = 27;
			this.btnPowY.Text = "x^y";
			this.btnPowY.UseVisualStyleBackColor = true;
			this.btnPowY.Click += new System.EventHandler(this.btnPowY_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(418, 503);
			this.Controls.Add(this.btnPowY);
			this.Controls.Add(this.btnTriple0);
			this.Controls.Add(this.btnAns);
			this.Controls.Add(this.btnErase);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.labIngresado);
			this.Controls.Add(this.labOperacion);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnDot);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btnSobreX);
			this.Controls.Add(this.btnRaiz);
			this.Controls.Add(this.btnPow);
			this.Controls.Add(this.btnCe);
			this.Controls.Add(this.btnPor);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnMenos);
			this.Controls.Add(this.btnMas);
			this.Controls.Add(this.btnIgual);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Name = "Form1";
			this.Text = "Calculadora";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnPor;
        private System.Windows.Forms.Button btnCe;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnSobreX;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labOperacion;
        private System.Windows.Forms.Label labIngresado;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnErase;
		private System.Windows.Forms.Button btnAns;
		private System.Windows.Forms.Button btnTriple0;
		private System.Windows.Forms.Button btnPowY;
	}
}

