using BusinessAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PratikStudioTalkies
{
    
    public partial class RatingUserControl1 : System.Web.UI.UserControl
    {
        RatingBusinessAccess _searchRatingBA = new RatingBusinessAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRating();
            }
        }
        private void BindRating()
        {
            ddlRating.DataSource = _searchRatingBA.GetRatings();
            ddlRating.DataTextField = "RatingName";
            ddlRating.DataValueField = "RatingId";
            ddlRating.DataBind();
        }
        public string SelectedText
        {
            get
            {
                return ddlRating.SelectedItem.Text;
            }
            set
            {
                ddlRating.SelectedItem.Text = value.ToString();
            }
        }

        public int? SelectedValue
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ddlRating.SelectedValue))
                {
                    return Convert.ToInt32(ddlRating.SelectedValue);
                }
                return null;              
            }
            set
            {
                ddlRating.SelectedValue = value.ToString();
            }
        }

        //public int? SelectedValue
        //{
        //    get
        //    {
        //        if (!string.IsNullOrWhiteSpace(ddlRating.SelectedValue))
        //        {
        //            return Convert.ToInt32(ddlRating.SelectedValue);
        //        }
        //        return null;
        //    }
        //    set
        //    {
        //        ddlRating.SelectedValue = Convert.ToString(value);
        //    }
        //}

    }
}