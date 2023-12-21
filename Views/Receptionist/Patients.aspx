<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Receptionist/ReceptionistMaster.Master" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="HopitalManagementSystem.Views.Receptionist.Patients" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Patient Details</h2>
                <form>
                    <div class="mb-3">
                        <label for="r_ptName" class="form-label">Name</label>
                        <input type="text" class="form-control" id="r_ptName" runat="server"/>
                    </div>
                    <div class="mb-3">
                        <label for="r_pphone" class="form-label">Phone</label>
                        <input type="text" class="form-control" id="r_pphone" runat="server"/>
                    </div>
                    <div class="mb-3">
                         <div class="mb-3">
                        <label for="ddl_rpgen" class="form-label">Gender</label>
                        <asp:DropDownList ID="ddl_rpgen" runat="server">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                        <label for="r_pdob" class="form-label">DOB</label>
                        <input type="date" class="form-control" id="r_pdob" runat="server" />
                    </div>
                    <div class="mb-3">
                        <label for="r_paddr" class="form-label">Address</label>
                        <input type="text" class="form-control" id="r_paddr" runat="server"/>
                    </div>
                    <div class="mb-3">
                        <label for="r_pallergy" class="form-label">Allergies</label>
                        <input type="text" class="form-control" id="r_pallergy" runat="server"/>
                    </div>
                    
                    

                   
                  <label ID="ErrMsg" runat="server" class="text-danger"></label><br/>

                    <asp:Button ID="btn_add" runat="server" Text="Save" CssClass="btn btn-warning" OnClick="btn_add_Click"  />
                    <asp:Button ID="btn_edit" runat="server" Text="Edit" CssClass="btn btn-primary" OnClick="btn_edit_Click"  />
                    <asp:Button ID="btn_Del" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btn_Del_Click" />
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/Laboratories.jpg" height="200px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h5>Patient List</h5>
                        <asp:GridView ID="GV_Rpatient" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GV_Rpatient_SelectedIndexChanged" >
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
