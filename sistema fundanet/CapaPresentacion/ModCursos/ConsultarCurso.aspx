<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultarCurso.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModCursos.ConsultarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table>
      
        <tr>

            <td width="100" height="307" rowspan="2">
            </td>

            <td width="430" height="307" class="imagen2" rowspan="2">
                <img src="../Imagenes/ImagenInicio.png" class="img" />
            </td>
            
             <td style="width: 454px">

                  <table style="width:100%; text-align:center;">
                      <tr>
                        <td colspan="2" style="width: 42%" > <asp:Label ID="LabelTitulo" runat="server" Text="Consultar Curso" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                      </tr>
                      <tr>
                           <td colspan="1" style="width: 42%" > <asp:Label ID="LBuscar" runat="server" Text="Buscar:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                           <td> 
                              <br />
                              <asp:TextBox ID="TBuscar" runat="server" style="margin-left: 0px" Width="117px" MaxLength="10"></asp:TextBox> 
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BBuscar" runat="server" Text="Buscar" OnClick="BBuscar_Click" />
                              <br />
                           </td>
                      </tr>
                      <tr>
                          <td colspan="2" style="width: 42%"  > 
                          
                              <br />
                          
                              <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
                                  <AlternatingRowStyle BackColor="White" />
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
                          
                              <br />
                          
                          </td>
                           
                      </tr>
                      <tr colspan:"2">
                           <td colspan="2" style="width: 100%" >
                             <br />                       
                                                 
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BMostrar" runat="server" Text="Mostrar Todos" OnClick="BMostrar_Click" />
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
                                                 
                             <asp:Button ID="BVolver" runat="server" Text="Volver" Width="95px" PostBackUrl="../ModInicio/Inicio.aspx" />   
                             <br />
                             <br />
                         </td>
                      </tr>
                      <tr>                        
                        <td colspan="2" style="width: 42%" > <asp:Label ID="LMensaje" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                      </tr>
                  </table>

             </td>

        </tr>
            
    </table>


</asp:Content>
