using Laba33;

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
            gvPhones.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Ціна ($)";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ReleaseYear";
            column.Name = "Рік виходу";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearOfPurchase";
            column.Name = "Рік покупки";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BatteryCapacity";
            column.Name = "Ємність акамулятору (mA/h)";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Has3Cameras";
            column.Name = "Три камери";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasWirelessCharging";
            column.Name = "Бездротова зарядка";
            gvPhones.Columns.Add(column);


            bindScrPhones.Add(new Phone("iPhone", "13 Pro Max", "800", "2021", "2022", "3200", true, true));
            EventArgs args = new EventArgs(); OnResize(args);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();

            fPhone fp = new fPhone(phone);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.Add(phone);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Phone phone = (Phone)bindScrPhones.List[bindScrPhones.Position];

            fPhone fp = new fPhone(phone);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                bindScrPhones.List[bindScrPhones.Position] = phone;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindScrPhones.RemoveCurrent();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindScrPhones.Clear();
            }
        }

        private void bindScrPhones_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}