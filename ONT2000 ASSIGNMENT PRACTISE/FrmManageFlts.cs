using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000_ASSIGNMENT_PRACTISE
{
    public partial class FrmManageFlts : Form
    {
        public FrmManageFlts()
        {
            InitializeComponent();
        }
        public int count = 0;
        public int faultID;

        private void FrmManageFlts_Load(object sender, EventArgs e)
        {
            lstBx.Items.Clear();
            flwPnl.Width = 55;
            Random r = new Random();
            faultID = r.Next(7, 100);
            txtFId.Text = faultID.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LandingFrm ln = new LandingFrm();
            this.Hide();
            ln.Show();
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                while (true)
                {
                    if (flwPnl.Width >= 45 & flwPnl.Width <= 200)
                    {
                        flwPnl.Width += 15;
                    }

                    if (flwPnl.Width >= 200)
                    {
                        count -= 1;
                        break;
                    }
                }

            }
            else
            {
                while (flwPnl.Width > 55)
                {
                    flwPnl.Width -= 15;
                }
                count = 1;
            }
        }

        private void flwPnl_MouseHover(object sender, EventArgs e)
        {
            while (true)
            {
                if (flwPnl.Width >= 45 & flwPnl.Width <= 200)
                {
                    flwPnl.Width += 15;

                }

                if (flwPnl.Width >= 200)
                {
                    break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            faultID += rd.Next(1, 1000);
            int temp = rd.Next(1, 1000);

            txtFId.Text = faultID.ToString();

            if (faultID != temp)
            {
                if (!string.IsNullOrEmpty(txtDesc.Text))
                {
                    
                    WriteFile(txtDesc.Text, txtFId.Text);
                }
                else
                {
                    MessageBox.Show("The field cannot be empty");
                }
            }
            else
            {
                this.Show();
            }
            txtDesc.Clear();
        }
      
        public static void WriteFile(string FaultType, string ID)
        {
            if (!string.IsNullOrEmpty(FaultType))
            {
                MessageBox.Show("Fault Description Added","Fault Description");
                StreamWriter writer = new StreamWriter("FaultTypes.txt", true);

                writer.WriteLine(ID +"#"+ FaultType);
                writer.Close();
            }
            else
            {
                MessageBox.Show("FIELD CANNOT BE EMPTY!", "WARNING");
                Console.Beep();
                Console.Beep();
            }
        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("FaultTypes.txt");
            string[] red = null;
            lstBx.Items.Clear();

            while (!reader.EndOfStream)
            {
                red = reader.ReadLine().Split('#');
                lstBx.Items.Add(red[0] + "\t\t" + red[1]);
            }
            reader.Close();
        }

        private void flwPnl_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            while (true)
            {
                if (flwPnl.Width >= 45 & flwPnl.Width <= 228)
                {
                    flwPnl.Width += 15;

                }

                if (flwPnl.Width >= 200)
                {
                    break;
                }
            }
        }

        private void btnStdnt_Click(object sender, EventArgs e)
        {
            FrmStudent student = new FrmStudent();
            student.Show();
            this.Hide();
        }

        private void btnPrprty_Click(object sender, EventArgs e)
        {
            FrmManageFlts student = new FrmManageFlts();
            student.Show();
            this.Hide();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            SearchFrm search = new SearchFrm();
            this.Hide();
            search.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faultscs flts = new Faultscs();
            flts.Show();
            this.Hide();
        }
    }
}
