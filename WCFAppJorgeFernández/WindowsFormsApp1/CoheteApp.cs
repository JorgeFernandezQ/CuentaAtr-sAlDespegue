using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CoheteApp : Form
    {
        private int tiempoactual = 0;
        DateTime dt = new DateTime();
        public CoheteApp()
        {
            InitializeComponent();
            this.Text = "Cuenta regresiva en segundos";
            this.Reiniciar.Enabled = false;
            this.Temporizador.Enabled = false;
            this.Parar.Enabled = false;
            this.Temporizador.Visible = false;
            this.Cohete.Visible = false;
        }

        private void Comenzar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TiempoIntroducido.Text == "")
                {
                    MessageBox.Show("La aplicación no comenzará hasta que introduzca un número válido (en segundos). ", "Advertencia del programa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (this.Comenzar.Text == "Comenzar" || this.Comenzar.Text == "Reanudar")
                    {
                        this.Reiniciar.Enabled = true;
                        tiempoactual = int.Parse(this.TiempoIntroducido.Text);
                        this.timer1 = new System.Windows.Forms.Timer();
                        this.timer1.Tick += new EventHandler(timer1_Tick);
                        this.timer1.Interval = 1000;
                        this.timer1.Start();
                        this.timer1.Enabled = true;
                        this.Comenzar.Enabled = false;
                        this.Parar.Enabled = true;
                        this.Temporizador.Visible = true;
                        this.TiempoIntroducido.Enabled = false;
                        Temporizador.Text = dt.AddSeconds(tiempoactual).ToString("mm:ss");
                        TiempoIntroducido.Text = dt.AddSeconds(tiempoactual).ToString("mm:ss");
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("{0}  Excepción producida.", ex);
            }
           
        }

        private void Temporizador_TextChanged(object sender, EventArgs e)
        {
            try {
                
                if (this.TiempoIntroducido.Text.All(char.IsDigit) == true) {
                    Console.WriteLine("true");
                }
                else if (this.TiempoIntroducido.Text.All(char.IsDigit) == false)
                {
                    if (this.TiempoIntroducido.Text.Contains(":") == true)
                    {
                        Console.WriteLine("Continue3");
                    }
                    else
                    {
                        MessageBox.Show("No introduzca letras. Solo se pueden introducir números.", "Advertencia del programa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.TiempoIntroducido.Text = String.Empty;
                        Console.WriteLine("false");
                    }
                }
                if ((int.Parse(this.TiempoIntroducido.Text) < 0 ))
                {
                    MessageBox.Show("Solo se pueden introducir número mayores a 0.", "Advertencia del programa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.TiempoIntroducido.Text = String.Empty;
                }
                else {
                    Console.WriteLine("Continue");
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}  Excepción producida.", ex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Parar_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            try
            {
                tiempoactual--;
                if (tiempoactual == 0)
                {
                    timer1.Stop();
                    this.Comenzar.Visible = false;
                    this.Parar.Visible = false;
                    this.Cohete.Visible = true;
                }
                Temporizador.Text = dt.AddSeconds(tiempoactual).ToString("mm:ss");

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Excepción producida.", ex);
            }
            

        }

        private void Reiniciar_Click(object sender, EventArgs e)
        {
            this.Reiniciar.Enabled = false;
            this.timer1.Stop();
            this.Comenzar.Text = "Comenzar";
            this.Temporizador.Visible = false;
            this.TiempoIntroducido.Text = "";
            this.TiempoIntroducido.Enabled = true;
            this.Comenzar.Visible = true;
            this.Parar.Visible = true;
            this.Cohete.Visible = false;
            this.Comenzar.Enabled = true;
            this.Parar.Enabled = false;
        }

        private void Parar_Click_1(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Parar.Enabled = false;
            this.Comenzar.Enabled = true;
            this.Comenzar.Text = "Reanudar";
        }
    }
}
