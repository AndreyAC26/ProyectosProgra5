<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empresa.aspx.cs" Inherits="WebCobros.Forms.Empresa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="row" style="margin-top:10px;margin-left:5px;">
            <div class="col-md-12">
                
            <asp:Button class="btn btn-default" ID="btnAgregar" runat="server" Text="Agregar" />
            <asp:Button class="btn btn-default" ID="btnEditar" runat="server" Text="Editar" />
            <asp:Button class="btn btn-default" ID="btnBorrar" runat="server" Text="Borrar" />
            </div>
    </div>
         </div>

     <div>
        <div>
            <div class="container">

                <asp:GridView ID="gridEmpresa" runat="server" Width="100%" Height="400px"></asp:GridView>
            </div>

        </div>
    </div>

    <div class="col-md-6 col-lg-6 col-xs-12 col-sm-12">
        <h1 style="text-align:center">Hola</h1>
    </div>

</asp:Content>
