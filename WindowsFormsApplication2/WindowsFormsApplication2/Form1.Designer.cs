namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msPen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msSolid = new System.Windows.Forms.ToolStripMenuItem();
            this.msDashed = new System.Windows.Forms.ToolStripMenuItem();
            this.msDotDashed = new System.Windows.Forms.ToolStripMenuItem();
            this.msDotted = new System.Windows.Forms.ToolStripMenuItem();
            this.msDotDotDashed = new System.Windows.Forms.ToolStripMenuItem();
            this.msBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBrush = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msBrushStar = new System.Windows.Forms.ToolStripMenuItem();
            this.msBrushSuperStar = new System.Windows.Forms.ToolStripMenuItem();
            this.msBrushGrass = new System.Windows.Forms.ToolStripMenuItem();
            this.msLine = new System.Windows.Forms.ToolStripMenuItem();
            this.msRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.msEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.msFill = new System.Windows.Forms.ToolStripMenuItem();
            this.msEraser = new System.Windows.Forms.ToolStripMenuItem();
            this.msIsFill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPen = new System.Windows.Forms.ToolStripButton();
            this.btnBrush = new System.Windows.Forms.ToolStripButton();
            this.btnLine = new System.Windows.Forms.ToolStripButton();
            this.btnRectangle = new System.Windows.Forms.ToolStripButton();
            this.btnEllipse = new System.Windows.Forms.ToolStripButton();
            this.btnFill = new System.Windows.Forms.ToolStripButton();
            this.btnErase = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPenWidth = new System.Windows.Forms.ToolStripTextBox();
            this.btnColorSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.GetBrightness = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.cms.SuspendLayout();
            this.cmsPen.SuspendLayout();
            this.cmsBrush.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(959, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate,
            this.tsmiOpen,
            this.toolStripSeparator2,
            this.tsmiSave,
            this.toolStripSeparator3,
            this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // tsmiCreate
            // 
            this.tsmiCreate.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCreate.Image")));
            this.tsmiCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCreate.Name = "tsmiCreate";
            this.tsmiCreate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiCreate.Size = new System.Drawing.Size(172, 22);
            this.tsmiCreate.Text = "&Создать";
            this.tsmiCreate.Click += new System.EventHandler(this.tsmiCreate_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsmiOpen.Image")));
            this.tsmiOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(172, 22);
            this.tsmiOpen.Text = "&Открыть";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(172, 22);
            this.tsmiSave.Text = "&Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem6.Text = "Выход";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDown = this.cms;
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPen,
            this.msBrush,
            this.msLine,
            this.msRectangle,
            this.msEllipse,
            this.msFill,
            this.msEraser,
            this.msIsFill});
            this.cms.Name = "contextMenuStrip1";
            this.cms.OwnerItem = this.инструментыToolStripMenuItem;
            this.cms.Size = new System.Drawing.Size(201, 180);
            // 
            // msPen
            // 
            this.msPen.Checked = true;
            this.msPen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.msPen.DropDown = this.cmsPen;
            this.msPen.Name = "msPen";
            this.msPen.ShortcutKeyDisplayString = "Alt+P";
            this.msPen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.msPen.Size = new System.Drawing.Size(200, 22);
            this.msPen.Text = "Карандаш";
            this.msPen.Click += new System.EventHandler(this.msTools_Click);
            // 
            // cmsPen
            // 
            this.cmsPen.AutoSize = false;
            this.cmsPen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSolid,
            this.msDashed,
            this.msDotDashed,
            this.msDotted,
            this.msDotDotDashed});
            this.cmsPen.Name = "cmsPen";
            this.cmsPen.OwnerItem = this.msPen;
            this.cmsPen.Size = new System.Drawing.Size(111, 155);
            // 
            // msSolid
            // 
            this.msSolid.AutoSize = false;
            this.msSolid.Checked = true;
            this.msSolid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.msSolid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msSolid.Image = ((System.Drawing.Image)(resources.GetObject("msSolid.Image")));
            this.msSolid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msSolid.Name = "msSolid";
            this.msSolid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.msSolid.ShowShortcutKeys = false;
            this.msSolid.Size = new System.Drawing.Size(110, 26);
            this.msSolid.ToolTipText = "Сплошная линия";
            this.msSolid.Click += new System.EventHandler(this.cmsPenStyle_Click);
            // 
            // msDashed
            // 
            this.msDashed.AutoSize = false;
            this.msDashed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msDashed.Image = ((System.Drawing.Image)(resources.GetObject("msDashed.Image")));
            this.msDashed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msDashed.Name = "msDashed";
            this.msDashed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.msDashed.ShowShortcutKeys = false;
            this.msDashed.Size = new System.Drawing.Size(110, 26);
            this.msDashed.ToolTipText = "Пунктирная линия";
            this.msDashed.Click += new System.EventHandler(this.cmsPenStyle_Click);
            // 
            // msDotDashed
            // 
            this.msDotDashed.AutoSize = false;
            this.msDotDashed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msDotDashed.Image = ((System.Drawing.Image)(resources.GetObject("msDotDashed.Image")));
            this.msDotDashed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msDotDashed.Name = "msDotDashed";
            this.msDotDashed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.msDotDashed.ShowShortcutKeys = false;
            this.msDotDashed.Size = new System.Drawing.Size(110, 26);
            this.msDotDashed.ToolTipText = "Точка-пунктирная линия";
            this.msDotDashed.Click += new System.EventHandler(this.cmsPenStyle_Click);
            // 
            // msDotted
            // 
            this.msDotted.AutoSize = false;
            this.msDotted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msDotted.Image = ((System.Drawing.Image)(resources.GetObject("msDotted.Image")));
            this.msDotted.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msDotted.Name = "msDotted";
            this.msDotted.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.msDotted.ShowShortcutKeys = false;
            this.msDotted.Size = new System.Drawing.Size(110, 26);
            this.msDotted.ToolTipText = "Точечная лииня";
            this.msDotted.Click += new System.EventHandler(this.cmsPenStyle_Click);
            // 
            // msDotDotDashed
            // 
            this.msDotDotDashed.AutoSize = false;
            this.msDotDotDashed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msDotDotDashed.Image = ((System.Drawing.Image)(resources.GetObject("msDotDotDashed.Image")));
            this.msDotDotDashed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msDotDotDashed.Name = "msDotDotDashed";
            this.msDotDotDashed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.msDotDotDashed.ShowShortcutKeys = false;
            this.msDotDotDashed.Size = new System.Drawing.Size(110, 26);
            this.msDotDotDashed.ToolTipText = "Точка-точка-пунктирная линия";
            this.msDotDotDashed.Click += new System.EventHandler(this.cmsPenStyle_Click);
            // 
            // msBrush
            // 
            this.msBrush.DropDown = this.cmsBrush;
            this.msBrush.Name = "msBrush";
            this.msBrush.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.msBrush.Size = new System.Drawing.Size(200, 22);
            this.msBrush.Text = "Кисть";
            this.msBrush.Click += new System.EventHandler(this.msTools_Click);
            // 
            // cmsBrush
            // 
            this.cmsBrush.AutoSize = false;
            this.cmsBrush.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBrushStar,
            this.msBrushSuperStar,
            this.msBrushGrass});
            this.cmsBrush.Name = "cmsPen";
            this.cmsBrush.OwnerItem = this.msBrush;
            this.cmsBrush.Size = new System.Drawing.Size(111, 103);
            // 
            // msBrushStar
            // 
            this.msBrushStar.AutoSize = false;
            this.msBrushStar.Checked = true;
            this.msBrushStar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.msBrushStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msBrushStar.Image = ((System.Drawing.Image)(resources.GetObject("msBrushStar.Image")));
            this.msBrushStar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msBrushStar.Name = "msBrushStar";
            this.msBrushStar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.msBrushStar.ShowShortcutKeys = false;
            this.msBrushStar.Size = new System.Drawing.Size(110, 26);
            this.msBrushStar.ToolTipText = "Звезда";
            this.msBrushStar.Click += new System.EventHandler(this.cmsBrushStyles_Click);
            // 
            // msBrushSuperStar
            // 
            this.msBrushSuperStar.AutoSize = false;
            this.msBrushSuperStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msBrushSuperStar.Image = ((System.Drawing.Image)(resources.GetObject("msBrushSuperStar.Image")));
            this.msBrushSuperStar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msBrushSuperStar.Name = "msBrushSuperStar";
            this.msBrushSuperStar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.msBrushSuperStar.ShowShortcutKeys = false;
            this.msBrushSuperStar.Size = new System.Drawing.Size(110, 26);
            this.msBrushSuperStar.ToolTipText = "Восьмиконечная звезда";
            this.msBrushSuperStar.Click += new System.EventHandler(this.cmsBrushStyles_Click);
            // 
            // msBrushGrass
            // 
            this.msBrushGrass.AutoSize = false;
            this.msBrushGrass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.msBrushGrass.Image = ((System.Drawing.Image)(resources.GetObject("msBrushGrass.Image")));
            this.msBrushGrass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.msBrushGrass.Name = "msBrushGrass";
            this.msBrushGrass.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.msBrushGrass.ShowShortcutKeys = false;
            this.msBrushGrass.Size = new System.Drawing.Size(110, 26);
            this.msBrushGrass.ToolTipText = "Трава";
            this.msBrushGrass.Click += new System.EventHandler(this.cmsBrushStyles_Click);
            // 
            // msLine
            // 
            this.msLine.Name = "msLine";
            this.msLine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.msLine.Size = new System.Drawing.Size(200, 22);
            this.msLine.Text = "Линия";
            this.msLine.Click += new System.EventHandler(this.msTools_Click);
            // 
            // msRectangle
            // 
            this.msRectangle.Name = "msRectangle";
            this.msRectangle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.msRectangle.Size = new System.Drawing.Size(200, 22);
            this.msRectangle.Text = "Прямоугольник";
            this.msRectangle.Click += new System.EventHandler(this.msTools_Click);
            // 
            // msEllipse
            // 
            this.msEllipse.Name = "msEllipse";
            this.msEllipse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.msEllipse.Size = new System.Drawing.Size(200, 22);
            this.msEllipse.Text = "Эллипс";
            this.msEllipse.Click += new System.EventHandler(this.msTools_Click);
            // 
            // msFill
            // 
            this.msFill.Name = "msFill";
            this.msFill.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.msFill.Size = new System.Drawing.Size(200, 22);
            this.msFill.Text = "Заливка";
            this.msFill.Click += new System.EventHandler(this.msTools_Click);
            // 
            // msEraser
            // 
            this.msEraser.Name = "msEraser";
            this.msEraser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.msEraser.Size = new System.Drawing.Size(200, 22);
            this.msEraser.Text = "Ластик";
            this.msEraser.Click += new System.EventHandler(this.msTools_Click);
            // 
            // msIsFill
            // 
            this.msIsFill.Name = "msIsFill";
            this.msIsFill.Size = new System.Drawing.Size(200, 22);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPen,
            this.btnBrush,
            this.btnLine,
            this.btnRectangle,
            this.btnEllipse,
            this.btnFill,
            this.btnErase,
            this.toolStripLabel1,
            this.txtPenWidth,
            this.btnColorSelection,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPen
            // 
            this.btnPen.Checked = true;
            this.btnPen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPen.Image = global::WindowsFormsApplication2.Properties.Resources.pencil;
            this.btnPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(23, 22);
            this.btnPen.Text = "Карандаш";
            this.btnPen.ToolTipText = "Крандаш";
            this.btnPen.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBrush.Image = ((System.Drawing.Image)(resources.GetObject("btnBrush.Image")));
            this.btnBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(23, 22);
            this.btnBrush.Text = "Кисть";
            this.btnBrush.ToolTipText = "Кисть";
            this.btnBrush.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnLine
            // 
            this.btnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLine.Image = global::WindowsFormsApplication2.Properties.Resources.line;
            this.btnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(23, 22);
            this.btnLine.Text = "Линия";
            this.btnLine.ToolTipText = "Линия";
            this.btnLine.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRectangle.Image = global::WindowsFormsApplication2.Properties.Resources.rectangle;
            this.btnRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(23, 22);
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.ToolTipText = "Прямоугольник";
            this.btnRectangle.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEllipse.Image = global::WindowsFormsApplication2.Properties.Resources.ellipse;
            this.btnEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(23, 22);
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.ToolTipText = "Эллипс";
            this.btnEllipse.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnFill
            // 
            this.btnFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFill.Image = global::WindowsFormsApplication2.Properties.Resources.fill;
            this.btnFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(23, 22);
            this.btnFill.Text = "Заливка";
            this.btnFill.ToolTipText = "Заливка";
            this.btnFill.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnErase.Image = global::WindowsFormsApplication2.Properties.Resources.eraser;
            this.btnErase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(23, 22);
            this.btnErase.Text = "Ластик";
            this.btnErase.ToolTipText = "Ластик";
            this.btnErase.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Ширина линии:";
            this.toolStripLabel1.ToolTipText = "Размер";
            // 
            // txtPenWidth
            // 
            this.txtPenWidth.MaxLength = 2;
            this.txtPenWidth.Name = "txtPenWidth";
            this.txtPenWidth.Size = new System.Drawing.Size(25, 25);
            this.txtPenWidth.Text = "1";
            this.txtPenWidth.ToolTipText = "Размер";
            this.txtPenWidth.TextChanged += new System.EventHandler(this.penWidthChanged);
            // 
            // btnColorSelection
            // 
            this.btnColorSelection.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnColorSelection.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnColorSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColorSelection.Image = global::WindowsFormsApplication2.Properties.Resources.spectr;
            this.btnColorSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColorSelection.Name = "btnColorSelection";
            this.btnColorSelection.Size = new System.Drawing.Size(23, 22);
            this.btnColorSelection.Text = "Цвет";
            this.btnColorSelection.ToolTipText = "Выбор цвета рисования";
            this.btnColorSelection.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel2.Text = "Выбор цвета:";
            // 
            // ofd
            // 
            this.ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.* ";
            this.ofd.InitialDirectory = "c:\\\\";
            this.ofd.RestoreDirectory = true;
            this.ofd.Title = "Открыть";
            // 
            // sfd
            // 
            this.sfd.Filter = "JPG Files (*.JPG)|*.jpg|PNG Files (*.PNG)|*.png|All files (*.*)|*.*";
            this.sfd.InitialDirectory = "c:\\\\";
            this.sfd.RestoreDirectory = true;
            this.sfd.Title = "Сохранить...";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 567);
            this.panel1.TabIndex = 2;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.Location = new System.Drawing.Point(85, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(766, 602);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // GetBrightness
            // 
            this.GetBrightness.Location = new System.Drawing.Point(297, 24);
            this.GetBrightness.Name = "GetBrightness";
            this.GetBrightness.Size = new System.Drawing.Size(71, 26);
            this.GetBrightness.TabIndex = 3;
            this.GetBrightness.Text = "Parser";
            this.GetBrightness.UseVisualStyleBackColor = true;
            this.GetBrightness.Click += new System.EventHandler(this.GetBrightness_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(959, 616);
            this.Controls.Add(this.GetBrightness);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графический редактор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cms.ResumeLayout(false);
            this.cmsPen.ResumeLayout(false);
            this.cmsBrush.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton btnColorSelection;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPenWidth;
        private System.Windows.Forms.ToolStripButton btnLine;
        private System.Windows.Forms.ToolStripButton btnRectangle;
        private System.Windows.Forms.ToolStripButton btnEllipse;
        private System.Windows.Forms.ToolStripButton btnErase;
        private System.Windows.Forms.ToolStripButton btnFill;
        private System.Windows.Forms.ToolStripButton btnBrush;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem msPen;
        private System.Windows.Forms.ToolStripMenuItem msBrush;
        private System.Windows.Forms.ToolStripMenuItem msLine;
        private System.Windows.Forms.ToolStripMenuItem msRectangle;
        private System.Windows.Forms.ToolStripMenuItem msEllipse;
        private System.Windows.Forms.ToolStripMenuItem msFill;
        private System.Windows.Forms.ToolStripMenuItem msEraser;
        private System.Windows.Forms.ToolStripMenuItem msIsFill;
        private System.Windows.Forms.ContextMenuStrip cmsPen;
        private System.Windows.Forms.ToolStripMenuItem msSolid;
        private System.Windows.Forms.ToolStripMenuItem msDashed;
        private System.Windows.Forms.ToolStripMenuItem msDotDashed;
        private System.Windows.Forms.ToolStripMenuItem msDotDotDashed;
        private System.Windows.Forms.ToolStripMenuItem msDotted;
        private System.Windows.Forms.ContextMenuStrip cmsBrush;
        private System.Windows.Forms.ToolStripMenuItem msBrushStar;
        private System.Windows.Forms.ToolStripMenuItem msBrushSuperStar;
        private System.Windows.Forms.ToolStripMenuItem msBrushGrass;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnPen;
        private System.Windows.Forms.Button GetBrightness;
    }
}

