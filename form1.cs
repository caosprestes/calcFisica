using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculdoraFisica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_f1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            //if para uma força, um angulo e um peso
            //f1, a e fp
            if (txt_f1.Text == "" && txt_a.Text == "" && txt_fp.Text == "")
            {
                double
                f1,
                f2 = Convert.ToDouble(txt_f2.Text),
                a,
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                kg = Convert.ToDouble(txt_kg.Text),
                fp = (Math.Round(kg * g, 2)),
                cosb = (Math.Cos(b * c)),
                sinb = (Math.Sin(b * c)),
                num = (fp - (f2 * sinb)),
                den = (f2 * cosb);

                a = Math.Round((Math.Atan(num / den)) / c, 2);
                f1 = Math.Round(((f2 * (Math.Cos(b * c))) / (Math.Cos(a * c))), 2);

                txt_fp.Text = fp.ToString();
                txt_a.Text = a.ToString();
                txt_f1.Text = f1.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //f1, a e kg
            if (txt_f1.Text == "" && txt_a.Text == "" && txt_kg.Text == "")
            {
                double
                f1,
                f2 = Convert.ToDouble(txt_f2.Text),
                a,
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2)),
                cosb = (Math.Cos(b * c)),
                sinb = (Math.Sin(b * c)),
                num = (fp - (f2 * sinb)),
                den = (f2 * cosb);

                a = Math.Round((Math.Atan(num / den)) / c, 2);
                f1 = Math.Round(((f2 * (Math.Cos(b * c))) / (Math.Cos(a * c))), 2);

                txt_kg.Text = kg.ToString();
                txt_a.Text = a.ToString();
                txt_f1.Text = f1.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //f2 e b e fp
            if (txt_f2.Text == "" && txt_b.Text == "" && txt_fp.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b,
                c = (Math.PI / 180),
                g = 9.8,
                kg = Convert.ToDouble(txt_kg.Text),
                fp = (Math.Round(kg * g, 2)),
                cosa = (Math.Cos(a * c)),
                sina = (Math.Sin(a * c)),
                num = (fp - (f1 * sina)),
                den = (f1 * cosa);

                b = Math.Round((Math.Atan(num / den)) / c, 2);
                f2 = Math.Round(((f1 * (Math.Cos(a * c))) / (Math.Cos(b * c))), 2);

                txt_fp.Text = fp.ToString();
                txt_b.Text = b.ToString();
                txt_f2.Text = f2.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //f2, b e kg
            if (txt_f2.Text == "" && txt_b.Text == "" && txt_kg.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b,
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2)),
                cosa = (Math.Cos(a * c)),
                sina = (Math.Sin(a * c)),
                num = (fp - (f1 * sina)),
                den = (f1 * cosa);

                b = Math.Round((Math.Atan(num / den)) / c, 2);
                f2 = Math.Round(((f1 * (Math.Cos(a * c))) / (Math.Cos(b * c))), 2);

                txt_kg.Text = kg.ToString();
                txt_b.Text = b.ToString();
                txt_f2.Text = f2.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //if para forças e pesos
            //if para f1, f2 e kg
            if (txt_f1.Text == "" && txt_f2.Text == "" && txt_kg.Text == "")
            {
                double
                f1,
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2));

                //criar a matriz
                double[,] sistema = new double[2, 3];

                //armazenar na matriz       
                sistema[0, 0] = Math.Cos(a * c);
                sistema[0, 1] = -(Math.Cos(b * c));
                sistema[0, 2] = 0;
                sistema[1, 0] = Math.Sin(a * c);
                sistema[1, 1] = Math.Sin(b * c);
                sistema[1, 2] = fp;

                //resultado
                double[] resultado = new double[3];
                resultado[0] = sistema[0, 0] * sistema[1, 1];
                resultado[1] = sistema[1, 0] * sistema[0, 1];
                resultado[2] = sistema[0, 0] * sistema[1, 2];

                f2 = Math.Round(resultado[2] / (resultado[0] - resultado[1]), 2);
                f1 = Math.Round(f2 * (Math.Cos(b * c) / Math.Cos(a * c)), 2);

                txt_f1.Text = f1.ToString();
                txt_f2.Text = f2.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;

            }

            //if para f1, f2 e fp
            if (txt_f1.Text == "" && txt_f2.Text == "" && txt_fp.Text == "")
            {
                double
                f1,
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                kg = Convert.ToDouble(txt_kg.Text),
                fp = (Math.Round(kg * g, 2));

                //criar a matriz
                double[,] sistema = new double[2, 3];

                //armazenar na matriz       
                sistema[0, 0] = Math.Cos(a * c);
                sistema[0, 1] = -(Math.Cos(b * c));
                sistema[0, 2] = 0;
                sistema[1, 0] = Math.Sin(a * c);
                sistema[1, 1] = Math.Sin(b * c);
                sistema[1, 2] = fp;

                //resultado
                double[] resultado = new double[3];
                resultado[0] = sistema[0, 0] * sistema[1, 1];
                resultado[1] = sistema[1, 0] * sistema[0, 1];
                resultado[2] = sistema[0, 0] * sistema[1, 2];

                f2 = Math.Round(resultado[2] / (resultado[0] - resultado[1]), 2);
                f1 = Math.Round(f2 * (Math.Cos(b * c) / Math.Cos(a * c)), 2);

                txt_f1.Text = f1.ToString();
                txt_f2.Text = f2.ToString();
                txt_fp.Text = fp.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //if para duas forças
            //if para f1 e f2
            if (txt_f1.Text == "" && txt_f2.Text == "")
            {
                double
                f1,
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2));

                //criar a matriz
                double[,] sistema = new double[2, 3];

                //armazenar na matriz       
                sistema[0, 0] = Math.Cos(a * c);
                sistema[0, 1] = -(Math.Cos(b * c));
                sistema[0, 2] = 0;
                sistema[1, 0] = Math.Sin(a * c);
                sistema[1, 1] = Math.Sin(b * c);
                sistema[1, 2] = fp;

                //resultado
                double[] resultado = new double[3];
                resultado[0] = sistema[0, 0] * sistema[1, 1];
                resultado[1] = sistema[1, 0] * sistema[0, 1];
                resultado[2] = sistema[0, 0] * sistema[1, 2];

                f2 = Math.Round(resultado[2] / (resultado[0] - resultado[1]), 2);
                f1 = Math.Round(f2 * (Math.Cos(b * c) / Math.Cos(a * c)), 2);

                txt_kg.Text = kg.ToString();
                txt_f1.Text = f1.ToString();
                txt_f2.Text = f2.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //if para angulo e força
            //f1 e a
            if (txt_a.Text == "" && txt_f1.Text == "")
            {
                double
                f1,
                f2 = Convert.ToDouble(txt_f2.Text),
                a,
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2)),
                cosb = (Math.Cos(b * c)),
                sinb = (Math.Sin(b * c)),
                num = (fp - (f2 * sinb)),
                den = (f2 * cosb);

                a = Math.Round((Math.Atan(num / den)) / c, 2);
                f1 = Math.Round(((f2 * (Math.Cos(b * c))) / (Math.Cos(a * c))), 2);

                txt_kg.Text = kg.ToString();
                txt_a.Text = a.ToString();
                txt_f1.Text = f1.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //f2 e b
            if (txt_f2.Text == "" && txt_b.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b,
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2)),
                cosa = (Math.Cos(a * c)),
                sina = (Math.Sin(a * c)),
                num = (fp - (f1 * sina)),
                den = (f1 * cosa);

                b = Math.Round((Math.Atan(num / den)) / c, 2);
                f2 = Math.Round(((f1 * (Math.Cos(a * c))) / (Math.Cos(b * c))), 2);

                txt_kg.Text = kg.ToString();
                txt_b.Text = b.ToString();
                txt_f2.Text = f2.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //if para angulo e peso
            //a e kg
            if (txt_a.Text == "" && txt_kg.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a,
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2));

                a = Math.Round((Math.Asin((fp - (f2 * Math.Sin(b * c))) / f1)) / c, 2);

                txt_a.Text = a.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //a e fp
            if (txt_a.Text == "" && txt_fp.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a,
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                kg = Convert.ToDouble(txt_kg.Text),
                fp = (Math.Round(kg * g, 2));

                a = Math.Round((Math.Asin((fp - (f2 * Math.Sin(b * c))) / f1)) / c, 2);

                txt_a.Text = a.ToString();
                txt_fp.Text = fp.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //b e kg
            if (txt_b.Text == "" && txt_kg.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a = Convert.ToDouble(txt_a.Text),
                b,
                c = (Math.PI / 180),
                g = 9.8,
                fp = Convert.ToDouble(txt_fp.Text),
                kg = (Math.Round(fp / g, 2));

                b = Math.Round((Math.Asin((fp - (f1 * Math.Sin(a * c))) / f2)) / c, 2);

                txt_b.Text = b.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //b e fp
            if (txt_b.Text == "" && txt_fp.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a = Convert.ToDouble(txt_a.Text),
                b,
                c = (Math.PI / 180),
                g = 9.8,
                kg = Convert.ToDouble(txt_kg.Text),
                fp = (Math.Round(kg * g, 2));

                b = Math.Round((Math.Asin((fp - (f1 * Math.Sin(a * c))) / f2)) / c, 2);

                txt_b.Text = b.ToString();
                txt_fp.Text = fp.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }


            // ifs para força peso e massa

            //f2 e kg ou fp
            if (txt_f2.Text == "" && txt_kg.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp,
                kg;

                f2 = Math.Round(((f1 * (Math.Cos(a * c))) / (Math.Cos(b * c))), 2);
                fp = Math.Round(((f1 * (Math.Sin(a * c))) + (f2 * (Math.Sin(b * c)))), 2);
                kg = (Math.Round(fp / g, 2));

                txt_f2.Text = f2.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            // f1 e kg ou fp
            if (txt_f1.Text == "" && txt_kg.Text == "" || txt_fp.Text == "")
            {
                double
                f1,
                f2 = Convert.ToDouble(txt_f2.Text),
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp,
                kg;

                f1 = Math.Round(((f2 * (Math.Cos(b * c))) / (Math.Cos(a * c))), 2);
                fp = Math.Round(((f1 * (Math.Sin(a * c))) + (f2 * (Math.Sin(b * c)))), 2);
                kg = (Math.Round(fp / g, 2));

                txt_f1.Text = f1.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            
            //f2 e fp
            if (txt_f2.Text == "" && txt_fp.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                kg = Convert.ToDouble(txt_kg.Text),
                fp = (Math.Round(kg * g, 2));

                f2 = Math.Round((fp - (f1 * (Math.Sin(a * c)))) / (Math.Sin(b * c)), 2);

                txt_f2.Text = f2.ToString();
                txt_fp.Text = fp.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //kg e fp
            if (txt_fp.Text == "" && txt_kg.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                g = 9.8,
                fp,
                kg;

                fp = Math.Round(f1 * Math.Sin(a * c) + f2 * Math.Sin(b * c), 2);
                kg = Math.Round(fp / g, 2);

                txt_fp.Text = fp.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }


            //f1
            if (txt_f1.Text == "")
            {
                double
                f1,
                f2 = Convert.ToDouble(txt_f2.Text),
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                fp = Convert.ToDouble(txt_fp.Text),
                g = 9.8,
                kg = Math.Round(fp / g, 2);

                f1 = Math.Round((fp - (f2 * (Math.Sin(b * c)))) / (Math.Sin(a * c)), 2);

                txt_f1.Text = f1.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //f2
            if (txt_f2.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2,
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                fp = Convert.ToDouble(txt_fp.Text),
                g = 9.8,
                kg = Math.Round(fp / g, 2);
                txt_kg.Text = kg.ToString();

                f2 = Math.Round((fp - (f1 * (Math.Sin(a * c)))) / (Math.Sin(b * c)), 2);

                txt_f2.Text = f2.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //a
            if (txt_a.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a,
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                fp = Convert.ToDouble(txt_fp.Text),
                g = 9.8,
                kg = Math.Round(fp / g, 2);

                a = Math.Round((Math.Asin((fp - (f2 * Math.Sin(b * c))) / f1)) / c, 2);

                txt_a.Text = a.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //b
            if (txt_b.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a = Convert.ToDouble(txt_a.Text),
                b,
                c = (Math.PI / 180),
                fp = Convert.ToDouble(txt_fp.Text),
                g = 9.8,
                kg = Math.Round(fp / g, 2);

                b = Math.Round((Math.Asin((fp - (f1 * Math.Sin(a * c))) / f2)) / c, 2);

                txt_b.Text = b.ToString();
                txt_kg.Text = kg.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }

            //kg ou fp
            if (txt_kg.Text == "" || txt_fp.Text == "")
            {
                double
                f1 = Convert.ToDouble(txt_f1.Text),
                f2 = Convert.ToDouble(txt_f2.Text),
                a = Convert.ToDouble(txt_a.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180),
                kg,
                fp,
                g = 9.8;

                fp = Math.Round(f1 * Math.Sin(a * c) + f2 * Math.Sin(b * c), 2);
                kg = Math.Round(fp / g, 2);

                txt_kg.Text = kg.ToString();
                txt_fp.Text = fp.ToString();
                txt_info.ForeColor = Color.Green;
                txt_info.Text = "Resultados!";
                txt_info.BackColor = Color.White;
            }
            
            //decomposições
            //decf1
            if (txt_f1x.Text == "" || txt_f1y.Text == "")
            {
                double
                f1x,
                f1y,
                f1 = Convert.ToDouble(txt_f1.Text),
                a = Convert.ToDouble(txt_a.Text),
                c = (Math.PI / 180);

                f1x = Math.Round(-(f1 * Math.Cos(a * c)), 2);
                f1y = Math.Round((f1 * Math.Sin(a * c)), 2);
                txt_f1x.Text = f1x.ToString() + " î";
                txt_f1y.Text = f1y.ToString() + " j";
            }

            //decf2
            if (txt_f2x.Text == "" || txt_f2y.Text == "")
            {

                double
                f2x,
                f2y,
                f2 = Convert.ToDouble(txt_f2.Text),
                b = Convert.ToDouble(txt_b.Text),
                c = (Math.PI / 180);

                f2x = Math.Round((f2 * Math.Cos(b * c)), 2);
                f2y = Math.Round((f2 * Math.Sin(b * c)), 2);
                txt_f2x.Text = f2x.ToString() + " î";
                txt_f2y.Text = f2y.ToString() + " j";
            }


            //decfp
            if (txt_fpx.Text == "" || txt_fpy.Text == "")
            {
                double
                fp = Convert.ToDouble(txt_fp.Text);
                
                txt_fpx.Text = 0 + " î";
                txt_fpy.Text = -fp + " j";
            }

            txt_f1.Text += "N";
            txt_f2.Text += "N";
            txt_fp.Text += "N";
            txt_a.Text += "º";
            txt_b.Text += "º";
            txt_kg.Text += "Kg";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_f1.Text = "";
            txt_f2.Text = "";
            txt_fp.Text = "";
            txt_a.Text = "";
            txt_b.Text = "";
            txt_kg.Text = "";
            txt_info.ForeColor = Color.White;
            txt_info.Text = "Informe os dois ângulos e uma força/massa!";
            txt_info.BackColor = Color.Black;
            txt_f1x.Text = "";
            txt_f1y.Text = "";
            txt_f2x.Text = "";
            txt_f2y.Text = "";
            txt_fpx.Text = "";
            txt_fpy.Text = "";
        }

        private void txt_kg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double
            f1x,
            f1y,
            f1 = Convert.ToDouble(txt_f1.Text),
            a = Convert.ToDouble(txt_a.Text),
            c = (Math.PI / 180);

            f1x = Math.Round(-(f1 * Math.Cos(a * c)), 2);
            f1y = Math.Round((f1 * Math.Sin(a * c)), 2);
            txt_f1x.Text = f1x.ToString() + " î";
            txt_f1y.Text = f1y.ToString() + " j";
        }

        private void txt_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double
            f1x = Convert.ToDouble(txt_f1x.Text),
            f1y = Convert.ToDouble(txt_f1y.Text),
            f1,
            a,
            c = (Math.PI / 180);

            f1 = Math.Round(Math.Sqrt((f1x * f1x) + (f1y * f1y)), 2);
            a = Math.Round((Math.Asin(((f1y / f1)))) / c, 2);
            txt_f1.Text = f1.ToString();
            txt_a.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double
            f2x,
            f2y,
            f2 = Convert.ToDouble(txt_f2.Text),
            b = Convert.ToDouble(txt_b.Text),
            c = (Math.PI / 180);

            f2x = Math.Round((f2 * Math.Cos(b * c)), 2);
            f2y = Math.Round((f2 * Math.Sin(b * c)), 2);
            txt_f2x.Text = f2x.ToString() + " î";
            txt_f2y.Text = f2y.ToString() + " j";
        }

        private void btn_decFp_Click(object sender, EventArgs e)
        {
            double
            fp = Convert.ToDouble(txt_fp.Text);

            txt_fpx.Text = 0 + " î";
            txt_fpy.Text = -fp + " j";
        }

        private void btn_comF2_Click(object sender, EventArgs e)
        {
            double
            f2x = Convert.ToDouble(txt_f2x.Text),
            f2y = Convert.ToDouble(txt_f2y.Text),
            f2,
            b,
            c = (Math.PI / 180);

            f2 = Math.Round(Math.Sqrt((f2x * f2x) + (f2y * f2y)), 2);
            b = Math.Round((Math.Asin(((f2y / f2)))) / c, 2);
            txt_f2.Text = f2.ToString();
            txt_b.Text = b.ToString();
        }

        private void btn_comFp_Click(object sender, EventArgs e)
        {
            double
            fpx = Convert.ToDouble(txt_fpx.Text),
            fpy = Convert.ToDouble(txt_fpy.Text),
            fp;

            fp = Math.Round(Math.Sqrt((fpx * fpx) + (fpy * fpy)), 2);
            txt_fp.Text = fp.ToString();
        }
    }
}
