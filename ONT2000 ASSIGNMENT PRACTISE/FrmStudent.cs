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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        public int count = 0;
        public int userId = 1000001;
        public string choic;
        private void btnHome_Click(object sender, EventArgs e)
        {
            LandingFrm ln = new LandingFrm();
            ln.Show();
            this.Hide();
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
       

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            txtStdnNo.Text = userId.ToString();
            cmbYr.Items.Add("First Year");cmbYr.Items.Add("Second Year");cmbYr.Items.Add("Third Year");cmbYr.Items.Add("Fourth Year");
            cmbRl.Items.Add("Student");cmbRl.Items.Add("Intern");

            FrmStudent frm = new FrmStudent();
            frm.ShowInTaskbar = false;

            cmbYr.Visible = false;
            lblYr.Visible = false;
            btnlst.Enabled = false;
            lblYr2.Visible = false;
        }

        private  void btnAdd_Click(object sender, EventArgs e)
        {
            string[] interns = GetInterns();
            string[] students = GetStudents();
            int rr = 0;
            try
            {
                //VALIDATE TEXTBOXES AND CMBS FOR THE INTERN
                if (!string.IsNullOrEmpty(txtNm.Text) & !string.IsNullOrEmpty(txtSrnm.Text) & !string.IsNullOrEmpty(dtpDao.Text) & !string.IsNullOrEmpty(cmbRl.Text))
                {

                    if (cmbRl.SelectedItem.ToString() == "Intern")
                    {
                        MessageBox.Show("Intern Added", "INTERN INFORMATION");
                        Random rn = new Random();
                        rr = rn.Next(1, 10000);
                        userId += rr;
                        txtStdnNo.Text = userId.ToString();

                        StreamWriter writer = new StreamWriter("Interns.txt", true);

                        if (txtStdnNo.Text != interns[0])
                        {
                            writer.Write(txtStdnNo.Text + "#" + txtNm.Text + "#" + txtSrnm.Text + "#" + dtpDao.Text + "#" + cmbRl.SelectedItem.ToString() + "\n");
                            writer.Close();
                        }
                        else
                        {
                            MessageBox.Show("Account Already In use!, Please try again", "WARNING");
                            rr += 15;
                        }


                    }
                    else
                    {
                        txtStdnNo.Text = userId.ToString();
                        
                        //VALIDATE YEAR OF STUDY FOR CMBYEAR
                        if (!string.IsNullOrEmpty(cmbYr.Text))
                        {
                            //VALIDATING USING USER ID TO MAKE SURE THERE ARE NO DUPLICATE USER IDs
                            if (txtStdnNo.Text != students[0])
                            {
                                MessageBox.Show("Student Added", "STUDENT INFORMATION");
                                StreamWriter writer = new StreamWriter("Students.txt", true);
                                writer.Write(txtStdnNo.Text + "#" + txtNm.Text + "#" + txtSrnm.Text + "#" + dtpDao.Text + "#" + cmbRl.SelectedItem.ToString() + "#" + cmbYr.SelectedItem.ToString() + "\n");

                                Random rn = new Random();
                                rr = rn.Next(1, 10000);
                                userId += rr;
                                txtStdnNo.Text = userId.ToString();

                                writer.Close();
                            }
                            else
                            {
                                MessageBox.Show("USER ID ALREADY EXISTS!", "WARNING");
                                rr += 15;
                            }
                        }
                        else
                        {
                            MessageBox.Show("THE FIELD CANNOT BE EMPTY");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("FIELDS CANNOT BE EMPTY!", "WARNING");
                }

            }
            catch (Exception )
            {
                throw new FormatException(MessageBox.Show("FORMAT ERROR").ToString());
            }

            txtNm.Clear();
            txtSrnm.Clear();
            dtpDao.ResetText();
            cmbRl.ResetText();
            cmbYr.ResetText();
        }
        public static string []GetInterns()
        {
            StreamReader reader = reader = new StreamReader("Interns.txt");
            string[] intrns = new string[5];

            while (!reader.EndOfStream)
            {
                intrns = reader.ReadLine().Split('#');
            }
            reader.Close();
            return intrns;
        }
        public static string[] GetStudents()
        {
            StreamReader reader = reader = new StreamReader("Interns.txt");
            string[] students = new string[5];

            while (!reader.EndOfStream)
            {
                students = reader.ReadLine().Split('#');
            }
            reader.Close();
            return students;

        }


        private void cmbRl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRl.SelectedItem.ToString() == "Intern")
            {
                cmbYr.Visible = false;
                lblYr.Visible = false;
                lblYr2.Visible = false;
            }
            else if(cmbRl.SelectedItem.ToString() == "Student")
            {
                cmbYr.Visible = true;
                lblYr.Visible = true;
                lblYr2.Visible = true;
            }
        }
       
        private void btnlst_Click(object sender, EventArgs e)
        {
            _.Items.Clear();

            StreamReader reader;

            if (rdIntrn.Checked == true)
            {
                choic = "Intern";


                if (choic == "Intern")
                {
                    cmbYr.Visible = false;
                    lblYr.Visible = false;

                    reader = new StreamReader("Interns.txt");
                    string[] intrns;
                   
                    while (!reader.EndOfStream)
                    {
                        intrns = reader.ReadLine().Split('#');

                        _.Items.Add(intrns[0] + " ".PadLeft(10) + intrns[1].PadLeft(10) + "\t\t  "+intrns[2]+"\t\t " + intrns[3] + "\t".PadLeft(13) + intrns[4]);
                    }
                    reader.Close();

                }
              

            }
            else if(rdStds.Checked == true)
            {

                //btnlst.Enabled = false;
                choic = "Students";

                if (choic == "Students")
                {
                    cmbYr.Visible = false;
                    lblYr.Visible = false;

                    reader = new StreamReader("Students.txt");
                    string[] intrns;

                    while (!reader.EndOfStream)
                    {
                        intrns = reader.ReadLine().Split('#');

                        _.Items.Add(intrns[0] + " ".PadLeft(10) + intrns[1].PadLeft(10) + "\t\t  " + intrns[2] + "\t\t " + intrns[3] + "\t".PadLeft(13) + intrns[4] + "\t\t "+ intrns[5]);
                    }
                    reader.Close();

                }

            }

        }

        private void rdIntrn_CheckedChanged(object sender, EventArgs e)
        {
            if(rdIntrn.Checked == true)
            {
                btnlst.Enabled = true;
                lblYr2.Visible = false;
                _.Items.Clear();

            }
            else
            {
                btnlst.Enabled = false;
            }
        }

        private void rdStds_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStds.Checked == true)
            {
                btnlst.Enabled = true;
                lblYr2.Visible = true;
                _.Items.Clear();
            }
            else
            {
                btnlst.Enabled = false;
            }
        }

        private void btnStdnt_Click(object sender, EventArgs e)
        {
            FrmStudent student = new FrmStudent();
            student.Show();
            this.Close();
        }

        private void btnPrprty_Click(object sender, EventArgs e)
        {
            FrmManageFlts student = new FrmManageFlts();
            student.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faultscs flts = new Faultscs();
            this.Close();
            flts.Show();
;        }

        private void btnSrch_Click_1(object sender, EventArgs e)
        {
            SearchFrm frm = new SearchFrm();
            this.Hide();
            frm.Show();
        }
    }
}
