using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationForInsert.ServiceReference1;

namespace WebApplicationForInsert
{
    public partial class _Default : Page
    {
        Service1Client objServiceClientobjService = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showdata();
            }
        }
        private void showdata()
        {
            DataSet ds = new DataSet();
            ds = objServiceClientobjService.SelectUserDetails();
            CategoriesGridView.DataSource = ds;
            CategoriesGridView.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "Update")
            {
                updateuserdetail();
                TextBoxUserName.Text = string.Empty;
                TextBoxPassword.Text = string.Empty;
                TextBoxCountry.Text = string.Empty;
                TextBoxEmail.Text = string.Empty;
                Button1.Text = "Submit";
            }
            else
            {
                insertuserdetail();
                showdata();
            }
        }
        private void insertuserdetail()
        {
            UserDetails userInfo = new UserDetails();
            userInfo.UserName = TextBoxUserName.Text;
            userInfo.Password = TextBoxPassword.Text;
            userInfo.Country = TextBoxCountry.Text;
            userInfo.Email = TextBoxEmail.Text;
            string result = objServiceClientobjService.InsertUserDetails(userInfo);
            LabelMessage.Text = result;
            showdata();
        }
        protected void CategoryButtonDelete_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            UserDetails userInfo = new UserDetails();
            userInfo.UserID = int.Parse(e.CommandArgument.ToString());
            objServiceClientobjService.DeleteUserDetails(userInfo);
            showdata();
        }
        protected void CategoryImageButtonEdit_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            UserDetails userInfo = new UserDetails();
            userInfo.UserID = int.Parse(e.CommandArgument.ToString());
            ViewState["UserId"] = userInfo.UserID;
            DataSet ds = new DataSet();
            ds = objServiceClientobjService.UpdateUserDetails(userInfo);
            if (ds.Tables[0].Rows.Count > 0)
            {
                TextBoxUserName.Text = ds.Tables[0].Rows[0]["UserName"].ToString();
                TextBoxPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                TextBoxCountry.Text = ds.Tables[0].Rows[0]["Country"].ToString();
                TextBoxEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                Button1.Text = "Update";
            }
        }
        private void updateuserdetail()
        {
            UserDetails userInfo = new UserDetails();
            userInfo.UserID = int.Parse(ViewState["UserId"].ToString());
            userInfo.UserName = TextBoxUserName.Text;
            userInfo.Password = TextBoxPassword.Text;
            userInfo.Country = TextBoxCountry.Text;
            userInfo.Email = TextBoxEmail.Text;
            objServiceClientobjService.UpdateRegistrationTable(userInfo);
            showdata();
        }
    }
}