using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckBoxExamp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCollege_Click(object sender, EventArgs e)
    {
        if (chkDiet.Checked == false &&  chkDietDs.Checked == false)
        {
            lblMessage.Text = "Kindly enter the college.";
        }
        if (chkDiet.Checked == true)
        {
            lblDiet.Visible = true;
            chkInverse.Visible = true;
            chkSelectAll.Visible = true;
            chkReset.Visible = true;
            chkCE.Visible = true;
            chkMch.Visible = true;
            chkEE.Visible = true;
            chkCivil.Visible = true;
            btnSubmit.Visible = true;
        }
        else if (chkDietDs.Checked == true)
        {
            lblDietds.Visible = true;
            chkInverse1.Visible = true;
            chkSelect.Visible = true;
            chkReset1.Visible = true;
            chkDsCE.Visible = true;
            chkDsMch.Visible = true;
            chkDsEE.Visible = true;
            chkDsCivil.Visible = true;
            btnSubmit.Visible = true;
        }
        if (chkDiet.Checked==true && chkDietDs.Checked==true)
        {
            lblDiet.Visible = true;
            chkInverse.Visible = true;
            chkSelectAll.Visible = true;
            chkReset.Visible = true;
            chkCE.Visible = true;
            chkMch.Visible = true;
            chkEE.Visible = true;
            chkCivil.Visible = true;
            btnSubmit.Visible = true;

            lblDietds.Visible = true;
            chkInverse1.Visible = true;
            chkSelect.Visible = true;
            chkReset1.Visible = true;
            chkDsCE.Visible = true;
            chkDsMch.Visible = true;
            chkDsEE.Visible = true;
            chkDsCivil.Visible = true;
            btnSubmit.Visible = true;
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (chkDiet.Checked == true)
        {
            string strBranch = "";

            if (chkCE.Checked)
            {
                strBranch += "Computer Engineering, ";
            }
            if (chkMch.Checked)
            {
                strBranch += "Mechanical Engineering, ";
            }
            if (chkEE.Checked)
            {
                strBranch += "Electrical Engineering, ";
            }
            if (chkCivil.Checked)
            {
                strBranch += "Civil Engineering ";
            }
            lblMessage.Text = "You have select DIET college and choose branches to " + strBranch;
        }
        else if (chkDietDs.Checked == true)
        {
            string strBranch = "";

            if (chkDsCE.Checked)
            {
                strBranch += "Computer Engineering, ";
            }
            if (chkDsMch.Checked)
            {
                strBranch += "Mechanical Engineering, ";
            }
            if (chkDsEE.Checked)
            {
                strBranch += "Electrical Engineering, ";
            }
            if (chkDsCivil.Checked)
            {
                strBranch += "Civil Engineering ";
            }
            lblMessage.Text = "You have select DIETDS college and choose branches to " + strBranch;
        }
        if (chkDiet.Checked == true && chkDietDs.Checked == true)
        {
            string strBranch = "",strBranch2 = "";

            if (chkCE.Checked)
            {
                strBranch += "Computer Engineering, ";
            }
            if (chkMch.Checked)
            {
                strBranch += "Mechanical Engineering, ";
            }
            if (chkEE.Checked)
            {
                strBranch += "Electrical Engineering, ";
            }
            if (chkCivil.Checked)
            {
                strBranch += "Civil Engineering ";
            }
         
            if (chkDsCE.Checked)
            {
                strBranch2 += "Computer Engineering, ";
            }
            if (chkDsMch.Checked)
            {
                strBranch2 += "Mechanical Engineering, ";
            }
            if (chkDsEE.Checked)
            {
                strBranch2 += "Electrical Engineering, ";
            }
            if (chkDsCivil.Checked)
            {
                strBranch2 += "Civil Engineering ";
            }
            lblMessage.Text = "You have select DIET,DIETDS college and choose courses to " + strBranch + strBranch2 ;

            //lblMessage.Text = "You have select DIETDS college and choose courses to " + strBranch2;
        }
    }

    protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        chkReset.Checked = false;   
        chkCE.Checked = true;
        chkCivil.Checked = true;
        chkEE.Checked = true;
        chkMch.Checked = true;
    }
    protected void chkSelect_CheckedChanged(object sender, EventArgs e)
    {
        chkReset1.Checked = false;
        chkDsCE.Checked = true;
        chkDsCivil.Checked = true;
        chkDsEE.Checked = true;
        chkDsMch.Checked = true;
    }
    protected void chkReset_CheckedChanged(object sender, EventArgs e)
    {
        chkSelectAll.Checked = false;
        chkCE.Checked = false;
        chkCivil.Checked = false;
        chkEE.Checked = false;
        chkMch.Checked = false;
    }
    protected void chkReset1_CheckedChanged(object sender, EventArgs e)
    {
        chkSelect.Checked = false;
        chkDsCE.Checked = false;
        chkDsCivil.Checked = false;
        chkDsEE.Checked = false;
        chkDsMch.Checked = false;
    }
    protected void chkInverse_CheckedChanged(object sender, EventArgs e)
    {
        if (chkCE.Checked == true)
        {
            chkCE.Checked = false;
            chkCivil.Checked = true;
            chkEE.Checked = true;
            chkMch.Checked = true;
        }
        else if (chkCivil.Checked)
        {
            chkCE.Checked = true;
            chkCivil.Checked = false;
            chkEE.Checked = true;
            chkMch.Checked = true;
        }
        else if (chkEE.Checked)
        {
            chkCE.Checked = true;
            chkCivil.Checked = true;
            chkEE.Checked = false;
            chkMch.Checked = true;
        }
        else if (chkMch.Checked)
        {
            chkCE.Checked = true;
            chkCivil.Checked = true;
            chkEE.Checked = true;
            chkMch.Checked = false;
        }
        else if (chkCE.Checked && chkCivil.Checked)
        {
            chkCE.Checked = false;
            chkCivil.Checked = false;
            chkEE.Checked = true;
            chkMch.Checked = true;
        }
        else if (chkCE.Checked && chkEE.Checked)
        {
            chkCE.Checked = false;
            chkCivil.Checked = true;
            chkEE.Checked = false;
            chkMch.Checked = true;
        }
        else if (chkCE.Checked && chkMch.Checked)
        {
            chkCE.Checked = false;
            chkCivil.Checked = true;
            chkEE.Checked = true;
            chkMch.Checked = false;
        }
        else if (chkEE.Checked && chkCivil.Checked)
        {
            chkCE.Checked = true;
            chkCivil.Checked = false;
            chkEE.Checked = false;
            chkMch.Checked = true;
        }
        else if (chkMch.Checked && chkEE.Checked)
        {
            chkCE.Checked = true;
            chkCivil.Checked = true;
            chkEE.Checked = false;
            chkMch.Checked = false;
        }
        else if (chkMch.Checked && chkCivil.Checked)
        {
            chkCE.Checked = true;
            chkCivil.Checked = false;
            chkEE.Checked = true;
            chkMch.Checked = false;
        }
        else if (chkCE.Checked && chkEE.Checked && chkMch.Checked)
        {
            chkCE.Checked = false;
            chkCivil.Checked = true;
            chkEE.Checked = false;
            chkMch.Checked = false;
        }
        else if (chkCE.Checked && chkMch.Checked && chkCivil.Checked)
        {
            chkCE.Checked = false;
            chkCivil.Checked = false;
            chkEE.Checked = true;
            chkMch.Checked = false;
        }
    }
}