<%@ Page Title="Agregar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarCliente.aspx.cs" Inherits="WebCobros01.AgregarCliente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h2>Agregar Cliente</h2>
    </div>
    <div class="container">

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label1" runat="server" Text="Empresa"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                 <asp:DropDownList ID="ddlEmpresas" runat="server" DataTextField="Empresa" DataValueField="IdEmpresa" Width="100%" OnSelectedIndexChanged="ddlEmpresas_SelectedIndexChanged"  ></asp:DropDownList>
            </div>
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtNombre" runat="server" Width="100%"></asp:TextBox>
            </div>
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label6" runat="server" Text="Identificación"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtIdentificacion" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label3" runat="server" Text="Correo"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtCorreo" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label4" runat="server" Text="Teléfono"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtTelefono" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>

        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">
            <div class="col-md-2 col-lg-2 col-xl-2 col-sm-12 col-xs-12" style="padding-top:5px;">
                <asp:Label ID="Label5" runat="server" Text="Direccion"></asp:Label>
            </div>
            <div class="col-md-10 col-lg-10 col-xl-10 col-sm-12 col-xs-12" style="padding-top:5px;" >
                <asp:TextBox ID="txtDireccion" runat="server" Width="100%"></asp:TextBox>
            </div>
            
        </div>
        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12" style="padding-top:10px">
            <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">         

                <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" Width="100%" />

            </div>
        </div>
        <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12" style="padding-top:10px">
            <div class="col-md-12 col-lg-12 col-xl-12 col-sm-12 col-xs-12">         
                <asp:Button ID="btnCancelar" runat="server"  Text="Cancelar" Width="100%" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </div>

</asp:Content>
