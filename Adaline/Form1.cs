using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adaline
{
    public partial class Form1 : Form
    {
        Adaline ada;
        Bitmap bmpFondo;
        Bitmap bmpAnimacion;
        Pen planoPen;
        Brush ceroBrush;
        Brush unoBrush;
        List<Entradas> entradas;
        float error;
        public Form1()
        {
            InitializeComponent();
            bmpFondo = new Bitmap(1000, 1000);
            bmpAnimacion = new Bitmap(1000, 1000);
            entradas = new List<Entradas>();
            pictureBoxCanvas.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCanvas.BackgroundImage = bmpFondo;
            pictureBoxCanvas.Image = bmpAnimacion;
            planoPen = new Pen(Color.Black, 4);
            unoBrush = new SolidBrush(Color.Red);
            ceroBrush = new SolidBrush(Color.Blue);
            listBoxEntradas.DataSource = null;
            dibujarCanvas();
            error = 1;
        }

        void dibujarCanvas()
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            for (int i = 1; i < 10; i++)
            {
                g.DrawLine(planoPen, i * 100, 0, i * 100, 999);
                g.DrawLine(planoPen, 0, i * 100, 999, i * 100);
            }
            pictureBoxCanvas.Refresh();
        }

        private void buttonPesos_Click(object sender, EventArgs e)
        {
            ada = new Adaline((float)numericUpDownLR.Value);
            mostrarValores(false);
            dibujarCirculos();
            dibujarPlano();
        }
        private void mostrarValores(bool regre)
        {
            string b, w0, w1;

            b = "B: " + ada.Pesos[0].ToString();
            w0 = "W0: " + ada.Pesos[1].ToString();
            if(!regre)
                w1 = "W1: " + ada.Pesos[2].ToString();
            else
                w1 = "Error: " + error.ToString();

            labelW0.Text = b;
            labelW1.Text = w0;
            labelW2.Text = w1;
        }

        private void dibujarCirculos()
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            foreach (Entradas ent in entradas)
            {
                if (ent.Clase == -1)
                    g.FillEllipse(ceroBrush, ent.X * 100 + 490, ent.Y * -100 + 490, 20, 20);
                else
                    g.FillEllipse(unoBrush, ent.X * 100 + 490, ent.Y * -100 + 490, 20, 20);
            }

            pictureBoxCanvas.Refresh();
        }

        void dibujarPlano()
        {
            float y1, y2, x1, x2;

            Graphics g = Graphics.FromImage(bmpAnimacion);

            g.Clear(Color.Transparent);

            y1 = (ada.Pesos[0] - ada.Pesos[1] * -5) / ada.Pesos[2];
            y2 = (ada.Pesos[0] - ada.Pesos[1] * 5) / ada.Pesos[2];

            x1 = (ada.Pesos[0] - ada.Pesos[2] * -5) / ada.Pesos[1];
            x2 = (ada.Pesos[0] - ada.Pesos[2] * 5) / ada.Pesos[1];

            if (Math.Abs(y1) <= 5 && Math.Abs(y2) <= 5)
                g.DrawLine(planoPen, -5 * 100 + 500, y1 * -100 + 500, 5 * 100 + 500, y2 * -100 + 500);
            else
                g.DrawLine(planoPen, x1 * 100 + 500, 5 * 100 + 500, x2 * 100 + 500, -5 * 100 + 500);

            pictureBoxCanvas.Refresh();
        }

        void dibujarPlanoR()
        {
            float y1, y2, x1, x2;

            Graphics g = Graphics.FromImage(bmpAnimacion);

            g.Clear(Color.Transparent);

            y1 = (ada.Pesos[0] + ada.Pesos[1] * -5);
            y2 = (ada.Pesos[0] + ada.Pesos[1] * 5);

            x1 = (-5 - ada.Pesos[0]) / ada.Pesos[1];
            x2 = (5 - ada.Pesos[0]) / ada.Pesos[1];

            if (Math.Abs(y1) <= 5 && Math.Abs(y2) <= 5)
                g.DrawLine(planoPen, -5 * 100 + 500, y1 * -100 + 500, 5 * 100 + 500, y2 * -100 + 500);
            else if (Math.Abs(x1) <= 5 && Math.Abs(x2) <= 5)
                g.DrawLine(planoPen, x1 * 100 + 500, 5 * 100 + 500, x2 * 100 + 500, -5 * 100 + 500);
            else { }

            pictureBoxCanvas.Refresh();
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(bmpFondo);

            float x, y;

            x = (e.X * 2f - 500f) / 100f;
            y = -1f * ((e.Y * 2f - 500f) / 100f);

            if (e.Button == MouseButtons.Left) //Clase -1
            {
                entradas.Add(new Entradas(-1, x, y));
                g.FillEllipse(ceroBrush, e.X * 2 - 10, e.Y * 2 - 10, 20, 20);
            }
            if (e.Button == MouseButtons.Right) //Clase 1
            {
                entradas.Add(new Entradas(1, x, y));
                g.FillEllipse(unoBrush, e.X * 2 - 10, e.Y * 2 - 10, 20, 20);
            }

            listBoxEntradas.DataSource = null;
            listBoxEntradas.DataSource = entradas;
            pictureBoxCanvas.Refresh();
        }

        private void buttonClas_Click(object sender, EventArgs e)
        {
            if (ada == null)
                return;

            error = 1;
            int epoca;
            float res;
            epoca = 1;

            while (epoca <= numericUpDownEpocas.Value && error > (float)numericUpDownError.Value)
            {
                dibujarPlano();
                error = 0;

                foreach (Entradas ent in entradas)
                {
                    res = evaluar(ent.X, ent.Y);
                    ada.actualizar(ent.Clase - res, ent.X, ent.Y);
                    error += (ent.Clase - res) * (ent.Clase - res);
                }

                dibujarPlano();

                epoca++;

                error /= entradas.Count;
            }

            epoca--;

            string mess = "Termino en epoca " + epoca.ToString() + " con un error de: " + error.ToString();
            dibujarPlano();
            MessageBox.Show(mess);

            mostrarValores(false);
        }

        private void buttonReg_MouseClick(object sender, MouseEventArgs e)
        {
            if (ada == null)
                return;

            error = 1;
            int epoca;
            float res;
            epoca = 1;

            while (epoca <= numericUpDownEpocas.Value && error > (float)numericUpDownError.Value)
            {
                dibujarPlano();
                error = 0;

                foreach (Entradas ent in entradas)
                {
                    res = evaluar(ent.X);
                    ada.actualizar(ent.Y - res, ent.X);
                    error += (ent.Y - res) * (ent.Y - res);
                }

                dibujarPlanoR();

                epoca++;

                error /= entradas.Count;
            }

            epoca--;

            string mess = "Termino en epoca " + epoca.ToString() + " con un error de: " + error.ToString();
            dibujarPlano();
            MessageBox.Show(mess);

            mostrarValores(true);
        }
        private float evaluar(float x, float y)
        {
            if ((ada.Pesos[1] * x + ada.Pesos[2] * y - ada.Pesos[0]) >= 0)
                return 1;
            else
                return -1;
        }

        private float evaluar(float x)
        {
            return ada.Pesos[1] * x + ada.Pesos[0];
        }

        private void numericUpDownLR_ValueChanged(object sender, EventArgs e)
        {
            if (ada == null)
                return;

            ada.RA = (float)numericUpDownError.Value;
        } 
    }
}
