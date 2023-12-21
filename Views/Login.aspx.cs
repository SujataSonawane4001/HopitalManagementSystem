using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopitalManagementSystem.Views
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();


        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            base.VerifyRenderingInServerForm(control);
        }
        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (ddl_role.SelectedIndex==0)
            {
                ErrMsg.InnerText = "Select a Role..!!";
            }else if(ddl_role.SelectedIndex == 1)
            {
                if(emailid.Value=="Admin@gmail.com" && pwd.Value =="Admin")
                {
                    string role = "Admin";
                    Session["uid"] = 1;
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/Doctors.aspx";
                    r_url = string.Format(r_url, role);
                    Response.Redirect(r_url);
                }
                else
                {
                    ErrMsg.InnerText = "Invalid Admin..!";
                }
            }
            else if (ddl_role.SelectedIndex == 2)
            {
              //  ErrMsg.InnerText = "Select a Doctor..!!";
                string Query = "Select  * from Doctor_tbl where DocEmail='{0}' and DocPass='{1}'";
                Query = string.Format(Query, emailid.Value, pwd.Value);
                DataTable dt = con.GetDatas(Query);
                if(dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Doctor..!";
                }
                else
                {
                    string role = "Doctors";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/Prescription.aspx";
                    r_url = string.Format(r_url, role);
                    Response.Redirect(r_url);
                }

            }
            else if (ddl_role.SelectedIndex == 3)
            {
                // ErrMsg.InnerText = "Select a Receptionist!!";
                string Query = "Select  * from Receptionist_tbl where RecEmail='{0}' and RecPassword='{1}'";
                Query = string.Format(Query, emailid.Value, pwd.Value);
                DataTable dt = con.GetDatas(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Recptionsidt..!";
                }
                else
                {
                    string role = "Receptionist";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/Patients.aspx";
                    r_url = string.Format(r_url, role);
                    Response.Redirect(r_url);
                }


            }
            else if (ddl_role.SelectedIndex == 4)
            {
                //ErrMsg.InnerText = "Select a Labrotarian..!!";
                string Query = "Select  * from Labrotarian_tbl where LabEmail='{0}' and LabPass='{1}'";
                Query = string.Format(Query, emailid.Value, pwd.Value);
                DataTable dt = con.GetDatas(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Laboratrian..!";
                }
                else
                {
                    string role = "Labrotarian";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "{0}/LabTest.aspx";
                    r_url = string.Format(r_url, role);
                    Response.Redirect(r_url);
                }


            }
        }
    }
}