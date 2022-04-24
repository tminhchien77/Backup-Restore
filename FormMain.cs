using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_restore
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.databases' table. You can move, or remove it, as needed.
            /*this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;*/
            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.dataSet.databases);

        }

        private void databasesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            string idDb = gvDatabases.SelectedRows[0].Cells[1].Value.ToString();
            Program.database= gvDatabases.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                this.backupsetTableAdapter.Connection.ConnectionString = Program.connstr;
                this.backupsetTableAdapter.Fill(this.dataSet.backupset, idDb);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            String sql = "SELECT COUNT(*) " +
                        "FROM sys.backup_devices " +
                        "WHERE SUBSTRING(name, 8, LEN(name) - 5) = '" + Program.database + "'";
            Program.myReader = Program.ExecSqlDataReader(sql);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int numBackupDevice = Program.myReader.GetInt32(0);
            Program.myReader.Close();
            if(numBackupDevice > 0) btnCreateDevice.Enabled = false;
            else   btnCreateDevice.Enabled = true;
            try
            {
                this.backupsetTableAdapter.Connection.ConnectionString = Program.connstr;
                this.backupsetTableAdapter.Fill(this.dataSet.backupset, Program.database);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (!btnCreateDevice.Enabled && bsBackupset.Count <= 0)
                btnRestoreAtTime.Enabled = false;
            else if (!btnRestoreAtTime.Enabled && bsBackupset.Count > 0)
                btnRestoreAtTime.Enabled = true;
        }

        private void btnCreateDevice_Click(object sender, EventArgs e)
        {
            String nameDevice= "DEVICE_"+Program.database;
            String str = "EXEC sp_addumpdevice 'disk', '"+ nameDevice + "', '"+Program.defaultPath+"/"+nameDevice+".bak'";
            try
            {
                Program.execNonQuery(str, "Đã tồn tại device này tại đường dẫn " + Program.defaultPath);
                btnCreateDevice.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo backup device\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }
        }
        private void backupDB()
        {
            String str = "BACKUP DATABASE " + Program.database + " TO DEVICE_" + Program.database;
            if (checkBoxWithInit.Checked)
                if (MessageBox.Show("Bạn chắc chắn muốn xoá các bản sao lưu cũ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    str += " WITH INIT";
            if (Program.execNonQuery(str) < 0)
            {
                MessageBox.Show("Lỗi sao lưu cơ sở dữ liệu " + Program.database);
                return;
            }
            else
            {
                MessageBox.Show("Sao lưu cơ sở dữ liệu thành công!");
                checkBoxWithInit.Checked = false;
            }
                
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            
            using (FormWait frm = new FormWait(backupDB))
            {
                /*this.Hide();*/
                frm.ShowDialog(this);
            }
            try
            {
                this.backupsetTableAdapter.Connection.ConnectionString = Program.connstr;
                this.backupsetTableAdapter.Fill(this.dataSet.backupset, Program.database);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi backup device\n" + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnCreateDevice_EnabledChanged(object sender, EventArgs e)
        {
            btnBackup.Enabled= btnRestore.Enabled = btnRestoreAtTime.Enabled = !btnCreateDevice.Enabled;
        }

        private void restoreDB()
        {
            int position = Int32.Parse(gvBackupset.SelectedRows[0].Cells[0].Value.ToString());
            String str = "ALTER DATABASE " + Program.database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                "USE master \n" +
                "RESTORE DATABASE " + Program.database + " FROM  DEVICE_" + Program.database + " WITH FILE = " + position + ", REPLACE \n" +
                "ALTER DATABASE " + Program.database + "  SET MULTI_USER";
            if (Program.execNonQuery(str, "Lỗi phục hồi cơ sở dữ liệu!") > 0)
            {
                MessageBox.Show("Thành công");
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            
            using (FormWait frm = new FormWait(restoreDB))
            {
                frm.ShowDialog(this);
            }
        }

        private void btnReStoreAtTime_Click(object sender, EventArgs e)
        {
            FormRestoreAtTime frmRestoreAtTime = new FormRestoreAtTime();
            frmRestoreAtTime.datetimeBackup = DateTime.Parse(gvBackupset.Rows[0].Cells[2].Value.ToString());
            frmRestoreAtTime.ShowDialog();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Program.conn.Close();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
