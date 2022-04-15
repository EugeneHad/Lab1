using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 3;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold);

           for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Gold;
                    dataGridView1.Rows[i].Cells[j].Style.ForeColor = Color.DarkBlue;
                   
                }
            }
            dataGridView1.Rows[0].Cells[0].Value = "Стратегии";
            dataGridView1.Rows[0].Cells[1].Value = "Молчать";
            dataGridView1.Rows[0].Cells[2].Value = "Сознаться";
            dataGridView1.Rows[1].Cells[0].Value = "Молчать";
            dataGridView1.Rows[2].Cells[0].Value = "Сознаться";

           /* dataGridView1.Rows[1].Cells[1].Value = "-25;-25";
            dataGridView1.Rows[1].Cells[2].Value = "50;0";
            dataGridView1.Rows[2].Cells[1].Value = "0;50";
            dataGridView1.Rows[2].Cells[2].Value = "15;15";*/

            dataGridView1.Rows[1].Cells[1].Value = "-10;5";
            dataGridView1.Rows[1].Cells[2].Value = "2;-2";
            dataGridView1.Rows[2].Cells[1].Value = "1;-1";
            dataGridView1.Rows[2].Cells[2].Value = "-1;1";
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            textBox1.Clear();
           
            try
            { 
                string[] a11 = dataGridView1.Rows[1].Cells[1].Value.ToString().Split(';');
                string[] a12 = dataGridView1.Rows[1].Cells[2].Value.ToString().Split(';');
                string[] a21 = dataGridView1.Rows[2].Cells[1].Value.ToString().Split(';');
                string[] a22 = dataGridView1.Rows[2].Cells[2].Value.ToString().Split(';');

                int c1 = Convert.ToInt32(a11[0]) - Convert.ToInt32(a12[0]) - Convert.ToInt32(a21[0]) + Convert.ToInt32(a22[0]);
                int a1 = Convert.ToInt32(a22[0]) - Convert.ToInt32(a12[0]);
                int d1 = Convert.ToInt32(a11[1]) - Convert.ToInt32(a12[1]) - Convert.ToInt32(a21[1]) + Convert.ToInt32(a22[1]);
                int b1 = Convert.ToInt32(a22[1]) - Convert.ToInt32(a21[1]);
                
            }
            catch 
            {
                MessageBox.Show("Вызвано исключение при обработке входных данных !");

                goto metka;
            }
            
                string[] s11 = dataGridView1.Rows[1].Cells[1].Value.ToString().Split(';');
                string[] s12 = dataGridView1.Rows[1].Cells[2].Value.ToString().Split(';');
                string[] s21 = dataGridView1.Rows[2].Cells[1].Value.ToString().Split(';');
                string[] s22 = dataGridView1.Rows[2].Cells[2].Value.ToString().Split(';');

                int c = Convert.ToInt32(s11[0]) - Convert.ToInt32(s12[0]) - Convert.ToInt32(s21[0]) + Convert.ToInt32(s22[0]);
                int a = Convert.ToInt32(s22[0]) - Convert.ToInt32(s12[0]);
                int d = Convert.ToInt32(s11[1]) - Convert.ToInt32(s12[1]) - Convert.ToInt32(s21[1]) + Convert.ToInt32(s22[1]);
                int b = Convert.ToInt32(s22[1]) - Convert.ToInt32(s21[1]);

            /*textBox1.Text += "C= " + c + '\r' + '\n';
            textBox1.Text += "alpha= " + a + '\r' + '\n';
            textBox1.Text += "D= " + d + '\r' + '\n';
            textBox1.Text += "beta= " + b + '\r' + '\n';*/

            if ((c == 0) || (d == 0))
            {
                
                    textBox1.Clear();
                    string[] s1 = dataGridView1.Rows[1].Cells[1].Value.ToString().Split(';');
                    string[] s2 = dataGridView1.Rows[1].Cells[2].Value.ToString().Split(';');
                    string[] s3 = dataGridView1.Rows[2].Cells[1].Value.ToString().Split(';');
                    string[] s4 = dataGridView1.Rows[2].Cells[2].Value.ToString().Split(';');

                    string[] P1 = new string[2];
                    if (Convert.ToInt32(s1[0]) > Convert.ToInt32(s3[0]))
                    {
                        P1[0] = "1;1";
                    }
                    else { P1[0] = "2;1"; }

                    if (Convert.ToInt32(s2[0]) > Convert.ToInt32(s4[0]))
                    {
                        P1[1] = "1;2";
                    }
                    else { P1[1] = "2;2"; }

                    string[] P2 = new string[2];

                    if (Convert.ToInt32(s1[1]) > Convert.ToInt32(s2[1]))
                    {
                        P2[0] = "1;1";
                    }
                    else { P2[0] = "1;2"; }

                    if (Convert.ToInt32(s3[1]) > Convert.ToInt32(s4[1]))
                    {
                        P2[1] = "2;1";
                    }
                    else { P2[1] = "2;2"; }

                    bool[] srav = new bool[4];
                    srav[0] = P1[0].Equals(P2[0]);
                    srav[1] = P1[0].Equals(P2[1]);
                    srav[2] = P1[1].Equals(P2[0]);
                    srav[3] = P1[1].Equals(P2[1]);
                textBox1.Text += "Равновесие по Нэшу в чистых стратегиях достигается при следующем выборе игроков :" + '\r' + '\n' + '\r' + '\n';
                for (int i = 0; i < 4; i++)
                    {
                        if ((srav[i] == true) && ((i == 0) || (i == 1)))
                        {
                            string[] res1 = P1[0].Split(';');
                            textBox1.Text += " " + dataGridView1.Rows[Convert.ToInt32(res1[0])].Cells[0].Value;
                            textBox1.Text += "; " + dataGridView1.Rows[0].Cells[Convert.ToInt32(res1[1])].Value;
                        }
                        if ((srav[i] == true) && ((i == 2) || (i == 3)))
                        {
                            string[] res2 = P1[1].Split(';');
                            textBox1.Text += " " + dataGridView1.Rows[Convert.ToInt32(res2[0])].Cells[0].Value;
                            textBox1.Text += "; " + dataGridView1.Rows[0].Cells[Convert.ToInt32(res2[1])].Value;

                        }
                    }


                
            }
            else
            {

                double q1 = a / (double)c;// при p=1        p(Cq-a)≥0 ; при p=0       (p - 1)(Cq - a)≥0,

                double p1 = b / (double)d;// при q=1        q(Dq-b)≥0;  при q=0       (q - 1)(Dq - b)≥0,


                if (p1 < 0) { p1 = p1 * (-1); }
                if (q1 < 0) { q1 = q1 * (-1); }

                textBox1.Text += "При p=1 имеем q ≤ " + String.Format("{0:F2}", q1) + '\r' + '\n';
                textBox1.Text += "При p=0 имеем  q ≥ " + String.Format("{0:F2}", q1) + '\r' + '\n';
                textBox1.Text += "При 0<p<1 имеем  q = " + String.Format("{0:F2}", q1) + '\r' + '\n';
                textBox1.Text += "При q=1 имеем p ≤ " + String.Format("{0:F2}", p1) + '\r' + '\n';
                textBox1.Text += "При q=0 имеем  p ≥ " + String.Format("{0:F2}", p1) + '\r' + '\n';
                textBox1.Text += "При 0<q<1 имеем  p = " + String.Format("{0:F2}", p1) + '\r' + '\n' + '\r' + '\n';



                double H1 = (Convert.ToInt32(s11[0]) + Convert.ToInt32(s22[0]) - Convert.ToInt32(s12[0]) - Convert.ToInt32(s21[0])) *
                   (p1) * (q1) + (Convert.ToInt32(s12[0]) - Convert.ToInt32(s22[0])) * (p1) +
                   (Convert.ToInt32(s21[0]) - Convert.ToInt32(s22[0])) * (q1) + Convert.ToInt32(s22[0]);
                double H2 = (Convert.ToInt32(s11[1]) + Convert.ToInt32(s22[1]) - Convert.ToInt32(s12[1]) - Convert.ToInt32(s21[1])) *
                  (p1) * (q1) + (Convert.ToInt32(s12[1]) - Convert.ToInt32(s22[1])) * (p1) +
                  (Convert.ToInt32(s21[1]) - Convert.ToInt32(s22[1])) * (q1) + Convert.ToInt32(s22[1]);
                textBox1.Text += "Смешанные стратегии игроков имеют вид: " + '\r' + '\n';
                textBox1.Text += "P(p*,1-p*) = (" + String.Format("{0:F2}", p1) + ';' + String.Format("{0:F2}", (1 - p1)) + ')' + '\r' + '\n';
                textBox1.Text += "Q(q*,1-q*) = (" + String.Format("{0:F2}", q1) + ';' + String.Format("{0:F2}", (1 - q1)) + ')' + '\r' + '\n' + '\r' + '\n';
                textBox1.Text += "Средние выигрыши игроков в точке равновесия: " + '\r' + '\n';
                textBox1.Text += "H1 = " + String.Format("{0:F2}", H1) + '\r' + '\n';
                textBox1.Text += "H2 = " + String.Format("{0:F2}", H2) + '\r' + '\n';

            
            }
        metka:;
        }

        
    }
}
