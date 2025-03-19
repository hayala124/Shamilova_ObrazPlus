namespace Shamilova_ObrazPlus.CustomControls
{
    partial class MaterialUserControl
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
            this.labelTypeAndNameMaterial = new System.Windows.Forms.Label();
            this.labelMinCount = new System.Windows.Forms.Label();
            this.labelCountInStock = new System.Windows.Forms.Label();
            this.labelPriceAndCountPerPackage = new System.Windows.Forms.Label();
            this.labelNeedCount = new System.Windows.Forms.Label();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTypeAndNameMaterial
            // 
            this.labelTypeAndNameMaterial.AutoSize = true;
            this.labelTypeAndNameMaterial.Location = new System.Drawing.Point(16, 20);
            this.labelTypeAndNameMaterial.Name = "labelTypeAndNameMaterial";
            this.labelTypeAndNameMaterial.Size = new System.Drawing.Size(220, 16);
            this.labelTypeAndNameMaterial.TabIndex = 0;
            this.labelTypeAndNameMaterial.Text = "Тип и Наименование материала";
            this.labelTypeAndNameMaterial.Click += new System.EventHandler(this.MaterialUserControl_Click);
            // 
            // labelMinCount
            // 
            this.labelMinCount.AutoSize = true;
            this.labelMinCount.Location = new System.Drawing.Point(16, 48);
            this.labelMinCount.Name = "labelMinCount";
            this.labelMinCount.Size = new System.Drawing.Size(184, 16);
            this.labelMinCount.TabIndex = 0;
            this.labelMinCount.Text = "Минимальное количество: ";
            this.labelMinCount.Click += new System.EventHandler(this.MaterialUserControl_Click);
            // 
            // labelCountInStock
            // 
            this.labelCountInStock.AutoSize = true;
            this.labelCountInStock.Location = new System.Drawing.Point(16, 76);
            this.labelCountInStock.Name = "labelCountInStock";
            this.labelCountInStock.Size = new System.Drawing.Size(159, 16);
            this.labelCountInStock.TabIndex = 0;
            this.labelCountInStock.Text = "Количество на складе: ";
            this.labelCountInStock.Click += new System.EventHandler(this.MaterialUserControl_Click);
            // 
            // labelPriceAndCountPerPackage
            // 
            this.labelPriceAndCountPerPackage.AutoSize = true;
            this.labelPriceAndCountPerPackage.Location = new System.Drawing.Point(16, 107);
            this.labelPriceAndCountPerPackage.Name = "labelPriceAndCountPerPackage";
            this.labelPriceAndCountPerPackage.Size = new System.Drawing.Size(46, 16);
            this.labelPriceAndCountPerPackage.TabIndex = 0;
            this.labelPriceAndCountPerPackage.Text = "Цена: ";
            this.labelPriceAndCountPerPackage.Click += new System.EventHandler(this.MaterialUserControl_Click);
            // 
            // labelNeedCount
            // 
            this.labelNeedCount.AutoSize = true;
            this.labelNeedCount.Location = new System.Drawing.Point(520, 20);
            this.labelNeedCount.Name = "labelNeedCount";
            this.labelNeedCount.Size = new System.Drawing.Size(167, 16);
            this.labelNeedCount.TabIndex = 0;
            this.labelNeedCount.Text = "Требуемое количество: ";
            this.labelNeedCount.Click += new System.EventHandler(this.MaterialUserControl_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProducts.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProducts.ForeColor = System.Drawing.Color.White;
            this.buttonProducts.Location = new System.Drawing.Point(473, 66);
            this.buttonProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(254, 35);
            this.buttonProducts.TabIndex = 3;
            this.buttonProducts.Text = "Перейти к продукции";
            this.buttonProducts.UseVisualStyleBackColor = false;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // MaterialUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.labelNeedCount);
            this.Controls.Add(this.labelPriceAndCountPerPackage);
            this.Controls.Add(this.labelCountInStock);
            this.Controls.Add(this.labelMinCount);
            this.Controls.Add(this.labelTypeAndNameMaterial);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Name = "MaterialUserControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(750, 150);
            this.Click += new System.EventHandler(this.MaterialUserControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTypeAndNameMaterial;
        private System.Windows.Forms.Label labelMinCount;
        private System.Windows.Forms.Label labelCountInStock;
        private System.Windows.Forms.Label labelPriceAndCountPerPackage;
        private System.Windows.Forms.Label labelNeedCount;
        private System.Windows.Forms.Button buttonProducts;
    }
}
