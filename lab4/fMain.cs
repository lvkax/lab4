namespace lab4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void bindScrPhones_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}