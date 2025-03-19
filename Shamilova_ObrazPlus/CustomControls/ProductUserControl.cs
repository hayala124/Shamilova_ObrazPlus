using Shamilova_ObrazPlus.Models;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Shamilova_ObrazPlus.Properties.Resources;

namespace Shamilova_ObrazPlus.CustomControls
{
    public partial class ProductUserControl : UserControl
    {
        Product _product;
        public ProductUserControl(Product product)
        {
            InitializeComponent();
            _product = product;
            SetLabelTextValues();
        }

        private void SetLabelTextValues()
        {
            labelProductTypeAndNameProduct.Text = $"{_product.ProductType.NameProductType} | {_product.NameProduct}";
            labelCost.Text += $"{_product.MinimumCostForPartner} руб.";

            if (_product.PathImage != null)
            {
                var resourceName = _product.PathImage.Replace(" ", "_").Replace("-", "_").Replace(".jpg", "");
                pictureBoxImage.Image = (Bitmap)ResourceManager.GetObject($"{resourceName}");
            }

            labelCountInStock.Text += _product.MaterialProduct.Where(id => id.ProductId == _product.IdProduct).Min(count => count.Material.CountInStock);
        }
    }
}
