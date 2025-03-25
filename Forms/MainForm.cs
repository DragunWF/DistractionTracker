namespace DistractionsTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string distractionInput = distractionComboBox.Text;
            if (string.IsNullOrWhiteSpace(distractionInput))
            {
                MessageBox.Show("Make sure to type something in the distraction combo box!");
                return;
            }

            // TODO: Implement
        }
    }
}
