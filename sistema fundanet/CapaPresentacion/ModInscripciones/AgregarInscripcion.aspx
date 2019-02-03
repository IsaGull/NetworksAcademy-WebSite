<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarInscripcion.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModInscripciones.AgregarInscripcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<table  style="width:100%; text-align:center;">

    <tr>


        <td style="width: 672px">
                <img src="../Imagenes/ImagenInicio.png"/>
        </td>

          <td>

            <table style="width:60%; text-align:center;">
                <tr>
                    <td colspan="4">
                        <asp:Label ID="LabelTitulo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger" Text="Nueva Inscripción"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="LMensaje" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
                
 
                <tr>
                    <td colspan="2">
                          <asp:Label ID="LabelCodigo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Código Sección:"></asp:Label>               
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TBCodigo" runat="server" Width="130px"></asp:TextBox>
                    </td>  
                </tr>
                <tr>    
                     <td colspan="2">
                         <asp:Label ID="LabelCI" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="CI Alumno:"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TBCI" runat="server" Width="130px"></asp:TextBox>
                    </td>              
                </tr> 
                <tr>
                    <td colspan="4">

                        <asp:Button ID="BBuscar" runat="server" Text="Buscar" OnClick="BBuscar_Click" />

                        <br />

                        <br />

                    </td>
                </tr>                
                 <tr>
                    <td colspan="4">
                        <asp:Label ID="LabelSubTitulo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Sección:"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>                 
                <tr>
                    <td>
                        <asp:Label ID="LabelCurso2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Curso:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LCurso" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelModulo2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Módulo:"></asp:Label>
                    </td>
                    <td style="width: 148px">
                        <asp:Label ID="LModulo" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelCodigo2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Código:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LCodigo" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelCapacidad" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Capacidad:"></asp:Label>
                    </td>
                    <td style="width: 148px">
                        <asp:Label ID="LCapacidad" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelFechaI2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Inicio:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LFechaI" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelFechaF" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Fin:"></asp:Label>
                    </td>
                    <td style="width: 148px">
                        <asp:Label ID="LFechaF" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="width:50%; text-align:left;">
                             <asp:Label ID="LabelHorario" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Horario:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelCosto" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Costo: Bsf"></asp:Label>
                    </td>
                    <td style="width: 148px">
                        <asp:Label ID="LCosto" runat="server" Text=""></asp:Label>
                    </td>                    
                </tr>                
                <tr>
                    <td colspan="4" style="text-align:left; height: 36px;">

                        <asp:BulletedList ID="LHorario" runat="server" Height="20px" Width="297px">
                        </asp:BulletedList>
                    </td>
                </tr>
                 <tr>
                    <td colspan="4">
                        <br />
                        <asp:Label ID="Label2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Alumno:"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr> 
                <tr>
                    <td>
                         <asp:Label ID="LabelCI2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="CI:"></asp:Label>
                    </td>
                    <td>
                         <asp:Label ID="LCI" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelNomb" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Nombre:"></asp:Label>
                    </td>
                    <td style="width: 148px">
                         <asp:Label ID="LabelNombre" runat="server" Text=""></asp:Label>
                    </td>                    
                </tr>
                  <tr>
                    <td colspan="4">
                        <br />
                        <asp:Button ID="ButtonInscribir" runat="server" Text="Inscribir"  Width="95px" OnClick="ButtonInscribir_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="Volver" Width="95px" PostBackUrl="../ModInicio/Inicio.aspx" /> 
                    </td>
                </tr>

            </table>

        </td>

    </tr>

</table>



</asp:Content>
