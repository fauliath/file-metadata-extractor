using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Metadata
{
    public partial class Form1 : Form
    {
        #region DefaultFormBehaviour
        public Form1()
        {
            InitializeComponent();
        }

        private void BUTTON_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BUTTON_MINIMISE_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region MoveForm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Move_Form(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion

        #region FolderBrowsers
        private void SELECT_FOLDER_BUTTON_Click(object sender, EventArgs e)
        {
            TEXTBOX_FOLDER_PATH.Focus();

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            
            dialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TEXTBOX_FOLDER_PATH.Text = dialog.FileName;
                TEXTBOX_FOLDER_PATH.SelectionStart = TEXTBOX_FOLDER_PATH.Text.Length;
            }
        }

        private void SELECT_CSV_BUTTON_Click(object sender, EventArgs e)
        {
            TEXTBOX_CSV_PATH.Focus();

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                TEXTBOX_CSV_PATH.Text = dialog.FileName + "\\" + Path.GetFileName(dialog.FileName) + " metadata.csv";
                TEXTBOX_CSV_PATH.SelectionStart = TEXTBOX_CSV_PATH.Text.Length;
            }
        }

        #endregion

        private void BUTTON_BEGIN_Click(object sender, EventArgs e)
        {

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Background_Worker_DoWork;
            bw.RunWorkerCompleted += Background_Worker_RunWorkerCompleted;

            bw.RunWorkerAsync();

            BUTTON_BEGIN.Enabled = false;
            TEXTBOX_FOLDER_PATH.Enabled = false;
            TEXTBOX_CSV_PATH.Enabled = false;
            PANEL_CHECKBOX.Enabled = false;
            BUTTON_BEGIN.Text = "Running ...";
            TEXTBOX_ERROR_LOG.Text = "";
        }
        
        private void Background_Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string folder = TEXTBOX_FOLDER_PATH.Text;

            if (string.IsNullOrWhiteSpace(folder))
            {
                MessageBox.Show("To begin, you must select a folder to enumerate.");
                return;
            }

            if (!Directory.Exists(folder))
            {
                MessageBox.Show("Your selected folder does not exist.");
                return;
            }

            string[] files = (Directory.GetFiles(folder, "*", SearchOption.AllDirectories));

            Write_Headers_To_File();

            foreach (string file in files)
            {
                List<string> properties = Get_Metadata(file);

                using (StreamWriter stream = new StreamWriter(TEXTBOX_CSV_PATH.Text, true))
                {
                    foreach (string property in properties)
                    {

                        stream.Write(property + ",");
                    }

                    stream.Write(Environment.NewLine);
                }
            }

            Add_To_Error_Log("no errors encountered");
            MessageBox.Show("Finished carving out metadata.");
            
        }
        
        private void Background_Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BUTTON_BEGIN.Enabled = true;
            BUTTON_BEGIN.Text = "Begin";
            TEXTBOX_FOLDER_PATH.Enabled = true;
            TEXTBOX_CSV_PATH.Enabled = true;
            PANEL_CHECKBOX.Enabled = true;
        }

        private List<string> Get_Metadata(string file)
        {
            List<string> properties = new List<string>();

            try
            {
                FileInfo fileInfo = new FileInfo(file);


                if (CHECKBOX_FILENAME.Checked)
                    try
                    {
                        properties.Add(Path.GetFileName(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }


                if (CHECKBOX_PATH.Checked)
                    try
                    {
                        properties.Add(Path.GetFullPath(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }


                if (CHECKBOX_EXT.Checked)
                    try
                    {
                        properties.Add(Path.GetExtension(file));
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }


                if (CHECKBOX_MODIFIED.Checked)
                    try
                    {
                        properties.Add(fileInfo.LastWriteTime.ToString());
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }


                if (CHECKBOX_ACCESSED.Checked)
                    try
                    {
                        properties.Add(fileInfo.LastAccessTime.ToString());
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }

                if (CHECKBOX_CREATED.Checked)
                    try
                    {
                        properties.Add(fileInfo.CreationTime.ToString());
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }

                if (CHECKBOX_READONLY.Checked)
                    try
                    {
                        properties.Add(fileInfo.IsReadOnly.ToString());
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }

                if (CHECKBOX_SIZE.Checked)
                    try
                    {
                        properties.Add(fileInfo.Length.ToString());
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }

                if (CHECKBOX_AUTHOR.Checked)
                    try
                    {
                        properties.Add(File.GetAccessControl(file).GetOwner(typeof(NTAccount)).ToString());
                    }
                    catch (Exception e)
                    {
                        properties.Add("null");
                        Add_To_Error_Log(e.Message);
                    }

            }
            catch (Exception e)
            {
                Add_To_Error_Log(e.Message);
            }

            return properties;
        }

        private void Write_Headers_To_File()
        {
            using (StreamWriter stream = new StreamWriter(TEXTBOX_CSV_PATH.Text, false))
            {
                if (CHECKBOX_FILENAME.Checked)
                    stream.Write("filename,");

                if (CHECKBOX_PATH.Checked)
                    stream.Write("full path,");

                if (CHECKBOX_EXT.Checked)
                    stream.Write("extension,");

                if (CHECKBOX_MODIFIED.Checked)
                    stream.Write("modified date,");

                if (CHECKBOX_ACCESSED.Checked)
                    stream.Write("accessed date,");

                if (CHECKBOX_CREATED.Checked)
                    stream.Write("created date,");

                if (CHECKBOX_READONLY.Checked)
                    stream.Write("read only,");

                if (CHECKBOX_SIZE.Checked)
                    stream.Write("file size (bytes),");

                if (CHECKBOX_AUTHOR.Checked)
                    stream.Write("author,");

                stream.Write(Environment.NewLine);
            }
        }

        private void Add_To_Error_Log(string output)
        {
            TEXTBOX_ERROR_LOG.Invoke(new Action(() =>
                    TEXTBOX_ERROR_LOG.AppendText("[" + DateTime.Now + "] " + output + "\n\n")
                ));
        }

        private void LABEL_ABOUT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is not resource intensive; if you see more than 50% usage coming from this application, then there is an issue, and the " +
                "process should be killed in Task Manager.\n" +
                "The name of the CSV file can be changed, by simply editing the file path in the text box.\n" +
                "There is a known issue with retrieving author from network drives, I am working on this.\n" +
                "Developed by Kieran Maher, on behalf of IT Group UK Ltd.");
        }
    }

    public class OnetsButton : Button
    {
        public OnetsButton()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }
    }
}
