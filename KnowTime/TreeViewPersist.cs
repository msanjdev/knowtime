using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace KnowTimeApp
{
	/// <summary>
	/// jhTreeViewTools is a namespace for classes around the TreeView control
	/// This (only) one is a class for saving and loading the TreeView 
	/// </summary>
    public class TreeViewPersist
	{

		#region Save (saveTree, saveNode)

        public static int SaveTree(TreeView tree, string filename)
        {
            Stream file = null;
            try
            {
                // Datei anlegen
                file = File.Open(filename, FileMode.Create);
                return SaveTree(tree, file);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

		/// <summary>
		/// Save the TreeView content
		/// </summary>
		/// <param name="tree"></param>
		/// <param name="filename"></param>
		/// <returns>Errorcode as int</returns>
		public static int SaveTree(TreeView tree, Stream output)
		{
			// Neues Array anlegen
			ArrayList al = new ArrayList();
			foreach (TreeNode tn in tree.Nodes)
			{
				// jede RootNode im TreeView sichern ...
				al.Add(tn);
			}

			// Binär-Formatierer init.
			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				// Serialisieren des Arrays
				bf.Serialize(output, al);
			}
			catch (System.Runtime.Serialization.SerializationException e)
			{
				MessageBox.Show("Serialization failed : {0}", e.Message);
				return -1; // ERROR
			}

			return 0; // OKAY
		}
		#endregion

	
		#region Load (loadTree, searchNode)
        public static int LoadTree(TreeView tree, string filename)
        {
            Stream file = null;

            try 
	        {	        
                if (File.Exists(filename))
                {
                    // Datei öffnen
                    file = File.Open(filename, FileMode.Open);
                    return LoadTree(tree, file);
                }
        	}
            finally
            {
                // Datei schliessen
                if (null == file)
                    file.Close();
            }
            return -1;
        }
        /// <summary>
		/// Load the TreeView content
		/// </summary>
		/// <param name="tree"></param>
		/// <param name="filename"></param>
		/// <returns>Errorcode as int</returns>
		public static int LoadTree(TreeView tree, Stream input)
		{
				// Binär-Formatierer init.
				BinaryFormatter bf = new BinaryFormatter();
				// Object var. init.
				object obj = null;
                try
                {
                    // Daten aus der Datei deserialisieren
                    obj = bf.Deserialize(input);
                }
                catch (System.Runtime.Serialization.SerializationException e)
                {
                    MessageBox.Show("De-Serialization failed : {0}", e.Message);
                    return -1;
                }

				// Neues Array erstellen
				ArrayList nodeList = obj as ArrayList;

				// load Root-Nodes
				foreach (TreeNode node in nodeList)
				{
					tree.Nodes.Add(node);
				}
				return 0;
		}
		
		#endregion
	}
}
