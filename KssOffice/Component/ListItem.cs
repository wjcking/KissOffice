using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Security.AccessControl;
using System;
namespace KssOffice
{
    /// <summary>
    /// 目前为word文档，可扩展继承aspose。words
    /// </summary>
    public partial class ListItem : ListBox
    {
        private object dataSource = null;
        private List<string> folderList;
        private List<string> fileList;
        private List<string> extentionList;
        public const string SystemVolumeInformation = "System Volume Information";

        public List<string> FileList
        {
            get { return fileList; } 
        }
        public ListItem()
        {
            InitializeComponent();
        }
        private void BindFiles(string folder)
        {
            DataSource = null;
            Items.Clear();

            if (folderList == null)
                folderList = new List<string>();

            if (fileList == null)
                fileList = new List<string>();
            fileList.Clear();

            folderList.Clear();
            folderList.Add(folder);
            BindFolder(folder);

            foreach (string fo in folderList)
            {
                Application.DoEvents();
                foreach (string ext in extentionList)
                {
                    string[] list = Directory.GetFiles(fo, "*"+ext);

                    fileList.AddRange(list);
                }
            }
            DataSource = fileList;
        }

        private void BindFolder(string folder)
        {
           
                if (string.IsNullOrEmpty(folder))
                    return;

                string[] directoryList = Directory.GetDirectories(folder);

                foreach (string dir in directoryList)
                {
                    if (!Directory.Exists(dir))
                        continue;
                    if (dir.IndexOf(SystemVolumeInformation) > -1)
                        continue;
 
                    Application.DoEvents();

                    folderList.Add(dir);
                    BindFolder(dir);
                }
      
        }
        public void BindFilesByDirectory(string folder, List<string> extentionList)
        {
            this.extentionList = extentionList;
            BindFiles(folder);
        }
        public object Source
        {
            get
            {
                if (dataSource == null)
                    return null;
                if (dataSource.GetType().Name == "DataTableCollection")
                    return dataSource as DataTableCollection;

                return dataSource;
            }
            set
            {
                Items.Clear();
                dataSource = value == null ? null : value;
                switch (dataSource.GetType().Name)
                {
                    case "DataTableCollection":
                        foreach (DataTable dtc in value as DataTableCollection)
                        {
                            Items.Add(dtc.TableName);
                        }
                        return;
                    default:

                        return;
                }
            }
        }
        public ListItem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void AsposeItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (SelectedIndex < 0)
                    return;

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    System.Diagnostics.Process.Start(Text);
                }
            }
            catch
            {

            }
        }
    }
}
