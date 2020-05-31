using Grabar.Forms;
using Grabar.Forms.Transactions;
using Grabar.Forms.Yearly_and_Month_Details;
using System.Windows.Forms;

namespace Grabar
{
    public partial class GrabarControl : Form
    {
        #region Properties
        private Form activeForm = null;
        ViewForm _ViewForm;
        EntryForm _EntryForm;
        #endregion
        public GrabarControl()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        #region Custom Design
        private void CustomizeDesign()
        {
            subPanelDetails.Visible = false;
            subPanelOther.Visible = false;
        }
        private void HideSubMenu()
        {
            if (subPanelDetails.Visible == true)
                subPanelDetails.Visible = false;
            if (subPanelOther.Visible == true)
                subPanelOther.Visible = false;
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private void OpenChildFormInContainer(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion   

        #region Button Details and Sub Menus
        private void BtnDaily_Click(object sender, System.EventArgs e)
        {
            ShowSubMenu(subPanelDetails);
        }

        private void SubBtnDetailsAdd_Click(object sender, System.EventArgs e)
        {
            _EntryForm = new EntryForm();
            //_EntryForm.Show();
            OpenChildFormInContainer(_EntryForm);
            //... other functionality
            HideSubMenu();
        }

        private void SubBtnDetailsView_Click(object sender, System.EventArgs e)
        {
            _ViewForm = new ViewForm();
            //_ViewForm.Show();
            OpenChildFormInContainer(_ViewForm);
            HideSubMenu();
        }

        private void SubBtnDetailsDelete_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region Button Other and Sub Menus
        private void BtnOther_Click(object sender, System.EventArgs e)
        {
            ShowSubMenu(subPanelOther);
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            OpenChildFormInContainer(new ManagePersons());
            HideSubMenu();
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            OpenChildFormInContainer(new Transactions());
            HideSubMenu();
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            OpenChildFormInContainer(new Display());
            HideSubMenu();
        }

        #endregion

        #region Button Help and Sub Menus

        private void BtnHelp_Click(object sender, System.EventArgs e)
        {
            HideSubMenu();
        }

        #endregion

        private void pictureBoxIcon_Click(object sender, System.EventArgs e)
        {

        }
    }
}
