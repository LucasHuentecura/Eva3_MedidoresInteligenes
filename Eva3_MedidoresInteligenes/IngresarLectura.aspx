<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="Eva3_MedidoresInteligenes.IngresarLectura" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidoresList">Medidores</label>
                        <asp:Label runat="server" ID="mensajesLbl" CssClass="text-danger"></asp:Label>
                        <<asp:DropDownList runat="server" ID="medidoresList" CssClass="form-select" AppendDataBoundItems="true">
                            <asp:ListItem Text="Seleccione un medidor"></asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="form-group">
                        <label for="Calendar1">Seleccione la fecha</label>
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                    </div>

                    <div class="form-group">
                        <div class="row">
                            <div class="col-md-6">
                                <label for="horaList">Hora</label>
                                <<asp:DropDownList runat="server" ID="horaList" CssClass="form-select" AppendDataBoundItems="true">
                                    <asp:ListItem Text="00"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6">
                                <label for="minutosList">Minutos</label>
                                <<asp:DropDownList runat="server" ID="minutosList" CssClass="form-select" AppendDataBoundItems="true">
                                    <asp:ListItem Text="00"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="consumoTxt">Ingrese el consumo</label>
                        <asp:Label runat="server" ID="mensajeConsumo" CssClass="text-danger"></asp:Label>
                        <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
            <div class="text-center">
                <asp:Button runat="server" ID="guardarLectura" OnClick="guardarLectura_Click" CssClass="btn btn-dark btn-lg" Text="Guardar Lectura" />
            </div>
            </div>
        </div>
    </div>
</asp:Content>
