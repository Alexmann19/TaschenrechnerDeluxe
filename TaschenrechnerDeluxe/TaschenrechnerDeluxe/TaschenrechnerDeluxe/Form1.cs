using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenrechnerDeluxe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double zahl1 = 0;
        public static double zahl2 = 0;
        public static double ergebnis = 0;
        public static string zahl1s = "";
        public static string zahl2s = "";
        public static string zahl1k = "";
        public static string zahl2k = "";
        public string zahl1e = "";
        public string zahl2e = "";
        public bool zweiteline = false;
        public bool delete1 = false;
        public bool delete2 = false;
        public int zeichen = 0;

        public void Rechnen (double zahl1d, double zahl2d)
        {
            if (zeichen == 3)
            {
                ergebnis = zahl1d + zahl2d;
                tbergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            if (zeichen == 1)
            {
                ergebnis = zahl1d * zahl2d;
                tbergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            if (zeichen == 2)
            {
                ergebnis = zahl1d / zahl2d;
                tbergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            if (zeichen == 4)
            {
                ergebnis = zahl1d - zahl2d;
                tbergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            if (zeichen == 5)
            {
                ergebnis = zahl2d / 100 * zahl1d;
                tbergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            if (zeichen == 6)
            {
                ergebnis = Math.Pow(zahl2d, 1.0 / zahl1d);
                tbergebnis.Text = Convert.ToString(ergebnis);
            }
            else
            {
                MessageBox.Show("Kein Mathe Zeichen Ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void zahl1i (string zahl1ss)
        {
            if (delete1 == true)
            {
                zahl1e = "";
                zahl1k = "";
                delete1 = false;
            }

            int count1 = zahl1k.Length;

            StringBuilder sb = new StringBuilder();

            sb.Append(zahl1k);

            sb.Insert(count1 ,zahl1ss, 1);

            zahl1e = sb.ToString();

            zahl1k = zahl1e;

            tbfeld1.Text = zahl1k;

            zahl1 = Convert.ToDouble(zahl1k);
        }

        public void zahl2i(string zahl2ss)
        {
            if (delete2 == true)
            {
                zahl2e = "";
                zahl2k = "";
                delete2 = false;
            }
            int zahlkl = Convert.ToInt32(zahl2ss);
            
            int count1 = zahl2k.Length;

            StringBuilder sb = new StringBuilder();

            sb.Append(zahl2k);

            sb.Insert(count1, zahl2ss, 1);

            zahl2e = sb.ToString();

            zahl2k = zahl2e;

            tbfeld2.Text = zahl2k;

            if (zeichen == 2 & tbfeld2.Text == "0")
            {
                MessageBox.Show("Man kann nicht durch 0 Dividieren", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbfeld2.Text = "";
                delete2 = true;
            }
            else
            zahl2 = Convert.ToDouble(zahl2k);
            
        }

        private void btaste1_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("1");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("1");
            }
        }

        private void btastemal_Click(object sender, EventArgs e)
        {
            zweiteline = true;
            zeichen = 1;
            tbzeichen.Text = "x";
            btastekomma.Enabled = true;
            if (tbfeld2.Text.Contains(",") == true)
            {
                btastekomma.Enabled = false;
            }
        }

        private void btaste2_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("2");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("2");
            }
        }

        private void btaste3_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("3");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("3");
            }
        }

        private void btuste4_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("4");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("4");
            }
        }

        private void btaste5_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("5");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("5");
            }
        }

        private void btaste6_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("6");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("6");
            }
        }

        private void btaste7_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("7");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("7");
            }
        }

        private void btaste8_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("8");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("8");
            }
        }

        private void btaste9_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i("9");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("9");
            }
        }

        private void btastekomma_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1i(",");
            }
            else
            if (zweiteline == true)
            {
                zahl2i(",");
            }
            btastekomma.Enabled = false;
        }

        private void btaste0_Click(object sender, EventArgs e)
        {
            if(zweiteline == false)
            {
                zahl1i("0");
            }
            else
            if (zweiteline == true)
            {
                zahl2i("0");
            }
        }

        private void btastegeteilt_Click(object sender, EventArgs e)
        {
            zweiteline = true;
            zeichen = 2;
            tbzeichen.Text = "/";
            btastekomma.Enabled = true;
            if (tbfeld2.Text.Contains(",") == true)
            {
                btastekomma.Enabled = false;
            }
        }

        private void btasteplus_Click(object sender, EventArgs e)
        {
            zweiteline = true;
            zeichen = 3;
            tbzeichen.Text = "+";
            btastekomma.Enabled = true;
            if (tbfeld2.Text.Contains(",") == true)
            {
                btastekomma.Enabled = false;
            }
        }

        private void btasteminus_Click(object sender, EventArgs e)
        {
            zweiteline = true;
            zeichen = 4;
            tbzeichen.Text = "-";
            btastekomma.Enabled = true;
            if (tbfeld2.Text.Contains(",") == true)
            {
                btastekomma.Enabled = false;
            }
        }

        private void btasteprozent_Click(object sender, EventArgs e)
        {
            zweiteline = true;
            zeichen = 5;
            tbzeichen.Text = "%";
            btastekomma.Enabled = true;
            if (tbfeld2.Text.Contains(",") == true)
            {
                btastekomma.Enabled = false;
            }
        }

        private void btastewurzel_Click(object sender, EventArgs e)
        {
            zweiteline = true;
            zeichen = 6;
            tbzeichen.Text = "Wurzel";
            btastekomma.Enabled = true;
            if (tbfeld2.Text.Contains(",") == true)
            {
                btastekomma.Enabled = false;
            }
        }

        private void bergebnis_Click(object sender, EventArgs e)
        {
            Rechnen(zahl1, zahl2);
            btastekomma.Enabled = true;
        }

        private void bdeleteall_Click(object sender, EventArgs e)
        {
            tbergebnis.Text = "";
            tbfeld1.Text = "";
            tbfeld2.Text = "";
            btastekomma.Enabled = true;
            zeichen = 0;
            tbzeichen.Text = "";
            zweiteline = false;
            delete1 = true;
            delete2 = true;
            
        }

        private void bsetergebnis1_Click(object sender, EventArgs e)
        {
            delete2 = true;
            tbfeld2.Text = "";
            tbergebnis.Text = "";
            zeichen = 0;
            tbzeichen.Text = "";
            zweiteline = false;
            
            tbfeld1.Text = Convert.ToString(ergebnis);
            zahl1k = Convert.ToString(ergebnis);
            zahl1 = ergebnis;
            if (zahl1k.Contains(",") == true)
            {
                btastekomma.Enabled = false;
            }
        }

        private void bsetergebnis2_Click(object sender, EventArgs e)
        {
            delete1 = true;
            tbfeld1.Text = "";
            tbergebnis.Text = "";
            zeichen = 0;
            tbzeichen.Text = "";
            zweiteline = false;

            tbfeld2.Text = Convert.ToString(ergebnis);
            zahl2k = Convert.ToString(ergebnis);
            zahl2 = ergebnis;
        }

        private void btastevminus_Click(object sender, EventArgs e)
        {
            if (zweiteline == false)
            {
                zahl1 = zahl1 * -1.0;
                tbfeld1.Text = Convert.ToString(zahl1);
            }
            else
            if (zweiteline == true)
            {
                zahl2 = zahl2 * -1.0;
                tbfeld2.Text = Convert.ToString(zahl2);
            }
        }
    }
}
