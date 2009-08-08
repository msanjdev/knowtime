namespace KnowTimeApp
{
    partial class KnowTimeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowTimeMain));
            this.icoTaskbar = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ctxTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trmnStartTiming = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trmnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.trmnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.trmnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdAddType = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lvTimeLog = new System.Windows.Forms.ListView();
            this.clStart = new System.Windows.Forms.ColumnHeader();
            this.clStop = new System.Windows.Forms.ColumnHeader();
            this.clDuration = new System.Windows.Forms.ColumnHeader();
            this.clDesc = new System.Windows.Forms.ColumnHeader();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStopTiming = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdDtNext = new System.Windows.Forms.Button();
            this.cmdDtPrev = new System.Windows.Forms.Button();
            this.dtLog = new System.Windows.Forms.DateTimePicker();
            this.lblNowTask = new System.Windows.Forms.Label();
            this.lblNowTiming = new System.Windows.Forms.Label();
            this.tmrDuration = new System.Windows.Forms.Timer(this.components);
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.newMainTaskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSOutlookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxTypes.SuspendLayout();
            this.ctxTree.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // icoTaskbar
            // 
            this.icoTaskbar.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icoTaskbar.BalloonTipText = "Time is flying";
            this.icoTaskbar.BalloonTipTitle = "Going going gone...";
            this.icoTaskbar.ContextMenuStrip = this.ctxTypes;
            this.icoTaskbar.Icon = ((System.Drawing.Icon)(resources.GetObject("icoTaskbar.Icon")));
            this.icoTaskbar.Text = "Timer Application";
            this.icoTaskbar.Visible = true;
            this.icoTaskbar.Click += new System.EventHandler(this.icoTaskbar_Click);
            this.icoTaskbar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icoTaskbar_MouseDoubleClick);
            // 
            // ctxTypes
            // 
            this.ctxTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.ctxTypes.Name = "contextMenuStrip1";
            this.ctxTypes.Size = new System.Drawing.Size(181, 70);
            this.ctxTypes.Opening += new System.ComponentModel.CancelEventHandler(this.ctxTypes_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ctxTaskType_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.ContextMenuStrip = this.ctxTree;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(6, 36);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(173, 260);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            // 
            // ctxTree
            // 
            this.ctxTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trmnStartTiming,
            this.toolStripSeparator1,
            this.trmnAdd,
            this.trmnEdit,
            this.trmnDelete});
            this.ctxTree.Name = "ctxTree";
            this.ctxTree.Size = new System.Drawing.Size(149, 98);
            // 
            // trmnStartTiming
            // 
            this.trmnStartTiming.Name = "trmnStartTiming";
            this.trmnStartTiming.Size = new System.Drawing.Size(148, 22);
            this.trmnStartTiming.Text = "Start Timing";
            this.trmnStartTiming.Click += new System.EventHandler(this.trmnAction_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // trmnAdd
            // 
            this.trmnAdd.Name = "trmnAdd";
            this.trmnAdd.Size = new System.Drawing.Size(148, 22);
            this.trmnAdd.Text = "Add Sub-Task";
            this.trmnAdd.Click += new System.EventHandler(this.trmnAction_Click);
            // 
            // trmnEdit
            // 
            this.trmnEdit.Name = "trmnEdit";
            this.trmnEdit.Size = new System.Drawing.Size(148, 22);
            this.trmnEdit.Text = "Edit";
            this.trmnEdit.Click += new System.EventHandler(this.trmnAction_Click);
            // 
            // trmnDelete
            // 
            this.trmnDelete.Name = "trmnDelete";
            this.trmnDelete.Size = new System.Drawing.Size(148, 22);
            this.trmnDelete.Text = "Remove";
            this.trmnDelete.Click += new System.EventHandler(this.trmnAction_Click);
            // 
            // cmdAddType
            // 
            this.cmdAddType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddType.Location = new System.Drawing.Point(0, 21);
            this.cmdAddType.Name = "cmdAddType";
            this.cmdAddType.Size = new System.Drawing.Size(22, 21);
            this.cmdAddType.TabIndex = 3;
            this.cmdAddType.Text = "+";
            this.cmdAddType.UseVisualStyleBackColor = true;
            this.cmdAddType.Click += new System.EventHandler(this.newMainTaskMenuItem_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.Location = new System.Drawing.Point(185, 36);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(150, 260);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.Leave += new System.EventHandler(this.txtDesc_Leave);
            // 
            // lvTimeLog
            // 
            this.lvTimeLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clStart,
            this.clStop,
            this.clDuration,
            this.clDesc});
            this.lvTimeLog.FullRowSelect = true;
            this.lvTimeLog.GridLines = true;
            this.lvTimeLog.HideSelection = false;
            this.lvTimeLog.LabelEdit = true;
            this.lvTimeLog.Location = new System.Drawing.Point(3, 66);
            this.lvTimeLog.Name = "lvTimeLog";
            this.lvTimeLog.Size = new System.Drawing.Size(332, 243);
            this.lvTimeLog.TabIndex = 3;
            this.lvTimeLog.UseCompatibleStateImageBehavior = false;
            this.lvTimeLog.View = System.Windows.Forms.View.Details;
            // 
            // clStart
            // 
            this.clStart.Text = "Start";
            // 
            // clStop
            // 
            this.clStop.Text = "Stop";
            // 
            // clDuration
            // 
            this.clDuration.Text = "Duration";
            // 
            // clDesc
            // 
            this.clDesc.Text = "Task";
            this.clDesc.Width = 143;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(88, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(28, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Idle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Timer Status:";
            // 
            // cmdStopTiming
            // 
            this.cmdStopTiming.Enabled = false;
            this.cmdStopTiming.Location = new System.Drawing.Point(290, 33);
            this.cmdStopTiming.Name = "cmdStopTiming";
            this.cmdStopTiming.Size = new System.Drawing.Size(75, 23);
            this.cmdStopTiming.TabIndex = 0;
            this.cmdStopTiming.Text = "&Stop Timing";
            this.cmdStopTiming.UseVisualStyleBackColor = true;
            this.cmdStopTiming.Click += new System.EventHandler(this.cmdStopTiming_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmdAddType);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.txtDesc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(341, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tasks";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdDtNext);
            this.tabPage2.Controls.Add(this.cmdDtPrev);
            this.tabPage2.Controls.Add(this.dtLog);
            this.tabPage2.Controls.Add(this.lvTimeLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdDtNext
            // 
            this.cmdDtNext.Location = new System.Drawing.Point(129, 40);
            this.cmdDtNext.Name = "cmdDtNext";
            this.cmdDtNext.Size = new System.Drawing.Size(17, 23);
            this.cmdDtNext.TabIndex = 2;
            this.cmdDtNext.Text = ">";
            this.cmdDtNext.UseVisualStyleBackColor = true;
            this.cmdDtNext.Click += new System.EventHandler(this.cmdDtChange_Click);
            // 
            // cmdDtPrev
            // 
            this.cmdDtPrev.Location = new System.Drawing.Point(111, 40);
            this.cmdDtPrev.Name = "cmdDtPrev";
            this.cmdDtPrev.Size = new System.Drawing.Size(17, 23);
            this.cmdDtPrev.TabIndex = 1;
            this.cmdDtPrev.Text = "<";
            this.cmdDtPrev.UseVisualStyleBackColor = true;
            this.cmdDtPrev.Click += new System.EventHandler(this.cmdDtChange_Click);
            // 
            // dtLog
            // 
            this.dtLog.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLog.Location = new System.Drawing.Point(3, 40);
            this.dtLog.MinDate = new System.DateTime(2009, 1, 1, 0, 0, 0, 0);
            this.dtLog.Name = "dtLog";
            this.dtLog.Size = new System.Drawing.Size(101, 20);
            this.dtLog.TabIndex = 0;
            this.dtLog.ValueChanged += new System.EventHandler(this.dtLog_ValueChanged);
            // 
            // lblNowTask
            // 
            this.lblNowTask.AutoSize = true;
            this.lblNowTask.Location = new System.Drawing.Point(190, 39);
            this.lblNowTask.Name = "lblNowTask";
            this.lblNowTask.Size = new System.Drawing.Size(27, 13);
            this.lblNowTask.TabIndex = 11;
            this.lblNowTask.Text = "task";
            // 
            // lblNowTiming
            // 
            this.lblNowTiming.AutoSize = true;
            this.lblNowTiming.Location = new System.Drawing.Point(146, 39);
            this.lblNowTiming.Name = "lblNowTiming";
            this.lblNowTiming.Size = new System.Drawing.Size(43, 13);
            this.lblNowTiming.TabIndex = 12;
            this.lblNowTiming.Text = "0:00:00";
            // 
            // tmrDuration
            // 
            this.tmrDuration.Interval = 1000;
            this.tmrDuration.Tick += new System.EventHandler(this.tmrDuration_Tick);
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "*.xml";
            this.sfdExport.FileName = "MyTimeLog.xml";
            this.sfdExport.Filter = "XML Files|*.xml";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.timeLogToolStripMenuItem,
            this.importToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(374, 24);
            this.mnuMain.TabIndex = 14;
            this.mnuMain.Text = "menuStrip1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMainTaskMenuItem,
            this.saveTasksToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem4.Text = "&KnowTime";
            // 
            // newMainTaskMenuItem
            // 
            this.newMainTaskMenuItem.Name = "newMainTaskMenuItem";
            this.newMainTaskMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMainTaskMenuItem.Size = new System.Drawing.Size(198, 22);
            this.newMainTaskMenuItem.Text = "New Main Task";
            this.newMainTaskMenuItem.ToolTipText = "Add a root task. Also use the + button.";
            this.newMainTaskMenuItem.Click += new System.EventHandler(this.newMainTaskMenuItem_Click);
            // 
            // saveTasksToolStripMenuItem
            // 
            this.saveTasksToolStripMenuItem.Name = "saveTasksToolStripMenuItem";
            this.saveTasksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveTasksToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.saveTasksToolStripMenuItem.Text = "&Save Tasks";
            this.saveTasksToolStripMenuItem.ToolTipText = "Save tasks and update the context menu.";
            this.saveTasksToolStripMenuItem.Click += new System.EventHandler(this.saveTasksToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.settingsToolStripMenuItem.Text = "&Preferences...";
            this.settingsToolStripMenuItem.ToolTipText = "Settings.";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timeLogToolStripMenuItem
            // 
            this.timeLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exportToXMLToolStripMenuItem});
            this.timeLogToolStripMenuItem.Name = "timeLogToolStripMenuItem";
            this.timeLogToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.timeLogToolStripMenuItem.Text = "Time &Log";
            this.timeLogToolStripMenuItem.ToolTipText = "The journal where entries are stored";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.clearToolStripMenuItem.Text = "&Clear Log (Selected Day)";
            this.clearToolStripMenuItem.ToolTipText = "Clear all entries in the selected day\'s log. Cannot be undone.";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exportToXMLToolStripMenuItem.Text = "Export To &XML...";
            this.exportToXMLToolStripMenuItem.ToolTipText = "Export the time log to an XML file, viewable in applications like a browser or ed" +
                "itable in Microsoft Excel.";
            this.exportToXMLToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSOutlookToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.importToolStripMenuItem.Text = "&Import Tasks";
            this.importToolStripMenuItem.ToolTipText = "Import tasks from various sources, currently supported: Microsoft Outlook (in pro" +
                "gress)";
            // 
            // mSOutlookToolStripMenuItem
            // 
            this.mSOutlookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTasksToolStripMenuItem,
            this.refreshTasksToolStripMenuItem});
            this.mSOutlookToolStripMenuItem.Name = "mSOutlookToolStripMenuItem";
            this.mSOutlookToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mSOutlookToolStripMenuItem.Text = "Microsoft &Outlook";
            this.mSOutlookToolStripMenuItem.ToolTipText = "Microsoft Outlook task list.";
            // 
            // importTasksToolStripMenuItem
            // 
            this.importTasksToolStripMenuItem.Name = "importTasksToolStripMenuItem";
            this.importTasksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importTasksToolStripMenuItem.Text = "&Import...";
            this.importTasksToolStripMenuItem.ToolTipText = "Imports tasks from Microsoft Outlook";
            this.importTasksToolStripMenuItem.Click += new System.EventHandler(this.importTasksToolStripMenuItem_Click_1);
            // 
            // refreshTasksToolStripMenuItem
            // 
            this.refreshTasksToolStripMenuItem.Name = "refreshTasksToolStripMenuItem";
            this.refreshTasksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshTasksToolStripMenuItem.Text = "&Refresh";
            this.refreshTasksToolStripMenuItem.ToolTipText = "Currently, the same as Import Tasks, as the profile information isn\'t being store" +
                "d.";
            this.refreshTasksToolStripMenuItem.Click += new System.EventHandler(this.refreshTasksToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.usageToolStripMenuItem.Text = "&Usage";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // KnowTimeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 415);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.lblNowTiming);
            this.Controls.Add(this.lblNowTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdStopTiming);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "KnowTimeMain";
            this.Text = "KnowTime - Your Time Tracker";
            this.Load += new System.EventHandler(this.KnowTimeMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KnowTimeMain_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ctxTypes.ResumeLayout(false);
            this.ctxTree.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon icoTaskbar;
        private System.Windows.Forms.ContextMenuStrip ctxTypes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip ctxTree;
        private System.Windows.Forms.ToolStripMenuItem trmnAdd;
        private System.Windows.Forms.ToolStripMenuItem trmnDelete;
        private System.Windows.Forms.ToolStripMenuItem trmnEdit;
        private System.Windows.Forms.Button cmdAddType;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ListView lvTimeLog;
        private System.Windows.Forms.ColumnHeader clStart;
        private System.Windows.Forms.ColumnHeader clStop;
        private System.Windows.Forms.ColumnHeader clDuration;
        private System.Windows.Forms.ColumnHeader clDesc;
        private System.Windows.Forms.ToolStripMenuItem trmnStartTiming;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdStopTiming;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNowTask;
        private System.Windows.Forms.Label lblNowTiming;
        private System.Windows.Forms.Timer tmrDuration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DateTimePicker dtLog;
        private System.Windows.Forms.Button cmdDtNext;
        private System.Windows.Forms.Button cmdDtPrev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem saveTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMainTaskMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSOutlookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshTasksToolStripMenuItem;

    }
}

