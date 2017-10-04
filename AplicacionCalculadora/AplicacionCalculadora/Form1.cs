using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCalculadora
{
    public partial class Form1 : Form
    {
		public String SEPARADOR_DECIMAL = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		public const String MAS ="+",
			MENOS ="-",
			POR="*",
			DIV="/",
			FRACCION="/x",
			POW ="^2",
			RAIZ ="raiz",
			POWY = "^",
			CERO ="0";
		private String simbolo;
		private double ans;
		private ServicioCalculadora.CalculadoraClient calculadora;
		private Boolean ultimoOperacion;

		public Form1()
        {
            InitializeComponent();
			calculadora = new ServicioCalculadora.CalculadoraClient();
			ultimoOperacion = false;
			simbolo = "";
			ans = 0;
			comprobarIngresado();
		}

		/**
		 * Helpers
		 */

        private void resetIngresado()
        {
            labIngresado.Text = CERO;
			pictureBox1.Focus();
		}

        private void comprobarIngresado()
        {
            if (labIngresado.Text.Length >= 20)
            {
                btnErase_Click(null, null);
			}
			pictureBox1.Focus();
		}
		private void actualizarOperacion()
		{
			if (ultimoOperacion)
			{
				labOperacion.Text = labOperacion.Text + " " + simbolo;
			}
			else
			{
				labOperacion.Text = labIngresado.Text + " " + simbolo;
			}
			ultimoOperacion = true;
			resetIngresado();
			pictureBox1.Focus();
		}
		private void actualizarNumero(double numero)
		{
			
			if (labIngresado.Text == CERO)
			{
				labIngresado.Text = numero + "";
			}
			else
			{
				labIngresado.Text += numero + "";
			}
			ultimoOperacion = false;
			comprobarIngresado();
		}
		private void handleKey(object sender, KeyEventArgs e)
		{
			//MessageBox.Show(e.KeyData.ToString(), "Se presiono", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			switch (e.KeyData)
			{
				case Keys.NumPad1:
					{
						btn1_Click(sender, e);
						break;
					}
				case Keys.NumPad2:
					{
						btn2_Click(sender, e);
						break;
					}
				case Keys.NumPad3:
					{
						btn3_Click(sender, e);
						break;
					}
				case Keys.NumPad4:
					{
						btn4_Click(sender, e);
						break;
					}
				case Keys.NumPad5:
					{
						btn5_Click(sender, e);
						break;
					}
				case Keys.NumPad6:
					{
						btn6_Click(sender, e);
						break;
					}
				case Keys.NumPad7:
					{
						btn7_Click(sender, e);
						break;
					}
				case Keys.NumPad8:
					{
						btn8_Click(sender, e);
						break;
					}
				case Keys.NumPad9:
					{
						btn9_Click(sender, e);
						break;
					}
				case Keys.NumPad0:
					{
						btn0_Click(sender, e);
						break;
					}
				case Keys.Back:
					{
						btnErase_Click(sender, e);
						break;
					}
				case Keys.Add:
					{
						btnMas_Click(sender, e);
						break;
					}
				case Keys.Subtract:
					{
						btnMenos_Click(sender, e);
						break;
					}
				case Keys.Divide:
					{
						btnDiv_Click(sender, e);
						break;
					}
				case Keys.Multiply:
					{
						btnPor_Click(sender, e);
						break;
					}
				case Keys.Decimal:
					{
						btnDot_Click(sender, e);
						break;
					}
				case Keys.Return:
					{
						btnIgual_Click(sender, e);
						break;
					}
				default:
					{
						break;
					}
			}
		}
		/**
		 * Botones borrar
		 */
		private void btnCe_Click(object sender, EventArgs e)
        {
            resetIngresado();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            resetIngresado();
            labOperacion.Text = CERO;
        }

		/**
		 * Numeros
		 */
        private void btn7_Click(object sender, EventArgs e)
        {
			actualizarNumero(7);
		}
		
        private void btn8_Click(object sender, EventArgs e)
        {
			actualizarNumero(8);
		}

        private void btn9_Click(object sender, EventArgs e)
        {
			actualizarNumero(9);
		}

        private void btn4_Click(object sender, EventArgs e)
        {
			actualizarNumero(4);
		}

        private void btn5_Click(object sender, EventArgs e)
        {
			actualizarNumero(5);
		}

        private void btn6_Click(object sender, EventArgs e)
        {
			actualizarNumero(6);
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			actualizarNumero(1);
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			actualizarNumero(2);
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			actualizarNumero(3);
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			if (labIngresado.Text != CERO)
			{
				labIngresado.Text +=CERO;
			}
			ultimoOperacion = false;
			comprobarIngresado();
		}
		private void btnTriple0_Click(object sender, EventArgs e)
		{
			if (labIngresado.Text != CERO)
			{
				labIngresado.Text += CERO+CERO+CERO;
			}
			ultimoOperacion = false;
			comprobarIngresado();
		}
		private void btnDot_Click(object sender, EventArgs e)
		{
			if (!labIngresado.Text.Contains(SEPARADOR_DECIMAL))
			{
				labIngresado.Text += SEPARADOR_DECIMAL;
			}
			ultimoOperacion = false;
			comprobarIngresado();
		}

		private void btnErase_Click(object sender, EventArgs e)
		{
			if (!ultimoOperacion)
			{
				labIngresado.Text = labIngresado.Text.Substring(0, labIngresado.Text.Length - 1).Trim();
				if (labIngresado.Text.Length == 0)
				{
					resetIngresado();
				}
			}
			else
			{
				simbolo = "";
				labOperacion.Text = labOperacion.Text.Substring(0, labOperacion.Text.Length - 1).Trim();
			}			
		}

		/**
		 * Operaciones unarias
		 */
		private void btnPow_Click(object sender, EventArgs e)
		{
			simbolo = POW;
			btnIgual_Click(sender, e);
			resetIngresado();
		}

		private void btnAns_Click(object sender, EventArgs e)
		{
			resetIngresado();
			actualizarNumero(ans);
		}

		

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			handleKey(sender, e);
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			MessageBox.Show("Se presiono", "My Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			handleKey(sender, e);
		}

		
		
		private void btnPowY_Click(object sender, EventArgs e)
		{
			if (simbolo.Equals(""))
			{
				simbolo = POWY;
				actualizarOperacion();
			}
			else if (ultimoOperacion)
			{
				btnErase_Click(sender, e);
				btnMas_Click(sender, e);
			}
			else
			{
				btnIgual_Click(sender, e);
			}
		}

		private void btnRaiz_Click(object sender, EventArgs e)
		{
			simbolo = RAIZ;
			btnIgual_Click(sender, e);
			resetIngresado();
		}

		
		private void btnSobreX_Click(object sender, EventArgs e)
		{
			simbolo = FRACCION;
			btnIgual_Click(sender, e);
			resetIngresado();
		}
		/**
		 * Operaciones binarias
		 */
		private void btnDiv_Click(object sender, EventArgs e)
        {
			if (simbolo.Equals(""))
			{
				simbolo = DIV;
				actualizarOperacion();
			}
			else if (ultimoOperacion)
			{
				btnErase_Click(sender, e);
				btnDiv_Click(sender, e);
			}
			else
			{
				btnIgual_Click(sender, e);
			}
		}

        private void btnPor_Click(object sender, EventArgs e)
        {
			if (simbolo.Equals(""))
			{
				simbolo = POR;
				actualizarOperacion();
			}
			else if (ultimoOperacion)
			{
				btnErase_Click(sender, e);
				btnPor_Click(sender, e);
			}
			else
			{
				btnIgual_Click(sender, e);
			}
		}

        private void btnMas_Click(object sender, EventArgs e)
        {
			if (simbolo.Equals(""))
			{
				simbolo = MAS;
				actualizarOperacion();
			}
			else if (ultimoOperacion)
			{
				btnErase_Click(sender, e);
				btnMas_Click(sender, e);
			}
			else
			{
				btnIgual_Click(sender, e);
			}
		}

        private void btnMenos_Click(object sender, EventArgs e)
        {
			if (simbolo.Equals(""))
			{
				simbolo = MENOS;
				actualizarOperacion();
			}
			else if (ultimoOperacion)
			{
				btnErase_Click(sender, e);
				btnMenos_Click(sender, e);
			}
			else
			{
				btnIgual_Click(sender, e);
			}
        }

		
		/**
		 * Igual
		 */
		private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado = 0, uno=0, dos=0;
           
            if (!simbolo.Equals(""))
			{        
                if(simbolo!=POW && simbolo!= RAIZ && simbolo != FRACCION)
                {
                    uno = Double.Parse(labOperacion.Text.Substring(0, labOperacion.Text.Length - 1));
                }
                dos = Double.Parse(labIngresado.Text);
            }
            switch (simbolo)
            {
                case MAS:                   
                    resultado = calculadora.sumar(uno, dos);
                    break;
                case MENOS:
                    resultado = calculadora.restar(uno, dos);
                    break;
                case DIV:
                    resultado = calculadora.dividir(uno, dos);
                    break;
                case POR:
                    resultado = calculadora.multiplicar(uno, dos);
                    break;
                case FRACCION:
                    resultado = calculadora.fraccionUno(dos);
                    break;
                case RAIZ:
                    resultado = calculadora.sqrt(dos);
                    break;
                case POW:
                    resultado = calculadora.cuadrado( dos);
                    break;
				case POWY:
					resultado = calculadora.pow(uno, dos);
					break;
            }
			ans = resultado;
            labIngresado.Text = resultado+"";
            labOperacion.Text = resultado + "";
            simbolo = "";
        }
		
	}
}
