using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LB1.DBContext;

namespace LB1
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }

        Model1 model = new Model1();

        private void FormAddUsers_Load(object sender, System.EventArgs e)
        {
            bindingSource1.DataSource = model.Roles.ToList();
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",RegexOptions.IgnoreCase);
            if (!reg.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("Почта не соотвествует требованиям!");
                return;
            }
            if (!passwordTextBox.Text.Equals(passwordTextBox2.Text))
            {
                MessageBox.Show("Пароли не равны!");
                return;
            }
            if (String.IsNullOrWhiteSpace(loginTextBox.Text) ||
            String.IsNullOrWhiteSpace(passwordTextBox.Text) ||
            String.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
            String.IsNullOrWhiteSpace(secondNameTextBox.Text) ||
            !phoneTextBox.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            //Заполнение данных о новом пользователе
            Users users = new Users();
            users.ID = 0;
            users.Login = loginTextBox.Text;
            users.Password = passwordTextBox.Text;
            users.Email = emailTextBox.Text;
            users.Phone = phoneTextBox.Text;
            users.First_Name = firstNameTextBox.Text;
            users.Second_Name = secondNameTextBox.Text;
            users.RoleID = (int)roleIDComboBox.SelectedValue;
            users.Gender = radioButtonMen.Checked ? "Мужской" : "Женский";
            try
            {
                //сохранение данных в БД
                model.Users.Add(users);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Данные добавленны!");
            Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void roleIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
