using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopitalManagementSystem.Views.Doctors
{
    public partial class Prescription : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            ShowPrescript();
            GetTest();
            GetPatient();
        }
        public void ShowPrescript()
        {
            string Query = "Select *from Prescription_tbl";
            GV_prescript.DataSource = con.GetDatas(Query);
            GV_prescript.DataBind();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            base.VerifyRenderingInServerForm(control);
        }
        //get lab test
        public void GetTest()
        {
            string Query = "select *from Labtest_tbl";
            ddl_lbtest.DataTextField = con.GetDatas(Query).Columns["TestName"].ToString();
            ddl_lbtest.DataValueField = con.GetDatas(Query).Columns["TestId"].ToString();
            ddl_lbtest.DataSource= con.GetDatas(Query);
            ddl_lbtest.DataBind();
        }
        // get Patient 
        public void GetPatient()
        {
            string Query = "select *from Patient_tbl";
            ddl_pat.DataTextField = con.GetDatas(Query).Columns["PatName"].ToString();
            ddl_pat.DataValueField = con.GetDatas(Query).Columns["Patid"].ToString();
            ddl_pat.DataSource = con.GetDatas(Query);
            ddl_pat.DataBind();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int Doctor = 301;
                string patient = ddl_pat.SelectedValue.ToString();
                string medic = prmed.Value;
                string labtest = ddl_lbtest.SelectedValue.ToString();
                string cst = prcost.Value;
                
                String Query = "Insert into Prescription_tbl values('{0}',{1},'{2}',{3},'{4}')";
                Query = string.Format(Query,Doctor,patient,medic,labtest, cst);
                con.SetDatas(Query);
                ShowPrescript();
                ErrMsg.InnerText = "Prescription Added..!";

               
                prcost.Value = "";
                prmed.Value = "";
                ddl_pat.SelectedIndex = -1;
                ddl_lbtest.SelectedIndex = -1;

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }


        }
    }
}