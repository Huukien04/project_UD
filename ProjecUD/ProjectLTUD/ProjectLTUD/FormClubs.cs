using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectLTUD
{
    public partial class FormClubs : Form
    {
        string serverName, dbName;
        public FormClubs(string serverName, string dbName)
        {
            InitializeComponent();
            this.serverName = serverName;
            this.dbName = dbName;
        }
        

        #region Xử lý các các nút Club
        private void OpenChildForm(Form childForm)
        {
            try
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlDesktop.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnArs_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Arsenal");
            Bitmap clubLogoPath = (Bitmap)imgBtnArs.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnArs_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Arsenal");
            Bitmap clubLogoPath = (Bitmap)imgBtnArs.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnAvl_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Aston Villa");
            Bitmap clubLogoPath = (Bitmap)imgBtnAvl.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnAvl_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Aston Villa");
            Bitmap clubLogoPath = (Bitmap)imgBtnAvl.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnBou_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Bournemouth");
            Bitmap clubLogoPath = (Bitmap)imgBtnBou.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnBou_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Bournemouth");
            Bitmap clubLogoPath = (Bitmap)imgBtnBou.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnBre_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Brentford");
            Bitmap clubLogoPath = (Bitmap)imgBtnBre.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnBre_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Brentford");
            Bitmap clubLogoPath = (Bitmap)imgBtnBre.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnBha_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Brighton");
            Bitmap clubLogoPath = (Bitmap)imgBtnBha.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnBha_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Brighton");
            Bitmap clubLogoPath = (Bitmap)imgBtnBha.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnBur_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Burnley");
            Bitmap clubLogoPath = (Bitmap)imgBtnBur.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnBur_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Burnley");
            Bitmap clubLogoPath = (Bitmap)imgBtnBur.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnChe_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Chelsea");
            Bitmap clubLogoPath = (Bitmap)imgBtnChe.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnChe_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Chelsea");
            Bitmap clubLogoPath = (Bitmap)imgBtnChe.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnCry_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Crystal Palace");
            Bitmap clubLogoPath = (Bitmap)imgBtnCry.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnCry_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Crystal Palace");
            Bitmap clubLogoPath = (Bitmap)imgBtnCry.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnEve_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Everton");
            Bitmap clubLogoPath = (Bitmap)imgBtnEve.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnEve_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Everton");
            Bitmap clubLogoPath = (Bitmap)imgBtnEve.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnFul_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Fulham");
            Bitmap clubLogoPath = (Bitmap)imgBtnFul.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnFul_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Fulham");
            Bitmap clubLogoPath = (Bitmap)imgBtnFul.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnLiv_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Liverpool");
            Bitmap clubLogoPath = (Bitmap)imgBtnLiv.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnLiv_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Liverpool");
            Bitmap clubLogoPath = (Bitmap)imgBtnLiv.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnLut_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Luton Town");
            Bitmap clubLogoPath = (Bitmap)imgBtnLut.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnLut_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Luton Town");
            Bitmap clubLogoPath = (Bitmap)imgBtnLut.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnMci_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Manchester City");
            Bitmap clubLogoPath = (Bitmap)imgBtnMci.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnMci_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Manchester City");
            Bitmap clubLogoPath = (Bitmap)imgBtnMci.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnMun_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Manchester United");
            Bitmap clubLogoPath = (Bitmap)imgBtnMun.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnMun_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Manchester United");
            Bitmap clubLogoPath = (Bitmap)imgBtnMun.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnNew_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Newcastle");
            Bitmap clubLogoPath = (Bitmap)imgBtnNew.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Newcastle");
            Bitmap clubLogoPath = (Bitmap)imgBtnNew.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnNfo_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Nottingham Forest");
            Bitmap clubLogoPath = (Bitmap)imgBtnNfo.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnNfo_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Nottingham Forest");
            Bitmap clubLogoPath = (Bitmap)imgBtnNfo.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnShu_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Sheffield United");
            Bitmap clubLogoPath = (Bitmap)imgBtnShu.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnShu_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Sheffield United");
            Bitmap clubLogoPath = (Bitmap)imgBtnShu.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnTot_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Totenham");
            Bitmap clubLogoPath = (Bitmap)imgBtnTot.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnTot_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Tottenham");
            Bitmap clubLogoPath = (Bitmap)imgBtnTot.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnWhu_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("West Ham United");
            Bitmap clubLogoPath = (Bitmap)imgBtnWhu.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnWhu_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("West Ham United");
            Bitmap clubLogoPath = (Bitmap)imgBtnWhu.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void imgBtnWol_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Wolverhampton");
            Bitmap clubLogoPath = (Bitmap)imgBtnWol.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }

        private void btnWol_Click(object sender, EventArgs e)
        {
            FormClub frm = new FormClub(serverName, dbName);
            frm.SetTeamInfo("Wolverhampton");
            Bitmap clubLogoPath = (Bitmap)imgBtnWol.Image;
            frm.SetClubLogo(clubLogoPath);
            OpenChildForm(frm);
        }
        #endregion
    }
}
