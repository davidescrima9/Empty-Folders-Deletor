using CustomUI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Empty_Folders_Deletor
{
    public partial class formMain : CustomForm
    {
        public formMain()
        {
            InitializeComponent();
        }

        private List<String> GetEmptyFolders(String path)
        {
            return Directory.GetDirectories(path, "*", SearchOption.AllDirectories).Where(x => Directory.GetFiles(x, "*", SearchOption.AllDirectories).Length == 0 && Directory.GetDirectories(x, "*", SearchOption.AllDirectories).Length == 0).ToList();
        }

        private List<String> GetEmptyFiles(String path)
        {
            return Directory.GetFiles(path, "*", SearchOption.AllDirectories).Where(x => File.Exists(x) && new FileInfo(x).Length == 0).ToList();
        }

        private void customButtonCheckEmptyFolders_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxPath.Text))
            {
                CustomMessageBox.ShowError("Can't find the selected folder", "ERROR", CustomDialogButton.Ok);
                return;
            }

            textBoxLog.Text = String.Empty;

            List<String> emptyFolders = GetEmptyFolders(textBoxPath.Text);

            String outputFolders = String.Empty;
            int i = 0;

            foreach (String s in emptyFolders)
            {
                outputFolders += s + "\r\n";
                i++;
            }

            outputFolders = outputFolders.TrimEnd("\r\n".ToCharArray());

            String s1 = String.Format("Found {0} empty folders!", i);
            textBoxLog.Text = s1 + "\r\n\r\nFolders List:\r\n" + outputFolders;

            CustomMessageBox.ShowInformation(s1, "OK", CustomDialogButton.Ok);
        }

        private void customButtonProcessEmptyFolders_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.ShowInformation("Are you sure you want to proceed?", "CAUTION", CustomDialogButton.YesNo) == DialogResult.Yes)
            {
                if (!Directory.Exists(textBoxPath.Text))
                {
                    CustomMessageBox.ShowError("Can't find the selected folder", "ERROR", CustomDialogButton.Ok);
                    return;
                }

                textBoxLog.Text = String.Empty;

                List<String> emptyFolders = GetEmptyFolders(textBoxPath.Text);

                String outputFolders = String.Empty;
                int i = 0;

                foreach (String s in emptyFolders)
                {
                    outputFolders += s + "\r\n";
                    i++;

                    Directory.Delete(s, false);
                }

                outputFolders = outputFolders.TrimEnd("\r\n".ToCharArray());

                String s1 = String.Format("Removed {0} empty folders!", i);
                textBoxLog.Text = s1 + "\r\n\r\nFolders List:\r\n" + outputFolders;

                CustomMessageBox.ShowInformation(s1, "OK", CustomDialogButton.Ok);
            }
        }

        private void customButtonCheckEmptyFiles_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxPath.Text))
            {
                CustomMessageBox.ShowError("Can't find the selected folder", "ERROR", CustomDialogButton.Ok);
                return;
            }

            textBoxLog.Text = String.Empty;

            List<String> emptyFiles = GetEmptyFiles(textBoxPath.Text);

            String outputFiles = String.Empty;
            int i = 0;

            foreach (String s in emptyFiles)
            {
                outputFiles += s + "\r\n";
                i++;
            }

            outputFiles = outputFiles.TrimEnd("\r\n".ToCharArray());

            String s1 = String.Format("Found {0} empty files!", i);
            textBoxLog.Text = s1 + "\r\n\r\nFiles List:\r\n" + outputFiles;

            CustomMessageBox.ShowInformation(s1, "OK", CustomDialogButton.Ok);
        }

        private void customButtonProcessEmptyFiles_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.ShowInformation("Are you sure you want to proceed?", "CAUTION", CustomDialogButton.YesNo) == DialogResult.Yes)
            {
                if (!Directory.Exists(textBoxPath.Text))
                {
                    CustomMessageBox.ShowError("Can't find the selected folder", "ERROR", CustomDialogButton.Ok);
                    return;
                }

                textBoxLog.Text = String.Empty;

                List<String> emptyFiles = GetEmptyFiles(textBoxPath.Text);

                String outputFiles = String.Empty;
                int i = 0;

                foreach (String s in emptyFiles)
                {
                    outputFiles += s + "\r\n";
                    i++;

                    File.Delete(s);
                }

                outputFiles = outputFiles.TrimEnd("\r\n".ToCharArray());

                String s1 = String.Format("Removed {0} empty files!", i);
                textBoxLog.Text = s1 + "\r\n\r\nFiles List:\r\n" + outputFiles;

                CustomMessageBox.ShowInformation(s1, "OK", CustomDialogButton.Ok);
            }
        }

        private void customButtonBrowse_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxPath.Text))
            {
                folderBrowserDialogPath.SelectedPath = textBoxPath.Text;
            }
            
            if (folderBrowserDialogPath.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialogPath.SelectedPath;
            }
        }
    }
}
