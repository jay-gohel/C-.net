using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class ListControlDemo_ListBoxDemo : System.Web.UI.Page
{
    ArrayList ar1 = new ArrayList();  
    ArrayList ar2 = new ArrayList();  
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        foreach (ListItem li in lsbCountry.Items)
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
    protected void btnAddItem_Click(object sender, EventArgs e)
    {
        ListItem li = new ListItem();
        li.Text = txtCountryName.Text;
        li.Value = txtCountryCode.Text;

        lsbCountry.Items.Add(li);

        txtCountryName.Text = " ";
        txtCountryCode.Text = "";
    }
    protected void btnGrater_Click(object sender, EventArgs e)
    {
        if (lsbCountry.SelectedIndex >= 0)
        {
            for (int i = 0; i < lsbCountry.Items.Count; i++)  
            {  
                if (lsbCountry.Items[i].Selected)  
                {  
                    if (!ar1.Contains(lsbCountry.Items[i]))  
                    {  
                        ar1.Add(lsbCountry.Items[i]);  
                    }  
                }  
            }  
            for (int i = 0; i < ar1.Count; i++)  
            {
                if (!lsbSecond.Items.Contains(((ListItem)ar1[i])))  
                {  
                    lsbSecond.Items.Add(((ListItem)ar1[i]));  
                }  
                lsbCountry.Items.Remove(((ListItem)ar1[i]));  
            }  
            lsbSecond.SelectedIndex = -1;  
         
          
        }
    }
    protected void btnDoubleGrater_Click(object sender, EventArgs e)
    {
        while (lsbCountry.Items.Count != 0)
        {
            for (int i = 0; i < lsbCountry.Items.Count; i++)
            {
                lsbSecond.Items.Add(lsbCountry.Items[i]);
                lsbCountry.Items.Remove(lsbCountry.Items[i]);
            }
        }  
    }
    protected void btnLessthen_Click(object sender, EventArgs e)
    {
        if (lsbSecond.SelectedIndex >= 0)
        {
            for (int i = 0; i < lsbSecond.Items.Count; i++)
            {
                if (lsbSecond.Items[i].Selected)
                {
                    if (!ar2.Contains(lsbSecond.Items[i]))
                    {
                        ar2.Add(lsbSecond.Items[i]);
                    }
                }
            }
            for (int i = 0; i < ar2.Count; i++)
            {
                if (!lsbCountry.Items.Contains(((ListItem)ar2[i])))
                {
                    lsbCountry.Items.Add(((ListItem)ar2[i]));
                }
                lsbSecond.Items.Remove(((ListItem)ar2[i]));
            }
            lsbCountry.SelectedIndex = -1;
        }  
    }
    protected void btnDoubleLessthen_Click(object sender, EventArgs e)
    {
        while (lsbSecond.Items.Count != 0)
        {
            for (int i = 0; i < lsbSecond.Items.Count; i++)
            {
                lsbCountry.Items.Add(lsbSecond.Items[i]);
                lsbSecond.Items.Remove(lsbSecond.Items[i]);
            }
        }  
    }
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        var items = (from ListItem li in lsbCountry.Items 
                     where li.Selected == true
                     select li).ToList<ListItem>();

        foreach (ListItem li in items)
        {
            lsbCountry.Items.Remove(li);
        }

        txtCountryName.Text = "";
        txtCountryCode.Text = "";
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        
    }
}