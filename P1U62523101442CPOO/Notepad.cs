namespace P1U62523101442CPOO
{
    public partial class Notepad : Form
    {
        string? currentPath = null;
        public Notepad()
        {
            InitializeComponent();
            this.Text = "Untitle: Notepad";
        }

        void SaveAsFile()
        {
            if (saveFileDialog1 == null)
                saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentPath = saveFileDialog1.FileName;
                FileStream file = new FileStream(currentPath, FileMode.Create, FileAccess.Write);

                StreamWriter writeFile = new StreamWriter(file);
                writeFile.WriteLine(textBox.Text);
                writeFile.Close();

                file.Close();
                this.Text = $"{Path.GetFileName(currentPath)}: Notepad";
            }
            else
                MessageBox.Show("We can't save this file, sorry :(.");
        }

        void saveFile()
        {
            if (string.IsNullOrEmpty(currentPath))
            {
                SaveAsFile();
                return;
            }

            FileStream file = new FileStream(currentPath, FileMode.Create, FileAccess.Write);

            StreamWriter writeFile = new StreamWriter(file);
            writeFile.WriteLine(textBox.Text);
            writeFile.Close();

            file.Close();
            this.Text = $"{Path.GetFileName(currentPath)}: Notepad";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                var result = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveFile();
                    textBox.Text = null;
                }

                else if (result == DialogResult.No)
                    textBox.Text = null;

                else if (result == DialogResult.Cancel)
                    return;
            }
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Notepad newNotepad = new Notepad();
            newNotepad.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentPath = openFileDialog1.FileName;

                StreamReader read = new StreamReader(openFileDialog1.FileName);
                textBox.Text = read.ReadToEnd();
                read.Close();

                this.Text = $"{Path.GetFileNameWithoutExtension(currentPath)}: Notepad";
            }
            else
                MessageBox.Show("We can't open this file, sorry :(.");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = "";
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }
    }
}
