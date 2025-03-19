namespace Shamilova_ObrazPlus.Forms
{
    partial class MainForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxImageEmployee = new System.Windows.Forms.PictureBox();
            this.buttonClientAuthorization = new System.Windows.Forms.Button();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.buttonEmployeeAuthorization = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buttonExit);
            this.splitContainer.Panel1.Controls.Add(this.pictureBoxImageEmployee);
            this.splitContainer.Panel1.Controls.Add(this.buttonClientAuthorization);
            this.splitContainer.Panel1.Controls.Add(this.buttonAddMaterial);
            this.splitContainer.Panel1.Controls.Add(this.buttonEmployeeAuthorization);
            this.splitContainer.Panel1.Controls.Add(this.labelList);
            this.splitContainer.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel);
            this.splitContainer.Size = new System.Drawing.Size(822, 517);
            this.splitContainer.SplitterDistance = 150;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(477, 11);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(231, 35);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxImageEmployee
            // 
            this.pictureBoxImageEmployee.Location = new System.Drawing.Point(545, 52);
            this.pictureBoxImageEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImageEmployee.Name = "pictureBoxImageEmployee";
            this.pictureBoxImageEmployee.Size = new System.Drawing.Size(88, 80);
            this.pictureBoxImageEmployee.TabIndex = 3;
            this.pictureBoxImageEmployee.TabStop = false;
            // 
            // buttonClientAuthorization
            // 
            this.buttonClientAuthorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.buttonClientAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClientAuthorization.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientAuthorization.ForeColor = System.Drawing.Color.White;
            this.buttonClientAuthorization.Location = new System.Drawing.Point(231, 99);
            this.buttonClientAuthorization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClientAuthorization.Name = "buttonClientAuthorization";
            this.buttonClientAuthorization.Size = new System.Drawing.Size(231, 35);
            this.buttonClientAuthorization.TabIndex = 2;
            this.buttonClientAuthorization.Text = "Войти как клиент";
            this.buttonClientAuthorization.UseVisualStyleBackColor = false;
            this.buttonClientAuthorization.Click += new System.EventHandler(this.buttonClientAuthorization_Click);
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.buttonAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddMaterial.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddMaterial.ForeColor = System.Drawing.Color.White;
            this.buttonAddMaterial.Location = new System.Drawing.Point(231, 9);
            this.buttonAddMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(231, 37);
            this.buttonAddMaterial.TabIndex = 2;
            this.buttonAddMaterial.Text = "Добавить материал";
            this.buttonAddMaterial.UseVisualStyleBackColor = false;
            this.buttonAddMaterial.Visible = false;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // buttonEmployeeAuthorization
            // 
            this.buttonEmployeeAuthorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(71)))), ((int)(((byte)(107)))));
            this.buttonEmployeeAuthorization.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEmployeeAuthorization.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmployeeAuthorization.ForeColor = System.Drawing.Color.White;
            this.buttonEmployeeAuthorization.Location = new System.Drawing.Point(231, 54);
            this.buttonEmployeeAuthorization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEmployeeAuthorization.Name = "buttonEmployeeAuthorization";
            this.buttonEmployeeAuthorization.Size = new System.Drawing.Size(231, 37);
            this.buttonEmployeeAuthorization.TabIndex = 2;
            this.buttonEmployeeAuthorization.Text = "Войти как сотрудник";
            this.buttonEmployeeAuthorization.UseVisualStyleBackColor = false;
            this.buttonEmployeeAuthorization.Click += new System.EventHandler(this.buttonEmployeeAuthorization_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelList.Location = new System.Drawing.Point(3, 16);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(168, 21);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "Список продукции";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Shamilova_ObrazPlus.Properties.Resources.Образ_плюс1;
            this.pictureBox.Location = new System.Drawing.Point(39, 53);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(85, 79);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(822, 362);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 517);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(500, 444);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button buttonEmployeeAuthorization;
        private System.Windows.Forms.Button buttonClientAuthorization;
        public System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddMaterial;
        public System.Windows.Forms.PictureBox pictureBoxImageEmployee;
    }
}