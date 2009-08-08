using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KnowTimeApp
{
    public partial class KnowTimeHelp : Form
    {
        public KnowTimeHelp()
        {
            InitializeComponent();
        }

        private void KnowTimeHelp_Load(object sender, EventArgs e)
        {
            String s = @"Thank you for trying out KnowTime.

KnowTime is a simple, unobstrusive tool that helps you to realise how you are spending your time. Objective: increasing your focus and productivity.

In the Tasks pane, define some tasks by using the + button. Then add further sub-tasks by right clicking on any task. Notes can be added per task in the right pane.

Once done, you can start timing! Just right click on any task and select Start Timing from the context menu.

Once the application is minimised, it reduces to a notiication icon on your system tray.

Change one's Status (current task), by Right Clicking on the notification icon.

A time log displays the tasks and duration for each, in a list view, per day. This can be exported to an XML file, and viewed in Excel or a browser.

KnowTime is free to use - any feedback is greatly appreciated! (timelylife@gmail.com)";

            txtHelp.Text = s;
            txtHelp.Select(0, 0);
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            AboutKnowTime ak = new AboutKnowTime();
            ak.ShowDialog();
            ak.Dispose();
        }
    }
}
