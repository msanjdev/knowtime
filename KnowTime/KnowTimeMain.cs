using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace KnowTimeApp
{
    public partial class KnowTimeMain : Form
    {
        public KnowTimeMain()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
            icoTaskbar.Visible = true;
        }


        private void icoTaskbar_Click(object sender, EventArgs e)
        {
            MouseEventArgs m = null;

            if (e is MouseEventArgs)
            {

                m = (MouseEventArgs)e;

                if (m.Button == MouseButtons.Left)
                {
                    // mnuTaskbar.Show(Form1.ActiveForm, e.Location);
                    Show();
                    BringToFront();
                    TopMost = true;
                    TopMost = false;

                    WindowState = FormWindowState.Normal;
                    // icoTaskbar.Visible = false;
                }
            }
        }

        bool isNew = false;

        private void NewNode(TreeNode s)
        {
            TreeNode n = null;

            isNew = true;
            if (s == null)
                n = treeView1.Nodes.Add("New");
            else
            {
                n = treeView1.SelectedNode.Nodes.Add("New");
                treeView1.SelectedNode.Expand();
            }

            treeView1.SelectedNode = n;
            treeView1.SelectedNode.BeginEdit();

        }
        private void trmnAction_Click(object sender, EventArgs e)
        {
            String action = sender.ToString();
            isNew = false;

            var s = treeView1.SelectedNode;

            if (action.StartsWith("Add"))
            {
                NewNode(s);
            }
            else if (action.StartsWith("Remove") && s != null)
            {
                treeView1.SelectedNode.Expand();

                if (MessageBox.Show("Confirm deletion of task and all subtasks associated with it?", "KnowTime - Your Time Keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) 
                    == DialogResult.OK)
                {
                    treeView1.SelectedNode = treeView1.SelectedNode.Parent;
                    treeView1.Nodes.Remove(s);
                }
            }
            else if (action.StartsWith("Edit") && s != null)
            {
                treeView1.LabelEdit = true;

                treeView1.SelectedNode.Expand();
                treeView1.SelectedNode.BeginEdit();
            }
            else if (action.StartsWith("Start") && s != null)
            {
                StartTiming(treeView1.SelectedNode.Text);
            }
        }

        private string GetLastDuration()
        {
            var diff = DateTime.Now - lastStarted;
            return String.Format("{0}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds);

        }
        private void UpdateTiming()
        {
            if (lvTimeLog.Items.Count == 0)
                return;

            var last = lvTimeLog.Items[lvTimeLog.Items.Count - 1];

            //  last time - now = duration
            var started = DateTime.Parse(last.SubItems[0].Text);

            var duration = DateTime.Now - started;

            last.SubItems[1].Text = DateTime.Now.ToShortTimeString();
            last.SubItems[2].Text = GetLastDuration();
        }

        DateTime lastStarted;

        private void StartTiming(String entry)
        {
            lblStatus.Text = "Running";

            lblNowTask.Text = entry;
            lblNowTiming.Text = "0:00:00";

            icoTaskbar.Text = Application.ProductName + " : " + lblStatus.Text + " : " + entry;

            mniStopTiming.Enabled = cmdStopTiming.Enabled = true;

            UpdateTiming();

            string[] val = new string[4];

            lastStarted = DateTime.Now;

            val[0] = lastStarted.ToShortTimeString();
            val[1] = "";
            val[2] = "";
            val[3] = entry;

            ListViewItem lvi = new ListViewItem(val);

            lvTimeLog.Items.Add(lvi);

            tmrDuration.Start();

            

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
            isNew = false;
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null && isNew)
            {
                treeView1.SelectedNode = e.Node.Parent;
                treeView1.Nodes.Remove(e.Node);
            }
            else
            {
                isTasksSaved = false;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtDesc.Text = (string) treeView1.SelectedNode.Tag;
        }

        private void txtDesc_Leave(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.SelectedNode.Tag = txtDesc.Text;
        }

        private void KnowTimeMain_Load(object sender, EventArgs e)
        {
            icoTaskbar.Text = Application.ProductName + " : " + lblStatus.Text;

            LoadData();
            LoadMenu();
            LoadLog();
        }

        private void LoadMenuTasks(TreeNodeCollection nodes, ToolStripItemCollection menuItems)
        {
            ToolStripMenuItem m ;

            foreach (TreeNode n in nodes)
            {
                m = (ToolStripMenuItem)menuItems.Add(n.Text);
                m.Click += new System.EventHandler(this.ctxTaskType_Click);

                if (n.Nodes.Count > 0)
                {
                    LoadMenuTasks(n.Nodes, m.DropDownItems);
                }
            }
        }

        ToolStripMenuItem mniStopTiming = null, mniOutlook = null;

        private void LoadMenu()
        {
            //  from tree view we create the context menu
            //  treeview --> ctxTypes 
            TreeNodeCollection nodes = treeView1.Nodes;

            //  clear design time test data if any
            ctxTypes.Items.Clear();

            mniStopTiming = (ToolStripMenuItem)ctxTypes.Items.Add("&Stop Timing");
            mniStopTiming.Enabled = false;
            mniStopTiming.Click += new System.EventHandler(this.cmdStopTiming_Click);
            ctxTypes.Items.Add(new ToolStripSeparator());

            LoadMenuTasks(nodes, ctxTypes.Items);

            ctxTypes.Items.Add(new ToolStripSeparator());
            var m = (ToolStripMenuItem)ctxTypes.Items.Add("&Exit");
            m.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        }

        bool isTasksSaved = true;

        private void SaveTasks()
        {
            MemoryStream str = new MemoryStream();

            TreeViewPersist.SaveTree(treeView1, str);

            Application.UserAppDataRegistry.SetValue("TREEDATA", str.ToArray());

            isTasksSaved = true;
        }


        private void LoadData()
        {
            var val = (byte[])Application.UserAppDataRegistry.GetValue("TREEDATA");

            if (val != null)
            {
                MemoryStream str = new MemoryStream(val);

                TreeViewPersist.LoadTree(treeView1, str);
            }

            //lvTimeLog.Columns.Clear();
            lvTimeLog.GridLines = true;
            lvTimeLog.LabelEdit = true;
            lvTimeLog.LabelWrap = true;

            lblNowTiming.Text = lblNowTask.Text = "";
        }


        private void icoTaskbar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ctxTaskType_Click(object sender, EventArgs e)
        {
            StartTiming(sender.ToString());
        }

        private void ctxTypes_Opening(object sender, CancelEventArgs e)
        {

        }

        private void StopTiming()
        {
            lblStatus.Text = "Idle";
            mniStopTiming.Enabled = cmdStopTiming.Enabled = false;
            tmrDuration.Stop();

            UpdateTiming();

            lblNowTask.Text = "";
            lblNowTiming.Text = "";

            icoTaskbar.Text = Application.ProductName + " : " + lblStatus.Text;
        }

        private void cmdStopTiming_Click(object sender, EventArgs e)
        {
            StopTiming();
        }

        private void tmrDuration_Tick(object sender, EventArgs e)
        {
            if (lastStarted != null)
            {
                var diff = (DateTime.Now - lastStarted);
                lblNowTiming.Text = GetLastDuration();
            }
        }

        private void cmdDtChange_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "<")
            {
                dtLog.Value = dtLog.Value.AddDays(-1);
            }
            else
            {
                dtLog.Value = dtLog.Value.AddDays(1);
            }
        }

        TimeLogJournal j = null;

        private void ShowLog(DateTime day)
        {
            ListViewItem lvi;

            lvTimeLog.Items.Clear();

            foreach (var l in j[day])
            {
                lvi = new ListViewItem(new String[4]);

                lvi.SubItems[0].Text = l.Start;
                lvi.SubItems[1].Text = l.End;
                lvi.SubItems[2].Text = l.Duration;
                lvi.SubItems[3].Text = l.Task;

                lvTimeLog.Items.Add(lvi);
            }
        }

        private void LoadLog()
        {
            j = TimeLogJournal.Load();
            ShowLog(DateTime.Now);

        }

        private void ClearLog()
        {
            j[dtLog.Value].Clear();
            lvTimeLog.Items.Clear();
        }

        private void SaveLog()
        {
            DateTime day = currentDay;

            j[day].Clear();

            foreach (ListViewItem item in lvTimeLog.Items)
            {
                TimeLogEntry l = new TimeLogEntry();

                l.Start = item.SubItems[0].Text;
                l.End = item.SubItems[1].Text;
                l.Duration = item.SubItems[2].Text;
                l.Task = item.SubItems[3].Text;

                j[day].Add(l);
            }

            j.Save();
        }

        DateTime currentDay = DateTime.Now;

        private void dtLog_ValueChanged(object sender, EventArgs e)
        {
            SaveLog();

            currentDay = dtLog.Value.Date;
            ShowLog(currentDay);
        }

        public void SerializeToXML(String fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(TimeLogJournal));
            TextWriter textWriter = new StreamWriter(fileName);
            serializer.Serialize(textWriter, j);
            textWriter.Close();
        }

        private void KnowTimeMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLog();

            if (!isTasksSaved)
            {
                var res = MessageBox.Show("Save tasks?", "KnowTime - Your Time Keeper", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    SaveTasks();
                }
            }
        }

        KnowTimeSettings settings = new KnowTimeSettings();

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode newNode;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode destinationNode = ((TreeView)sender).GetNodeAt(pt);
                newNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (destinationNode != newNode)
                {
                    destinationNode.Nodes.Add((TreeNode)newNode.Clone());
                    destinationNode.Expand();
                    //Remove Original Node
                    newNode.Remove();
                }
            }
        }

        private void saveTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTasks();
            
            LoadMenu();

            MessageBox.Show("Tasks and notes saved (to Registry). Context menu updated.", "KnowTime", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

            if (MessageBox.Show("Clear all entries of timelog for the selected date?", "KnowTime - Your Time Keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                ClearLog();
            }
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KnowTimeHelp kh = new KnowTimeHelp();
            kh.ShowDialog();
            kh.Dispose();
        }

        private void newMainTaskMenuItem_Click(object sender, EventArgs e)
        {
            NewNode(null);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutKnowTime ak = new AboutKnowTime();
            ak.ShowDialog();
            ak.Dispose();
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

            DialogResult d = sfdExport.ShowDialog();

            if (d == DialogResult.OK)
            {
                String fileName = sfdExport.FileName;
                SerializeToXML(fileName);
            }
        }

        private void ImportFromOutlook()
        {
            List<String> outlookTasks = OutlookTasks.GetTasks();

            if (outlookTasks != null && outlookTasks.Count > 0)
            {

                if (mniOutlook == null)
                {
                    mniOutlook = new ToolStripMenuItem("&Outlook");

                    ctxTypes.Items.Insert(1, mniOutlook);
                    ctxTypes.Items.Insert(1, new ToolStripSeparator());
                }

                mniOutlook.DropDownItems.Clear();

                foreach (var task in outlookTasks)
                {
                    var m = mniOutlook.DropDownItems.Add(task);
                    m.Click += new System.EventHandler(this.ctxTaskType_Click);
                }

                MessageBox.Show("Tasks were retrieved and context menu was updated.", "KnowTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No tasks were retrieved", "KnowTime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void importTasksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ImportFromOutlook();
        }

        private void refreshTasksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ImportFromOutlook();
        }
    }
}
