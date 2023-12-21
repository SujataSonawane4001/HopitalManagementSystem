<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HopitalManagementSystem.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Libs/Bootsrap/css/bootstrap.min.css" />
    <link rel="stylesheet" href="../CSS/Login.css" />
</head>
<body style="background-image:url(../Assets/Images/Login.jpg);background-size:cover">
    <div class="container-fluid">
        <div class="row" style="height:120px"></div>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-5 bg-light shadow-lg opacity-75 rounded-3">
                <h1 class="T pl-3 text-primary text-center">Heaven Care Clinic</h1>
                  <form id="form1" runat="server">
  <div class="mb-3">
    <label for="emailid" class="form-label">Email address</label>
    <input type="email" class="form-control" id="emailid" aria-describedby="emailid" runat="server"/>
  </div>
  <div class="mb-3">
    <label for="pwd" class="form-label">Password</label>
    <input type="text" class="form-control" id="pwd" runat="server"/>
  </div>
   <div class="mb-3 form-check">
                        
                        <asp:DropDownList ID="ddl_role" runat="server" class="form-control">
                            <asp:ListItem>Select Role</asp:ListItem>
                            <asp:ListItem>Admin</asp:ListItem>
                             <asp:ListItem>Doctors</asp:ListItem>
                            <asp:ListItem>Receptionist</asp:ListItem>
                             <asp:ListItem>Labrotarian</asp:ListItem>
                             
                        </asp:DropDownList>
                         </div>
                      <div class="d-grid">
                          <label id="ErrMsg" runat="server" class="text-danger"></label><br/>
                    
                                              <asp:Button ID="btn_login" runat="server" Text="Login" CssClass="btn btn-primary btn-block" OnClick="btn_login_Click"  />

                      </div>
                      <br />
</form>
            </div>
            <div class="col-md-3"></div>
        </div>
    </div>
  
</body>
</html>
