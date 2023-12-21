using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopitalManagementSystem.Views.Labrotarian
{
    public partial class LabTest : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            ShowLabTest();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            base.VerifyRenderingInServerForm(control);
        }

        public void ShowLabTest()
        {
            string Query = "Select *from Labtest_tbl";
            GV_LabTest.DataSource = con.GetDatas(Query);
            GV_LabTest.DataBind();
        }
        protected void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string User = Session["uid"] as string;
                string testname = lbtName.Value;
                string testcost = lbtcost.Value;
                
                String Query = "Insert into Labtest_tbl values('{0}','{1}','{2}')";
                Query = string.Format(Query, testname, testcost, User);
                con.SetDatas(Query);
                ShowLabTest();
                ErrMsg.InnerText = "Test Added..!";

                lbtName.Value="";
                lbtcost.Value="";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }


        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string testname = lbtName.Value;
                string testcost = lbtcost.Value;
                string Query = "Update Labtest_tbl set TestName='{0}',TestCost='{1}' where TestId='{2}'";
                Query = string.Format(Query, testname, testcost,GV_LabTest.SelectedRow.Cells[1].Text);
                con.SetDatas(Query);
                ShowLabTest();
                ErrMsg.InnerText = "Test Updated..!";

                lbtName.Value = "";
                lbtcost.Value = "";


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
                if (lbtName.Value == "")
                {
                    ErrMsg.InnerText = "Select a Test";
                }
                else
                {
                    string Query = "Delete from Labtest_tbl where TestId={0}";
                    Query = string.Format(Query,GV_LabTest.SelectedRow.Cells[1].Text);
                    con.SetDatas(Query);
                    
                    ShowLabTest();

                    ErrMsg.InnerText = "Test Deleted..!";
                    key = 0;
                    lbtName.Value = "";
                    lbtcost.Value = "";

                }

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void GV_LabTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbtName.Value = GV_LabTest.SelectedRow.Cells[2].Text;
            lbtcost.Value = GV_LabTest.SelectedRow.Cells[3].Text;
            if (lbtName.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(GV_LabTest.SelectedRow.Cells[1].Text);
            }
        }
    }
}