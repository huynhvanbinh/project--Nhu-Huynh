
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.subMenu1 = new demo1.subMenu();
            this.palMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.palMainMenu.Size = new System.Drawing.Size(45, 395);
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
            this.tab7.Size = new System.Drawing.Size(45, 44);
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
            this.tab6.Size = new System.Drawing.Size(45, 44);
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
            this.tab5.ButtonText = "Bán hàng";
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
            this.tab5.Size = new System.Drawing.Size(45, 44);
            this.tab5.TabIndex = 7;
            this.tab5.Tag = "4";
            this.tab5.Text = "Bán hàng";
            this.tab5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab5.Textcolor = System.Drawing.Color.White;
            this.tab5.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab5.Click += new System.EventHandler(this.sideMenu_Click);
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
            this.tab4.Size = new System.Drawing.Size(45, 44);
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
            this.tab3.Size = new System.Drawing.Size(45, 44);
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
            this.tab2.ButtonText = "Quản lý";
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
            this.tab2.Size = new System.Drawing.Size(45, 44);
            this.tab2.TabIndex = 4;
            this.tab2.Tag = "1";
            this.tab2.Text = "Quản lý";
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
            this.tab1.Iconimage = global::demo1.Properties.Resources.home;
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
            this.tab1.Size = new System.Drawing.Size(45, 44);
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
            this.panel1.Size = new System.Drawing.Size(45, 85);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(-28, 3);
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
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.subMenu1);
            this.panel2.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(45, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 395);
            this.panel2.TabIndex = 2;
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
            // subMenu1
            // 
            this.bunifuTransition1.SetDecoration(this.subMenu1, BunifuAnimatorNS.DecorationType.None);
            this.subMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subMenu1.Location = new System.Drawing.Point(0, 85);
            this.subMenu1.Name = "subMenu1";
            this.subMenu1.Size = new System.Drawing.Size(200, 310);
            this.subMenu1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.palMainMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.palMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private subMenu subMenu1;
        private System.Windows.Forms.Panel panel3;
    }
}