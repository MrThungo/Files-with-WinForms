namespace ONT2000_ASSIGNMENT_PRACTISE
{
    partial class LandingFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingFrm));
            this.flwPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNav = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStdnt = new System.Windows.Forms.Button();
            this.btnPrprty = new System.Windows.Forms.Button();
            this.btnSrch = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flwpnlPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flwPnl.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flwpnlPictures.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwPnl
            // 
            this.flwPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.flwPnl.Controls.Add(this.btnNav);
            this.flwPnl.Controls.Add(this.btnHome);
            this.flwPnl.Controls.Add(this.btnStdnt);
            this.flwPnl.Controls.Add(this.btnPrprty);
            this.flwPnl.Controls.Add(this.btnSrch);
            this.flwPnl.Controls.Add(this.button4);
            this.flwPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwPnl.Location = new System.Drawing.Point(0, 0);
            this.flwPnl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flwPnl.Name = "flwPnl";
            this.flwPnl.Size = new System.Drawing.Size(210, 696);
            this.flwPnl.TabIndex = 3;
            this.flwPnl.MouseHover += new System.EventHandler(this.flwPnl_MouseHover);
            // 
            // btnNav
            // 
            this.btnNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnNav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNav.BackgroundImage")));
            this.btnNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnNav.Location = new System.Drawing.Point(3, 4);
            this.btnNav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNav.Name = "btnNav";
            this.btnNav.Size = new System.Drawing.Size(48, 32);
            this.btnNav.TabIndex = 0;
            this.btnNav.UseVisualStyleBackColor = false;
            this.btnNav.Click += new System.EventHandler(this.btnNav_Click);
            this.btnNav.MouseHover += new System.EventHandler(this.btnNav_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 43);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(222, 85);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnStdnt
            // 
            this.btnStdnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnStdnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStdnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdnt.ForeColor = System.Drawing.Color.White;
            this.btnStdnt.Location = new System.Drawing.Point(3, 134);
            this.btnStdnt.Name = "btnStdnt";
            this.btnStdnt.Size = new System.Drawing.Size(222, 85);
            this.btnStdnt.TabIndex = 2;
            this.btnStdnt.Text = "Manage Users";
            this.btnStdnt.UseVisualStyleBackColor = false;
            this.btnStdnt.Click += new System.EventHandler(this.btnStdnt_Click);
            this.btnStdnt.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnPrprty
            // 
            this.btnPrprty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnPrprty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrprty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrprty.ForeColor = System.Drawing.Color.White;
            this.btnPrprty.Location = new System.Drawing.Point(3, 225);
            this.btnPrprty.Name = "btnPrprty";
            this.btnPrprty.Size = new System.Drawing.Size(222, 85);
            this.btnPrprty.TabIndex = 3;
            this.btnPrprty.Text = "Manage Faults";
            this.btnPrprty.UseVisualStyleBackColor = false;
            this.btnPrprty.Click += new System.EventHandler(this.btnPrprty_Click);
            this.btnPrprty.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // btnSrch
            // 
            this.btnSrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.btnSrch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrch.ForeColor = System.Drawing.Color.White;
            this.btnSrch.Location = new System.Drawing.Point(3, 316);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(222, 85);
            this.btnSrch.TabIndex = 4;
            this.btnSrch.Text = "Search Faults";
            this.btnSrch.UseVisualStyleBackColor = false;
            this.btnSrch.Click += new System.EventHandler(this.btnSrch_Click);
            this.btnSrch.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(41)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 85);
            this.button4.TabIndex = 11;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-327, 287);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(327, 186);
            this.materialDrawer1.TabIndex = 9;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 6000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpeg");
            this.imageList1.Images.SetKeyName(1, "2.jpeg");
            this.imageList1.Images.SetKeyName(2, "3.jpeg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "TIME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.monthCalendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(14, 14);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.monthCalendar1);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(353, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(261, 230);
            this.materialCard1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(207, 328);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1094, 346);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(330, 300);
            this.button5.TabIndex = 1;
            this.button5.Text = "Search Faults";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(339, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 289);
            this.button2.TabIndex = 4;
            this.button2.Text = "Faults";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::ONT2000_ASSIGNMENT_PRACTISE.Properties.Resources.phe_lu_ma;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(658, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(433, 340);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(631, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 229);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manage Faults";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(333, 296);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage Users";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flwpnlPictures
            // 
            this.flwpnlPictures.AutoSize = true;
            this.flwpnlPictures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flwpnlPictures.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flwpnlPictures.Controls.Add(this.button3);
            this.flwpnlPictures.Controls.Add(this.materialCard1);
            this.flwpnlPictures.Controls.Add(this.button1);
            this.flwpnlPictures.Location = new System.Drawing.Point(204, 0);
            this.flwpnlPictures.Name = "flwpnlPictures";
            this.flwpnlPictures.Size = new System.Drawing.Size(969, 302);
            this.flwpnlPictures.TabIndex = 4;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "IMG-20220614-WA0002.jpg");
            this.imageList2.Images.SetKeyName(1, "NDUMISO FR PRJ.PNG");
            this.imageList2.Images.SetKeyName(2, "Screenshot_20220724-162102_Duo.jpg");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // LandingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1301, 696);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.flwPnl);
            this.Controls.Add(this.flwpnlPictures);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LandingFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.LandingFrm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.LandingFrm_MouseEnter);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LandingFrm_MouseMove);
            this.flwPnl.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flwpnlPictures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwPnl;
        private System.Windows.Forms.Button btnNav;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnStdnt;
        private System.Windows.Forms.Button btnPrprty;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.Button button4;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flwpnlPictures;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}