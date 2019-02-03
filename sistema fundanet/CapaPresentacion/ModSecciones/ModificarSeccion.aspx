<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ModificarSeccion.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModSecciones.ModificarSeccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

<table style="width:100%; text-align:center;">

    <tr>


       <td>
            <img class="img" src="../Imagenes/ImagenInicio.png" />
        </td>

        <td>

            <table style="width:50%; text-align:center;">
                <tr>
                    <td colspan="4">
                        <asp:Label ID="LabelTitulo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger" Text="Modificar Sección"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>              
                <tr>
                    <td>
                          <asp:Label ID="LabelCurso" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Curso:"></asp:Label>               
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLCurso" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLCurso_SelectedIndexChanged" Height="16px"  Width="130px">
                        </asp:DropDownList>
                    </td>     
                     <td>
                         <asp:Label ID="LabelModulo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Módulo:"></asp:Label>
                    </td>
                    <td>
                              <asp:DropDownList ID="DDLModulo" runat="server" style="margin-left: 0px" AutoPostBack="True" Height="16px" Width="130px">
                              </asp:DropDownList>
                    </td>              
                </tr> 
                <tr>
                    <td>
                          <asp:Label ID="LabelCodigo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Código:"></asp:Label>               
                    </td>
                    <td>
                        <asp:TextBox ID="TBCodigo" runat="server" Width="130px"></asp:TextBox>
                    </td>     
                     <td>
                         <asp:Label ID="LabelFechaI" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Inicio:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TBFechaI" runat="server" TextMode="Date"  Width="130px"></asp:TextBox>
                    </td>              
                </tr> 
                <tr>
                    <td colspan="4">

                        <br />

                        <asp:Button ID="BBuscar" runat="server" Text="Buscar" OnClick="BBuscar_Click" />

                        <br />

                        <br />

                    </td>
                </tr>
                 <tr>
                    <td colspan="4">

                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:CommandField />
                                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>

                    </td>
                </tr>
                 <tr>
                    <td colspan="4">
                        <br />
                        <asp:Label ID="LabelSubTitulo" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Sección Seleccionada:"></asp:Label>
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
                        <asp:Label ID="LabelCapacidad" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Capacidad:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TBCapacidad" runat="server" TextMode="Number" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td>
                        <asp:Label ID="LabelModulo2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Módulo:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LModulo" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelFechaI2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Inicio:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TBFechaIA" runat="server" Width="100px"></asp:TextBox>
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
                        <asp:Label ID="LabelFechaF" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Fecha fin:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TBFechaF" runat="server" Width="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">

                    </td>
                    <td>
                        <asp:Label ID="LabelCosto" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Costo: Bsf"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TBCosto" runat="server" TextMode="Number" Width="100px"></asp:TextBox>
                    </td>                    
                </tr>    
                <tr>
                    <td colspan="4">
                             <br />
                             <asp:Label ID="LabelHorario" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Horario:"></asp:Label>
                    </td>

                </tr>            
               
                <tr >
                    <td colspan="2" rowspan="4">

                        <asp:ListBox ID="LBHorario" runat="server" Width="236px" Font-Size="X-Small" style="margin-right: 0px"></asp:ListBox>

                    </td> 
                    <td>
                        <asp:Label ID="LabelSede" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Sede:"></asp:Label>               
                         
                    </td>
                    <td>
                         <asp:DropDownList ID="DDLSede" runat="server" AutoPostBack="True" Height="16px" Width="100px" OnSelectedIndexChanged="DDLSede_SelectedIndexChanged" >
                        </asp:DropDownList>
                         
                    </td>
                    
                </tr>
                 <tr>
                     <td>
                         <asp:Label ID="LabelSalon" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Salón:"></asp:Label>
                    </td>
                    <td>
                              <asp:DropDownList ID="DDLSalon" runat="server" style="margin-left: 0px" AutoPostBack="True" Height="16px" Width="100px">
                              </asp:DropDownList>
                    </td> 
                </tr>
                 <tr>
                    <td>
                          <asp:Label ID="Labeldia" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Día:"></asp:Label>
                    </td>
                    <td>
                       <asp:DropDownList ID="DDLDia" runat="server" style="margin-left: 0px" AutoPostBack="True" Height="16px" Width="100px">
                        </asp:DropDownList>
                    </td> 
                </tr>   
               
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Inicio:"></asp:Label>
                    </td>
                    <td>

                        <asp:TextBox ID="TBHoraI" runat="server" Width="90px" TextMode="Time"></asp:TextBox>

                    </td> 
                </tr>
                 <tr>
                    <td colspan="2">
                        <asp:Button ID="BBorrar" runat="server" Text="Borrar Lista" OnClick="BBorrar_Click"/>
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Button ID="BAgregarHor" runat="server" Text="Agregar" OnClick="BAgregarHor_Click"/>
                    </td>
                     <td>
                        <asp:Label ID="Label2" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Text="Fin:"></asp:Label>
                    </td>
                    <td>

                        <asp:TextBox ID="TBHoraF" runat="server" TextMode="Time" Width="90px"></asp:TextBox>

                    </td>
                </tr> 
                  <tr>
                    <td colspan="4">
                        <br />
                        <br />
                        <asp:Label ID="LMensaje" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label>
                        <br />
                    </td>
                </tr>
                  <tr>
                      <td colspan="2">
                        <asp:Button ID="BModificar" runat="server" Text="Modificar" Width="95px"/> 
                    </td>
                    <td colspan="2">
                        <asp:Button ID="BVolver" runat="server" Text="Volver" Width="95px" PostBackUrl="../ModInicio/Inicio.aspx" /> 
                    </td>
                </tr>
            </table>

        </td>

    </tr>

</table>

</asp:Content>
