<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControlDeAcceso.aspx.cs" Inherits="ProyectoJCAA.Forms.ControlDeAcceso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<nav class="navbar navbar-primary">
  <div class="container-fluid col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12"> 
      <form class="navbar-form navbar-left" role="search" >
        <div class="form-group col-md-6 col-lg-6 col-xl-6 col-sm-12 col-xs-12">
          <input type="text" class="form-control" placeholder="Search" width="100%">
        </div>
          <div class="col-md-6 col-lg-6 col-xl-6 col-sm-12 col-xs-12">
        <button type="submit" class="btn btn-default">Submit</button>
          </div>
      </form>
    </div>
</nav>

</asp:Content>
