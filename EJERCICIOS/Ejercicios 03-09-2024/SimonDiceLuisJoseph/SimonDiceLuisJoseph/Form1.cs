using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SimonDiceLuisJoseph
{
    public partial class Form1 : Form
    {

        Random ran = new Random();
        Timer tiempo;
        int contador = 0;
        int cifra = 600;
        Button boton;

        List<int> secuencia_generada = new List<int>();
        List<int> secuencia_insertada = new List<int>();
        public Form1()
        {
            InitializeComponent();
            pbColor.BackColor = Color.White;
        }

        private void generarSecuencia(object sender, EventArgs e)
        {
            //Borra la lista para cuando tenga que regenerarse
            secuencia_generada.Clear();

            //Inserción de 4 valores aleatorios en lista
            for (int x = 0; x < 4; x++)
            {
                secuencia_generada.Add(ran.Next(0,4));           
            
            }

            muestraColor(sender, e);    

        }

        private async void insertarColor(object sender, EventArgs e)
        {
            //Casting de sender a botón
            boton = sender as Button;

            if (contador < 4)
            {
                //Reconocimiento de la cifra en el nombre para identificar el botón pulsado
                switch (boton.Name[boton.Name.Length - 1])
                {

                    case '0':
                        secuencia_insertada.Add(0);
                        pbColor.BackColor = Color.Blue;
                        contador++;
                        break;

                    case '1':
                        secuencia_insertada.Add(1);
                        pbColor.BackColor = Color.Green;
                        contador++;
                        break;

                    case '2':
                        secuencia_insertada.Add(2); 
                        pbColor.BackColor = Color.Yellow;
                        contador++;
                        break;

                    case '3':
                        secuencia_insertada.Add(3);
                        pbColor.BackColor = Color.Red;
                        contador++;
                        break;

                }
            }

             if (contador == 4){
                //Identificar si se ha pulsado la misma secuencia de números que los generados.
                bool sonIguales = secuencia_generada.OrderBy(x => x).SequenceEqual(secuencia_insertada.OrderBy(x => x));
                //Si se ha acercado y el adelanto no es 0, se reduce la velocidad y se generan nuevos números.
                if (sonIguales) {
                    MessageBox.Show("¡¡¡Has acertado!!!");  
                    contador = 0;
                    if (cifra > 20)
                    {
                        Task.Delay(cifra - 20);
                        MessageBox.Show("¡¡¡Velocidad aumentada!!!");
                    }
                    else {
                        MessageBox.Show("¡¡¡No se ha podido aumentar la velocidad!!!");
                    }
                    
                    secuencia_insertada.Clear();
                    generarSecuencia(sender, e);
                }
                else {
                    MessageBox.Show("¡¡¡Te has equivocado!!!");   
                    this.Close();
                }
            }


        }

            private async void muestraColor(object sender, EventArgs e)
        {

            for (int x = 0; x < 4; x++)
            {

                pbColor.BackColor = Color.White;
                switch (secuencia_generada[x])
                {

                    case 0:
                        
                        pbColor.BackColor = Color.Blue;
                        

                        break;
                        

                    case 1:
                        
                        pbColor.BackColor = Color.Green;

                        break;

                    case 2:

                        pbColor.BackColor = Color.Yellow;

                        break;

                    case 3:
                        
                        pbColor.BackColor = Color.Red;

                        break;
                
                }
         
                await Task.Delay(cifra);
                pbColor.BackColor = Color.White;

            }
        }
    }
}
