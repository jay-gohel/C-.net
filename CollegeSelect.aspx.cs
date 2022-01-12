using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CollegeSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnCollege_Click(object sender, EventArgs e)
    {
        if(rbDiet.Checked==true)
        {
            lblDiet.Visible = true;
            rbcomp.Visible = true;
            rbElect.Visible = true;
            rbMech.Visible = true;
            rbCivil.Visible = true;
            btnDept.Visible = true;

            lblDiestds.Visible = false;
            rbDSComp.Visible = false;
            rbDSElect.Visible = false;
            rbDSMech.Visible = false;
            RbDSCivil.Visible = false;
        }
        else if (rbDietds.Checked)
        {
            lblDiet.Visible = false;
            rbcomp.Visible = false;
            rbElect.Visible = false;
            rbMech.Visible = false;
            rbCivil.Visible = false;
            btnDept.Visible = false;

            lblDiestds.Visible = true;
            rbDSComp.Visible = true;
            rbDSElect.Visible = true;
            rbDSMech.Visible = true;
            RbDSCivil.Visible = true;
            btnDept.Visible = true;
        }
    }
    protected void btnDept_Click(object sender, EventArgs e)
    {
        if (rbDiet.Checked)
        {
            if (rbcomp.Checked)
            {
                lblMessage.Text = "You have a select DIET college and the you have choose degree in computer engineering department";
            }
            else if(rbMech.Checked)
            {
                lblMessage.Text = "You have a select DIET college and the you have choose degree in Mechanical engineering department";
            }
            else if(rbElect.Checked)
            {
                lblMessage.Text = "You have a select DIET college and the you have choose degree in Electrical engineering department";
            }
            else if(rbCivil.Checked)
            {
                lblMessage.Text = "You have a select DIET college and the you have choose degree in Civil engineering department";
            }
            else
            {
                lblMessage.Text = "Kindly choose the any of the DIET courses";
            }
        }
        else if (rbDietds.Checked)
        {
            if (rbDSComp.Checked)
            {
                lblMessage.Text = "You have a select DIETDS college and the you have choose Diploma in computer engineering department";
            }
            else if (rbDSMech.Checked)
            {
                lblMessage.Text = "You have a select DIETDS college and the you have choose Diploma in Mechanical engineering department";
            }
            else if (rbDSElect.Checked)
            {
                lblMessage.Text = "You have a select DIETDS college and the you have choose Diploma in Electrical engineering department";
            }
            else if (RbDSCivil.Checked)
            {
                lblMessage.Text = "You have a select DIETDS college and the you have choose Diploma in Civil engineering department";
            }
            else
            {
                lblMessage.Text = "Kindly choose the any of the DIETDS course";
            }
        }
        else
        {
            lblMessage.Text = "Kindly select the college and choose the appropriate course's ";
        }
    }
  
}