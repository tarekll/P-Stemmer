using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pstemmer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_browse_in_Click(object sender, EventArgs e)
        {
            if (modelFolderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInput_directory.Text = modelFolderDialog.SelectedPath;
            }
        }

        private void button_browse_out_Click(object sender, EventArgs e)
        {
            if (modelFolderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput_directory.Text = modelFolderDialog.SelectedPath;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int count = Directory.EnumerateFiles(textBoxInput_directory.Text, "*.txt").Count();
            progressBar1.Maximum = count;
            progressBar1.Step = 1;
            LoadCorpus();
        }
        public void LoadCorpus(params char[] delimiter)
        {
            int count = 1;
            string[] replace = { ",", "|", ">", "<", "?", ";", ".", ")", "(", "\"", "*", "&", "%", "$", "#", "@", "!", "»", "«", "،", "،", ":", "/", "١", "٠", "٢", "٧", "٥", "٨", "٣", "٤" };
            foreach (string file in Directory.EnumerateFiles(textBoxInput_directory.Text, "*.txt"))
            {

                progressBar1.Value = count;
                count += 1;

                string contents = File.ReadAllText(file);
                string filenameWithoutPath = Path.GetFileName(file.ToString());
                string new_contents = "";
                for (int i = 0; i < replace.Length; i++)
                {
                    contents = contents.Replace(replace[i], " ");
                }

                foreach (var word in contents.ToLower().Split(delimiter))
                {
                    string token = clearPrefix(word);

                    new_contents += token + " ";
                }

                File.WriteAllText(textBoxOutput_directory.Text  + "/" + filenameWithoutPath, new_contents);

            }
            MessageBox.Show("Done");
            progressBar1.Value = 0;
            
        }

        private string clearPrefix(string word)
        {

            List<string> Prefix = new List<string> { "و", "ال", "وال", "بال", "كال", "فال", "لل", "ول", "ل" };
            var aa = Prefix.ToArray().OrderByDescending(aux => aux.Length).ToArray();
            //Just remove these Prefixes : "و", "ال", "وال", "بال", "كال", "فال", "لل", "ول", "ل" 
            foreach (var item in aa)
            {
                if (word.Length > item.Length)
                {
                    if (word.Substring(0, item.Length) == item)
                    {
                        word = word.Substring(0, item.Length).Replace(item, "") + word.Substring(item.Length, word.Length - item.Length);
                        break;
                    }
                }
            }
            //

            return word;
        }
    }
}
