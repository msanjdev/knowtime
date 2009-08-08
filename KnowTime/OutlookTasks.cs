using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;     // to use Missing.Value

using Outlook = Microsoft.Office.Interop.Outlook;

namespace KnowTimeApp
{
    class OutlookTasks
    {
        public static List<String> GetTasks2()
        {
            return new List<string>(new String[] { "task1", "task2" });
        }
        public static List<String> GetTasks()
        {
            List<String> tasks = new List<string>();

            Outlook.Application oApp = null;
            Outlook.NameSpace oNS = null;

            try
            {
                // Create the Outlook application.
                oApp = new Outlook.Application();

                // Get the NameSpace and Logon information.
                // Outlook.NameSpace oNS = (Outlook.NameSpace)oApp.GetNamespace("mapi");
                oNS = oApp.GetNamespace("MAPI");

                //Log on by using a dialog box to choose the profile.
                oNS.Logon(Missing.Value, Missing.Value, true, true);

                // Get the Calendar folder.
                Outlook.MAPIFolder oTaskList = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderTasks);

                // Get the Items (Appointments) collection from the Calendar folder.
                Outlook.Items oItems = oTaskList.Items;

                foreach (Outlook.TaskItem item in oItems)
                {
                    tasks.Add(item.Subject);
                }

                oItems = null;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e, "KnowTime", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            finally
            {
                // Done. Log off.
                if (oNS != null)
                    oNS.Logoff();
                oNS = null;
                oApp = null;
            }

            return tasks;
        }
    }
}
