<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Cursos.aspx.cs" Inherits="Presentacion.Cursos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<br />  
<asp:Panel ID="PanelForm" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <asp:Label ID="lblTitulo" runat="server" Text="Cursos"></asp:Label>
        </div>
        <div class="panel-body">
            <br />
            <div class="form-horizontal">
                <div class="form-group">
                    <label for="ddlTipoDocumento" class="col-sm-1 control-label">Cursos</label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="ddlCurso" runat="server" CssClass="form-control" AutoPostBack="true"  OnSelectedIndexChanged="ddlCurso_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
                <br />  
                <div Class="table table-responsive">   
                    <asp:GridView ID="gvCursosA" runat="server" CssClass="table table-responsive" AutoGenerateColumns="false" BorderStyle="Double">
                        <Columns>
                            <asp:BoundField DataField="IdCurso" HeaderText="Id" SortExpression="IdCurso" />
                            <asp:BoundField DataField="VerAlumno" HeaderText="Alumno" SortExpression="VerAlumno" />
                            <asp:BoundField DataField="Anio" HeaderText="Año" SortExpression="Anio" />
                            <asp:BoundField DataField="Semestre" HeaderText="Semestre" SortExpression="Semestre" />
                            <asp:BoundField DataField="NombreCurso" HeaderText="Curso" SortExpression="NombreCurso"/>
                            <asp:BoundField DataField="Turno" HeaderText="Turno" SortExpression="Turno"/>
                        </Columns>
                    </asp:GridView>
                </div>

                <br />  
                <div Class="table table-responsive">   
                    <asp:GridView ID="gvCursoP" runat="server" CssClass="table table-responsive" AutoGenerateColumns="false" BorderStyle="Double">
                        <Columns>
                            <asp:BoundField DataField="IdCurso" HeaderText="Id" SortExpression="IdCurso" />
                            <asp:BoundField DataField="VerProfesor" HeaderText="Profesor" SortExpression="VerProfesor" />
                            <asp:BoundField DataField="Anio" HeaderText="Año" SortExpression="Anio" />
                            <asp:BoundField DataField="Semestre" HeaderText="Semestre" SortExpression="Semestre" />
                            <asp:BoundField DataField="NombreCurso" HeaderText="Curso" SortExpression="NombreCurso"/>
                            <asp:BoundField DataField="Turno" HeaderText="Turno" SortExpression="Turno"/>
                        </Columns>
                    </asp:GridView>
                </div>
            </div >
        </div>
    </div>
</asp:Panel>

</asp:Content>

