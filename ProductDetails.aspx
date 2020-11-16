<%@ Page Title="" Language="C#" MasterPageFile="~/LandingPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="E_Billing.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:1000px; height:500px;background-color:dodgerblue">
 <form action="/action_page.php" class="was-validated">
     
  <div class="form-group" style="width:1000px;padding-left:300px;">
    <label for="pname">Product Name:<asp:TextBox CssClass="auto-style12" type="text" ID="TextBox1" placeholder="Enter Product Name" name="pname" runat="server" required Height="38px" Width="441px"></asp:TextBox>
      </label>
      &nbsp;</div>
     <div class="form-group" style="width:1000px;padding-left:300px;">
    <label for="pname">Product Price:<asp:TextBox CssClass="auto-style12" type="text" ID="TextBox2" placeholder="Enter Product Price" name="pprice" runat="server" required Height="38px" Width="441px"></asp:TextBox>
      </label>
      &nbsp;</div>
     <div class="form-group" style="width:1000px;padding-left:300px;">
    <label for="pname">Product Qty:<asp:TextBox CssClass="auto-style12" type="text" ID="TextBox3" placeholder="Enter Product Qty" name="pqty" runat="server" required Height="38px" Width="441px"></asp:TextBox>
      </label>
      &nbsp;</div>
     <div class="form-group" style="width:500px;padding-left:400px;">
         <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
     </div>
     <asp:Label ID="Label1" runat="server" ForeColor="green"></asp:Label>
</form>
</div>
</asp:Content>
