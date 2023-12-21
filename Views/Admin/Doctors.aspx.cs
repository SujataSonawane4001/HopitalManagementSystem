using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HopitalManagementSystem.Views.Admin
{
    public partial class Doctors : System.Web.UI.Page
    {
        Models.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Models.Functions();
            ShowDoctor();


        }
        //Add this override method
        public override void VerifyRenderingInServerForm(Control control)
        {
            base.VerifyRenderingInServerForm(control);
        }
        private void ShowDoctor()
        {
            string Query = "Select *from Doctor_tbl";
            GV_doctor.DataSource = con.GetDatas(Query);
            GV_doctor.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string Dname = DocName.Value;
                string Dphone = DocPhone.Value;
                string Dexp = DocExp.Value;
                string Dspe = Docspe.Value;
                string Dgen = docgen.SelectedItem.ToString();
                string DAdd = Docaddr.Value;
                string Ddob = Docdob.Value;
                string Dpass = docpwd.Value;
                string Demail = Docemail.Value;
                string Query = "Insert into Doctor_tbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                Query = string.Format(Query, Dname, Dphone, Dexp, Dspe, Dgen, DAdd, Ddob, Dpass, Demail);
                con.SetDatas(Query);
                ShowDoctor();
                ErrMsg.InnerText = "Doctor Added...!";

                DocName.Value="";
                 DocPhone.Value="";
                DocExp.Value= "";
                 Docspe.Value="";
                docgen.SelectedIndex = -1;
                Docaddr.Value="";
                 Docdob.Value="";
                 docpwd.Value="";
                Docemail.Value = "";


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
                string Dname = DocName.Value;
                string Dphone = DocPhone.Value;
                string Dexp = DocExp.Value;
                string Dspe = Docspe.Value;
                string Dgen = docgen.SelectedItem.ToString();
                string DAdd = Docaddr.Value;
                string Ddob = Docdob.Value;
                string Dpass = docpwd.Value;
                string Demail = Docemail.Value;
                string Query = "Update Doctor_tbl set DocName='{0}',DocPhone='{1}',DocExp='{2}',DocSpec='{3}',DocGen='{4}',DocAdd='{5}',DocDob='{6}',DocPass='{7}',DocEmail='{8}' where DocId='{9}'";
                Query = string.Format(Query, Dname, Dphone, Dexp, Dspe, Dgen, DAdd, Ddob, Dpass,Demail, GV_doctor.SelectedRow.Cells[1].Text);
                con.SetDatas(Query);
                ShowDoctor();
                ErrMsg.InnerText = "Doctor Updated...!";

                DocName.Value = "";
                DocPhone.Value = "";
                DocExp.Value = "";
                Docspe.Value = "";
                docgen.SelectedIndex = -1; 
                Docaddr.Value = "";
                Docdob.Value = "";
                docpwd.Value = "";
                Docemail.Value = "";

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
                if (DocName.Value == "")
                {
                    ErrMsg.InnerText = "Select a Receptionist";
                }
                else
                {
                    string Query = "Delete from Doctor_tbl where DocId={0}";
                    Query = string.Format(Query,GV_doctor.SelectedRow.Cells[1].Text);
                    con.SetDatas(Query);
                    ShowDoctor();
                    ErrMsg.InnerText = "Doctor Deleted..!";
                    key = 0;
                    DocName.Value = "";
                    DocPhone.Value = "";
                    DocExp.Value = "";
                    Docspe.Value = "";
                    docgen.SelectedIndex = -1;
                    Docaddr.Value = "";
                    Docdob.Value = "";
                    docpwd.Value = "";
                    Docemail.Value = "";
                }

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void GV_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocName.Value = GV_doctor.SelectedRow.Cells[2].Text; 
            DocPhone.Value = GV_doctor.SelectedRow.Cells[3].Text;
            DocExp.Value  = GV_doctor.SelectedRow.Cells[4].Text;
            Docspe.Value = GV_doctor.SelectedRow.Cells[5].Text;
            docgen.SelectedItem.Value = GV_doctor.SelectedRow.Cells[6].Text;
            Docaddr.Value = GV_doctor.SelectedRow.Cells[7].Text;
            Docdob.Value = GV_doctor.SelectedRow.Cells[8].Text;
            docpwd.Value = GV_doctor.SelectedRow.Cells[9].Text;
            Docemail.Value = GV_doctor.SelectedRow.Cells[10].Text;

            if (DocName.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(GV_doctor.SelectedRow.Cells[1].Text);
            }

        }
    }
}