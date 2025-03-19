using System;
using System.Windows.Forms;

namespace Shamilova_ObrazPlus.Forms
{
    public partial class CreateUpdateMaterialForm : ParentForm
    {
        public CreateUpdateMaterialForm()
        {
            InitializeComponent();
        }

        private void materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameMaterialTextBox.Text) ||
                string.IsNullOrEmpty(materialTypeIdComboBox.Text) || string.IsNullOrEmpty(unitPriceTextBox.Text) ||
                string.IsNullOrEmpty(unitOfMeasurementTextBox.Text) || minimumCountNumericUpDown.Value == 0)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shamilova_ObrazPlusDataSet);
            MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void CreateUpdateMaterialForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shamilova_ObrazPlusDataSet.MaterialType". При необходимости она может быть перемещена или удалена.
            this.materialTypeTableAdapter.Fill(this.shamilova_ObrazPlusDataSet.MaterialType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shamilova_ObrazPlusDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.shamilova_ObrazPlusDataSet.Material);
        }

        private void unitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Преобразование символа запятой в точку.
            if (e.KeyChar == ',')
                e.KeyChar = '.';
        
            // Ограничение ввода символов.
            if (e.KeyChar < '0' | e.KeyChar > '9' && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Запрет ввода разделителя первым символом.
            if (unitPriceTextBox.SelectionStart == 0 & e.KeyChar == '.')
            {
                e.Handled = true;
            }
            // Запрет ввода числа при вводе первым символом 0. 
            if (unitPriceTextBox.Text == "0")
            {
                if (e.KeyChar != '.' & e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
            // Запрет на ввод более 2 знаков после точки.
            if (unitPriceTextBox.Text.IndexOf('.') > 0)
            {
                if (unitPriceTextBox.Text.Substring(unitPriceTextBox.Text.IndexOf('.')).Length > 2)
                {
                    if (e.KeyChar != (char)Keys.Back)
                        e.Handled = true;
                }
            }

            // Ввод только 1 разделителя.
            if (e.KeyChar == '.')
            {
                if (unitPriceTextBox.Text.IndexOf('.') != -1)
                    e.Handled = true;
            }
        }

        private void ClearAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
            }
        }

        public void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ClearAllControls(this);
        }
    }
}
