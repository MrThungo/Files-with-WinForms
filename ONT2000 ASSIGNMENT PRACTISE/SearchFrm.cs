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
    public partial class SearchFrm : Form
    {
        public SearchFrm()
        {
            InitializeComponent();
        }
         public int count = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Faultscs flts = new Faultscs();
            flts.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void SearchFrm_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] faults = null;
            bool state = true;
            //SEARCHING THE FILE USING ID FIELD
            if (!string.IsNullOrEmpty(txtFault.Text))
            {
                try
                {

                    //READING FAULT FILE AND SEARCHING THROUGH THE FILE USING THE FAULTID
                    StreamReader reader = new StreamReader("Fault.txt");
                    while (!reader.EndOfStream)
                    {
                        faults = reader.ReadLine().Split('#');

                        if (txtFault.Text == faults[0])
                        {
                            lsBox.Items.Clear();
                            state = false;

                            lsBox.Items.Add("FaultID\tFault Type\t\t         Fault Description\tStudent Reporting\tIntern Responsible\n");
                            lsBox.Items.Add(faults[0] + "\t" + faults[1] + "\t" + faults[2] + "\t" + faults[3] + "\t" + faults[4]);
                        }
                    }

                    if (state )
                    {
                        MessageBox.Show(txtFault.Text.ToUpper() + " WAS NOT FOUND");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("THE FAULT FILE IS EMPTY!", "WARNING!");
                    Faultscs flt = new Faultscs();
                    this.Hide();
                    flt.Show();
                }
            }
            else
            {
                MessageBox.Show("THE FAULT FIELD MUST NOT BE EMPTY");
            }
            txtFault.Clear();
        }

        private void btnFltTyp_Click(object sender, EventArgs e)
        {
            string[] faultType = null;
            bool state = true;
            //SEARCHING THE FILE USING ID FIELD
            if (!string.IsNullOrEmpty(txtFaultType.Text))
            {
                try
                {
                    //READING FAULT FILE AND SEARCHING THROUGH THE FILE USING THE FAULTID
                    StreamReader reader = new StreamReader("FaultTypes.txt");
                    while (!reader.EndOfStream)
                    {
                        faultType = reader.ReadLine().Split('#');


                        if (txtFaultType.Text == faultType[0])
                        {
                            lsBox.Items.Clear();

                            lsBox.Items.Add("FaultTypeID" +"\tFault Description");
                            lsBox.Items.Add(faultType[0] + "\t\t" + faultType[1]);
                            state = false;
                        }

                    }
                    if (state)
                    {
                        lsBox.Items.Clear();
                        MessageBox.Show("FAULT TYPE ID NO FOUND");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("THE FAULT TYPE FILE IS EMPTY!", "WARNING!");
                    FrmManageFlts flttype = new FrmManageFlts();
                    this.Hide();
                    flttype.Show();
                }
            }
            else
            {
                MessageBox.Show("THE FAULT TYPE FIELD MUST NOT BE EMPTY");
            }

            txtFaultType.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             string[] stud = null;
            bool state = true;
            lsBox.Items.Clear();
            if (!string.IsNullOrEmpty(txtStudent.Text))
            {
                StreamReader reader = new StreamReader("Students.txt");

                try
                {

                    while (!reader.EndOfStream)
                    {
                        stud = reader.ReadLine().Split('#');
                        if (txtStudent.Text == stud[0])
                        {
                            lsBox.Items.Add("ID\tName\tSurname\t\tDate of Birth\t\tRole\tYear of Study");
                            lsBox.Items.Add(stud[0] + "\t" + stud[1] + "\t" + stud[2] + "\t\t" + stud[3] + "\t" + stud[4] +"\t" +stud[5]);
                            state = false;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("STUDENT FILE MUST NOT BE EMPTY!");
                    this.Hide();
                    FrmStudent.ActiveForm.Show();
                }
                if (state)
                {
                    MessageBox.Show(txtStudent.Text.ToUpper() + " WAS NOT FOUND");
                }

            }
            else
            {
                MessageBox.Show("STUDENT FIELD MUST NOT BE NULL!");
            }

            txtStudent.Clear();


        }

        private void btnNav_Click(object sender, EventArgs e)
        {
          

        }
    }
}
