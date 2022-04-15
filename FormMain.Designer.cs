namespace backup_restore
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gvDatabases = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new backup_restore.DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvBackupset = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBackupset = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStoreAtTime = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnCreateDevice = new System.Windows.Forms.Button();
            this.databasesTableAdapter = new backup_restore.DataSetTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new backup_restore.DataSetTableAdapters.TableAdapterManager();
            this.backupsetTableAdapter = new backup_restore.DataSetTableAdapters.backupsetTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBackupset)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDatabases
            // 
            this.gvDatabases.AllowUserToAddRows = false;
            this.gvDatabases.AllowUserToDeleteRows = false;
            this.gvDatabases.AllowUserToResizeColumns = false;
            this.gvDatabases.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gvDatabases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDatabases.AutoGenerateColumns = false;
            this.gvDatabases.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            this.gvDatabases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvDatabases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvDatabases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDatabases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatabases.ColumnHeadersVisible = false;
            this.gvDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gvDatabases.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvDatabases.DataSource = this.databasesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDatabases.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDatabases.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvDatabases.EnableHeadersVisualStyles = false;
            this.gvDatabases.Location = new System.Drawing.Point(0, 60);
            this.gvDatabases.MultiSelect = false;
            this.gvDatabases.Name = "gvDatabases";
            this.gvDatabases.ReadOnly = true;
            this.gvDatabases.RowHeadersVisible = false;
            this.gvDatabases.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.gvDatabases.RowTemplate.Height = 35;
            this.gvDatabases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvDatabases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDatabases.Size = new System.Drawing.Size(180, 390);
            this.gvDatabases.TabIndex = 0;
            this.gvDatabases.SelectionChanged += new System.EventHandler(this.databasesDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "database_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "database_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gvBackupset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 390);
            this.panel2.TabIndex = 2;
            // 
            // gvBackupset
            // 
            this.gvBackupset.AllowUserToAddRows = false;
            this.gvBackupset.AllowUserToDeleteRows = false;
            this.gvBackupset.AllowUserToResizeColumns = false;
            this.gvBackupset.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.gvBackupset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvBackupset.AutoGenerateColumns = false;
            this.gvBackupset.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvBackupset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBackupset.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvBackupset.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBackupset.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvBackupset.ColumnHeadersHeight = 30;
            this.gvBackupset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gvBackupset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gvBackupset.DataSource = this.bsBackupset;
            this.gvBackupset.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvBackupset.EnableHeadersVisualStyles = false;
            this.gvBackupset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvBackupset.Location = new System.Drawing.Point(0, 0);
            this.gvBackupset.MultiSelect = false;
            this.gvBackupset.Name = "gvBackupset";
            this.gvBackupset.ReadOnly = true;
            this.gvBackupset.RowHeadersVisible = false;
            this.gvBackupset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBackupset.Size = new System.Drawing.Size(620, 286);
            this.gvBackupset.TabIndex = 0;
            this.gvBackupset.VirtualMode = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bản sao lưu thứ #";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nội dung";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 225;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "backup_start_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thời điểm sao lưu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Người thực hiện";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // bsBackupset
            // 
            this.bsBackupset.DataMember = "backupset";
            this.bsBackupset.DataSource = this.dataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(160)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.btnStoreAtTime);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnCreateDevice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 3;
            // 
            // btnStoreAtTime
            // 
            this.btnStoreAtTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStoreAtTime.FlatAppearance.BorderSize = 0;
            this.btnStoreAtTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreAtTime.ForeColor = System.Drawing.Color.Black;
            this.btnStoreAtTime.Image = ((System.Drawing.Image)(resources.GetObject("btnStoreAtTime.Image")));
            this.btnStoreAtTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreAtTime.Location = new System.Drawing.Point(405, 0);
            this.btnStoreAtTime.Name = "btnStoreAtTime";
            this.btnStoreAtTime.Size = new System.Drawing.Size(125, 60);
            this.btnStoreAtTime.TabIndex = 3;
            this.btnStoreAtTime.Text = "Phục hồi với mốc thời gian";
            this.btnStoreAtTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreAtTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStoreAtTime.UseVisualStyleBackColor = true;
            this.btnStoreAtTime.Click += new System.EventHandler(this.btnStoreAtTime_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(280, 0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(125, 60);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Phục hồi";
            this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.Black;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(155, 0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(125, 60);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Sao lưu";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnCreateDevice
            // 
            this.btnCreateDevice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateDevice.FlatAppearance.BorderSize = 0;
            this.btnCreateDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDevice.ForeColor = System.Drawing.Color.Black;
            this.btnCreateDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDevice.Image")));
            this.btnCreateDevice.Location = new System.Drawing.Point(0, 0);
            this.btnCreateDevice.Name = "btnCreateDevice";
            this.btnCreateDevice.Size = new System.Drawing.Size(155, 60);
            this.btnCreateDevice.TabIndex = 0;
            this.btnCreateDevice.Text = "Tạo backup device";
            this.btnCreateDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateDevice.UseVisualStyleBackColor = true;
            this.btnCreateDevice.EnabledChanged += new System.EventHandler(this.btnCreateDevice_EnabledChanged);
            this.btnCreateDevice.Click += new System.EventHandler(this.btnCreateDevice_Click);
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = backup_restore.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // backupsetTableAdapter
            // 
            this.backupsetTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 104);
            this.panel3.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(122, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gvDatabases);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBackupset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private DataSetTableAdapters.databasesTableAdapter databasesTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gvDatabases;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateDevice;
        private System.Windows.Forms.Button btnStoreAtTime;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.BindingSource bsBackupset;
        private DataSetTableAdapters.backupsetTableAdapter backupsetTableAdapter;
        private System.Windows.Forms.DataGridView gvBackupset;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

