<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Doctors/DoctorMaster.Master" AutoEventWireup="true" CodeBehind="Prescription.aspx.cs" Inherits="HopitalManagementSystem.Views.Doctors.Prescription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyBody" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Prescription Details</h2>
                <form>
                   
                    <div class="mb-3">
                        <label for="ddl_pat" class="form-label">Patient</label>
                        <asp:DropDownList ID="ddl_pat" runat="server" class="form-control">
                            
                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="prmed" class="form-label">Medicines</label>
                        <input type="text" class="form-control" id="prmed" runat="server"/>
                    </div>
                     <div class="mb-3">
                        <label for="ddl_lbtest" class="form-label">Labtest</label>
                        <asp:DropDownList ID="ddl_lbtest" runat="server" class="form-control">
                            
                        </asp:DropDownList>
                         </div>
                    <div class="mb-3">
                        <label for="prcost" class="form-label">Cost</label>
                        <input type="text" class="form-control" id="prcost" runat="server"/>
                    </div>
                    <div class="d-grid">
                   
                  <label ID="ErrMsg" runat="server" class="text-danger"></label><br/>
                    
                    <asp:Button ID="btn_save" runat="server" Text="Save Prescription" CssClass="btn btn-primary btn-block" OnClick="btn_save_Click" />
                    </div>
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
                        <h5>Prescription Details Here</h5>
                        <asp:GridView ID="GV_prescript" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" >
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
