namespace DomowyFastFood
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.domowyFastFoodDataSet = new DomowyFastFood.DomowyFastFoodDataSet();
            this.domowyFastFoodDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauracjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauracjaTableAdapter = new DomowyFastFood.DomowyFastFoodDataSetTableAdapters.RestauracjaTableAdapter();
            this.iDRestauracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaRestauracjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danieDniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Synchronizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(438, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(54, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Last Sync";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(504, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Never Used";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRestauracjiDataGridViewTextBoxColumn,
            this.nazwaRestauracjiDataGridViewTextBoxColumn,
            this.danieDniaDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.restauracjaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // domowyFastFoodDataSet
            // 
            this.domowyFastFoodDataSet.DataSetName = "DomowyFastFoodDataSet";
            this.domowyFastFoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // domowyFastFoodDataSetBindingSource
            // 
            this.domowyFastFoodDataSetBindingSource.DataSource = this.domowyFastFoodDataSet;
            this.domowyFastFoodDataSetBindingSource.Position = 0;
            // 
            // restauracjaBindingSource
            // 
            this.restauracjaBindingSource.DataMember = "Restauracja";
            this.restauracjaBindingSource.DataSource = this.domowyFastFoodDataSetBindingSource;
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
            this.nazwaRestauracjiDataGridViewTextBoxColumn.DataPropertyName = "Nazwa Restauracji";
            this.nazwaRestauracjiDataGridViewTextBoxColumn.HeaderText = "Nazwa Restauracji";
            this.nazwaRestauracjiDataGridViewTextBoxColumn.Name = "nazwaRestauracjiDataGridViewTextBoxColumn";
            // 
            // danieDniaDataGridViewTextBoxColumn
            // 
            this.danieDniaDataGridViewTextBoxColumn.DataPropertyName = "Danie Dnia";
            this.danieDniaDataGridViewTextBoxColumn.HeaderText = "Danie Dnia";
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
            // bttnOrder
            // 
            this.bttnOrder.Location = new System.Drawing.Point(417, 323);
            this.bttnOrder.Name = "bttnOrder";
            this.bttnOrder.Size = new System.Drawing.Size(75, 23);
            this.bttnOrder.TabIndex = 5;
            this.bttnOrder.Text = "Zamów!";
            this.bttnOrder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 383);
            this.Controls.Add(this.bttnOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domowyFastFoodDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauracjaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource domowyFastFoodDataSetBindingSource;
        private DomowyFastFoodDataSet domowyFastFoodDataSet;
        private System.Windows.Forms.BindingSource restauracjaBindingSource;
        private DomowyFastFoodDataSetTableAdapters.RestauracjaTableAdapter restauracjaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRestauracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaRestauracjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danieDniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bttnOrder;
    }
}

