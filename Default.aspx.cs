using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessAccess;
using BusinessEntities;

namespace PratikStudioTalkies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SearchMovieBusinessAccess _searchMovieBA = new SearchMovieBusinessAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        private void BindGrid()
        {
            try
            {
                //gvwMovies.DataSource = _searchMovieBA.GetAllMovies(obj);
                gvwMovies.DataBind();
            }
            catch (Exception)
            {
                lblError.Text = "Error in loading Customers";
            }
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            gvwMovies.PageIndex = e.NewPageIndex;
            gvwMovies.DataBind();
        }

        protected void GridView_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvwMovies.PageIndex = e.NewPageIndex;            // GRIDVIEW PAGING.
                                                            //BindGrid();       // CALL YOU METHOD TO LOAD DATA TO THE GRIDVIEW OR DO OTHER STUFF.
        }


        protected void gvwMovies_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string movieId = Convert.ToString(gvwMovies.DataKeys[e.NewSelectedIndex].Value);
            Session["movieId"] = movieId;
            Response.Redirect("MovieDetails.aspx");
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                RequestMovieBE obj = new RequestMovieBE();
                if (!string.IsNullOrWhiteSpace(txtMovieTitle.Text))
                {
                    obj.Title = Convert.ToString(txtMovieTitle.Text.Trim());
                }

                obj.GenerId = GenerUserControl11.SelectedValue;

                if (!string.IsNullOrWhiteSpace(txtDateOfRelease.Text))
                {
                    obj.DateOfRelease = Convert.ToDateTime(txtDateOfRelease.Text.Trim());
                }

                obj.RatingId = RatingUserControl11.SelectedValue;

                gvwMovies.DataSource = _searchMovieBA.GetAllMovies(obj);
                gvwMovies.DataBind();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
            }
        }
    }
}