namespace DomowyFastFood
{
    partial class frmAdminControlPanel
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.iDZamowieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRestauracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domowyFastFoodDataSet = new DomowyFastFood.DomowyFastFoodDataSet();
            this.zamowienieTableAdapter = new DomowyFastFood.DomowyFastFoodDataSetTableAdapters.ZamowienieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZamowieniaDataGridViewTextBoxColumn,
            this.iDRestauracjiDataGridViewTextBoxColumn,
            this.iDKlientaDataGridViewTextBoxColumn});
            this.dgvOrder.DataSource = this.zamowienieBindingSource;
            this.dgvOrder.Location = new System.Drawing.Point(12, 12);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(342, 190);
            this.dgvOrder.TabIndex = 0;
            // 
            // iDZamowieniaDataGridViewTextBoxColumn
            // 
            this.iDZamowieniaDataGridViewTextBoxColumn.DataPropertyName = "ID_Zamowienia";
            this.iDZamowieniaDataGridViewTextBoxColumn.HeaderText = "ID_Zamowienia";
            this.iDZamowieniaDataGridViewTextBoxColumn.Name = "iDZamowieniaDataGridViewTextBoxColumn";
            // 
            // iDRestauracjiDataGridViewTextBoxColumn
            // 
            this.iDRestauracjiDataGridViewTextBoxColumn.DataPropertyName = "ID_Restauracji";
            this.iDRestauracjiDataGridViewTextBoxColumn.HeaderText = "ID_Restauracji";
            this.iDRestauracjiDataGridViewTextBoxColumn.Name = "iDRestauracjiDataGridViewTextBoxColumn";
            // 
            // iDKlientaDataGridViewTextBoxColumn
            // 
            this.iDKlientaDataGridViewTextBoxColumn.DataPropertyName = "ID_Klienta";
            this.iDKlientaDataGridViewTextBoxColumn.HeaderText = "ID_Klienta";
            this.iDKlientaDataGridViewTextBoxColumn.Name = "iDKlientaDataGridViewTextBoxColumn";
            // 
            // zamowienieBindingSource
            // 
            this.zamowienieBindingSource.DataMember = "Zamowienie";
            this.zamowienieBindingSource.DataSource = this.domowyFastFoodDataSet;
            // 
            // domowyFastFoodDataSet
            // 
            this.domowyFastFoodDataSet.DataSetName = "DomowyFastFoodDataSet";
            this.domowyFastFoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zamowienieTableAdapter
            // 
            this.zamowienieTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.dgvOrder);
            this.Name = "frmAdminControlPanel";
            this.Text = "frmAdminControlPanel";
            this.Load += new System.EventHandler(this.frmAdminControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private DomowyFastFoodDataSet domowyFastFoodDataSet;
        private System.Windows.Forms.BindingSource zamowienieBindingSource;
        private DomowyFastFoodDataSetTableAdapters.ZamowienieTableAdapter zamowienieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZamowieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRestauracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKlientaDataGridViewTextBoxColumn;
    }
}