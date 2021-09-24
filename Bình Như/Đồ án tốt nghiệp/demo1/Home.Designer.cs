
namespace demo1
{
    partial class Home
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.palMainMenu = new System.Windows.Forms.Panel();
            this.tab7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.palsubmenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.palMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.palsubmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMainMenu
            // 
            this.palMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.palMainMenu.Controls.Add(this.tab7);
            this.palMainMenu.Controls.Add(this.tab6);
            this.palMainMenu.Controls.Add(this.tab5);
            this.palMainMenu.Controls.Add(this.tab4);
            this.palMainMenu.Controls.Add(this.tab3);
            this.palMainMenu.Controls.Add(this.tab2);
            this.palMainMenu.Controls.Add(this.tab1);
            this.palMainMenu.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.palMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.palMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.palMainMenu.Location = new System.Drawing.Point(0, 0);
            this.palMainMenu.Name = "palMainMenu";
            this.palMainMenu.Size = new System.Drawing.Size(177, 482);
            this.palMainMenu.TabIndex = 1;
            // 
            // tab7
            // 
            this.tab7.Active = false;
            this.tab7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab7.BorderRadius = 0;
            this.tab7.ButtonText = "Help";
            this.tab7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab7, BunifuAnimatorNS.DecorationType.None);
            this.tab7.DisabledColor = System.Drawing.Color.Gray;
            this.tab7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab7.Iconcolor = System.Drawing.Color.Transparent;
            this.tab7.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab7.Iconimage")));
            this.tab7.Iconimage_right = null;
            this.tab7.Iconimage_right_Selected = null;
            this.tab7.Iconimage_Selected = null;
            this.tab7.IconMarginLeft = 0;
            this.tab7.IconMarginRight = 0;
            this.tab7.IconRightVisible = true;
            this.tab7.IconRightZoom = 0D;
            this.tab7.IconVisible = true;
            this.tab7.IconZoom = 90D;
            this.tab7.IsTab = true;
            this.tab7.Location = new System.Drawing.Point(0, 349);
            this.tab7.Name = "tab7";
            this.tab7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab7.OnHoverTextColor = System.Drawing.Color.White;
            this.tab7.selected = false;
            this.tab7.Size = new System.Drawing.Size(177, 44);
            this.tab7.TabIndex = 9;
            this.tab7.Tag = "6";
            this.tab7.Text = "Help";
            this.tab7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab7.Textcolor = System.Drawing.Color.White;
            this.tab7.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab7.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab6
            // 
            this.tab6.Active = false;
            this.tab6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab6.BorderRadius = 0;
            this.tab6.ButtonText = "Settings";
            this.tab6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab6, BunifuAnimatorNS.DecorationType.None);
            this.tab6.DisabledColor = System.Drawing.Color.Gray;
            this.tab6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab6.Iconcolor = System.Drawing.Color.Transparent;
            this.tab6.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab6.Iconimage")));
            this.tab6.Iconimage_right = null;
            this.tab6.Iconimage_right_Selected = null;
            this.tab6.Iconimage_Selected = null;
            this.tab6.IconMarginLeft = 0;
            this.tab6.IconMarginRight = 0;
            this.tab6.IconRightVisible = true;
            this.tab6.IconRightZoom = 0D;
            this.tab6.IconVisible = true;
            this.tab6.IconZoom = 90D;
            this.tab6.IsTab = true;
            this.tab6.Location = new System.Drawing.Point(0, 305);
            this.tab6.Name = "tab6";
            this.tab6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab6.OnHoverTextColor = System.Drawing.Color.White;
            this.tab6.selected = false;
            this.tab6.Size = new System.Drawing.Size(177, 44);
            this.tab6.TabIndex = 8;
            this.tab6.Tag = "5";
            this.tab6.Text = "Settings";
            this.tab6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab6.Textcolor = System.Drawing.Color.White;
            this.tab6.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab6.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab5
            // 
            this.tab5.Active = false;
            this.tab5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab5.BorderRadius = 0;
            this.tab5.ButtonText = "   Bán hàng";
            this.tab5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab5, BunifuAnimatorNS.DecorationType.None);
            this.tab5.DisabledColor = System.Drawing.Color.Gray;
            this.tab5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab5.Iconcolor = System.Drawing.Color.Transparent;
            this.tab5.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab5.Iconimage")));
            this.tab5.Iconimage_right = null;
            this.tab5.Iconimage_right_Selected = null;
            this.tab5.Iconimage_Selected = null;
            this.tab5.IconMarginLeft = 0;
            this.tab5.IconMarginRight = 0;
            this.tab5.IconRightVisible = true;
            this.tab5.IconRightZoom = 0D;
            this.tab5.IconVisible = true;
            this.tab5.IconZoom = 90D;
            this.tab5.IsTab = true;
            this.tab5.Location = new System.Drawing.Point(0, 261);
            this.tab5.Name = "tab5";
            this.tab5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab5.OnHoverTextColor = System.Drawing.Color.White;
            this.tab5.selected = false;
            this.tab5.Size = new System.Drawing.Size(177, 44);
            this.tab5.TabIndex = 7;
            this.tab5.Tag = "4";
            this.tab5.Text = "   Bán hàng";
            this.tab5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab5.Textcolor = System.Drawing.Color.White;
            this.tab5.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab5.Click += new System.EventHandler(this.banhang);
            // 
            // tab4
            // 
            this.tab4.Active = false;
            this.tab4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab4.BorderRadius = 0;
            this.tab4.ButtonText = "Chấm công";
            this.tab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab4, BunifuAnimatorNS.DecorationType.None);
            this.tab4.DisabledColor = System.Drawing.Color.Gray;
            this.tab4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab4.Iconcolor = System.Drawing.Color.Transparent;
            this.tab4.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab4.Iconimage")));
            this.tab4.Iconimage_right = null;
            this.tab4.Iconimage_right_Selected = null;
            this.tab4.Iconimage_Selected = null;
            this.tab4.IconMarginLeft = 0;
            this.tab4.IconMarginRight = 0;
            this.tab4.IconRightVisible = true;
            this.tab4.IconRightZoom = 0D;
            this.tab4.IconVisible = true;
            this.tab4.IconZoom = 90D;
            this.tab4.IsTab = true;
            this.tab4.Location = new System.Drawing.Point(0, 217);
            this.tab4.Name = "tab4";
            this.tab4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab4.OnHoverTextColor = System.Drawing.Color.White;
            this.tab4.selected = false;
            this.tab4.Size = new System.Drawing.Size(177, 44);
            this.tab4.TabIndex = 6;
            this.tab4.Tag = "3";
            this.tab4.Text = "Chấm công";
            this.tab4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4.Textcolor = System.Drawing.Color.White;
            this.tab4.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab4.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab3
            // 
            this.tab3.Active = false;
            this.tab3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab3.BorderRadius = 0;
            this.tab3.ButtonText = "Hóa đơn";
            this.tab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab3, BunifuAnimatorNS.DecorationType.None);
            this.tab3.DisabledColor = System.Drawing.Color.Gray;
            this.tab3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab3.Iconcolor = System.Drawing.Color.Transparent;
            this.tab3.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab3.Iconimage")));
            this.tab3.Iconimage_right = null;
            this.tab3.Iconimage_right_Selected = null;
            this.tab3.Iconimage_Selected = null;
            this.tab3.IconMarginLeft = 0;
            this.tab3.IconMarginRight = 0;
            this.tab3.IconRightVisible = true;
            this.tab3.IconRightZoom = 0D;
            this.tab3.IconVisible = true;
            this.tab3.IconZoom = 90D;
            this.tab3.IsTab = true;
            this.tab3.Location = new System.Drawing.Point(0, 173);
            this.tab3.Name = "tab3";
            this.tab3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab3.OnHoverTextColor = System.Drawing.Color.White;
            this.tab3.selected = false;
            this.tab3.Size = new System.Drawing.Size(177, 44);
            this.tab3.TabIndex = 5;
            this.tab3.Tag = "2";
            this.tab3.Text = "Hóa đơn";
            this.tab3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab3.Textcolor = System.Drawing.Color.White;
            this.tab3.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab3.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab2
            // 
            this.tab2.Active = false;
            this.tab2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab2.BorderRadius = 0;
            this.tab2.ButtonText = "    Quản lý";
            this.tab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab2, BunifuAnimatorNS.DecorationType.None);
            this.tab2.DisabledColor = System.Drawing.Color.Gray;
            this.tab2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab2.Iconcolor = System.Drawing.Color.Transparent;
            this.tab2.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab2.Iconimage")));
            this.tab2.Iconimage_right = null;
            this.tab2.Iconimage_right_Selected = null;
            this.tab2.Iconimage_Selected = null;
            this.tab2.IconMarginLeft = 0;
            this.tab2.IconMarginRight = 0;
            this.tab2.IconRightVisible = true;
            this.tab2.IconRightZoom = 0D;
            this.tab2.IconVisible = true;
            this.tab2.IconZoom = 90D;
            this.tab2.IsTab = true;
            this.tab2.Location = new System.Drawing.Point(0, 129);
            this.tab2.Name = "tab2";
            this.tab2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab2.OnHoverTextColor = System.Drawing.Color.White;
            this.tab2.selected = false;
            this.tab2.Size = new System.Drawing.Size(177, 44);
            this.tab2.TabIndex = 4;
            this.tab2.Tag = "1";
            this.tab2.Text = "    Quản lý";
            this.tab2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab2.Textcolor = System.Drawing.Color.White;
            this.tab2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tab1
            // 
            this.tab1.Active = false;
            this.tab1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab1.BorderRadius = 0;
            this.tab1.ButtonText = "      Home";
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tab1, BunifuAnimatorNS.DecorationType.None);
            this.tab1.DisabledColor = System.Drawing.Color.Gray;
            this.tab1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab1.Iconcolor = System.Drawing.Color.Transparent;
            this.tab1.Iconimage = ((System.Drawing.Image)(resources.GetObject("tab1.Iconimage")));
            this.tab1.Iconimage_right = null;
            this.tab1.Iconimage_right_Selected = null;
            this.tab1.Iconimage_Selected = null;
            this.tab1.IconMarginLeft = 0;
            this.tab1.IconMarginRight = 0;
            this.tab1.IconRightVisible = true;
            this.tab1.IconRightZoom = 0D;
            this.tab1.IconVisible = true;
            this.tab1.IconZoom = 50D;
            this.tab1.IsTab = true;
            this.tab1.Location = new System.Drawing.Point(0, 85);
            this.tab1.Name = "tab1";
            this.tab1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab1.OnHoverTextColor = System.Drawing.Color.White;
            this.tab1.selected = false;
            this.tab1.Size = new System.Drawing.Size(177, 44);
            this.tab1.TabIndex = 2;
            this.tab1.Tag = "0";
            this.tab1.Text = "      Home";
            this.tab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab1.Textcolor = System.Drawing.Color.White;
            this.tab1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 85);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(38, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // palsubmenu
            // 
            this.palsubmenu.Controls.Add(this.panel2);
            this.palsubmenu.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.palsubmenu, BunifuAnimatorNS.DecorationType.None);
            this.palsubmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.palsubmenu.Location = new System.Drawing.Point(177, 0);
            this.palsubmenu.Name = "palsubmenu";
            this.palsubmenu.Size = new System.Drawing.Size(200, 482);
            this.palsubmenu.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 85);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 397);
            this.panel2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.bunifuTransition1.SetDecoration(this.tabControl1, BunifuAnimatorNS.DecorationType.None);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bunifuFlatButton3);
            this.tabPage1.Controls.Add(this.bunifuFlatButton2);
            this.tabPage1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuTransition1.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "0";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = true;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Chấm công";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = false;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = false;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 91);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = true;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton3.TabIndex = 8;
            this.bunifuFlatButton3.Tag = "1";
            this.bunifuFlatButton3.Text = "Chấm công";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = true;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Chấm công";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(3, 47);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Tag = "1";
            this.bunifuFlatButton2.Text = "Chấm công";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = true;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Chấm công";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Tag = "1";
            this.bunifuFlatButton1.Text = "Chấm công";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Active = true;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Nhan vien";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = false;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = false;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(3, 3);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = true;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton4.TabIndex = 6;
            this.bunifuFlatButton4.Tag = "1";
            this.bunifuFlatButton4.Text = "Nhan vien";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Active = true;
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Chấm công";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = false;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = false;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = true;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(3, 47);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = true;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton5.TabIndex = 7;
            this.bunifuFlatButton5.Tag = "1";
            this.bunifuFlatButton5.Text = "Chấm công";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Active = true;
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Chấm công";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = false;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = false;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = true;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(3, 91);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = true;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton6.TabIndex = 8;
            this.bunifuFlatButton6.Tag = "1";
            this.bunifuFlatButton6.Text = "Chấm công";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Active = true;
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Chấm công";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = false;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = false;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = true;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(3, 135);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = true;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton7.TabIndex = 9;
            this.bunifuFlatButton7.Tag = "1";
            this.bunifuFlatButton7.Text = "Chấm công";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Active = true;
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Chấm công";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = false;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = false;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = true;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(3, 179);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = true;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(186, 44);
            this.bunifuFlatButton8.TabIndex = 10;
            this.bunifuFlatButton8.Tag = "1";
            this.bunifuFlatButton8.Text = "Chấm công";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bunifuFlatButton8);
            this.tabPage2.Controls.Add(this.bunifuFlatButton7);
            this.tabPage2.Controls.Add(this.bunifuFlatButton6);
            this.tabPage2.Controls.Add(this.bunifuFlatButton5);
            this.tabPage2.Controls.Add(this.bunifuFlatButton4);
            this.bunifuTransition1.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 482);
            this.Controls.Add(this.palsubmenu);
            this.Controls.Add(this.palMainMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.palMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.palsubmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton tab1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton tab5;
        private Bunifu.Framework.UI.BunifuFlatButton tab4;
        private Bunifu.Framework.UI.BunifuFlatButton tab3;
        private Bunifu.Framework.UI.BunifuFlatButton tab2;
        private Bunifu.Framework.UI.BunifuFlatButton tab7;
        private Bunifu.Framework.UI.BunifuFlatButton tab6;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel palsubmenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
    }
}