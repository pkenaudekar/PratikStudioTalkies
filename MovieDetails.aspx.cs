using BusinessAccess;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PratikStudioTalkies
{
    public partial class MovieDetails : System.Web.UI.Page
    {
        private SearchMovieBusinessAccess _movieBA = new SearchMovieBusinessAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["movieId"] != null && !IsPostBack)
            {
                BindMovieDetails();
            }
        }

        private void BindMovieDetails()
        {

            int movieId = Convert.ToInt32(Session["movieId"]);
            try
            {
                ResponseMovieBE movie = new ResponseMovieBE();
                movie = _movieBA.GetMoviesById(movieId);
                //lblOrderDate.Text = Convert.ToString(order.OrderDate);
                //DateTime dat = Convert.ToDateTime("1986-03-24T00:00:00");
                lblDateOfRelease.Text = movie.DateOfRelease.ToString("dd-MM-yyyy");
                lblMovieName.Text = movie.Title;
                lblDescription.Text = movie.Description;
                lblGenre.Text = movie.GenreName;
                lblRating.Text = movie.RatingName;
                gvwMovieDetails.DataSource = movie.MovieCastDetails;
                gvwMovieDetails.DataBind();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
            }
        }
    }
}