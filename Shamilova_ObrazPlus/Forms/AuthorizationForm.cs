using Shamilova_ObrazPlus.Models;
using Shamilova_ObrazPlus.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Shamilova_ObrazPlus.Forms
{
    public partial class AuthorizationForm : ParentForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private Employee GetEmployye()
        {
            var employee = Program.context.Employee.FirstOrDefault(e => e.Login == textBoxLogin.Text);

            return employee;
        }

        private static bool Login(string login, string password)
        {
            using (var dbContext = new ObrazPlus_Db())
            {
                var employee = dbContext.Employee.FirstOrDefault(e => e.Login == login && e.Password == password);
                var checkLogin = dbContext.Employee.FirstOrDefault(e => e.Login == login);
                if (employee != null)
                {
                    if (employee.JobTitle.NameJobTitle == JobTitlesClass.Administrator)
                        GlobalVariablesClass.CurrentJobTitleOfEmployee = JobTitlesClass.Administrator;
                    else if (employee.JobTitle.NameJobTitle == JobTitlesClass.Storekeeper)
                        GlobalVariablesClass.CurrentJobTitleOfEmployee = JobTitlesClass.Storekeeper;
                    else if (employee.JobTitle.NameJobTitle == JobTitlesClass.Manager)
                        GlobalVariablesClass.CurrentJobTitleOfEmployee = JobTitlesClass.Manager;

                    employee.TimeLastEntrance = DateTime.Now.ToString();
                    employee.EntranceTypeId = (int)EntranceTypeClass.SuccessfulLogin;
                    dbContext.SaveChanges();
                    return true;
                }
                if (checkLogin != null)
                {
                    checkLogin.EntranceTypeId = (int)EntranceTypeClass.UnsuccessfulLogin;
                    dbContext.SaveChanges();
                }
                return false;
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isAuthenticated = Login(login, password);

            if (isAuthenticated)
            {
                try
                {
                    var employee = GetEmployye();
                    Program.context.SaveChanges();
                    MessageBox.Show($"Вы успешно вошли в систему как {GlobalVariablesClass.CurrentJobTitleOfEmployee} - \n{employee.Surname} {employee.Name}!", "Успех", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль, попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
    }
}