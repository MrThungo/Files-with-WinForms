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
    public partial class Faultscs : Form
    {
        public Faultscs()
        {
            InitializeComponent();
            
        }

        public int count = 0;
        Random rn = new Random();
        public int fltID;
        public int temp = 0;
        private void Faultscs_Load(object sender, EventArgs e)
        {
            fltID = rn.Next(25, 350);

            string[] interns = null;
            string[] students = null;


            try
            {
                StreamReader reader = new StreamReader("Students.txt");

                //READING  STUDENTS FILE AND LOADING COMBOBOX
                while (!reader.EndOfStream)
                {
                    students = reader.ReadLine().Split('#');
                    cmbStudReport.Items.Add(students[1] + " " + students[2]);
                }
                reader.Close();

                //CHECKIMG IF FILE EMPTY
                //IF EMPTY SEND TO THE USERS FORM AND INSERT A STUDENT USER
                if (cmbStudReport.Items.Count == 0)
                {
                    MessageBox.Show("THE STUDENT FILE MUST NOT BE EMPTY!", "WARNING!");
                    this.Close();
                    FrmStudent std = new FrmStudent();
                    std.Show();
                }

                //READING  INTERNS FILE AND LOADING COMBOBOX
                reader = new StreamReader("Interns.txt");
                while (!reader.EndOfStream)
                {
                    interns = reader.ReadLine().Split('#');
                    cmbInternReport.Items.Add(interns[1] + " " + interns[2]);
                }
                reader.Close();

                //CHECKIMG IF FILE EMPTY
                //IF EMPTY SEND TO THE USERS FORM AND INSERT AN INTERN USER
                if (cmbInternReport.Items.Count == 0)
                {
                    MessageBox.Show("THE INTERN FILE MUST NOT BE EMPTY!", "WARNING!");
                    this.Close();
                    FrmStudent std = new FrmStudent();
                    std.Show();
                }

                //READING FROM FAULT TYPE AND LOADING THE DATA TO THE COMBO BOX
                try
                {

                    reader = new StreamReader("FaultTypes.txt");
                    string[] faultType = null;

                    while (!reader.EndOfStream)
                    {
                        faultType = reader.ReadLine().Split('#');
                        cmbFltType.Items.Add(faultType[1]);
                    }
                    reader.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("THE FAULT TYPE FILE MUST NOT BE EMPTY!", "WARNING");
                    FrmManageFlts flts = new FrmManageFlts();
                    this.Hide();
                    flts.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("THE INTERN/STUDENT FILE MUST NOT BE EMPTY!", "WARNING!");
                this.Close();
                FrmStudent std = new FrmStudent();
                std.Show();
            }


            txtID.Text = fltID.ToString();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LandingFrm ln = new LandingFrm();
            ln.Show();
            this.Close();
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
            flts.Show();
            this.Close();
        }
        private void btnNav_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                while (true)
                {
                    if (flwPnl.Width >= 45 & flwPnl.Width <= 228)
                    {
                        flwPnl.Width += 15;
                    }

                    if (flwPnl.Width >= 228)
                    {
                        count -= 1;
                        flwPnl.Width = 228;
                        break;
                    }
                }

            }
            else
            {
                while (flwPnl.Width >= 55)
                {
                    flwPnl.Width -= 25;

                }
                count = 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            fltID += rd.Next(1, 1005);
            temp += rd.Next(1, 1010);

            StreamWriter writer = new StreamWriter("Fault.txt",true);
            try
            {
                if (fltID != temp)
                {
                    if (!string.IsNullOrEmpty(txtDescrption.Text) & !string.IsNullOrEmpty(cmbInternReport.Text) & !string.IsNullOrEmpty(cmbStudReport.Text) & !string.IsNullOrEmpty(cmbFltType.Text)  )
                    {
                        writer.WriteLine(txtID.Text + "#" + txtDescrption.Text + "#" + cmbFltType.SelectedItem.ToString() + "#" + cmbStudReport.SelectedItem.ToString() + "#" + cmbInternReport.SelectedItem.ToString());
                        writer.Close();
                        MessageBox.Show("FAULT ADDED", "SUCCESSFUL", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        MessageBox.Show("THE FIELDS MUST NO BE EMPTY!");
                    }
                }
                else
                {
                    this.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("FIELD MUST NOT BE EMPTY!", "WARNING!");
                this.Show();
            }
            txtID.Text = fltID.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //READING FROM THE FILE AND DISPLAYING TO THE LISTBOX
            string[] faults = null;
            lsBox.Items.Clear();
            try
            {
                lsBox.Items.Add("Fault ID \t       Fault Description \t      Fault Type             Student Reporting \t       Intern Responsible\t");
                StreamReader reader = new StreamReader("Fault.txt");

                while (!reader.EndOfStream)
                {
                    faults = reader.ReadLine().Split('#');
                   
                    lsBox.Items.Add(faults[0] + " ".PadRight(12) + faults[2] + " ".PadRight(8) + faults[1] + " ".PadRight(10) + faults[3] + " ".PadRight(30) + faults[4]);
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
           

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            SearchFrm srch = new SearchFrm();
            this.Hide();
            srch.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
