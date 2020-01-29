using BusinessAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PratikStudioTalkies
{
    public partial class GenerUserControl1 : System.Web.UI.UserControl
    {
        GenerBusinessAccess _searchGenerBA = new GenerBusinessAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindGener();
            }          
        }
        private void BindGener()
        {
            ddlGener.DataSource = _searchGenerBA.GetGenres();
            ddlGener.DataTextField = "GenreName";
            ddlGener.DataValueField = "GenreId";
            ddlGener.DataBind();
        }
        public string SelectedText
        {
            get
            {
                return ddlGener.SelectedItem.Text;
            }
            set
            {
                ddlGener.SelectedItem.Text = value.ToString();
            }
        }

        public int SelectedValue
        {
            get
            {
                return Convert.ToInt32(ddlGener.SelectedValue);
            }
            set
            {
                ddlGener.SelectedValue = value.ToString();
            }
        }

    }
}