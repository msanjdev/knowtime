using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace KnowTimeApp
{
    [Serializable()] 
    public class TimeLogJournal
    {
        public TimeLogJournal()
        {
            Name = "diary";
            entries = new Dictionary<DateTime, List<TimeLogEntry>>();
        }

        private Dictionary<DateTime, List<TimeLogEntry>> entries { get; set; }

        public String Name { get; set; }

        /*
        private List<KeyValuePair<DateTime, List<TimeLogEntry>>> DayEntries
        {
            get 
            {
                List<KeyValuePair<DateTime, List<TimeLogEntry>>> l = new List<KeyValuePair<DateTime, List<TimeLogEntry>>>();

                foreach (var key in entries.Keys)
                {
                    var val = new KeyValuePair<DateTime, List<TimeLogEntry>>(key.Date, entries[key]);
                    l.Add(val);
                }

                return l;
            }
        }
         * */

        //[XmlInclude(typeof(DayEntriesData))]
        //public ArrayList DayEntries
        /*
         *                 ArrayList l = new ArrayList();

                foreach (var key in entries.Keys)
                {
                    l.Add(new DayEntriesData(key.Date, entries[key]));
                }

         * */
        public List<DayEntriesData> DayEntries
        {
            get 
            {
                List<DayEntriesData> l = new List<DayEntriesData>();

                foreach (var key in entries.Keys)
                {
                    l.Add(new DayEntriesData(key.Date, entries[key]));
                }

                //MessageBox.Show(l.Count.ToString());
                return l;
            }
        }

        public List<TimeLogEntry> this[DateTime date]
        {
            get {
                //  ignore time stamp
                date = date.Date;

                if (!entries.ContainsKey(date))
                    entries[date] = new List<TimeLogEntry>();

                return entries[date];
            }
        }


        public static TimeLogJournal Load()
        {
            var val = (byte[])Application.UserAppDataRegistry.GetValue("LOGDATA");
            if (val == null)
            {
                KnowTimeHelp kh = new KnowTimeHelp();
                kh.ShowDialog();
                kh.Dispose();

                return new TimeLogJournal();
            }

            MemoryStream str = new MemoryStream(val);

            // Binär-Formatierer init.
            BinaryFormatter bf = new BinaryFormatter();
            // Object var. init.
            object obj = null;
            try
            {
                // Daten aus der Datei deserialisieren
                obj = bf.Deserialize(str);
            }
            catch (System.Runtime.Serialization.SerializationException e)
            {
                MessageBox.Show(String.Format("De-Serialization failed : {0}", e.Message));
                return null;
            }

            TimeLogJournal j = obj as TimeLogJournal;

            return j != null ? j : new TimeLogJournal();
        }

        public void Save()
        {
            MemoryStream str = new MemoryStream();

            // Binär-Formatierer init.
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                // Serialisieren des Arrays
                bf.Serialize(str, this);
            }
            catch (System.Runtime.Serialization.SerializationException e)
            {
                MessageBox.Show(String.Format("Serialization failed : {0}", e.Message));
            }

            Application.UserAppDataRegistry.SetValue("LOGDATA", str.ToArray());
        }
    }

    /// <summary>
    /// Just for xml serialization
    /// </summary>
    [Serializable()] 
    public class DayEntriesData
    {
        public DayEntriesData()
        {
        }
        public DayEntriesData(DateTime day, List<TimeLogEntry> e)
        {
            Day = day;
            Entries = e;
        }

        [XmlAttribute("Day")]
        public DateTime Day { get; set; }
        public List<TimeLogEntry> Entries { get; set; }
    }

    [Serializable()] 
    public class TimeLogEntry
    {
        public String Start { get; set; }
        public String End { get; set; }
        public String Duration { get; set; }
        public String Task { get; set; }
        public String Notes { get; set; }
    }
}
