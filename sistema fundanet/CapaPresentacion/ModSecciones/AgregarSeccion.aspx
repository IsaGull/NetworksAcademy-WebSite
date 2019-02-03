<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarSeccion.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModSecciones.AgregarSeccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 <table style="width:100%; text-align:center;">

    <tr>


       <td style="width: 100px">
            <img class="img" src="../Imagenes/ImagenInicio.png" />
        </td>

        <td style="width: 100px">

            <table style="width:50%; text-align:center;">
                <tr>
                    <td colspan="4">
                        <asp:Label ID="LabelTitulo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger" Text="Agregar Sección"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                          <asp:Label ID="LabelCurso" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Curso:"></asp:Label>               
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLCurso" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLCurso_SelectedIndexChanged" Height="16px"  Width="100px">
                        </asp:DropDownList>
                    </td>     
                     <td>
                         <asp:Label ID="LabelModulo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Módulo:"></asp:Label>
                    </td>
                    <td>
                              <asp:DropDownList ID="DDLModulo" runat="server" style="margin-left: 0px" AutoPostBack="True" Height="16px" Width="100px">
                              </asp:DropDownList>
                    </td>              
                </tr>    
                 <tr>
                    <td>
                          <br />
                          <br />
                          <asp:Label ID="LabelSede" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Sede:"></asp:Label>               
                    </td>
                    <td>
                        <br />
                        <br />
                        <asp:DropDownList ID="DDLSede" runat="server" AutoPostBack="True" Height="16px" Width="100px" OnSelectedIndexChanged="DDLSede_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>     
                     <td>
                         <br />
                         <br />
                         <asp:Label ID="LabelSalon" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Salón:"></asp:Label>
                    </td>
                    <td>
                              <br />
                              <asp:DropDownList ID="DDLSalon" runat="server" style="margin-left: 0px" AutoPostBack="True" Height="16px" Width="100px">
                              </asp:DropDownList>
                    </td>              
                </tr>   
                
                
                
                <tr>
                    <td colspan="2">
                         <asp:Label ID="LabelHorario" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Horario Seleccionado:"></asp:Label>
                   </td>
                    <td>
                         <asp:Label ID="Labeldia" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Día:"></asp:Label>
                    </td>
                    <td>
                         <asp:DropDownList ID="DDLDia" runat="server" style="margin-left: 0px" AutoPostBack="True" Height="16px" Width="100px">
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr >
                    <td colspan="2" rowspan="2">

                        <asp:ListBox ID="LBHorario" runat="server" Width="234px"></asp:ListBox>

                    </td> 
                    <td>
                        <asp:Label ID="Label1" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Hora inicio:"></asp:Label>
                    </td>
                    <td>

                        <asp:TextBox ID="TBHoraI" runat="server" Width="90px" TextMode="Time"></asp:TextBox>

                    </td>  
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Hora fin:"></asp:Label>
                    </td>
                    <td>

                        <asp:TextBox ID="TBHoraF" runat="server" TextMode="Time" Width="90px"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="BBorrar" runat="server" Text="Borrar Lista" OnClick="BBorrar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td colspan="2">
                         <asp:Button ID="BAgregarHor" runat="server" Text="Agregar" OnClick="BAgregarHor_Click" />
                    </td>
                </tr>           
                
                         
               <tr>
                   <td colspan="2">
                       <br />
                       <asp:Label ID="LabelCodigo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Código:"></asp:Label>
                   </td>
                   <td colspan="2">
                       <br />
                       <asp:TextBox ID="TBCodigo" runat="server" Width="128px"></asp:TextBox>
                   </td>
               </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LabelCapacidad" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Capacidad:"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TBcapacidad" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" >
                        <asp:Label ID="LabelCosto" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Costo: BSF."></asp:Label>
                        <br />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TBCosto" runat="server" TextMode="Number" Width="128px"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="LabelFechaI" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Fecha Inicio:"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="TBFechaI" runat="server" TextMode="Date" Width="128px"></asp:TextBox>
                    </td>
               </tr>
                <tr>
                    <td colspan="2">                  
                        <asp:Label ID="LabelFechaF" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Fecha Fin:"></asp:Label>
                    &nbsp;</td>
                    
                    <td colspan="2">

                       

                        <asp:TextBox ID="TBFechaF" runat="server" TextMode="Date" Width="128px"></asp:TextBox>
                    </td>
                 </tr>              
                
                <tr>
                    <td colspan="4" style="width: 100%">
                        <br />
                        <asp:Button ID="BAgregarSecc" runat="server" Text="Agregar" Width="90px" OnClick="BAgregarSecc_Click" />

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
                                                 
                             <asp:Button ID="BVolver" runat="server" PostBackUrl="../ModInicio/Inicio.aspx" Text="Volver" Width="95px" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="width: 42%">
                        <asp:Label ID="LMensaje" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                </tr>
            </table>

        </td>

    </tr>

</table>

</asp:Content>
