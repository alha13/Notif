<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user.aspx.cs" Inherits="user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Utilisateur</title>
        <script src="js/bootstrap.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/bootstrap-grid.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            margin-left: 0;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="container text-center" style="background-color: #c3c5c9; height: 900px; text-align: center">
       <div class="row" style="height: 100px;">

       </div>
       <div class="row" >
         <div class="container" style="text-align: center">
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
         <h2><b>Service de Notification par Email</b></h2>
       </div>
       </div>
         <hr />



     <div class="container" style="text-align: center">
          <div class="row"  style="text-align: center">
            <div class="col-md-4">
                <div class="card">
  <div class="card-header" style="background-color: #d3dee8;">
    
     <%-- licence 1--%>
      <asp:RadioButton ID="licence1" runat="server" Text="LICENCE I" GroupName="licence" />
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item"><%--<br />--%>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Algèbres" ValidationGroup="g" />


    </li>
    <li class="list-group-item">
      <%--  <br />--%>
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Logiques" />


    </li>
    <li class="list-group-item">
        <%--<br />--%>
        <asp:CheckBox ID="CheckBox4" runat="server" Text="Architectures" />


    </li>
    <li class="list-group-item">
     <%--   <br />--%>
        <asp:CheckBox ID="CheckBox5" runat="server" Text="Analyses" />


    </li>
    <li class="list-group-item">
        <%-- <br />--%>
        <asp:CheckBox ID="CheckBox6" runat="server" Text="Projet Perso" />


    </li>
  </ul>
</div>
            </div>

            <div class="col-md-4">
                <div class="card">
  <div class="card-header" style="background-color: #f9d4ef;">

      <%--LICENCE 2--%>
    <asp:RadioButton ID="licence2" runat="server" Text="LICENCE II" GroupName="licence" />
     
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item">
       <%-- <br />--%>
        <asp:CheckBox ID="CheckBox7" runat="server" Text="PHP" />


    </li>
    <li class="list-group-item">
       <%-- <br />--%>
        <asp:CheckBox ID="CheckBox8" runat="server" Text="Algèbres" />


    </li>
    <li class="list-group-item">
      <%--  <br />--%>
        <asp:CheckBox ID="CheckBox9" runat="server" Text="Analyses" />


    </li>
    <li class="list-group-item">
        <%--<br />--%>
        <asp:CheckBox ID="CheckBox10" runat="server"  Text="Comptabilités" />


    </li>
    <li class="list-group-item">
      <%-- <br />--%>
        <asp:CheckBox ID="CheckBox11" runat="server" Text=" C#" />


    </li>
  </ul>
</div>
            </div>




            <div class="col-md-4">
                <div class="card">
  <div class="card-header" style="background-color: #efc6bf; text-color: #ffff">

    <%--  Licence 3--%>
     <asp:RadioButton ID="licence3" runat="server" Text="LICENCE III" GroupName="licence" />
  </div>
  <ul class="list-group list-group-flush">
    <li class="list-group-item">
        <%--<asp:Label ID="Label11" runat="server" Text="GRH"></asp:Label> <br />--%>
        <asp:CheckBox ID="CheckBox12" runat="server" Text="GRH" />

    </li>
    <li class="list-group-item">
      <%--  <asp:Label ID="Label12" runat="server" Text="Label">ISI</asp:Label> <br />--%>
        <asp:CheckBox ID="CheckBox13" runat="server" Text="ISI" />

    </li>
    <li class="list-group-item">
        <%--<asp:Label ID="Label13" runat="server" Text="Label"> PHP</asp:Label> <br />--%>
        <asp:CheckBox ID="CheckBox14" runat="server" Text="PHP" />


    </li>
    <li class="list-group-item">
       <%-- <asp:Label ID="Label14" runat="server" Text="Label">ASP .Net</asp:Label> <br />--%>
        <asp:CheckBox ID="CheckBox15" runat="server" Text="ASP .Net" />


    </li>
    <li class="list-group-item">
       <%-- <asp:Label ID="Label15" runat="server" Text="Label">Optimisations</asp:Label> <br />--%>
        <asp:CheckBox ID="CheckBox16" runat="server" Text="Optimisations" />


    </li>
  </ul>
</div>
            </div>


          </div>
          <hr />
          <div class="row" style="height: 30px;">

          </div>
          <div class="row"  style="text-align: center">
            <div class="col-md-4">

            </div>

            <div class="col-md-4">

                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Width="216px" TextMode="Email" ></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Souscrir"  style=" width: auto;" Font-Bold="True" Font-Size="Medium" OnClick="Souscrir"/>
                <br />
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" color ="red" ForeColor="Red"></asp:Label>
            </div>
            <div class="col-md-4">

                

            </div>
          </div>

         <div class="row" style="height: 100px;">

          </div>

         <hr />
        </div>
        <div class="row" >
          <div class="container" style="height: 100px; text-align:center">
          <%--  <h5 style="text-align:center">Tous drots résevés </h5>--%>
          </div>

     </div>
        </div>

    </div>

    </form>

</body>
</html>
