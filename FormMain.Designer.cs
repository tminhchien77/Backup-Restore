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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.gvDatabases = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new backup_restore.DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxWithInit = new System.Windows.Forms.CheckBox();
            this.gvBackupset = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBackupset = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnRestoreAtTime = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnCreateDevice = new System.Windows.Forms.Button();
            this.databasesTableAdapter = new backup_restore.DataSetTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new backup_restore.DataSetTableAdapters.TableAdapterManager();
            this.backupsetTableAdapter = new backup_restore.DataSetTableAdapters.backupsetTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBackupset)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(231)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDatabases.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvDatabases.Dock = System.Windows.Forms.DockStyle.Left;
            this.gvDatabases.EnableHeadersVisualStyles = false;
            this.gvDatabases.Location = new System.Drawing.Point(0, 99);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 390);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.checkBoxWithInit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(180, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 77);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xoá tất cả các bản sao lưu cũ";
            // 
            // checkBoxWithInit
            // 
            this.checkBoxWithInit.AutoSize = true;
            this.checkBoxWithInit.Location = new System.Drawing.Point(244, 29);
            this.checkBoxWithInit.Name = "checkBoxWithInit";
            this.checkBoxWithInit.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWithInit.TabIndex = 0;
            this.checkBoxWithInit.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBackupset.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvBackupset.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvBackupset.EnableHeadersVisualStyles = false;
            this.gvBackupset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvBackupset.Location = new System.Drawing.Point(180, 99);
            this.gvBackupset.MultiSelect = false;
            this.gvBackupset.Name = "gvBackupset";
            this.gvBackupset.ReadOnly = true;
            this.gvBackupset.RowHeadersVisible = false;
            this.gvBackupset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBackupset.Size = new System.Drawing.Size(620, 313);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnRestoreAtTime);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnCreateDevice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 3;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnect.Location = new System.Drawing.Point(530, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDisconnect.Size = new System.Drawing.Size(125, 60);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Huỷ kết nối";
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnRestoreAtTime
            // 
            this.btnRestoreAtTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRestoreAtTime.FlatAppearance.BorderSize = 0;
            this.btnRestoreAtTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreAtTime.ForeColor = System.Drawing.Color.White;
            this.btnRestoreAtTime.Image = ((System.Drawing.Image)(resources.GetObject("btnRestoreAtTime.Image")));
            this.btnRestoreAtTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreAtTime.Location = new System.Drawing.Point(405, 0);
            this.btnRestoreAtTime.Name = "btnRestoreAtTime";
            this.btnRestoreAtTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnRestoreAtTime.Size = new System.Drawing.Size(125, 60);
            this.btnRestoreAtTime.TabIndex = 3;
            this.btnRestoreAtTime.Text = "Phục hồi với mốc thời gian";
            this.btnRestoreAtTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreAtTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoreAtTime.UseVisualStyleBackColor = true;
            this.btnRestoreAtTime.Click += new System.EventHandler(this.btnReStoreAtTime_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(280, 0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
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
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.Image")));
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(155, 0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
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
            this.btnCreateDevice.ForeColor = System.Drawing.Color.White;
            this.btnCreateDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDevice.Image")));
            this.btnCreateDevice.Location = new System.Drawing.Point(0, 0);
            this.btnCreateDevice.Name = "btnCreateDevice";
            this.btnCreateDevice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 39);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Backup && Restore";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(770, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gvBackupset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gvDatabases);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatabases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBackupset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnRestoreAtTime;
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
        private System.Windows.Forms.CheckBox checkBoxWithInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}

