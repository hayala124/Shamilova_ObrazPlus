using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Shamilova_ObrazPlus.CustomControls;
using Shamilova_ObrazPlus.Services;

namespace Shamilova_ObrazPlus.Forms
{
    public partial class MainForm : ParentForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowMaterials()
        {
            var materials = Program.context.Material.OrderBy(m => m.NameMaterial).ToList();

            foreach (var material in materials)
            {
                splitContainer.Panel2.Controls[0].Controls.Add(new MaterialUserControl(material));
            }
        }

        public void ShowProducts()
        {
            var products = Program.context.Product.OrderBy(m => m.NameProduct).ToList();

            foreach (var product in products)
            {
                splitContainer.Panel2.Controls[0].Controls.Add(new ProductUserControl(product));
            }
        }

        public void ClearList()
        {
            splitContainer.Panel2.Controls[0].Controls.Clear();
        }

        public void RefreshJobTitle()
        {
            if (GlobalVariablesClass.CurrentJobTitleOfEmployee == JobTitlesClass.Guest)
            {
                labelList.Text = "Список продукции";
                RefreshProducts();
            }
            else if (GlobalVariablesClass.CurrentJobTitleOfEmployee == JobTitlesClass.Storekeeper)
            {
                labelList.Text = "Список материалов";
                RefreshMaterials();
            }
            else if (GlobalVariablesClass.CurrentJobTitleOfEmployee == JobTitlesClass.Administrator)
            {
                RefreshProducts();
            }
        }

        public void RefreshMaterials()
        {
            ClearList();
            ShowMaterials();
        }

        public void RefreshProducts()
        {
            ClearList();
            ShowProducts();
        }

        private void ButtonVisible(bool value)
        {
            buttonClientAuthorization.Visible = value;
            buttonEmployeeAuthorization.Visible = value;
            buttonExit.Visible = !value;

            if (GlobalVariablesClass.CurrentJobTitleOfEmployee == JobTitlesClass.Storekeeper)
                buttonAddMaterial.Visible = !value;
            else
                buttonAddMaterial.Visible = false; 
        }

        private void LogOutOfSystem()
        {
            GlobalVariablesClass.CurrentJobTitleOfEmployee = JobTitlesClass.Guest;
            ButtonVisible(true);
            RefreshJobTitle();
        }

        private void LogIn()
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            var saved = authorizationForm.ShowDialog();

            if (saved == DialogResult.OK)
            {
                ButtonVisible(false);
                RefreshJobTitle();
            }
        }

        private void buttonEmployeeAuthorization_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void buttonClientAuthorization_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshJobTitle();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            LogOutOfSystem();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            CreateUpdateMaterialForm createUpdateMaterialForm = new CreateUpdateMaterialForm();
            var saved = createUpdateMaterialForm.ShowDialog();

            if (saved == DialogResult.OK)
            {
                RefreshJobTitle();
            }
        }
    }
}
