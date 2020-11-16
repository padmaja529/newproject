<%@ Page Title="" Language="C#" MasterPageFile="~/LandingPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_Billing.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style12 {
            display: block;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
        }
        .auto-style13 {
            width: 165px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:1000px; height:500px;background-color:darkturquoise">
 <form action="/action_page.php" class="was-validated">
     <div class="form-group" style="width:480px;padding-left:450px;padding-top:40px">
         <label for="admin" style="font-size: 26px" class="auto-style13">AdminLogin</label>
     </div>
  <div class="form-group" style="width:1000px;padding-left:300px;">
    <label for="uname">Username:<asp:TextBox CssClass="auto-style12" type="text" ID="TextBox2" placeholder="Enter username" name="uname" runat="server" required Height="38px" Width="441px"></asp:TextBox>
      </label>
      &nbsp;</div>
  <div class="form-group" style="width:1000px;padding-left:300px;">
    <label for="pwd">Password:<asp:TextBox CssClass="auto-style12" type="password" ID="TextBox1" placeholder="Enter password" name="pswd" runat="server" required Height="36px" Width="440px"></asp:TextBox>
      </label>
      &nbsp;</div>
  <div class="form-group form-check" style="width:1000px;padding-left:300px;">
    <label class="form-check-label">
      <input class="form-check-input" type="checkbox" name="remember" required> I agree.
      <div class="invalid-feedback">Check this checkbox to continue.</div>
    </label>
  </div>
     <div class="form-group" style="width:500px;padding-left:400px;">
         <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
     </div>
     <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
</form>
</div>
</asp:Content>
