<%@ Page Title="" Language="C#" MasterPageFile="~/PrincipalMaster.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="Eva3_MedidoresInteligenes.VerMedidores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Medidores</h3>
                </div>
                <div class="card-body">
                    <asp:GridView ID="grillaMedidor" CssClass="table table-hover table-bordered" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="false" runat="server">
                        <Columns>
                            <asp:BoundField DataField="serialNumber" HeaderText="Número de Série" />
                            <asp:BoundField DataField="type" HeaderText="Tipo de medidor" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="ingresarLectura" CommandArgument='<%# Eval("serialNumber") %>' runat="server" CssClass="btn btn-danger" Text="Ingresar Lectura" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
