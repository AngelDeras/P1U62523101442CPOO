namespace P1U62523101442CPOO
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        void SaveFile()
        {
            if (saveFileDialog1 == null)
                saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);

                StreamWriter writeFile = new StreamWriter(file);
                writeFile.WriteLine(textBox.Text);
                writeFile.Close();

                file.Close();
            }
            else
                MessageBox.Show("We can't save this file, sorry :(.");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                var result = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
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
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                textBox.Text = read.ReadToEnd();
                read.Close();
            }
        }
    }
}
