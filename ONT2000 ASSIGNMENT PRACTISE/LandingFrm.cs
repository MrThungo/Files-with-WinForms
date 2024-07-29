using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000_ASSIGNMENT_PRACTISE
{
    public partial class LandingFrm : Form
    {
        public LandingFrm()
        {
            InitializeComponent();
            LoadImages();
        }
        OpenFileDialog dg = new OpenFileDialog();

        public int count = 0;
        public int ctmr = 1;
        public int Imgcount = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            flwPnl.Width = 55;
            var now = DateTime.Now;
            label1.Text = now.ToString();
            timer1.Start();
            timer2.Start();
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                while (true)
                {
                    if (flwPnl.Width >= 45 & flwPnl.Width <= 210)
                    {
                        flwPnl.Width += 15;
                    }

                    if (flwPnl.Width >= 210)
                    {
                        count -= 15;
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

        private void btnStdnt_Click(object sender, EventArgs e)
        {
            FrmStudent std = new FrmStudent();

            std.Show();
            this.Hide();
        }

        private void btnPrprty_Click(object sender, EventArgs e)
        {
            FrmManageFlts flts = new FrmManageFlts();
            flts.Show();
            this.Hide();
        }

        private void flwPnl_MouseHover(object sender, EventArgs e)
        {

            while (true)
            {
                if (flwPnl.Width >= 45 & flwPnl.Width <= 210)
                {
                    flwPnl.Width += 15;

                }

                if (flwPnl.Width >= 210)
                {
                    break;
                }
            }
        }

        private void btnNav_MouseHover(object sender, EventArgs e)
        {
            while (true)
            {
                if (flwPnl.Width >= 45 & flwPnl.Width <= 210)
                {
                    flwPnl.Width += 15;

                }

                if (flwPnl.Width >= 210)
                {
                    break;
                }
            }
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            while (true)
            {
                if (flwPnl.Width >= 45 & flwPnl.Width <= 210)
                {
                    flwPnl.Width += 15;
                }

                if (flwPnl.Width >= 210)
                {
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

 

        private void LandingFrm_MouseEnter(object sender, EventArgs e)
        {
        }

        private void LandingFrm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void LandingFrm_Activated(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
       
        private ImageList LoadImages()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.IMG_20220714_WA0005);
            imageList.Images.Add(Properties.Resources.NDUMISO_FR_PRJ);
            imageList.Images.Add(Properties.Resources.Screenshot_20220724_162102_Duo);
            imageList.Images.Add(Properties.Resources.bckg);
            return imageList;
        }
    private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 5000;
            Imgcount++;

            if(Imgcount > 3)
            {
                Imgcount = 0;
            }
            else if(Imgcount == 0)
            {
                button6.BackgroundImage = Properties.Resources.IMG_20220714_WA0005;
            }
            else if (Imgcount == 1)
            {
                button6.BackgroundImage = Properties.Resources.NDUMISO_FR_PRJ;
            }
            else if(Imgcount == 2)
            {
                button6.BackgroundImage = Properties.Resources.phe_lu_ma;

            }
            else if(Imgcount == 3)
            {
                button6.BackgroundImage = Properties.Resources.bckg;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStudent std = new FrmStudent();
            std.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmManageFlts flts = new FrmManageFlts();
            flts.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Faultscs flts = new Faultscs();
            this.Hide();
            flts.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchFrm searchFrm = new SearchFrm();
            this.Hide();
            searchFrm.Show();
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            SearchFrm frm = new SearchFrm();
            this.Hide();
            frm.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chkImageInsert_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkImageInsert.Checked == true)
            //{
            //    OpenFileDialog dg = new OpenFileDialog();

            //    if (dg.ShowDialog() == DialogResult.OK)
            //    {
            //        this.circular1.Image = Image.FromFile(dg.FileName);
            //        chkImageInsert.Visible = false;
            //        circular1.Visible = true;
            //    }
            //}
            //else
            //{
            //    circular1.Visible = false;
            //    chkImageInsert.Visible = true;
            //}
        }

        private void circular1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Faultscs flts = new Faultscs();
            this.Hide();
            flts.Show();
        }
    }
}
    

