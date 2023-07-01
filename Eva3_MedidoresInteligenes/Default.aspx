<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Eva3_MedidoresInteligenes.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajesLbl" CssClass="text-success"> </asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="serialNumberTxt">Número de Série</label>
                        <asp:TextBox ID="serialNumberTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="typeList"></label>
                        <asp:DropDownList ID="typeList" runat="server" CssClass="form-select" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione una opción"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group text-center">
                        <asp:Button ID="agregarBtn" runat="server" OnClick="agregarBtn_Click" Text="Guardar" CssClass="btn btn-primary btn-large" />
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
