namespace TextEditor
{
    using System.Diagnostics;
    using System.Windows.Forms;


    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            this.InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/JulianG97/TextEditor");
            }
            catch
            {
                MessageBox.Show("An error occured! The website couldn't be opened!", "TextEditor", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
