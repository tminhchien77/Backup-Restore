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
    public partial class FormRestoreAtTime : Form
    {
        public DateTime datetimeBackup;
        public FormRestoreAtTime()
        {
            InitializeComponent();
            

        }

        void restoreAtTime()
        {
            String str = "USE tempdb \n" +
                "ALTER DATABASE " + Program.database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                "BACKUP LOG " + Program.database + " TO DISK = '" + Program.defaultPath + "/backuplogfile.trn' WITH INIT \n" +
                "RESTORE DATABASE " + Program.database + " FROM DISK = '" + Program.defaultPath + "/DEVICE_" + Program.database + ".bak' WITH NORECOVERY, REPLACE\n" +
                "RESTORE DATABASE " + Program.database + " FROM DISK = '" + Program.defaultPath + "/backuplogfile.trn' WITH STOPAT='" + dtpDate.Value.ToString("yyyy-MM-dd") + " " + dtpTime.Value.TimeOfDay.ToString() + "'\n" +
                "ALTER DATABASE " + Program.database + "  SET MULTI_USER";
/*            "RESTORE DATABASE " + Program.database + " FROM  DEVICE_" + Program.database + " WITH FILE = " + position + ", REPLACE \n" +
*/            if (Program.execNonQuery(str, "Lỗi phục hồi cơ sở dữ liệu!") > 0)
            {
                MessageBox.Show("Thành công");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
           /* if (dtpDate.Value.Date == datetimeBackup.Date && dtpTime.Value.TimeOfDay.Ticks < datetimeBackup.TimeOfDay.Ticks)
            {
                MessageBox.Show("Thời điểm phục hồi phải sau thời điểm sao lưu: " + datetimeBackup.ToString("dd/MM/yyyy HH:mm:ss"), "", MessageBoxButtons.OK);
                return ;
            }

            if (dtpDate.Value.Date == DateTime.Now.Date && dtpTime.Value.TimeOfDay.Ticks >= DateTime.Now.AddMinutes(-3).TimeOfDay.Ticks)
            {
                MessageBox.Show("Thời điểm phục hồi phải trước thời điểm hiện tại.", "", MessageBoxButtons.OK);
                return;
            }*/
            using (FormWait frm=new FormWait(restoreAtTime))
            {
                this.Hide();
                frm.ShowDialog(this);
            }
        }

        private void FormRestoreAtTime_Load(object sender, EventArgs e)
        {
            dtpDate.MinDate = datetimeBackup.Date;
            dtpDate.Value = datetimeBackup.Date;
            dtpTime.Value = datetimeBackup;
        }
    }
}
