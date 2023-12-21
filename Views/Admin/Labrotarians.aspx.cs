using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopitalManagementSystem.Views.Admin
{
    public partial class Labrotarians : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            ShowLab();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            base.VerifyRenderingInServerForm(control);
        }
        public void ShowLab()
        {
            string Query = "Select *from Labrotarian_tbl";
            GV_Lab.DataSource = con.GetDatas(Query);
            GV_Lab.DataBind();

        }


        protected void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string labname = lbName.Value;
                string labemail = lbemail.Value;
                string labpass = lbpwd.Value;
                string labphn = lbphone.Value;
                string labaddr = lbaddr.Value;
                string labgn = ddl_gen.SelectedItem.ToString();
                String Query = "Insert into Labrotarian_tbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = string.Format(Query, labname, labemail, labpass, labphn, labaddr, labgn);
                con.SetDatas(Query);
                ShowLab();
                ErrMsg.InnerText = "Laboratrian Added..!";

                lbName.Value = "";
                lbemail.Value="";
                lbpwd.Value="";
                lbphone.Value="";
                lbaddr.Value="";
                ddl_gen.SelectedIndex = -1;

            }
            catch(Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }


        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string labname = lbName.Value;
                string labemail = lbemail.Value;
                string labpass = lbpwd.Value;
                string labphn = lbphone.Value;
                string labaddr = lbaddr.Value;
                string labgn = ddl_gen.SelectedItem.ToString();
                string Query = "Update Labrotarian_tbl set LabName='{0}',LabEmail='{1}',LabPass='{2}',LabPhone='{3}',LabAddress='{4}',LabGen='{5}' where LabId='{6}'";
                Query = string.Format(Query, labname, labemail, labpass, labphn, labaddr, labgn, GV_Lab.SelectedRow.Cells[1].Text);
                con.SetDatas(Query);
                ShowLab();
                ErrMsg.InnerText = "Laboratrian Added..!";

                lbName.Value = "";
                lbemail.Value = "";
                lbpwd.Value = "";
                lbphone.Value = "";
                lbaddr.Value = "";
                ddl_gen.SelectedIndex = -1;


            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }


        }
        int key = 0;
        protected void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbName.Value == "")
                {
                    ErrMsg.InnerText = "Select a Laboratrian";
                }
                else
                {
                    string Query = "Delete from Labrotarian_tbl where LabId={0}";
                    Query = string.Format(Query, GV_Lab.SelectedRow.Cells[1].Text);
                    con.SetDatas(Query);
                    ShowLab();
                    ErrMsg.InnerText = "Labotarian Deleted..!";
                    key = 0;
                    lbName.Value = "";
                    lbemail.Value = "";
                    lbpwd.Value = "";
                    lbphone.Value = "";
                    lbaddr.Value = "";
                    ddl_gen.SelectedIndex = -1;
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void GV_Lab_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbName.Value = GV_Lab.SelectedRow.Cells[2].Text;
            lbemail.Value = GV_Lab.SelectedRow.Cells[3].Text;
            lbpwd.Value = GV_Lab.SelectedRow.Cells[4].Text;
            lbphone.Value = GV_Lab.SelectedRow.Cells[5].Text;
            lbaddr.Value = GV_Lab.SelectedRow.Cells[6].Text;
            ddl_gen.SelectedItem.Value= GV_Lab.SelectedRow.Cells[7].Text;
            if (lbName.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(GV_Lab.SelectedRow.Cells[1].Text);
            }

        }





    }
    }
