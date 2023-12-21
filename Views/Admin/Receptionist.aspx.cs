using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopitalManagementSystem.Views.Admin
{
    public partial class Receptionist : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            ShowReceptionist();

        }
        //Add this oveerid method
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }
        private void ShowReceptionist()
        {
            string Query = "Select *from Receptionist_tbl";
            GV_Reception.DataSource = con.GetDatas(Query);
            GV_Reception.DataBind();
        }
        protected void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string Rname = rcName.Value;
                string Remail = rcemail.Value;
                string RAdd = rcaddr.Value;
                string RPhone = rcphone.Value;
                string Rpass= rcpwd.Value;
                string Query = "Insert into Receptionist_tbl values('{0}','{1}','{2}','{3}','{4}')";
                Query = string.Format(Query, Rname, Remail, RAdd, RPhone, Rpass);
                con.SetDatas(Query);
                ShowReceptionist();
                ErrMsg.InnerText = "Receptionist Added...!";

                rcName.Value="";
                rcemail.Value="";
                rcaddr.Value="";
                rcphone.Value="";
                rcpwd.Value="";


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
                string Rname = rcName.Value;
                string Remail = rcemail.Value;
                string RAdd = rcaddr.Value;
                string RPhone = rcphone.Value;
                string Rpass = rcpwd.Value;
                string Query = "Update Receptionist_tbl set RecName='{0}',RecEmail='{1}',RecAdd='{2}',RecPhone='{3}',RecPassword='{4}' where RecId='{5}'";
                Query = string.Format(Query, Rname, Remail, RAdd, RPhone, Rpass, GV_Reception.SelectedRow.Cells[1].Text);
                con.SetDatas(Query);
                ShowReceptionist();
                ErrMsg.InnerText = "Receptionist Updated...!";

                rcName.Value = "";
                rcemail.Value = "";
                rcaddr.Value = "";
                rcphone.Value = "";
                rcpwd.Value = "";


            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                if(rcName.Value=="")
                {
                    ErrMsg.InnerText = "Select a Recetionist";
                }
                else
                {
                    string Query = "Delete from Receptionist_tbl where RecId={0}";
                    Query = string.Format(Query,GV_Reception.SelectedRow.Cells[1].Text);
                    con.SetDatas(Query);
                    ShowReceptionist();
                    ErrMsg.InnerText = "Receptionist Deleted..!";
                    key = 0;
                    rcName.Value = "";
                    rcemail.Value = "";
                    rcaddr.Value = "";
                    rcphone.Value = "";
                    rcpwd.Value = "";
                }
                
            }
            catch(Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        int key = 0;
        protected void GV_Reception_SelectedIndexChanged(object sender, EventArgs e)
        {
            rcName.Value = GV_Reception.SelectedRow.Cells[2].Text;
            rcemail.Value = GV_Reception.SelectedRow.Cells[3].Text;
            rcaddr.Value = GV_Reception.SelectedRow.Cells[4].Text;
            rcphone.Value = GV_Reception.SelectedRow.Cells[5].Text;
            rcpwd.Value = GV_Reception.SelectedRow.Cells[6].Text;

            if(rcName.Value=="")
            {
                key = 0;
            }else
            {
                key = Convert.ToInt32(GV_Reception.SelectedRow.Cells[1].Text);
            }

        }
    }
}