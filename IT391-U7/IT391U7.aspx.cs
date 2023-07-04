using System;
using System.Web.UI.WebControls;
using IT391_U7.App_Start;

namespace IT391_U7
{
    public partial class IT391U7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Getting all grades from XML
            StudentGrades grades = new StudentGrades("studentGrades.xml");

            //Converting Average, Highest, and Lowest grade to String
            txtAverageGrade.Text = grades.AvgGrade.ToString();
            txtHighestGrade.Text = grades.MaxGrade.ToString();
            txtLowestGrade.Text = grades.MinGrade.ToString();
            Button1.Click += new EventHandler(this.Button1_Click);
            Button2.Click += new EventHandler(this.Button2_Click);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            //clickedButton.Enabled = false;

            // Display the grades
            txtAverageGrade.Visible = true;
            txtHighestGrade.Visible = true;
            txtLowestGrade.Visible = true;
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //Hides all the grades
            txtAverageGrade.Visible = false;
            txtHighestGrade.Visible = false;
            txtLowestGrade.Visible = false;
        }
    }
}