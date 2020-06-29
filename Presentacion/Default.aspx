<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentacion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<br />  
<asp:Panel ID="PanelList" runat="server">  
    <div class="panel panel-primary">
        <div class="panel-body text-center">
            <div>   
                <asp:GridView ID="gvAlumnos" runat="server" CssClass="table table-responsive" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                        <asp:BoundField DataField="TipoDocumento" HeaderText="TipoDocumento" SortExpression="TipoDocumento" />
                        <asp:BoundField DataField="NroDocumento" HeaderText="Documento" SortExpression="NroDocumento"/>
                        <asp:BoundField DataField="FechaIngreso" HeaderText="Fecha Ingreso" SortExpression="FechaIngreso" DataFormatString="{0:MM/dd/yyyy}"/>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HyperLink ID="hlDetalle" runat="server" NavigateUrl='<%# "~/Default.aspx?id=" + Eval("IdAlumno") + "&modo=detalle" %>'>Detalle</asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Panel>

<asp:Panel ID="PanelForm" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <asp:Label ID="lblTitulo" runat="server" Text="Alumnos"></asp:Label>
        </div>
        <div class="panel-body">
            <br />
            <div class="form-horizontal">
                <div class="form-group">
                    <label for="txtNombre" class="col-sm-2 control-label">Nombre</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" MaxLength="40"></asp:TextBox>
                    </div>
                    <label for="txtApellido" class="col-sm-2 control-label">Apellido</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" MaxLength="40"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="ddlTipoDocumento" class="col-sm-2 control-label">Tipo Documento</label>
                    <div class="col-sm-4">
                        <asp:DropDownList ID="ddlTipoDocumento" runat="server" CssClass="form-control">
                            <asp:ListItem>Dni</asp:ListItem>
                            <asp:ListItem>Pasaporte</asp:ListItem>
                            <asp:ListItem>Dni</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <label for="txtDocumento" class="col-sm-2 control-label">Documento</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" MaxLength="40"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="ddlSexo" class="col-sm-2 control-label">Sexo</label>
                    <div class="col-sm-4">
                        <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                            <asp:ListItem>Femenino</asp:ListItem>
                            <asp:ListItem>Masculino</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <label for="txtFechaNacimiento" class="col-sm-2 control-label">Fecha Nacimiento</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtDomicilio" class="col-sm-2 control-label">Domicilio</label>
                    <div class="col-sm-10">
                        <asp:TextBox ID="txtDomicilio" runat="server" CssClass="form-control" MaxLength="300" TextMode="MultiLine" Width="100%"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label for="ddlCarrera" class="col-sm-2 control-label">Carrera</label>
                    <div class="col-sm-4">
                        <asp:DropDownList ID="ddlCarrera" runat="server" CssClass="form-control">
                            <asp:ListItem>Ingenieria en Computacion</asp:ListItem>
                            <asp:ListItem>Ingenieria Electronica</asp:ListItem>
                            <asp:ListItem>Ingenieria en Sistemas</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <label for="txtFechaIngreso" class="col-sm-2 control-label">Fecha Ingreso</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtFechaIngreso" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    </div>
                </div>
            </div >
            <br />
            <div class="text-danger">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" Operator="LessThan" Type="Date" ControlToValidate="txtFechaNacimiento"></asp:CompareValidator> <br />   
                <asp:RequiredFieldValidator ID="ValidatorNombre" runat="server" ErrorMessage="El nombre del alumno es obligatorio." ControlToValidate="txtNombre"></asp:RequiredFieldValidator> <br />   
                <asp:RequiredFieldValidator ID="ValidatorApellido" runat="server" ErrorMessage="El apellido del alumno es obligatorio." ControlToValidate="txtApellido"></asp:RequiredFieldValidator> <br /> 
                <asp:RequiredFieldValidator ID="ValidatorDocumento" runat="server" ErrorMessage="El documento del alumno es obligatorio." ControlToValidate="txtDocumento"></asp:RequiredFieldValidator> <br /> 
                <asp:RequiredFieldValidator ID="ValidatorFechaNacimiento" runat="server" ErrorMessage="La fecha de nacimiento del alumno es obligatorio." ControlToValidate="txtFechaNacimiento"></asp:RequiredFieldValidator> <br /> 
                <asp:RequiredFieldValidator ID="ValidatorFechaIngreso" runat="server" ErrorMessage="La fecha de ingreso es obligatorio." ControlToValidate="txtFechaIngreso"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="panel-footer">
            <div class="text-right">
                <asp:Button ID="btnLimpiar" runat="server" CssClass="btn btn-primary" Text="Limpiar" OnClick="btnLimpiar_Click" />
                <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="Guardar" OnClick="btnAceptar_Click" />
            </div>
        </div>
    </div>
</asp:Panel>
</asp:Content>
