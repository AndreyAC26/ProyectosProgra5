<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="WebCobros.Forms.EditarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="text-center">
        <h2>Editar Cliente</h2>
    </div>

    <div class="container">

         <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">
             <div class="col-md-2 col-lg-2 col-lx-2 col-xs-12 col-sm-12" style="padding-top:5px">
                 <asp:Label ID="Label1" runat="server" Text="Empresa"></asp:Label>
             </div>

             <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12" style="padding-top:5px">
                <asp:DropDownList ID="ddlEmpresas" runat="server" DataTextField="Empresa" DataValueField="IdEmpresa" Width="100%"></asp:DropDownList>

             </div>

    </div>

    <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">

             <div class="col-md-2 col-lg-2 col-lx-2 col-xs-12 col-sm-12" style="padding-top:5px">
                 <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        </div>
    
           <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12" style="padding-top:5px">
               <asp:TextBox ID="txtNombre" runat="server" Width="100%"></asp:TextBox>
        </div>

        

    </div>

    <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">

        <div class="col-md-2 col-lg-2 col-lx-2 col-xs-12 col-sm-12" style="padding-top:5px">
            <asp:Label ID="Label6" runat="server" Text="Identificacion"></asp:Label>
        </div>
    
           <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12" style="padding-top:5px">
                       <asp:TextBox ID="txtIdentificacion" runat="server" Width="100%"></asp:TextBox>

        </div>


    </div>

    <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">

        <div class="col-md-2 col-lg-2 col-lx-2 col-xs-12 col-sm-12" style="padding-top:5px">
            <asp:Label ID="Label3" runat="server" Text="Correo"></asp:Label>
        </div>
    
           <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12" style="padding-top:5px">
                       <asp:TextBox ID="txtCorreo" runat="server" Width="100%"></asp:TextBox>

        </div>


    </div>

    <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">

                     <div class="col-md-2 col-lg-2 col-lx-2 col-xs-12 col-sm-12" style="padding-top:5px">
                         <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
        </div>
    
           <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12" style="padding-top:5px">
                       <asp:TextBox ID="txtTelefono" runat="server" Width="100%"></asp:TextBox>

        </div>


    </div>

    <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">

                     <div class="col-md-2 col-lg-2 col-lx-2 col-xs-12 col-sm-12" style="padding-top:5px">
                         <asp:Label ID="Label5" runat="server" Text="Direccion"></asp:Label>
        </div>
    
           <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12" style="padding-top:5px">
                       <asp:TextBox ID="txtDireccion" runat="server" Width="100%"></asp:TextBox>

        </div>


    </div>

         <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">

        <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="100%" />
        </div>
              </div>

       <div class="col-md-12 col-lg-12 col-lx-12 col-xs-12 col-sm-12">

        <div class="col-md-10 col-lg-10 col-lx-10 col-xs-12 col-sm-12">
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Width="100%" />
        </div>
            </div>
    </div>

</asp:Content>
