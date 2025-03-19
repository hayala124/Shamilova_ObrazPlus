namespace Shamilova_ObrazPlus.CustomControls
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelProductTypeAndNameProduct = new System.Windows.Forms.Label();
            this.labelCountInStock = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(20, 29);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(115, 87);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelProductTypeAndNameProduct
            // 
            this.labelProductTypeAndNameProduct.AutoSize = true;
            this.labelProductTypeAndNameProduct.Location = new System.Drawing.Point(156, 40);
            this.labelProductTypeAndNameProduct.Name = "labelProductTypeAndNameProduct";
            this.labelProductTypeAndNameProduct.Size = new System.Drawing.Size(214, 16);
            this.labelProductTypeAndNameProduct.TabIndex = 1;
            this.labelProductTypeAndNameProduct.Text = "Тип | Наименование продукции";
            // 
            // labelCountInStock
            // 
            this.labelCountInStock.AutoSize = true;
            this.labelCountInStock.Location = new System.Drawing.Point(545, 73);
            this.labelCountInStock.Name = "labelCountInStock";
            this.labelCountInStock.Size = new System.Drawing.Size(139, 16);
            this.labelCountInStock.TabIndex = 1;
            this.labelCountInStock.Text = "Наличие на складе: ";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(156, 87);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(83, 16);
            this.labelCost.TabIndex = 1;
            this.labelCost.Text = "Стоимость: ";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelCountInStock);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelProductTypeAndNameProduct);
            this.Controls.Add(this.pictureBoxImage);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "ProductUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(750, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelProductTypeAndNameProduct;
        private System.Windows.Forms.Label labelCountInStock;
        private System.Windows.Forms.Label labelCost;
    }
}
