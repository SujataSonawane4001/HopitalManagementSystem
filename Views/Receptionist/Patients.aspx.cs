using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopitalManagementSystem.Views.Receptionist
{
    public partial class Patients : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            ShowPatientList();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            base.VerifyRenderingInServerForm(control);
        }
        public void ShowPatientList()
        {
            string Query = "Select *from Patient_tbl";
            GV_Rpatient.DataSource = con.GetDatas(Query);
            GV_Rpatient.DataBind();

        }


        protected void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string User = Session["uid"] as string;
                string ptname = r_ptName.Value;
                string ptphone = r_pphone.Value;
                string ptgen = ddl_rpgen.SelectedItem.ToString();
                string ptdob = r_pdob.Value;
                string ptaddr = r_paddr.Value;
                string ptallergy = r_pallergy.Value;
                String Query = "Insert into Patient_tbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                Query = string.Format(Query, ptname, ptphone, ptgen, ptdob, ptaddr, ptallergy, User);
                con.SetDatas(Query);
                ShowPatientList();
                ErrMsg.InnerText = "Patient Added..!";

                r_ptName.Value = "";
                r_pphone.Value = "";
                r_pdob.Value = "";
                r_paddr.Value = "";
                r_pallergy.Value = "";
                ddl_rpgen.SelectedIndex = -1;

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
                string ptname = r_ptName.Value;
                string ptphone = r_pphone.Value;
                string ptgen = ddl_rpgen.SelectedItem.ToString();
                string ptdob = r_pdob.Value;
                string ptaddr = r_paddr.Value;
                string ptallergy = r_pallergy.Value;
                string Query = "Update Patient_tbl set PatName='{0}',PatPhone='{1}',PatGen='{2}',PatDob='{3}',PatAdd='{4}',PatAllergy='{5}' where Patid='{6}'";
                Query = string.Format(Query, ptname, ptphone, ptgen, ptdob, ptaddr, ptallergy, GV_Rpatient.SelectedRow.Cells[1].Text);
                con.SetDatas(Query);
                ShowPatientList();
                ErrMsg.InnerText = "Patient Updated..!";

                r_ptName.Value = "";
                r_pphone.Value = "";
                r_pdob.Value = "";
                r_paddr.Value = "";
                r_pallergy.Value = "";
                ddl_rpgen.SelectedIndex = -1;

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
                if (r_ptName.Value == "")
                {
                    ErrMsg.InnerText = "Select a Patient";
                }
                else
                {
                    string Query = "Delete from Patient_tbl where Patid={0}";
                    Query = string.Format(Query, GV_Rpatient.SelectedRow.Cells[1].Text);
                    con.SetDatas(Query);
                    ShowPatientList();
                    ErrMsg.InnerText = "Patient Deleted..!";
                    key = 0;
                    r_ptName.Value = "";
                    r_pphone.Value = "";
                    r_pdob.Value = "";
                    r_paddr.Value = "";
                    r_pallergy.Value = "";
                    ddl_rpgen.SelectedIndex = -1;
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }

        }

        protected void GV_Rpatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_ptName.Value = GV_Rpatient.SelectedRow.Cells[2].Text;
            r_pphone.Value = GV_Rpatient.SelectedRow.Cells[3].Text;
            ddl_rpgen.SelectedItem.Value = GV_Rpatient.SelectedRow.Cells[4].Text;
            r_pdob.Value = GV_Rpatient.SelectedRow.Cells[5].Text;
            r_paddr.Value = GV_Rpatient.SelectedRow.Cells[6].Text;
            r_pallergy.Value = GV_Rpatient.SelectedRow.Cells[7].Text;
            
            if (r_ptName.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(GV_Rpatient.SelectedRow.Cells[1].Text);
            }


        }
    }
}