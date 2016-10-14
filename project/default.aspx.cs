using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // if loading the page for the first time
            // populate the student grid
            if (!IsPostBack)
            {
                // Get the student data
                this.GetStudents();
            }
        }
        private void GetStudents()
        {
            // connect to EF DB
            using (Model db = new Model())
            {
                // query the Student Table using EF and LINQ
                var Students = (from allStudents in db.Tables
                                select allStudents);

                // bind the result to the Students GridView
                GridView.DataSource = Students.ToList();
                GridView.DataBind();
            }
        }

    }
}