using LB1.DBContext;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LB1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Model1 model = new Model1();

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model.Users.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddUsers form = new FormAddUsers();
            form.ShowDialog();
            dataGridView1.DataSource = model.Users.ToList();
        }
    }
}
