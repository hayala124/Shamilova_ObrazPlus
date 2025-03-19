using Shamilova_ObrazPlus.Forms;
using Shamilova_ObrazPlus.Models;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Shamilova_ObrazPlus.CustomControls
{
    public partial class MaterialUserControl : UserControl
    {
        Material _material;
        public MaterialUserControl(Material material)
        {
            InitializeComponent();
            _material = material;
            SetLabelTextValues();
        }

        private void SetLabelTextValues()
        {
            labelTypeAndNameMaterial.Text = $"{_material.MaterialType.NameMaterialType} | {_material.NameMaterial}";
            labelMinCount.Text += $"{_material.MinimumCount}";
            labelCountInStock.Text += $"{_material.CountInStock}";
            labelPriceAndCountPerPackage.Text += $"{_material.UnitPrice} р/{_material.UnitOfMeasurement} | Количество в упаковке: {_material.CountPerPackage}";
            labelNeedCount.Text += _material.MaterialProduct.Where(id => id.MateriaId == _material.IdMaterial).Sum(mp => mp.RequiredCountOfMaterial);
        }

        private void buttonProducts_Click(object sender, System.EventArgs e)
        {
            var products = Program.context.Product
                .Where(p => p.MaterialProduct.Any(mp => mp.MateriaId == _material.IdMaterial))
                .OrderBy(p => p.NameProduct).ToList();

            ViewingProductListForm listForm = new ViewingProductListForm(products);
            listForm.ShowDialog();
            
        }

        private void MaterialUserControl_Click(object sender, System.EventArgs e)
        {
            CreateUpdateMaterialForm createUpdateMaterialForm = new CreateUpdateMaterialForm();
            var saved = createUpdateMaterialForm.ShowDialog();
            if (saved == DialogResult.OK)
            {
                SetLabelTextValues();
            }
        }
    }
}
