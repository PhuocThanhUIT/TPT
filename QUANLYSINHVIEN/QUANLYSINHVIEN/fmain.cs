using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYSINHVIEN
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        bool is_panQLSVExpand = true;//khoi tao 1 bien co de xet xem panel dang o che do expand hay collapse
        bool is_panQLMHExpand = true;
        int x_pnQlSV, y_pnQLSV, x_pnQLD, y_pnQLD, x_pnQLMH, y_pnQLMH;

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAboutTeamTPT about = new fAboutTeamTPT();
            about.ShowDialog();
        }

        private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Login frmLogin = new Login())
            {
                //frmLogin.setGroupbox = new Login.EnableGroupbox(enable_groupbox);
                //nhận tham so truyen ve tu ham delegate EnableGroupbox
                frmLogin.ShowDialog();
            }
            if (grB_leftMenu.Enabled == true)
            {
                DangNhapToolStripMenuItem.Enabled = false;
                DangXuatToolStripMenuItem.Enabled = true;
                pan_Main.Enabled = true;
                quanlyTK_ToolStripMenuItem.Enabled = true;
                TacVuToolStripMenuItem.Enabled = true;
                báoCáoToolStripMenuItem.Enabled = true;
            }
        }

        private void quanlyTK_ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lblTitle.Text = "Quản lý tài khoản";
            uc_User user = new uc_User();

            qlsv_xl.AddControl(pan_Main, user);
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quanliSV_L_MH_NGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanliGV_Khoa_khoahoc_HEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhapDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuatDSMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xuatDSSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xemDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fmain_Load(object sender, EventArgs e)
        {


            btnQLSV_collapse.Visible = true;
            btnQLSV_ex.Visible = false;

            btnQLMH_Collapse.Visible = true;
            btnQLMH_ex.Visible = false;

            btnQLDIEM_Collapse.Visible = true;
            btnQLDIEM_ex.Visible = false;

            //pan_MenuMH.Height = 0;
            //pan_MenuQLDIEM.Height = 0;

            x_pnQlSV = pan_QLSV.Location.X;
            y_pnQLSV = pan_QLSV.Location.Y;

            x_pnQLMH = pan_QLMH.Location.X;
            y_pnQLMH = pan_QLMH.Location.Y;

            x_pnQLD = pan_QLDIEM.Location.X;
            y_pnQLD = pan_QLDIEM.Location.Y;

            //  grB_leftMenu.Visible = false;
            grB_leftMenu.Enabled = false;
            menuStrip1.Visible = true;

            TacVuToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;

            lblTitle.Text = "CHƯƠNG TRÌNH QUẢN LÍ SINH VIÊN";


        }
    }
}
