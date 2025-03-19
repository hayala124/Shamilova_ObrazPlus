namespace Shamilova_ObrazPlus.Forms
{
    partial class CreateUpdateMaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameMaterialLabel;
            System.Windows.Forms.Label materialTypeIdLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label countInStockLabel;
            System.Windows.Forms.Label unitOfMeasurementLabel;
            System.Windows.Forms.Label minimumCountLabel;
            System.Windows.Forms.Label countPerPackageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUpdateMaterialForm));
            this.shamilova_ObrazPlusDataSet = new Shamilova_ObrazPlus.Shamilova_ObrazPlusDataSet();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new Shamilova_ObrazPlus.Shamilova_ObrazPlusDataSetTableAdapters.MaterialTableAdapter();
            this.tableAdapterManager = new Shamilova_ObrazPlus.Shamilova_ObrazPlusDataSetTableAdapters.TableAdapterManager();
            this.materialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materialBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameMaterialTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitOfMeasurementTextBox = new System.Windows.Forms.TextBox();
            this.materialTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.materialTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countPerPackageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialTypeTableAdapter = new Shamilova_ObrazPlus.Shamilova_ObrazPlusDataSetTableAdapters.MaterialTypeTableAdapter();
            this.minimumCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.countInStockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            nameMaterialLabel = new System.Windows.Forms.Label();
            materialTypeIdLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            countInStockLabel = new System.Windows.Forms.Label();
            unitOfMeasurementLabel = new System.Windows.Forms.Label();
            minimumCountLabel = new System.Windows.Forms.Label();
            countPerPackageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shamilova_ObrazPlusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).BeginInit();
            this.materialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPerPackageNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countInStockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameMaterialLabel
            // 
            nameMaterialLabel.AutoSize = true;
            nameMaterialLabel.Location = new System.Drawing.Point(73, 106);
            nameMaterialLabel.Name = "nameMaterialLabel";
            nameMaterialLabel.Size = new System.Drawing.Size(154, 18);
            nameMaterialLabel.TabIndex = 3;
            nameMaterialLabel.Text = "Название материала";
            // 
            // materialTypeIdLabel
            // 
            materialTypeIdLabel.AutoSize = true;
            materialTypeIdLabel.Location = new System.Drawing.Point(73, 148);
            materialTypeIdLabel.Name = "materialTypeIdLabel";
            materialTypeIdLabel.Size = new System.Drawing.Size(114, 18);
            materialTypeIdLabel.TabIndex = 5;
            materialTypeIdLabel.Text = "Тип материала";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(73, 188);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(117, 18);
            unitPriceLabel.TabIndex = 7;
            unitPriceLabel.Text = "Цена за единицу";
            // 
            // countInStockLabel
            // 
            countInStockLabel.AutoSize = true;
            countInStockLabel.Location = new System.Drawing.Point(73, 226);
            countInStockLabel.Name = "countInStockLabel";
            countInStockLabel.Size = new System.Drawing.Size(159, 18);
            countInStockLabel.TabIndex = 9;
            countInStockLabel.Text = "Количество на складе";
            // 
            // unitOfMeasurementLabel
            // 
            unitOfMeasurementLabel.AutoSize = true;
            unitOfMeasurementLabel.Location = new System.Drawing.Point(73, 343);
            unitOfMeasurementLabel.Name = "unitOfMeasurementLabel";
            unitOfMeasurementLabel.Size = new System.Drawing.Size(140, 18);
            unitOfMeasurementLabel.TabIndex = 15;
            unitOfMeasurementLabel.Text = "Единица измерения";
            // 
            // minimumCountLabel
            // 
            minimumCountLabel.AutoSize = true;
            minimumCountLabel.Location = new System.Drawing.Point(73, 265);
            minimumCountLabel.Name = "minimumCountLabel";
            minimumCountLabel.Size = new System.Drawing.Size(187, 18);
            minimumCountLabel.TabIndex = 17;
            minimumCountLabel.Text = "Минимальное количество";
            // 
            // countPerPackageLabel
            // 
            countPerPackageLabel.AutoSize = true;
            countPerPackageLabel.Location = new System.Drawing.Point(73, 307);
            countPerPackageLabel.Name = "countPerPackageLabel";
            countPerPackageLabel.Size = new System.Drawing.Size(165, 18);
            countPerPackageLabel.TabIndex = 18;
            countPerPackageLabel.Text = "Количество в упаковке";
            // 
            // shamilova_ObrazPlusDataSet
            // 
            this.shamilova_ObrazPlusDataSet.DataSetName = "Shamilova_ObrazPlusDataSet";
            this.shamilova_ObrazPlusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.shamilova_ObrazPlusDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.ClientTypeTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EntranceTypeTableAdapter = null;
            this.tableAdapterManager.JobTitleTableAdapter = null;
            this.tableAdapterManager.MaterialProductTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
            this.tableAdapterManager.MaterialTypeTableAdapter = null;
            this.tableAdapterManager.PostalCodeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.RegionTableAdapter = null;
            this.tableAdapterManager.StreetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shamilova_ObrazPlus.Shamilova_ObrazPlusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // materialBindingNavigator
            // 
            this.materialBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.materialBindingNavigator.BindingSource = this.materialBindingSource;
            this.materialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materialBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.materialBindingNavigatorSaveItem});
            this.materialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialBindingNavigator.Name = "materialBindingNavigator";
            this.materialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialBindingNavigator.Size = new System.Drawing.Size(583, 27);
            this.materialBindingNavigator.TabIndex = 0;
            this.materialBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // materialBindingNavigatorSaveItem
            // 
            this.materialBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("materialBindingNavigatorSaveItem.Image")));
            this.materialBindingNavigatorSaveItem.Name = "materialBindingNavigatorSaveItem";
            this.materialBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.materialBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.materialBindingNavigatorSaveItem.Click += new System.EventHandler(this.materialBindingNavigatorSaveItem_Click);
            // 
            // nameMaterialTextBox
            // 
            this.nameMaterialTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.nameMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "NameMaterial", true));
            this.nameMaterialTextBox.Location = new System.Drawing.Point(312, 103);
            this.nameMaterialTextBox.Name = "nameMaterialTextBox";
            this.nameMaterialTextBox.Size = new System.Drawing.Size(202, 26);
            this.nameMaterialTextBox.TabIndex = 4;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(312, 180);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(202, 26);
            this.unitPriceTextBox.TabIndex = 8;
            this.unitPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitPriceTextBox_KeyPress);
            // 
            // unitOfMeasurementTextBox
            // 
            this.unitOfMeasurementTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.unitOfMeasurementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "UnitOfMeasurement", true));
            this.unitOfMeasurementTextBox.Location = new System.Drawing.Point(312, 340);
            this.unitOfMeasurementTextBox.Name = "unitOfMeasurementTextBox";
            this.unitOfMeasurementTextBox.Size = new System.Drawing.Size(202, 26);
            this.unitOfMeasurementTextBox.TabIndex = 16;
            // 
            // materialTypeIdComboBox
            // 
            this.materialTypeIdComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.materialTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "MaterialTypeId", true));
            this.materialTypeIdComboBox.DataSource = this.materialTypeBindingSource;
            this.materialTypeIdComboBox.DisplayMember = "NameMaterialType";
            this.materialTypeIdComboBox.FormattingEnabled = true;
            this.materialTypeIdComboBox.Location = new System.Drawing.Point(312, 145);
            this.materialTypeIdComboBox.Name = "materialTypeIdComboBox";
            this.materialTypeIdComboBox.Size = new System.Drawing.Size(202, 26);
            this.materialTypeIdComboBox.TabIndex = 17;
            this.materialTypeIdComboBox.ValueMember = "IdMaterialType";
            // 
            // materialTypeBindingSource
            // 
            this.materialTypeBindingSource.DataMember = "MaterialType";
            this.materialTypeBindingSource.DataSource = this.shamilova_ObrazPlusDataSet;
            // 
            // countPerPackageNumericUpDown
            // 
            this.countPerPackageNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.countPerPackageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.materialBindingSource, "CountPerPackage", true));
            this.countPerPackageNumericUpDown.Location = new System.Drawing.Point(312, 299);
            this.countPerPackageNumericUpDown.Name = "countPerPackageNumericUpDown";
            this.countPerPackageNumericUpDown.Size = new System.Drawing.Size(201, 26);
            this.countPerPackageNumericUpDown.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Добавить/редактировать материал";
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.shamilova_ObrazPlusDataSet;
            // 
            // materialTypeTableAdapter
            // 
            this.materialTypeTableAdapter.ClearBeforeFill = true;
            // 
            // minimumCountNumericUpDown
            // 
            this.minimumCountNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.minimumCountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.materialBindingSource, "MinimumCount", true));
            this.minimumCountNumericUpDown.Location = new System.Drawing.Point(313, 257);
            this.minimumCountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.minimumCountNumericUpDown.Name = "minimumCountNumericUpDown";
            this.minimumCountNumericUpDown.Size = new System.Drawing.Size(201, 26);
            this.minimumCountNumericUpDown.TabIndex = 18;
            // 
            // countInStockNumericUpDown
            // 
            this.countInStockNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.countInStockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.materialBindingSource, "CountInStock", true));
            this.countInStockNumericUpDown.Location = new System.Drawing.Point(312, 218);
            this.countInStockNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.countInStockNumericUpDown.Name = "countInStockNumericUpDown";
            this.countInStockNumericUpDown.Size = new System.Drawing.Size(200, 26);
            this.countInStockNumericUpDown.TabIndex = 20;
            // 
            // CreateUpdateMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countInStockNumericUpDown);
            this.Controls.Add(countPerPackageLabel);
            this.Controls.Add(this.countPerPackageNumericUpDown);
            this.Controls.Add(minimumCountLabel);
            this.Controls.Add(this.minimumCountNumericUpDown);
            this.Controls.Add(this.materialTypeIdComboBox);
            this.Controls.Add(nameMaterialLabel);
            this.Controls.Add(this.nameMaterialTextBox);
            this.Controls.Add(materialTypeIdLabel);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(countInStockLabel);
            this.Controls.Add(unitOfMeasurementLabel);
            this.Controls.Add(this.unitOfMeasurementTextBox);
            this.Controls.Add(this.materialBindingNavigator);
            this.MinimumSize = new System.Drawing.Size(375, 414);
            this.Name = "CreateUpdateMaterialForm";
            this.Text = "Добавление/редактирование материала";
            this.Load += new System.EventHandler(this.CreateUpdateMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shamilova_ObrazPlusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).EndInit();
            this.materialBindingNavigator.ResumeLayout(false);
            this.materialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPerPackageNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countInStockNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Shamilova_ObrazPlusDataSet shamilova_ObrazPlusDataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private Shamilova_ObrazPlusDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private Shamilova_ObrazPlusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton materialBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameMaterialTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox unitOfMeasurementTextBox;
        private System.Windows.Forms.ComboBox materialTypeIdComboBox;
        private System.Windows.Forms.NumericUpDown countPerPackageNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private System.Windows.Forms.BindingSource materialTypeBindingSource;
        private Shamilova_ObrazPlusDataSetTableAdapters.MaterialTypeTableAdapter materialTypeTableAdapter;
        private System.Windows.Forms.NumericUpDown minimumCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown countInStockNumericUpDown;
    }
}