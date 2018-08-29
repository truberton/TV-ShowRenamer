using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TV_ShowRenamer
{
    /// <summary>
    /// Program for renaming files
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] PreviousDirectoryFiles;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseDirectory_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Path_Textbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Path_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Directory.Exists(Path_Textbox.Text))
            {
                //Deletes previous files in listbox
                ResetListbox();
            }
        }

        private void RenameBtn_Click(object sender, RoutedEventArgs e)
        {
            //If textboxes are not filled you cannot rename any files
            if (string.IsNullOrWhiteSpace(RenameTxtbox.Text) || !Directory.Exists(Path_Textbox.Text) || string.IsNullOrWhiteSpace(FirstEpisode.Text))
            {
                System.Windows.MessageBox.Show("Please fill all textboxes");
            }

            else
            {
                int FirstEpisodeNum = int.Parse(FirstEpisode.Text);
                string[] FilesInDirectory = Directory.GetFiles(Path_Textbox.Text);
                PreviousDirectoryFiles = FilesInDirectory;
                string episodeName;
                string FileType;
                foreach (string file in FilesInDirectory)
                {
                    FileType = System.IO.Path.GetExtension(file);
                    //Siin on if, sest kui sisestad S01E*, siis see näeb välja S01E1 kuni S01E10, kuid nii on see S01E01 kuni S01E10 (palju ilusam)
                    if (FirstEpisodeNum < 10 && ZeroBeforeNumber_Checkbox.IsChecked.GetValueOrDefault())
                    {
                        episodeName = System.IO.Path.Combine(Path_Textbox.Text, RenameTxtbox.Text + FileType);
                        episodeName = episodeName.Replace("{episode}", "0" + FirstEpisodeNum.ToString());
                        File.Move(file, episodeName);
                    }
                    else
                    {
                        episodeName = System.IO.Path.Combine(Path_Textbox.Text, RenameTxtbox.Text + FileType);
                        episodeName = episodeName.Replace("{episode}", FirstEpisodeNum.ToString());
                        File.Move(file, episodeName);
                    }
                    FirstEpisodeNum++;
                }
                FirstEpisode.Text = "";
                RenameTxtbox.Text = "";
                ResetListbox();
                System.Windows.Forms.MessageBox.Show("Task completed");
            }
        }

        private void FirstEpisode_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ResetListbox()
        {
            //Deletes previous files in listbox
            Files.Items.Clear();
            string[] FilesInDirectory = Directory.GetFiles(Path_Textbox.Text);
            Array.Sort(FilesInDirectory, (x, y) => String.Compare(x, y));

            foreach (var item in FilesInDirectory)
            {
                ListBoxItem itm = new ListBoxItem();
                itm.Content = System.IO.Path.GetFileName(item);

                Files.Items.Add(itm);
            }
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            string[] FilesInDirectory = Directory.GetFiles(Path_Textbox.Text);
            int i = 0;
            foreach (var CurrentFile in FilesInDirectory)
            {
                File.Move(CurrentFile, PreviousDirectoryFiles[i]);
                i++;
            }
            ResetListbox();
        }

        private void ZeroBeforeNumber_Checkbox_Checked(object sender, RoutedEventArgs e)
        {

        }

    }
}
