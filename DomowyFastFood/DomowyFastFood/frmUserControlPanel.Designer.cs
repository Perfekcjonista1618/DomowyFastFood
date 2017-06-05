namespace DomowyFastFood
{
    partial class frmUserControlPanel
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
            this.dgvRestaurant = new System.Windows.Forms.DataGridView();
            this.domowyFastFoodDataSet1 = new DomowyFastFood.DomowyFastFoodDataSet1();
            this.restauracjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauracjaTableAdapter = new DomowyFastFood.DomowyFastFoodDataSet1TableAdapters.RestauracjaTableAdapter();
            this.iDRestauracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaRestauracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danieDniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.lblSyncTitle = new System.Windows.Forms.Label();
            this.lblSyncInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRestaurant
            // 
            this.dgvRestaurant.AutoGenerateColumns = false;
            this.dgvRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRestauracjiDataGridViewTextBoxColumn,
            this.nazwaRestauracjiDataGridViewTextBoxColumn,
            this.danieDniaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dgvRestaurant.DataSource = this.restauracjaBindingSource;
            this.dgvRestaurant.Location = new System.Drawing.Point(12, 12);
            this.dgvRestaurant.Name = "dgvRestaurant";
            this.dgvRestaurant.Size = new System.Drawing.Size(441, 271);
            this.dgvRestaurant.TabIndex = 0;
            // 
            // domowyFastFoodDataSet1
            // 
            this.domowyFastFoodDataSet1.DataSetName = "DomowyFastFoodDataSet1";
            this.domowyFastFoodDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauracjaBindingSource
            // 
            this.restauracjaBindingSource.DataMember = "Restauracja";
            this.restauracjaBindingSource.DataSource = this.domowyFastFoodDataSet1;
            // 
            // restauracjaTableAdapter
            // 
            this.restauracjaTableAdapter.ClearBeforeFill = true;
            // 
            // iDRestauracjiDataGridViewTextBoxColumn
            // 
            this.iDRestauracjiDataGridViewTextBoxColumn.DataPropertyName = "ID_Restauracji";
            this.iDRestauracjiDataGridViewTextBoxColumn.HeaderText = "ID_Restauracji";
            this.iDRestauracjiDataGridViewTextBoxColumn.Name = "iDRestauracjiDataGridViewTextBoxColumn";
            this.iDRestauracjiDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazwaRestauracjiDataGridViewTextBoxColumn
            // 
            this.nazwaRestauracjiDataGridViewTextBoxColumn.DataPropertyName = "NazwaRestauracji";
            this.nazwaRestauracjiDataGridViewTextBoxColumn.HeaderText = "NazwaRestauracji";
            this.nazwaRestauracjiDataGridViewTextBoxColumn.Name = "nazwaRestauracjiDataGridViewTextBoxColumn";
            // 
            // danieDniaDataGridViewTextBoxColumn
            // 
            this.danieDniaDataGridViewTextBoxColumn.DataPropertyName = "DanieDnia";
            this.danieDniaDataGridViewTextBoxColumn.HeaderText = "DanieDnia";
            this.danieDniaDataGridViewTextBoxColumn.Name = "danieDniaDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(378, 314);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Zamów!";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(259, 314);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Synchronizuj";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // lblSyncTitle
            // 
            this.lblSyncTitle.AutoSize = true;
            this.lblSyncTitle.Location = new System.Drawing.Point(12, 314);
            this.lblSyncTitle.Name = "lblSyncTitle";
            this.lblSyncTitle.Size = new System.Drawing.Size(124, 13);
            this.lblSyncTitle.TabIndex = 3;
            this.lblSyncTitle.Text = "Ostatnia Synchronizacja:";
            // 
            // lblSyncInfo
            // 
            this.lblSyncInfo.AutoSize = true;
            this.lblSyncInfo.Location = new System.Drawing.Point(143, 314);
            this.lblSyncInfo.Name = "lblSyncInfo";
            this.lblSyncInfo.Size = new System.Drawing.Size(10, 13);
            this.lblSyncInfo.TabIndex = 4;
            this.lblSyncInfo.Text = "-";
            // 
            // UserControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 361);
            this.Controls.Add(this.lblSyncInfo);
            this.Controls.Add(this.lblSyncTitle);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dgvRestaurant);
            this.Name = "UserControlPanel";
            this.Text = "Domowy Fast Food";
            this.Load += new System.EventHandler(this.UserControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRestaurant;
        private DomowyFastFoodDataSet1 domowyFastFoodDataSet1;
        private System.Windows.Forms.BindingSource restauracjaBindingSource;
        private DomowyFastFoodDataSet1TableAdapters.RestauracjaTableAdapter restauracjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRestauracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaRestauracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danieDniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label lblSyncTitle;
        private System.Windows.Forms.Label lblSyncInfo;
    }
}