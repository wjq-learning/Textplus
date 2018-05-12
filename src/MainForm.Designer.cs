namespace Textplus
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.TsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.TsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.TsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.TsmiCut = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.TsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiTurnTo = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.TsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiTime = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiPattern = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiAuto = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiFont = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiView = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiTools = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiStat = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiDebug = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiAnalyzer = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.TsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.fdlg = new System.Windows.Forms.FontDialog();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tssl = new System.Windows.Forms.ToolStripStatusLabel();
			this.psdlg = new System.Windows.Forms.PageSetupDialog();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.ptdlg = new System.Windows.Forms.PrintDialog();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.newButton = new System.Windows.Forms.ToolStripButton();
			this.openButton = new System.Windows.Forms.ToolStripButton();
			this.saveButton = new System.Windows.Forms.ToolStripButton();
			this.saveAsButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.undoButton = new System.Windows.Forms.ToolStripButton();
			this.cutButton = new System.Windows.Forms.ToolStripButton();
			this.copyButton = new System.Windows.Forms.ToolStripButton();
			this.pasteButton = new System.Windows.Forms.ToolStripButton();
			this.deleteButton = new System.Windows.Forms.ToolStripButton();
			this.timeButton = new System.Windows.Forms.ToolStripButton();
			this.fontButton = new System.Windows.Forms.ToolStripButton();
			this.panel = new System.Windows.Forms.Panel();
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFile,
            this.TsmiEdit,
            this.TsmiPattern,
            this.TsmiView,
            this.TsmiDebug,
            this.TsmiHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(739, 25);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "菜单栏";
			// 
			// TsmiFile
			// 
			this.TsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiNew,
            this.TsmiOpen,
            this.TsmiSave,
            this.TsmiSaveAs,
            this.toolStripMenuItem1,
            this.TsmiSetting,
            this.TsmiPrint,
            this.toolStripMenuItem2,
            this.TsmiExit});
			this.TsmiFile.Name = "TsmiFile";
			this.TsmiFile.Size = new System.Drawing.Size(58, 21);
			this.TsmiFile.Text = "文件(&F)";
			// 
			// TsmiNew
			// 
			this.TsmiNew.Name = "TsmiNew";
			this.TsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.TsmiNew.Size = new System.Drawing.Size(174, 22);
			this.TsmiNew.Text = "新建(&N)";
			this.TsmiNew.Click += new System.EventHandler(this.TsmiNew_Click);
			// 
			// TsmiOpen
			// 
			this.TsmiOpen.Name = "TsmiOpen";
			this.TsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.TsmiOpen.Size = new System.Drawing.Size(174, 22);
			this.TsmiOpen.Text = "打开(&O)...";
			this.TsmiOpen.Click += new System.EventHandler(this.TsmiOpen_Click);
			// 
			// TsmiSave
			// 
			this.TsmiSave.Name = "TsmiSave";
			this.TsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.TsmiSave.Size = new System.Drawing.Size(174, 22);
			this.TsmiSave.Text = "保存(&S)";
			this.TsmiSave.Click += new System.EventHandler(this.TsmiSave_Click);
			// 
			// TsmiSaveAs
			// 
			this.TsmiSaveAs.Name = "TsmiSaveAs";
			this.TsmiSaveAs.Size = new System.Drawing.Size(174, 22);
			this.TsmiSaveAs.Text = "另存为(&A)...";
			this.TsmiSaveAs.Click += new System.EventHandler(this.TsmiSaveAs_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
			// 
			// TsmiSetting
			// 
			this.TsmiSetting.Name = "TsmiSetting";
			this.TsmiSetting.Size = new System.Drawing.Size(174, 22);
			this.TsmiSetting.Text = "页面设置(&U)...";
			this.TsmiSetting.Click += new System.EventHandler(this.TsmiSetting_Click);
			// 
			// TsmiPrint
			// 
			this.TsmiPrint.Name = "TsmiPrint";
			this.TsmiPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.TsmiPrint.Size = new System.Drawing.Size(174, 22);
			this.TsmiPrint.Text = "打印(&P)...";
			this.TsmiPrint.Click += new System.EventHandler(this.TsmiPrint_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
			// 
			// TsmiExit
			// 
			this.TsmiExit.Name = "TsmiExit";
			this.TsmiExit.Size = new System.Drawing.Size(174, 22);
			this.TsmiExit.Text = "退出(&X)";
			this.TsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
			// 
			// TsmiEdit
			// 
			this.TsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiUndo,
            this.toolStripMenuItem3,
            this.TsmiCut,
            this.TsmiCopy,
            this.TsmiPaste,
            this.TsmiDelete,
            this.toolStripMenuItem4,
            this.TsmiSearch,
            this.TsmiReplace,
            this.TsmiTurnTo,
            this.toolStripMenuItem5,
            this.TsmiSelectAll,
            this.TsmiTime});
			this.TsmiEdit.Name = "TsmiEdit";
			this.TsmiEdit.Size = new System.Drawing.Size(59, 21);
			this.TsmiEdit.Text = "编辑(&E)";
			// 
			// TsmiUndo
			// 
			this.TsmiUndo.Enabled = false;
			this.TsmiUndo.Name = "TsmiUndo";
			this.TsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.TsmiUndo.Size = new System.Drawing.Size(167, 22);
			this.TsmiUndo.Text = "撤销(&U)";
			this.TsmiUndo.Click += new System.EventHandler(this.TsmiUndo_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
			// 
			// TsmiCut
			// 
			this.TsmiCut.Enabled = false;
			this.TsmiCut.Name = "TsmiCut";
			this.TsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.TsmiCut.Size = new System.Drawing.Size(167, 22);
			this.TsmiCut.Text = "剪切(&T)";
			this.TsmiCut.Click += new System.EventHandler(this.TsmiCut_Click);
			// 
			// TsmiCopy
			// 
			this.TsmiCopy.Enabled = false;
			this.TsmiCopy.Name = "TsmiCopy";
			this.TsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.TsmiCopy.Size = new System.Drawing.Size(167, 22);
			this.TsmiCopy.Text = "复制(&C)";
			this.TsmiCopy.Click += new System.EventHandler(this.TsmiCopy_Click);
			// 
			// TsmiPaste
			// 
			this.TsmiPaste.Name = "TsmiPaste";
			this.TsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.TsmiPaste.Size = new System.Drawing.Size(167, 22);
			this.TsmiPaste.Text = "粘贴(&P)";
			this.TsmiPaste.Click += new System.EventHandler(this.TsmiPaste_Click);
			// 
			// TsmiDelete
			// 
			this.TsmiDelete.Enabled = false;
			this.TsmiDelete.Name = "TsmiDelete";
			this.TsmiDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.TsmiDelete.Size = new System.Drawing.Size(167, 22);
			this.TsmiDelete.Text = "删除(&L)";
			this.TsmiDelete.Click += new System.EventHandler(this.TsmiDelete_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 6);
			// 
			// TsmiSearch
			// 
			this.TsmiSearch.Name = "TsmiSearch";
			this.TsmiSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.TsmiSearch.Size = new System.Drawing.Size(167, 22);
			this.TsmiSearch.Text = "查找(&F)";
			this.TsmiSearch.Click += new System.EventHandler(this.TsmiSearch_Click);
			// 
			// TsmiReplace
			// 
			this.TsmiReplace.Name = "TsmiReplace";
			this.TsmiReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
			this.TsmiReplace.Size = new System.Drawing.Size(167, 22);
			this.TsmiReplace.Text = "替换(&R)";
			this.TsmiReplace.Click += new System.EventHandler(this.TsmiReplace_Click);
			// 
			// TsmiTurnTo
			// 
			this.TsmiTurnTo.Name = "TsmiTurnTo";
			this.TsmiTurnTo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.TsmiTurnTo.Size = new System.Drawing.Size(167, 22);
			this.TsmiTurnTo.Text = "转到(&G)";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(164, 6);
			// 
			// TsmiSelectAll
			// 
			this.TsmiSelectAll.Name = "TsmiSelectAll";
			this.TsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.TsmiSelectAll.Size = new System.Drawing.Size(167, 22);
			this.TsmiSelectAll.Text = "全选(&A)";
			this.TsmiSelectAll.Click += new System.EventHandler(this.TsmiSelectAll_Click);
			// 
			// TsmiTime
			// 
			this.TsmiTime.Name = "TsmiTime";
			this.TsmiTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.TsmiTime.Size = new System.Drawing.Size(167, 22);
			this.TsmiTime.Text = "时间/日期(&D)";
			this.TsmiTime.Click += new System.EventHandler(this.TsmiTime_Click);
			// 
			// TsmiPattern
			// 
			this.TsmiPattern.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAuto,
            this.TsmiFont});
			this.TsmiPattern.Name = "TsmiPattern";
			this.TsmiPattern.Size = new System.Drawing.Size(62, 21);
			this.TsmiPattern.Text = "格式(&O)";
			// 
			// TsmiAuto
			// 
			this.TsmiAuto.Name = "TsmiAuto";
			this.TsmiAuto.Size = new System.Drawing.Size(152, 22);
			this.TsmiAuto.Text = "自动换行(&W)";
			this.TsmiAuto.Click += new System.EventHandler(this.TsmiAuto_Click);
			// 
			// TsmiFont
			// 
			this.TsmiFont.Name = "TsmiFont";
			this.TsmiFont.Size = new System.Drawing.Size(152, 22);
			this.TsmiFont.Text = "字体(&F)";
			this.TsmiFont.Click += new System.EventHandler(this.TsmiFont_Click);
			// 
			// TsmiView
			// 
			this.TsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiTools,
            this.TsmiStat});
			this.TsmiView.Name = "TsmiView";
			this.TsmiView.Size = new System.Drawing.Size(60, 21);
			this.TsmiView.Text = "查看(&V)";
			// 
			// TsmiTools
			// 
			this.TsmiTools.Checked = true;
			this.TsmiTools.CheckState = System.Windows.Forms.CheckState.Checked;
			this.TsmiTools.Name = "TsmiTools";
			this.TsmiTools.Size = new System.Drawing.Size(152, 22);
			this.TsmiTools.Text = "工具栏(&T)";
			this.TsmiTools.Click += new System.EventHandler(this.TsmiTools_Click);
			// 
			// TsmiStat
			// 
			this.TsmiStat.Checked = true;
			this.TsmiStat.CheckState = System.Windows.Forms.CheckState.Checked;
			this.TsmiStat.Name = "TsmiStat";
			this.TsmiStat.Size = new System.Drawing.Size(152, 22);
			this.TsmiStat.Text = "状态栏(&S)";
			this.TsmiStat.Click += new System.EventHandler(this.TsmiStat_Click);
			// 
			// TsmiDebug
			// 
			this.TsmiDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAnalyzer});
			this.TsmiDebug.Name = "TsmiDebug";
			this.TsmiDebug.Size = new System.Drawing.Size(61, 21);
			this.TsmiDebug.Text = "调试(&D)";
			// 
			// TsmiAnalyzer
			// 
			this.TsmiAnalyzer.Name = "TsmiAnalyzer";
			this.TsmiAnalyzer.Size = new System.Drawing.Size(152, 22);
			this.TsmiAnalyzer.Text = "词法分析(&A)";
			this.TsmiAnalyzer.Click += new System.EventHandler(this.TsmiAnalyzer_Click);
			// 
			// TsmiHelp
			// 
			this.TsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiMenu,
            this.toolStripMenuItem6,
            this.TsmiAbout});
			this.TsmiHelp.Name = "TsmiHelp";
			this.TsmiHelp.Size = new System.Drawing.Size(61, 21);
			this.TsmiHelp.Text = "帮助(&H)";
			// 
			// TsmiMenu
			// 
			this.TsmiMenu.Name = "TsmiMenu";
			this.TsmiMenu.Size = new System.Drawing.Size(164, 22);
			this.TsmiMenu.Text = "查看帮助(&H)";
			this.TsmiMenu.Click += new System.EventHandler(this.TsmiMenu_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(161, 6);
			// 
			// TsmiAbout
			// 
			this.TsmiAbout.Name = "TsmiAbout";
			this.TsmiAbout.Size = new System.Drawing.Size(164, 22);
			this.TsmiAbout.Text = "关于Textplus(&A)";
			this.TsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
			// 
			// ofd
			// 
			this.ofd.Filter = "文本文档|*.txt|所有文件|*.*";
			// 
			// sfd
			// 
			this.sfd.Filter = "文本文档|*.txt|所有文件|*.*";
			// 
			// fdlg
			// 
			this.fdlg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.statusStrip.Enabled = false;
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl});
			this.statusStrip.Location = new System.Drawing.Point(0, 397);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(739, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(724, 17);
			this.toolStripStatusLabel1.Spring = true;
			// 
			// tssl
			// 
			this.tssl.Name = "tssl";
			this.tssl.Size = new System.Drawing.Size(0, 17);
			// 
			// printDocument
			// 
			this.printDocument.OriginAtMargins = true;
			this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
			this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
			// 
			// ptdlg
			// 
			this.ptdlg.UseEXDialog = true;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// toolStrip
			// 
			this.toolStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openButton,
            this.saveButton,
            this.saveAsButton,
            this.toolStripSeparator1,
            this.undoButton,
            this.cutButton,
            this.copyButton,
            this.pasteButton,
            this.deleteButton,
            this.timeButton,
            this.fontButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 25);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(739, 27);
			this.toolStrip.TabIndex = 3;
			this.toolStrip.Text = "工具栏";
			// 
			// newButton
			// 
			this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
			this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(24, 24);
			this.newButton.Text = "新建";
			this.newButton.Click += new System.EventHandler(this.TsmiNew_Click);
			// 
			// openButton
			// 
			this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
			this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(24, 24);
			this.openButton.Text = "打开";
			this.openButton.Click += new System.EventHandler(this.TsmiOpen_Click);
			// 
			// saveButton
			// 
			this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
			this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(24, 24);
			this.saveButton.Text = "保存";
			this.saveButton.Click += new System.EventHandler(this.TsmiSave_Click);
			// 
			// saveAsButton
			// 
			this.saveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
			this.saveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(24, 24);
			this.saveAsButton.Text = "另存为";
			this.saveAsButton.Click += new System.EventHandler(this.TsmiSaveAs_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// undoButton
			// 
			this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.undoButton.Enabled = false;
			this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
			this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.undoButton.Name = "undoButton";
			this.undoButton.Size = new System.Drawing.Size(24, 24);
			this.undoButton.Text = "撤销";
			this.undoButton.Click += new System.EventHandler(this.TsmiUndo_Click);
			// 
			// cutButton
			// 
			this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cutButton.Enabled = false;
			this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
			this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutButton.Name = "cutButton";
			this.cutButton.Size = new System.Drawing.Size(24, 24);
			this.cutButton.Text = "剪切";
			this.cutButton.Click += new System.EventHandler(this.TsmiCut_Click);
			// 
			// copyButton
			// 
			this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copyButton.Enabled = false;
			this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
			this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(24, 24);
			this.copyButton.Text = "复制";
			this.copyButton.Click += new System.EventHandler(this.TsmiCopy_Click);
			// 
			// pasteButton
			// 
			this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
			this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteButton.Name = "pasteButton";
			this.pasteButton.Size = new System.Drawing.Size(24, 24);
			this.pasteButton.Text = "粘贴";
			this.pasteButton.Click += new System.EventHandler(this.TsmiPaste_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.deleteButton.Enabled = false;
			this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
			this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(24, 24);
			this.deleteButton.Text = "删除";
			this.deleteButton.Click += new System.EventHandler(this.TsmiDelete_Click);
			// 
			// timeButton
			// 
			this.timeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.timeButton.Image = ((System.Drawing.Image)(resources.GetObject("timeButton.Image")));
			this.timeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.timeButton.Name = "timeButton";
			this.timeButton.Size = new System.Drawing.Size(24, 24);
			this.timeButton.Text = "时间";
			this.timeButton.Click += new System.EventHandler(this.TsmiTime_Click);
			// 
			// fontButton
			// 
			this.fontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.fontButton.Image = ((System.Drawing.Image)(resources.GetObject("fontButton.Image")));
			this.fontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.fontButton.Name = "fontButton";
			this.fontButton.Size = new System.Drawing.Size(24, 24);
			this.fontButton.Text = "字体";
			this.fontButton.Click += new System.EventHandler(this.TsmiFont_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.textBox);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 52);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(739, 345);
			this.panel.TabIndex = 4;
			// 
			// textBox
			// 
			this.textBox.AcceptsTab = true;
			this.textBox.AutoWordSelection = true;
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.textBox.Location = new System.Drawing.Point(0, 0);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(739, 345);
			this.textBox.TabIndex = 2;
			this.textBox.Text = "";
			this.textBox.SelectionChanged += new System.EventHandler(this.textBox_SelectionChanged);
			this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(739, 419);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "无标题 - Textplus";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem TsmiFile;
		private System.Windows.Forms.ToolStripMenuItem TsmiNew;
		private System.Windows.Forms.ToolStripMenuItem TsmiOpen;
		private System.Windows.Forms.ToolStripMenuItem TsmiSave;
		private System.Windows.Forms.ToolStripMenuItem TsmiSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem TsmiSetting;
		private System.Windows.Forms.ToolStripMenuItem TsmiPrint;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem TsmiExit;
		private System.Windows.Forms.ToolStripMenuItem TsmiEdit;
		private System.Windows.Forms.ToolStripMenuItem TsmiUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem TsmiCut;
		private System.Windows.Forms.ToolStripMenuItem TsmiCopy;
		private System.Windows.Forms.ToolStripMenuItem TsmiPaste;
		private System.Windows.Forms.ToolStripMenuItem TsmiDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem TsmiSearch;
		private System.Windows.Forms.ToolStripMenuItem TsmiReplace;
		private System.Windows.Forms.ToolStripMenuItem TsmiTurnTo;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem TsmiSelectAll;
		private System.Windows.Forms.ToolStripMenuItem TsmiTime;
		private System.Windows.Forms.ToolStripMenuItem TsmiPattern;
		private System.Windows.Forms.ToolStripMenuItem TsmiAuto;
		private System.Windows.Forms.ToolStripMenuItem TsmiFont;
		private System.Windows.Forms.ToolStripMenuItem TsmiView;
		private System.Windows.Forms.ToolStripMenuItem TsmiStat;
		private System.Windows.Forms.ToolStripMenuItem TsmiHelp;
		private System.Windows.Forms.ToolStripMenuItem TsmiMenu;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem TsmiAbout;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.FontDialog fdlg;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel tssl;
		private System.Windows.Forms.PageSetupDialog psdlg;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.PrintDialog ptdlg;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton newButton;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.ToolStripButton openButton;
		private System.Windows.Forms.ToolStripButton saveButton;
		private System.Windows.Forms.ToolStripButton saveAsButton;
		private System.Windows.Forms.ToolStripButton undoButton;
		private System.Windows.Forms.ToolStripButton cutButton;
		private System.Windows.Forms.ToolStripButton copyButton;
		private System.Windows.Forms.ToolStripButton pasteButton;
		private System.Windows.Forms.ToolStripButton deleteButton;
		private System.Windows.Forms.ToolStripButton timeButton;
		private System.Windows.Forms.ToolStripButton fontButton;
		private System.Windows.Forms.ToolStripMenuItem TsmiTools;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		public System.Windows.Forms.RichTextBox textBox;
		private System.Windows.Forms.ToolStripMenuItem TsmiDebug;
		private System.Windows.Forms.ToolStripMenuItem TsmiAnalyzer;
	}
}

