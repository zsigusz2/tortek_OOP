using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tortek
{
    public partial class frm_tortek : Form
    {
        public frm_tortek()
        {
            InitializeComponent();
        }
        //Globális változók
        Tortek s;
        int sz1, sz2, n1, n2;
        double eredmeny;

        //Kilépés gomb
        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Radio buttonok
        private void rb_osszeadas_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton seged = (RadioButton)sender; //netről néztem

            switch (seged.Name)
            {
                case "rb_osszeadas":
                    {
                        la_muveletijel.Text = "+";
                        la_eredmeny.Text = "";
                        break;
                    }

                case "rb_kivonas":
                    {
                        la_muveletijel.Text = "-";
                        la_eredmeny.Text = "";
                        break;
                    }

                case "rb_szorzas":
                    {
                        la_muveletijel.Text = "×";
                        la_eredmeny.Text = "";
                        break;
                    }

                case "rb_osztas":
                    {
                        la_muveletijel.Text = "/";
                        la_eredmeny.Text = "";
                        break;
                    }
            }
        }

        //Számolás
        private void bt_szamol_Click(object sender, EventArgs e)
        {
            //Összeadás
            if (rb_osszeadas.Checked == true)
            {
                if (tb_szamlalo1.Text == "" || tb_szamlalo2.Text == "" || tb_nevezo1.Text == "" || tb_nevezo2.Text == "")
                {
                    MessageBox.Show("Kérem, minden mezőt töltsön ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sz1 = int.Parse(tb_szamlalo1.Text);
                    n1 = int.Parse(tb_nevezo1.Text);
                    sz2 = int.Parse(tb_szamlalo2.Text);
                    n2 = int.Parse(tb_nevezo2.Text);

                    s = new Tortek(sz1, n1, sz2, n2);
                    eredmeny = s.Osszeadas();
                    la_eredmeny.Text = eredmeny.ToString("#0.###");
                }
            }

            //Kivonás
            else if (rb_kivonas.Checked == true)
            {
                if (tb_szamlalo1.Text == "" || tb_szamlalo2.Text == "" || tb_nevezo1.Text == "" || tb_nevezo2.Text == "")
                {
                    MessageBox.Show("Kérem, minden mezőt töltsön ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sz1 = int.Parse(tb_szamlalo1.Text);
                    n1 = int.Parse(tb_nevezo1.Text);
                    sz2 = int.Parse(tb_szamlalo2.Text);
                    n2 = int.Parse(tb_nevezo2.Text);

                    s = new Tortek(sz1, n1, sz2, n2);
                    eredmeny = s.Kivonas();
                    la_eredmeny.Text = eredmeny.ToString("#0.###");
                }
            }

            //Szorzás
            else if (rb_szorzas.Checked == true)
            {
                if (tb_szamlalo1.Text == "" || tb_szamlalo2.Text == "" || tb_nevezo1.Text == "" || tb_nevezo2.Text == "")
                {
                    MessageBox.Show("Kérem, minden mezőt töltsön ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sz1 = int.Parse(tb_szamlalo1.Text);
                    n1 = int.Parse(tb_nevezo1.Text);
                    sz2 = int.Parse(tb_szamlalo2.Text);
                    n2 = int.Parse(tb_nevezo2.Text);

                    s = new Tortek(sz1, n1, sz2, n2);
                    eredmeny = s.Szorzas();
                    la_eredmeny.Text = eredmeny.ToString("#0.###");
                }
            }

            //Osztás
            else if (rb_osztas.Checked == true)
            {
                if (tb_szamlalo1.Text == "" || tb_szamlalo2.Text == "" || tb_nevezo1.Text == "" || tb_nevezo2.Text == "")
                {
                    MessageBox.Show("Kérem, minden mezőt töltsön ki!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sz1 = int.Parse(tb_szamlalo1.Text);
                    n1 = int.Parse(tb_nevezo1.Text);
                    sz2 = int.Parse(tb_szamlalo2.Text);
                    n2 = int.Parse(tb_nevezo2.Text);

                    s = new Tortek(sz1, n1, sz2, n2);
                    eredmeny = s.Osztas();
                    la_eredmeny.Text = eredmeny.ToString("#0.###");
                }
            }
        }
    }
}
