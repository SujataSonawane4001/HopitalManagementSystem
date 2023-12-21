<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Doctors.aspx.cs" Inherits="HopitalManagementSystem.Views.Admin.Doctors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <h2>Doctor Details</h2>
                <form>
  <div class="mb-3">
    <label for="DocName" class="form-label">Doctor Name</label>
    <input type="text" class="form-control" id="DocName" runat="server"/>
  </div>
  <div class="mb-3">
    <label for="DocPhone" class="form-label">Phone</label>
    <input type="text" class="form-control" id="DocPhone" runat="server"/>
  </div>
                     <div class="mb-3">
    <label for="DocExp" class="form-label">Experience</label>
    <input type="text" class="form-control" id="DocExp" runat="server"/>
  </div>
                   <div class="mb-3">
    <label for="Docspe" class="form-label">Specialization</label>
    <input type="text" class="form-control" id="Docspe" runat="server"/>
  </div> 
  <div class="mb-3">
    <label for="docpwd" class="form-label">Password</label>
    <input type="text" class="form-control" id="docpwd" runat="server"/>
  </div>
                    <div class="mb-3">
    <label for="Docgen" class="form-label">Gender</label>
                        <asp:DropDownList ID="docgen" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
  </div> 
                    <div class="mb-3">
    <label for="Docaddr" class="form-label">Address</label>
    <input type="text" class="form-control" id="Docaddr" runat="server"/>
  </div> 
                    <div class="mb-3">
    <label for="Docdob" class="form-label">DOB</label>
    <input type="date" class="form-control" id="Docdob" runat="server"/>
  </div> 
                    <div class="mb-3">
    <label for="Docemail" class="form-label">Email</label>
    <input type="text" class="form-control" id="Docemail" runat="server"/>
  </div> 

  <label ID="ErrMsg" runat="server" class="text-danger"></label><br/>

                    <asp:Button ID="btn_add" runat="server" Text="Save" CssClass="btn btn-warning" OnClick="btn_add_Click"/>
                    <asp:Button ID="btn_edit" runat="server" Text="Edit" CssClass="btn btn-primary" OnClick="btn_edit_Click"/>
                    <asp:Button ID="btn_Del" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btn_Del_Click"/>
</form>
            </div>
            <div class="col-md-9">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/Doctors.jpg" height="200px" width="100%" class="rounded-3"/>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h5>Doctors Details Here</h5>
                        <asp:GridView ID="GV_doctor" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GV_doctor_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </div>
                </div>


            </div>
</div>


    </div>

</asp:Content>
