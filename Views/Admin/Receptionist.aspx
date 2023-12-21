﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Receptionist.aspx.cs" Inherits="HopitalManagementSystem.Views.Admin.Receptionist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">

     <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Receptionist Details</h2>
                <form>
                    <div class="mb-3">
                        <label for="rcName" class="form-label">Name</label>
                        <input type="text" class="form-control" id="rcName" runat="server" required="required" />
                    </div>
                    <div class="mb-3">
                        <label for="rcemail" class="form-label">Email</label>
                        <input type="email" class="form-control" id="rcemail" runat="server" required="required" />
                    </div>
                    <div class="mb-3">
                        <label for="rcaddr" class="form-label">Address</label>
                        <input type="text" class="form-control" id="rcaddr" runat="server" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="rcphone" class="form-label">Phone</label>
                        
                        <input type="text" class="form-control" id="rcphone" runat="server" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="rcpwd" class="form-label">Password</label>
                        <input type="text" class="form-control" id="rcpwd" runat="server" required="required"/>
                    </div>
                    <label ID="ErrMsg" runat="server" class="text-danger"></label><br/>

                   

                    <asp:Button ID="btn_add" runat="server" Text="Save" CssClass="btn btn-warning" OnClick="btn_add_Click" />
                    <asp:Button ID="btn_edit" runat="server" Text="Edit" CssClass="btn btn-primary" OnClick="btn_edit_Click" />
                    <asp:Button ID="btn_Del" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btn_Del_Click"/>
                    
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/hospital.jpg" height="200px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h5>Receptionist Details Here</h5>
                        <asp:GridView ID="GV_Reception" class="table table-hover" runat="server" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GV_Reception_SelectedIndexChanged">
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
