
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
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.palMainMenu = new System.Windows.Forms.Panel();
            this.tabhelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabcaidat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabxuathang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabnhaphang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tab4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabchamcong = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabquanly = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabhome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.palsubmenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btngoogle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnghenhac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndanhthu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncuahang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnkhuyenmai = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsanpham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnhoadon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnphieuxuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnphieunhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnhanvien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnngonngu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btngiaodien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnluongnhanvien = new Bunifu.Framework.UI.BunifuFlatButton();
            this.palMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.palsubmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMainMenu
            // 
            this.palMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.palMainMenu.Controls.Add(this.tabhelp);
            this.palMainMenu.Controls.Add(this.tabcaidat);
            this.palMainMenu.Controls.Add(this.tabxuathang);
            this.palMainMenu.Controls.Add(this.tabnhaphang);
            this.palMainMenu.Controls.Add(this.tab4);
            this.palMainMenu.Controls.Add(this.tabchamcong);
            this.palMainMenu.Controls.Add(this.tabquanly);
            this.palMainMenu.Controls.Add(this.tabhome);
            this.palMainMenu.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.palMainMenu, BunifuAnimatorNS.DecorationType.None);
            this.palMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.palMainMenu.Location = new System.Drawing.Point(0, 0);
            this.palMainMenu.Name = "palMainMenu";
            this.palMainMenu.Size = new System.Drawing.Size(177, 482);
            this.palMainMenu.TabIndex = 1;
            // 
            // tabhelp
            // 
            this.tabhelp.Active = false;
            this.tabhelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabhelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabhelp.BorderRadius = 0;
            this.tabhelp.ButtonText = "   Help";
            this.tabhelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabhelp, BunifuAnimatorNS.DecorationType.None);
            this.tabhelp.DisabledColor = System.Drawing.Color.Gray;
            this.tabhelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabhelp.Iconcolor = System.Drawing.Color.Transparent;
            this.tabhelp.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabhelp.Iconimage")));
            this.tabhelp.Iconimage_right = null;
            this.tabhelp.Iconimage_right_Selected = null;
            this.tabhelp.Iconimage_Selected = null;
            this.tabhelp.IconMarginLeft = 0;
            this.tabhelp.IconMarginRight = 0;
            this.tabhelp.IconRightVisible = true;
            this.tabhelp.IconRightZoom = 0D;
            this.tabhelp.IconVisible = true;
            this.tabhelp.IconZoom = 90D;
            this.tabhelp.IsTab = true;
            this.tabhelp.Location = new System.Drawing.Point(0, 376);
            this.tabhelp.Name = "tabhelp";
            this.tabhelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabhelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabhelp.OnHoverTextColor = System.Drawing.Color.White;
            this.tabhelp.selected = false;
            this.tabhelp.Size = new System.Drawing.Size(177, 44);
            this.tabhelp.TabIndex = 9;
            this.tabhelp.Tag = "";
            this.tabhelp.Text = "   Help";
            this.tabhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabhelp.Textcolor = System.Drawing.Color.White;
            this.tabhelp.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabhelp.Click += new System.EventHandler(this.help);
            // 
            // tabcaidat
            // 
            this.tabcaidat.Active = false;
            this.tabcaidat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabcaidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabcaidat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabcaidat.BorderRadius = 0;
            this.tabcaidat.ButtonText = "   Settings";
            this.tabcaidat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabcaidat, BunifuAnimatorNS.DecorationType.None);
            this.tabcaidat.DisabledColor = System.Drawing.Color.Gray;
            this.tabcaidat.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabcaidat.Iconcolor = System.Drawing.Color.Transparent;
            this.tabcaidat.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabcaidat.Iconimage")));
            this.tabcaidat.Iconimage_right = null;
            this.tabcaidat.Iconimage_right_Selected = null;
            this.tabcaidat.Iconimage_Selected = null;
            this.tabcaidat.IconMarginLeft = 0;
            this.tabcaidat.IconMarginRight = 0;
            this.tabcaidat.IconRightVisible = true;
            this.tabcaidat.IconRightZoom = 0D;
            this.tabcaidat.IconVisible = true;
            this.tabcaidat.IconZoom = 90D;
            this.tabcaidat.IsTab = true;
            this.tabcaidat.Location = new System.Drawing.Point(0, 332);
            this.tabcaidat.Name = "tabcaidat";
            this.tabcaidat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabcaidat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabcaidat.OnHoverTextColor = System.Drawing.Color.White;
            this.tabcaidat.selected = false;
            this.tabcaidat.Size = new System.Drawing.Size(177, 44);
            this.tabcaidat.TabIndex = 8;
            this.tabcaidat.Tag = "2";
            this.tabcaidat.Text = "   Settings";
            this.tabcaidat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabcaidat.Textcolor = System.Drawing.Color.White;
            this.tabcaidat.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcaidat.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tabxuathang
            // 
            this.tabxuathang.Active = false;
            this.tabxuathang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabxuathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabxuathang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabxuathang.BorderRadius = 0;
            this.tabxuathang.ButtonText = "   Xuất hàng";
            this.tabxuathang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabxuathang, BunifuAnimatorNS.DecorationType.None);
            this.tabxuathang.DisabledColor = System.Drawing.Color.Gray;
            this.tabxuathang.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabxuathang.Iconcolor = System.Drawing.Color.Transparent;
            this.tabxuathang.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabxuathang.Iconimage")));
            this.tabxuathang.Iconimage_right = null;
            this.tabxuathang.Iconimage_right_Selected = null;
            this.tabxuathang.Iconimage_Selected = null;
            this.tabxuathang.IconMarginLeft = 0;
            this.tabxuathang.IconMarginRight = 0;
            this.tabxuathang.IconRightVisible = true;
            this.tabxuathang.IconRightZoom = 0D;
            this.tabxuathang.IconVisible = true;
            this.tabxuathang.IconZoom = 90D;
            this.tabxuathang.IsTab = true;
            this.tabxuathang.Location = new System.Drawing.Point(0, 288);
            this.tabxuathang.Name = "tabxuathang";
            this.tabxuathang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabxuathang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabxuathang.OnHoverTextColor = System.Drawing.Color.White;
            this.tabxuathang.selected = false;
            this.tabxuathang.Size = new System.Drawing.Size(177, 44);
            this.tabxuathang.TabIndex = 12;
            this.tabxuathang.Tag = "4";
            this.tabxuathang.Text = "   Xuất hàng";
            this.tabxuathang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabxuathang.Textcolor = System.Drawing.Color.White;
            this.tabxuathang.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabxuathang.Click += new System.EventHandler(this.xuathang);
            // 
            // tabnhaphang
            // 
            this.tabnhaphang.Active = false;
            this.tabnhaphang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabnhaphang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabnhaphang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabnhaphang.BorderRadius = 0;
            this.tabnhaphang.ButtonText = "   Nhập hàng";
            this.tabnhaphang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabnhaphang, BunifuAnimatorNS.DecorationType.None);
            this.tabnhaphang.DisabledColor = System.Drawing.Color.Gray;
            this.tabnhaphang.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabnhaphang.Iconcolor = System.Drawing.Color.Transparent;
            this.tabnhaphang.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabnhaphang.Iconimage")));
            this.tabnhaphang.Iconimage_right = null;
            this.tabnhaphang.Iconimage_right_Selected = null;
            this.tabnhaphang.Iconimage_Selected = null;
            this.tabnhaphang.IconMarginLeft = 0;
            this.tabnhaphang.IconMarginRight = 0;
            this.tabnhaphang.IconRightVisible = true;
            this.tabnhaphang.IconRightZoom = 0D;
            this.tabnhaphang.IconVisible = true;
            this.tabnhaphang.IconZoom = 90D;
            this.tabnhaphang.IsTab = true;
            this.tabnhaphang.Location = new System.Drawing.Point(0, 244);
            this.tabnhaphang.Name = "tabnhaphang";
            this.tabnhaphang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabnhaphang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabnhaphang.OnHoverTextColor = System.Drawing.Color.White;
            this.tabnhaphang.selected = false;
            this.tabnhaphang.Size = new System.Drawing.Size(177, 44);
            this.tabnhaphang.TabIndex = 11;
            this.tabnhaphang.Tag = "4";
            this.tabnhaphang.Text = "   Nhập hàng";
            this.tabnhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabnhaphang.Textcolor = System.Drawing.Color.White;
            this.tabnhaphang.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabnhaphang.Click += new System.EventHandler(this.nhaphang);
            // 
            // tab4
            // 
            this.tab4.Active = false;
            this.tab4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab4.BorderRadius = 0;
            this.tab4.ButtonText = "   Bán hàng";
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
            this.tab4.Location = new System.Drawing.Point(0, 200);
            this.tab4.Name = "tab4";
            this.tab4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tab4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tab4.OnHoverTextColor = System.Drawing.Color.White;
            this.tab4.selected = false;
            this.tab4.Size = new System.Drawing.Size(177, 44);
            this.tab4.TabIndex = 7;
            this.tab4.Tag = "4";
            this.tab4.Text = "   Bán hàng";
            this.tab4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tab4.Textcolor = System.Drawing.Color.White;
            this.tab4.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab4.Click += new System.EventHandler(this.banhang);
            // 
            // tabchamcong
            // 
            this.tabchamcong.Active = false;
            this.tabchamcong.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabchamcong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabchamcong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabchamcong.BorderRadius = 0;
            this.tabchamcong.ButtonText = "   Chấm công";
            this.tabchamcong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabchamcong, BunifuAnimatorNS.DecorationType.None);
            this.tabchamcong.DisabledColor = System.Drawing.Color.Gray;
            this.tabchamcong.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabchamcong.Iconcolor = System.Drawing.Color.Transparent;
            this.tabchamcong.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabchamcong.Iconimage")));
            this.tabchamcong.Iconimage_right = null;
            this.tabchamcong.Iconimage_right_Selected = null;
            this.tabchamcong.Iconimage_Selected = null;
            this.tabchamcong.IconMarginLeft = 0;
            this.tabchamcong.IconMarginRight = 0;
            this.tabchamcong.IconRightVisible = true;
            this.tabchamcong.IconRightZoom = 0D;
            this.tabchamcong.IconVisible = true;
            this.tabchamcong.IconZoom = 90D;
            this.tabchamcong.IsTab = true;
            this.tabchamcong.Location = new System.Drawing.Point(0, 156);
            this.tabchamcong.Name = "tabchamcong";
            this.tabchamcong.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabchamcong.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabchamcong.OnHoverTextColor = System.Drawing.Color.White;
            this.tabchamcong.selected = false;
            this.tabchamcong.Size = new System.Drawing.Size(177, 44);
            this.tabchamcong.TabIndex = 6;
            this.tabchamcong.Tag = "3";
            this.tabchamcong.Text = "   Chấm công";
            this.tabchamcong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabchamcong.Textcolor = System.Drawing.Color.White;
            this.tabchamcong.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabchamcong.Click += new System.EventHandler(this.chamcong);
            // 
            // tabquanly
            // 
            this.tabquanly.Active = false;
            this.tabquanly.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabquanly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabquanly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabquanly.BorderRadius = 0;
            this.tabquanly.ButtonText = "    Quản lý";
            this.tabquanly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabquanly, BunifuAnimatorNS.DecorationType.None);
            this.tabquanly.DisabledColor = System.Drawing.Color.Gray;
            this.tabquanly.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabquanly.Iconcolor = System.Drawing.Color.Transparent;
            this.tabquanly.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabquanly.Iconimage")));
            this.tabquanly.Iconimage_right = null;
            this.tabquanly.Iconimage_right_Selected = null;
            this.tabquanly.Iconimage_Selected = null;
            this.tabquanly.IconMarginLeft = 0;
            this.tabquanly.IconMarginRight = 0;
            this.tabquanly.IconRightVisible = true;
            this.tabquanly.IconRightZoom = 0D;
            this.tabquanly.IconVisible = true;
            this.tabquanly.IconZoom = 90D;
            this.tabquanly.IsTab = true;
            this.tabquanly.Location = new System.Drawing.Point(0, 112);
            this.tabquanly.Name = "tabquanly";
            this.tabquanly.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabquanly.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabquanly.OnHoverTextColor = System.Drawing.Color.White;
            this.tabquanly.selected = false;
            this.tabquanly.Size = new System.Drawing.Size(177, 44);
            this.tabquanly.TabIndex = 4;
            this.tabquanly.Tag = "1";
            this.tabquanly.Text = "    Quản lý";
            this.tabquanly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabquanly.Textcolor = System.Drawing.Color.White;
            this.tabquanly.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabquanly.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // tabhome
            // 
            this.tabhome.Active = true;
            this.tabhome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabhome.BorderRadius = 0;
            this.tabhome.ButtonText = "    Home";
            this.tabhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.tabhome, BunifuAnimatorNS.DecorationType.None);
            this.tabhome.DisabledColor = System.Drawing.Color.Gray;
            this.tabhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabhome.Iconcolor = System.Drawing.Color.Transparent;
            this.tabhome.Iconimage = ((System.Drawing.Image)(resources.GetObject("tabhome.Iconimage")));
            this.tabhome.Iconimage_right = null;
            this.tabhome.Iconimage_right_Selected = null;
            this.tabhome.Iconimage_Selected = null;
            this.tabhome.IconMarginLeft = 0;
            this.tabhome.IconMarginRight = 0;
            this.tabhome.IconRightVisible = true;
            this.tabhome.IconRightZoom = 0D;
            this.tabhome.IconVisible = true;
            this.tabhome.IconZoom = 90D;
            this.tabhome.IsTab = true;
            this.tabhome.Location = new System.Drawing.Point(0, 68);
            this.tabhome.Name = "tabhome";
            this.tabhome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.tabhome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.tabhome.OnHoverTextColor = System.Drawing.Color.White;
            this.tabhome.selected = true;
            this.tabhome.Size = new System.Drawing.Size(177, 44);
            this.tabhome.TabIndex = 10;
            this.tabhome.Tag = "0";
            this.tabhome.Text = "    Home";
            this.tabhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabhome.Textcolor = System.Drawing.Color.White;
            this.tabhome.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabhome.Click += new System.EventHandler(this.sideMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 68);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Interval = 1000;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation7;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tabControl1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 414);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 33);
            this.panel4.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.bunifuTransition1.SetDecoration(this.tabControl1, BunifuAnimatorNS.DecorationType.None);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btngoogle);
            this.tabPage1.Controls.Add(this.btnnghenhac);
            this.tabPage1.Controls.Add(this.btndanhthu);
            this.bunifuTransition1.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "0";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btngoogle
            // 
            this.btngoogle.Active = false;
            this.btngoogle.Activecolor = System.Drawing.Color.Gainsboro;
            this.btngoogle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btngoogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngoogle.BorderRadius = 0;
            this.btngoogle.ButtonText = "    Google";
            this.btngoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btngoogle, BunifuAnimatorNS.DecorationType.None);
            this.btngoogle.DisabledColor = System.Drawing.Color.Gray;
            this.btngoogle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngoogle.Iconcolor = System.Drawing.Color.Transparent;
            this.btngoogle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btngoogle.Iconimage")));
            this.btngoogle.Iconimage_right = null;
            this.btngoogle.Iconimage_right_Selected = null;
            this.btngoogle.Iconimage_Selected = null;
            this.btngoogle.IconMarginLeft = 0;
            this.btngoogle.IconMarginRight = 0;
            this.btngoogle.IconRightVisible = false;
            this.btngoogle.IconRightZoom = 0D;
            this.btngoogle.IconVisible = false;
            this.btngoogle.IconZoom = 90D;
            this.btngoogle.IsTab = true;
            this.btngoogle.Location = new System.Drawing.Point(3, 91);
            this.btngoogle.Name = "btngoogle";
            this.btngoogle.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btngoogle.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btngoogle.OnHoverTextColor = System.Drawing.Color.White;
            this.btngoogle.selected = false;
            this.btngoogle.Size = new System.Drawing.Size(186, 44);
            this.btngoogle.TabIndex = 14;
            this.btngoogle.Tag = "0";
            this.btngoogle.Text = "    Google";
            this.btngoogle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngoogle.Textcolor = System.Drawing.Color.Gray;
            this.btngoogle.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnnghenhac
            // 
            this.btnnghenhac.Active = false;
            this.btnnghenhac.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnnghenhac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnnghenhac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnghenhac.BorderRadius = 0;
            this.btnnghenhac.ButtonText = "    Nghe nhạc";
            this.btnnghenhac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnnghenhac, BunifuAnimatorNS.DecorationType.None);
            this.btnnghenhac.DisabledColor = System.Drawing.Color.Gray;
            this.btnnghenhac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnghenhac.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnghenhac.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnnghenhac.Iconimage")));
            this.btnnghenhac.Iconimage_right = null;
            this.btnnghenhac.Iconimage_right_Selected = null;
            this.btnnghenhac.Iconimage_Selected = null;
            this.btnnghenhac.IconMarginLeft = 0;
            this.btnnghenhac.IconMarginRight = 0;
            this.btnnghenhac.IconRightVisible = false;
            this.btnnghenhac.IconRightZoom = 0D;
            this.btnnghenhac.IconVisible = false;
            this.btnnghenhac.IconZoom = 90D;
            this.btnnghenhac.IsTab = true;
            this.btnnghenhac.Location = new System.Drawing.Point(3, 47);
            this.btnnghenhac.Name = "btnnghenhac";
            this.btnnghenhac.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnnghenhac.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnnghenhac.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnghenhac.selected = false;
            this.btnnghenhac.Size = new System.Drawing.Size(186, 44);
            this.btnnghenhac.TabIndex = 13;
            this.btnnghenhac.Tag = "0";
            this.btnnghenhac.Text = "    Nghe nhạc";
            this.btnnghenhac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnghenhac.Textcolor = System.Drawing.Color.Gray;
            this.btnnghenhac.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btndanhthu
            // 
            this.btndanhthu.Active = true;
            this.btndanhthu.Activecolor = System.Drawing.Color.Gainsboro;
            this.btndanhthu.BackColor = System.Drawing.Color.Gainsboro;
            this.btndanhthu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndanhthu.BorderRadius = 0;
            this.btndanhthu.ButtonText = "    Doanh thu";
            this.btndanhthu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btndanhthu, BunifuAnimatorNS.DecorationType.None);
            this.btndanhthu.DisabledColor = System.Drawing.Color.Gray;
            this.btndanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndanhthu.Iconcolor = System.Drawing.Color.Transparent;
            this.btndanhthu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndanhthu.Iconimage")));
            this.btndanhthu.Iconimage_right = null;
            this.btndanhthu.Iconimage_right_Selected = null;
            this.btndanhthu.Iconimage_Selected = null;
            this.btndanhthu.IconMarginLeft = 0;
            this.btndanhthu.IconMarginRight = 0;
            this.btndanhthu.IconRightVisible = false;
            this.btndanhthu.IconRightZoom = 0D;
            this.btndanhthu.IconVisible = false;
            this.btndanhthu.IconZoom = 90D;
            this.btndanhthu.IsTab = true;
            this.btndanhthu.Location = new System.Drawing.Point(3, 3);
            this.btndanhthu.Name = "btndanhthu";
            this.btndanhthu.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btndanhthu.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btndanhthu.OnHoverTextColor = System.Drawing.Color.White;
            this.btndanhthu.selected = true;
            this.btndanhthu.Size = new System.Drawing.Size(186, 44);
            this.btndanhthu.TabIndex = 12;
            this.btndanhthu.Tag = "0";
            this.btndanhthu.Text = "    Doanh thu";
            this.btndanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndanhthu.Textcolor = System.Drawing.Color.Gray;
            this.btndanhthu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnluongnhanvien);
            this.tabPage2.Controls.Add(this.btncuahang);
            this.tabPage2.Controls.Add(this.btnkhuyenmai);
            this.tabPage2.Controls.Add(this.btnsanpham);
            this.tabPage2.Controls.Add(this.btnhoadon);
            this.tabPage2.Controls.Add(this.btnphieuxuat);
            this.tabPage2.Controls.Add(this.btnphieunhap);
            this.tabPage2.Controls.Add(this.btnnhanvien);
            this.bunifuTransition1.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "v";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btncuahang
            // 
            this.btncuahang.Active = false;
            this.btncuahang.Activecolor = System.Drawing.Color.Gainsboro;
            this.btncuahang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncuahang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncuahang.BorderRadius = 0;
            this.btncuahang.ButtonText = "    Cửa hàng";
            this.btncuahang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btncuahang, BunifuAnimatorNS.DecorationType.None);
            this.btncuahang.DisabledColor = System.Drawing.Color.Gray;
            this.btncuahang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncuahang.Iconcolor = System.Drawing.Color.Transparent;
            this.btncuahang.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncuahang.Iconimage")));
            this.btncuahang.Iconimage_right = null;
            this.btncuahang.Iconimage_right_Selected = null;
            this.btncuahang.Iconimage_Selected = null;
            this.btncuahang.IconMarginLeft = 0;
            this.btncuahang.IconMarginRight = 0;
            this.btncuahang.IconRightVisible = false;
            this.btncuahang.IconRightZoom = 0D;
            this.btncuahang.IconVisible = false;
            this.btncuahang.IconZoom = 90D;
            this.btncuahang.IsTab = true;
            this.btncuahang.Location = new System.Drawing.Point(3, 267);
            this.btncuahang.Name = "btncuahang";
            this.btncuahang.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btncuahang.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btncuahang.OnHoverTextColor = System.Drawing.Color.White;
            this.btncuahang.selected = false;
            this.btncuahang.Size = new System.Drawing.Size(186, 44);
            this.btncuahang.TabIndex = 24;
            this.btncuahang.Tag = "0";
            this.btncuahang.Text = "    Cửa hàng";
            this.btncuahang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncuahang.Textcolor = System.Drawing.Color.Gray;
            this.btncuahang.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnkhuyenmai
            // 
            this.btnkhuyenmai.Active = false;
            this.btnkhuyenmai.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnkhuyenmai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnkhuyenmai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkhuyenmai.BorderRadius = 0;
            this.btnkhuyenmai.ButtonText = "    Khuyến mãi";
            this.btnkhuyenmai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnkhuyenmai, BunifuAnimatorNS.DecorationType.None);
            this.btnkhuyenmai.DisabledColor = System.Drawing.Color.Gray;
            this.btnkhuyenmai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnkhuyenmai.Iconcolor = System.Drawing.Color.Transparent;
            this.btnkhuyenmai.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnkhuyenmai.Iconimage")));
            this.btnkhuyenmai.Iconimage_right = null;
            this.btnkhuyenmai.Iconimage_right_Selected = null;
            this.btnkhuyenmai.Iconimage_Selected = null;
            this.btnkhuyenmai.IconMarginLeft = 0;
            this.btnkhuyenmai.IconMarginRight = 0;
            this.btnkhuyenmai.IconRightVisible = false;
            this.btnkhuyenmai.IconRightZoom = 0D;
            this.btnkhuyenmai.IconVisible = false;
            this.btnkhuyenmai.IconZoom = 90D;
            this.btnkhuyenmai.IsTab = true;
            this.btnkhuyenmai.Location = new System.Drawing.Point(3, 223);
            this.btnkhuyenmai.Name = "btnkhuyenmai";
            this.btnkhuyenmai.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnkhuyenmai.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnkhuyenmai.OnHoverTextColor = System.Drawing.Color.White;
            this.btnkhuyenmai.selected = false;
            this.btnkhuyenmai.Size = new System.Drawing.Size(186, 44);
            this.btnkhuyenmai.TabIndex = 23;
            this.btnkhuyenmai.Tag = "0";
            this.btnkhuyenmai.Text = "    Khuyến mãi";
            this.btnkhuyenmai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhuyenmai.Textcolor = System.Drawing.Color.Gray;
            this.btnkhuyenmai.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnsanpham
            // 
            this.btnsanpham.Active = false;
            this.btnsanpham.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnsanpham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsanpham.BorderRadius = 0;
            this.btnsanpham.ButtonText = "    Sản phẩm";
            this.btnsanpham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnsanpham, BunifuAnimatorNS.DecorationType.None);
            this.btnsanpham.DisabledColor = System.Drawing.Color.Gray;
            this.btnsanpham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsanpham.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsanpham.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsanpham.Iconimage")));
            this.btnsanpham.Iconimage_right = null;
            this.btnsanpham.Iconimage_right_Selected = null;
            this.btnsanpham.Iconimage_Selected = null;
            this.btnsanpham.IconMarginLeft = 0;
            this.btnsanpham.IconMarginRight = 0;
            this.btnsanpham.IconRightVisible = false;
            this.btnsanpham.IconRightZoom = 0D;
            this.btnsanpham.IconVisible = false;
            this.btnsanpham.IconZoom = 90D;
            this.btnsanpham.IsTab = true;
            this.btnsanpham.Location = new System.Drawing.Point(3, 179);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnsanpham.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnsanpham.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsanpham.selected = false;
            this.btnsanpham.Size = new System.Drawing.Size(186, 44);
            this.btnsanpham.TabIndex = 22;
            this.btnsanpham.Tag = "0";
            this.btnsanpham.Text = "    Sản phẩm";
            this.btnsanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsanpham.Textcolor = System.Drawing.Color.Gray;
            this.btnsanpham.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnhoadon
            // 
            this.btnhoadon.Active = false;
            this.btnhoadon.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnhoadon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhoadon.BorderRadius = 0;
            this.btnhoadon.ButtonText = "    Hóa đơn";
            this.btnhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnhoadon, BunifuAnimatorNS.DecorationType.None);
            this.btnhoadon.DisabledColor = System.Drawing.Color.Gray;
            this.btnhoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhoadon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnhoadon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnhoadon.Iconimage")));
            this.btnhoadon.Iconimage_right = null;
            this.btnhoadon.Iconimage_right_Selected = null;
            this.btnhoadon.Iconimage_Selected = null;
            this.btnhoadon.IconMarginLeft = 0;
            this.btnhoadon.IconMarginRight = 0;
            this.btnhoadon.IconRightVisible = false;
            this.btnhoadon.IconRightZoom = 0D;
            this.btnhoadon.IconVisible = false;
            this.btnhoadon.IconZoom = 90D;
            this.btnhoadon.IsTab = true;
            this.btnhoadon.Location = new System.Drawing.Point(3, 135);
            this.btnhoadon.Name = "btnhoadon";
            this.btnhoadon.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnhoadon.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnhoadon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnhoadon.selected = false;
            this.btnhoadon.Size = new System.Drawing.Size(186, 44);
            this.btnhoadon.TabIndex = 21;
            this.btnhoadon.Tag = "0";
            this.btnhoadon.Text = "    Hóa đơn";
            this.btnhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhoadon.Textcolor = System.Drawing.Color.Gray;
            this.btnhoadon.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnphieuxuat
            // 
            this.btnphieuxuat.Active = false;
            this.btnphieuxuat.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnphieuxuat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnphieuxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnphieuxuat.BorderRadius = 0;
            this.btnphieuxuat.ButtonText = "    Phiếu xuất";
            this.btnphieuxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnphieuxuat, BunifuAnimatorNS.DecorationType.None);
            this.btnphieuxuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnphieuxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnphieuxuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnphieuxuat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnphieuxuat.Iconimage")));
            this.btnphieuxuat.Iconimage_right = null;
            this.btnphieuxuat.Iconimage_right_Selected = null;
            this.btnphieuxuat.Iconimage_Selected = null;
            this.btnphieuxuat.IconMarginLeft = 0;
            this.btnphieuxuat.IconMarginRight = 0;
            this.btnphieuxuat.IconRightVisible = false;
            this.btnphieuxuat.IconRightZoom = 0D;
            this.btnphieuxuat.IconVisible = false;
            this.btnphieuxuat.IconZoom = 90D;
            this.btnphieuxuat.IsTab = true;
            this.btnphieuxuat.Location = new System.Drawing.Point(3, 91);
            this.btnphieuxuat.Name = "btnphieuxuat";
            this.btnphieuxuat.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnphieuxuat.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnphieuxuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnphieuxuat.selected = false;
            this.btnphieuxuat.Size = new System.Drawing.Size(186, 44);
            this.btnphieuxuat.TabIndex = 20;
            this.btnphieuxuat.Tag = "0";
            this.btnphieuxuat.Text = "    Phiếu xuất";
            this.btnphieuxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnphieuxuat.Textcolor = System.Drawing.Color.Gray;
            this.btnphieuxuat.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphieuxuat.Click += new System.EventHandler(this.btnphieuxuat_Click);
            // 
            // btnphieunhap
            // 
            this.btnphieunhap.Active = false;
            this.btnphieunhap.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnphieunhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnphieunhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnphieunhap.BorderRadius = 0;
            this.btnphieunhap.ButtonText = "    Phiếu nhập";
            this.btnphieunhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnphieunhap, BunifuAnimatorNS.DecorationType.None);
            this.btnphieunhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnphieunhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnphieunhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnphieunhap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnphieunhap.Iconimage")));
            this.btnphieunhap.Iconimage_right = null;
            this.btnphieunhap.Iconimage_right_Selected = null;
            this.btnphieunhap.Iconimage_Selected = null;
            this.btnphieunhap.IconMarginLeft = 0;
            this.btnphieunhap.IconMarginRight = 0;
            this.btnphieunhap.IconRightVisible = false;
            this.btnphieunhap.IconRightZoom = 0D;
            this.btnphieunhap.IconVisible = false;
            this.btnphieunhap.IconZoom = 90D;
            this.btnphieunhap.IsTab = true;
            this.btnphieunhap.Location = new System.Drawing.Point(3, 47);
            this.btnphieunhap.Name = "btnphieunhap";
            this.btnphieunhap.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnphieunhap.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnphieunhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnphieunhap.selected = false;
            this.btnphieunhap.Size = new System.Drawing.Size(186, 44);
            this.btnphieunhap.TabIndex = 19;
            this.btnphieunhap.Tag = "0";
            this.btnphieunhap.Text = "    Phiếu nhập";
            this.btnphieunhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnphieunhap.Textcolor = System.Drawing.Color.Gray;
            this.btnphieunhap.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphieunhap.Click += new System.EventHandler(this.btnphieunhap_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Active = true;
            this.btnnhanvien.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnnhanvien.BackColor = System.Drawing.Color.Gainsboro;
            this.btnnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnhanvien.BorderRadius = 0;
            this.btnnhanvien.ButtonText = "    Nhân viên";
            this.btnnhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnnhanvien, BunifuAnimatorNS.DecorationType.None);
            this.btnnhanvien.DisabledColor = System.Drawing.Color.Gray;
            this.btnnhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnhanvien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnhanvien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.Iconimage")));
            this.btnnhanvien.Iconimage_right = null;
            this.btnnhanvien.Iconimage_right_Selected = null;
            this.btnnhanvien.Iconimage_Selected = null;
            this.btnnhanvien.IconMarginLeft = 0;
            this.btnnhanvien.IconMarginRight = 0;
            this.btnnhanvien.IconRightVisible = false;
            this.btnnhanvien.IconRightZoom = 0D;
            this.btnnhanvien.IconVisible = true;
            this.btnnhanvien.IconZoom = 90D;
            this.btnnhanvien.IsTab = true;
            this.btnnhanvien.Location = new System.Drawing.Point(3, 3);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnnhanvien.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnnhanvien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnhanvien.selected = true;
            this.btnnhanvien.Size = new System.Drawing.Size(186, 44);
            this.btnnhanvien.TabIndex = 18;
            this.btnnhanvien.Tag = "0";
            this.btnnhanvien.Text = "    Nhân viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Textcolor = System.Drawing.Color.Gray;
            this.btnnhanvien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnngonngu);
            this.tabPage3.Controls.Add(this.btngiaodien);
            this.bunifuTransition1.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnngonngu
            // 
            this.btnngonngu.Active = false;
            this.btnngonngu.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnngonngu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnngonngu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnngonngu.BorderRadius = 0;
            this.btnngonngu.ButtonText = "    Ngôn ngữ";
            this.btnngonngu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnngonngu, BunifuAnimatorNS.DecorationType.None);
            this.btnngonngu.DisabledColor = System.Drawing.Color.Gray;
            this.btnngonngu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnngonngu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnngonngu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnngonngu.Iconimage")));
            this.btnngonngu.Iconimage_right = null;
            this.btnngonngu.Iconimage_right_Selected = null;
            this.btnngonngu.Iconimage_Selected = null;
            this.btnngonngu.IconMarginLeft = 0;
            this.btnngonngu.IconMarginRight = 0;
            this.btnngonngu.IconRightVisible = false;
            this.btnngonngu.IconRightZoom = 0D;
            this.btnngonngu.IconVisible = false;
            this.btnngonngu.IconZoom = 90D;
            this.btnngonngu.IsTab = true;
            this.btnngonngu.Location = new System.Drawing.Point(3, 47);
            this.btnngonngu.Name = "btnngonngu";
            this.btnngonngu.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnngonngu.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnngonngu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnngonngu.selected = false;
            this.btnngonngu.Size = new System.Drawing.Size(186, 44);
            this.btnngonngu.TabIndex = 20;
            this.btnngonngu.Tag = "0";
            this.btnngonngu.Text = "    Ngôn ngữ";
            this.btnngonngu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnngonngu.Textcolor = System.Drawing.Color.Gray;
            this.btnngonngu.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btngiaodien
            // 
            this.btngiaodien.Active = true;
            this.btngiaodien.Activecolor = System.Drawing.Color.Gainsboro;
            this.btngiaodien.BackColor = System.Drawing.Color.Gainsboro;
            this.btngiaodien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngiaodien.BorderRadius = 0;
            this.btngiaodien.ButtonText = "    Giao diện";
            this.btngiaodien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btngiaodien, BunifuAnimatorNS.DecorationType.None);
            this.btngiaodien.DisabledColor = System.Drawing.Color.Gray;
            this.btngiaodien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngiaodien.Iconcolor = System.Drawing.Color.Transparent;
            this.btngiaodien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btngiaodien.Iconimage")));
            this.btngiaodien.Iconimage_right = null;
            this.btngiaodien.Iconimage_right_Selected = null;
            this.btngiaodien.Iconimage_Selected = null;
            this.btngiaodien.IconMarginLeft = 0;
            this.btngiaodien.IconMarginRight = 0;
            this.btngiaodien.IconRightVisible = false;
            this.btngiaodien.IconRightZoom = 0D;
            this.btngiaodien.IconVisible = false;
            this.btngiaodien.IconZoom = 90D;
            this.btngiaodien.IsTab = true;
            this.btngiaodien.Location = new System.Drawing.Point(3, 3);
            this.btngiaodien.Name = "btngiaodien";
            this.btngiaodien.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btngiaodien.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btngiaodien.OnHoverTextColor = System.Drawing.Color.White;
            this.btngiaodien.selected = true;
            this.btngiaodien.Size = new System.Drawing.Size(186, 44);
            this.btngiaodien.TabIndex = 19;
            this.btngiaodien.Tag = "0";
            this.btngiaodien.Text = "    Giao diện";
            this.btngiaodien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiaodien.Textcolor = System.Drawing.Color.Gray;
            this.btngiaodien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 68);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "cửa hàng như huỳnh";
            // 
            // btnluongnhanvien
            // 
            this.btnluongnhanvien.Active = false;
            this.btnluongnhanvien.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnluongnhanvien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnluongnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnluongnhanvien.BorderRadius = 0;
            this.btnluongnhanvien.ButtonText = "    Lương NV";
            this.btnluongnhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnluongnhanvien, BunifuAnimatorNS.DecorationType.None);
            this.btnluongnhanvien.DisabledColor = System.Drawing.Color.Gray;
            this.btnluongnhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnluongnhanvien.Iconcolor = System.Drawing.Color.Transparent;
            this.btnluongnhanvien.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnluongnhanvien.Iconimage")));
            this.btnluongnhanvien.Iconimage_right = null;
            this.btnluongnhanvien.Iconimage_right_Selected = null;
            this.btnluongnhanvien.Iconimage_Selected = null;
            this.btnluongnhanvien.IconMarginLeft = 0;
            this.btnluongnhanvien.IconMarginRight = 0;
            this.btnluongnhanvien.IconRightVisible = false;
            this.btnluongnhanvien.IconRightZoom = 0D;
            this.btnluongnhanvien.IconVisible = false;
            this.btnluongnhanvien.IconZoom = 90D;
            this.btnluongnhanvien.IsTab = true;
            this.btnluongnhanvien.Location = new System.Drawing.Point(3, 311);
            this.btnluongnhanvien.Name = "btnluongnhanvien";
            this.btnluongnhanvien.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnluongnhanvien.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.btnluongnhanvien.OnHoverTextColor = System.Drawing.Color.White;
            this.btnluongnhanvien.selected = false;
            this.btnluongnhanvien.Size = new System.Drawing.Size(186, 44);
            this.btnluongnhanvien.TabIndex = 25;
            this.btnluongnhanvien.Tag = "0";
            this.btnluongnhanvien.Text = "    Lương NV";
            this.btnluongnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluongnhanvien.Textcolor = System.Drawing.Color.Gray;
            this.btnluongnhanvien.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluongnhanvien.Click += new System.EventHandler(this.btnluongnhanvien_Click);
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
            this.Load += new System.EventHandler(this.Home_Load);
            this.palMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.palsubmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton tab4;
        private Bunifu.Framework.UI.BunifuFlatButton tabchamcong;
        private Bunifu.Framework.UI.BunifuFlatButton tabquanly;
        private Bunifu.Framework.UI.BunifuFlatButton tabhelp;
        private Bunifu.Framework.UI.BunifuFlatButton tabcaidat;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Panel palsubmenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuFlatButton tabhome;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton tabxuathang;
        private Bunifu.Framework.UI.BunifuFlatButton tabnhaphang;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btngoogle;
        private Bunifu.Framework.UI.BunifuFlatButton btnnghenhac;
        private Bunifu.Framework.UI.BunifuFlatButton btndanhthu;
        private Bunifu.Framework.UI.BunifuFlatButton btncuahang;
        private Bunifu.Framework.UI.BunifuFlatButton btnkhuyenmai;
        private Bunifu.Framework.UI.BunifuFlatButton btnsanpham;
        private Bunifu.Framework.UI.BunifuFlatButton btnhoadon;
        private Bunifu.Framework.UI.BunifuFlatButton btnphieuxuat;
        private Bunifu.Framework.UI.BunifuFlatButton btnphieunhap;
        private Bunifu.Framework.UI.BunifuFlatButton btnnhanvien;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuFlatButton btnngonngu;
        private Bunifu.Framework.UI.BunifuFlatButton btngiaodien;
        private Bunifu.Framework.UI.BunifuFlatButton btnluongnhanvien;
    }
}