<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ADMIN</title>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            margin-top: 96px;
        }
        .auto-style2 {
            width: 462px;
            height: 168px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            margin-left: 8px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">

   <div class="container border border-primary text-center shadow p-3 mb-5 bg rounded" style=" background-color: #c3c5c9">

       <img alt="" class="auto-style2" src="images/im-B000672_hp-billboard_965x325.FINAL.ReachforGreat_new.jpg" />
       <br />
       <br />
       <br />
<div class="row">


<div class="col-md-2">

</div>
       <div class="col-md-8">

         <div class="form-group">
    <label for="exampleFormControlInput1">  <h2><b>Saisisez la Notification, elle sera envoyée par Email</b></h2></label>
  </div>

         <ul class="list-group list-group-flush" >

      <li class="list-group-item">
        <%--<br />--%>
        <asp:Label ID="Label6" runat="server" Text="Niveau :" Font-Bold="True"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 31px" Height="35px" Width="188px" AutoPostBack ="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem  Value="1" Text="Licence 1" ></asp:ListItem>
            <asp:ListItem Value="2">Licence 2</asp:ListItem>
            <asp:ListItem Value="3">Licence 3</asp:ListItem>
        </asp:DropDownList>
    
          <br />
    </li>
    <li class="list-group-item">
        <%--<br />--%>
        <asp:Label ID="Label1" runat="server" Text="Catégories :  " Font-Bold="True"></asp:Label>

        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 5px" Width="185px" AutoPostBack="true">
       <%--     <asp:ListItem>Algebre</asp:ListItem>--%>
           
        </asp:DropDownList>
      

    </li>


    <li class="list-group-item">
      <%--  <br />--%>

        <asp:Label ID="Label2" runat="server" Text="Sujet :" Font-Bold="True"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="415px" CssClass="auto-style4"></asp:TextBox>

        <br />

    </li>
    <li class="list-group-item">
        <%--<br />--%>
        <asp:Label ID="Label3" runat="server" Text="Description: " Font-Bold="True"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3" Width="393px" Height="53px" TextMode="MultiLine"></asp:TextBox>

        <br />

    </li>
    
    <li class="list-group-item">
        <%-- <br />--%>
         <asp:Label ID="Label5" runat="server" Text="Message :" Font-Bold="True"></asp:Label>
         <asp:TextBox ID="TextBox4" runat="server" Height="207px" Width="618px" style="margin-left: 28px" TextMode="MultiLine"></asp:TextBox>

    </li>
             <li class="list-group-item">
     <%--   <br />--%>
        <asp:Label ID="Label4" runat="server" Text="Image :" Font-Bold="True"></asp:Label>
                 <br />
                 <asp:FileUpload ID="FileUpload1" runat="server" />

        <br />
                 <hr />

    </li>
  </ul>
  <div >
      <asp:Button ID="Btn_save" runat="server"  OnClick="btn_save_Click"  style="margin-left: auto;margin-top: 20px;" Text="Envoyer"  Width="126px" />
  </div>
   <table style="width:100%">
  <asp:Label ID="lbl_msg" runat="server" Text=""></asp:Label>
    </table>
 </div>


 <div class="col-md-2">

 </div>


</div>

       &nbsp;</div>


    </div>
    </form>
</body>
</html>
