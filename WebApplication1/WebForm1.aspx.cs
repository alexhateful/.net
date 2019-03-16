using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "PreInit";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "Init";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "InitComplete";
        }
        protected override void OnPreLoad(EventArgs e)
        {
            //Work and It will assign the values to label.  
            //If the page is post back, then label contrl values will be loaded from view state.  
            //E.g: If you string str = lblName.Text, then str will contain viewstate values.  
            lblName.Text = lblName.Text + "<br/>" + "PreLoad";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "Load";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "btnSubmit_Click";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "LoadComplete";
        }
        protected override void OnPreRender(EventArgs e)
        {
            //Work and It will assign the values to label.  
            lblName.Text = lblName.Text + "<br/>" + "PreRender";
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            //Work and It will assign the values to label.  
            //But "SaveStateComplete" values will not be available during post back. i.e. View state.  
            lblName.Text = lblName.Text + "<br/>" + "SaveStateComplete";
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Work and it will not effect label contrl, view stae and post back data.  
            lblName.Text = lblName.Text + "<br/>" + "UnLoad";
        }


        public void Print_data(string data)
        {
            text.Text = data;
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt16(counter.Text);
            label1.Text = "current count = " + count*3 + "<br>";
            //label1.CssClass = "alert-success";

        }

        protected void email_TextChanged(object sender, EventArgs e)
        {
            Print_data(email.Text);
        }

        protected void radion_submit_Click(object sender, EventArgs e)
        {
            radio_result.Text = RadioButtonList1.SelectedValue;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioButtonList1.SelectedItem.Attributes.CssStyle.Add("color", "red");
        }
    }
}