using Shamilova_ObrazPlus.CustomControls;
using Shamilova_ObrazPlus.Models;
using System;
using System.Collections.Generic;

namespace Shamilova_ObrazPlus.Forms
{
    public partial class ViewingProductListForm : ParentForm
    {
        List<Product> _product;
        public ViewingProductListForm(List<Product> product)
        {
            InitializeComponent();
            _product = product;
        }

        private void ShowProducts()
        {
            foreach (var product in _product)
            {
                flowLayoutPanelLisProduct.Controls.Add(new ProductUserControl(product));
            }
        }

        private void ViewingProductListForm_Load(object sender, EventArgs e)
        {
            ShowProducts();
        }
    }
}
