using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListControlDemo_DropDownList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void btnAddItem_Click(object sender, EventArgs e)
    {
        
        ListItem li = new ListItem();
        li.Text = txtCountryName.Text;
        li.Value = txtCountryCode.Text;

        ddlCountry.Items.Add(li);

        txtCountryName.Text = " ";
        txtCountryCode.Text = "";
    }
    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        foreach (ListItem li in ddlCountry.Items)
        {
            if (li.Selected == true)
            {
                lblMessage.Text += "<strong>" + li.Value.Trim() + " - " +
                                li.Text + "</strong>" + " <br />";
            }
            else
            {
                lblMessage.Text += li.Value.Trim() + " - " +
                                li.Text + "<br />";
            }
        }
    }
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        var items = (from ListItem li in ddlCountry.Items
                     where li.Selected == true
                     select li).ToList<ListItem>();

        foreach (ListItem li in items)
        {
            ddlCountry.Items.Remove(li);
        }
    }
}