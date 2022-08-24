<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agregar_Articulos.aspx.cs" Inherits="EX2OAAC.Formularios.Agregar_Articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h2>Agregar Articulo</h2>
    </div>
    <div class="container">


        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label2" runat="server" Text="Codigo del Articulo"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtCodigo" runat="server" Width="100%"></asp:TextBox>
            </div>
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label6" runat="server" Text="Descripción"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtDescripcion" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label3" runat="server" Text="Marca"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtMarca" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label4" runat="server" Text="Categoria"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtCategoria" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label5" runat="server" Text="Precio de Venta"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtPrecioVenta" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>
        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12" style="padding-top:10px">
            <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">         

                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="100%" OnClick="btnGuardar_Click" />

            </div>
        </div>

    </div>

</asp:Content>
