<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarRol.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModRoles.AgregarRol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <table >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/AgregarRol.png" class="img" />
            </td>


            <td style="width: 454px">


                <table style="width:100%; text-align:center;">
                    <tr>
                        <td colspan="2" style="width: 42%" > <asp:Label ID="Label3" runat="server" Text="Agregar Rol" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                       
                        
                    </tr>
                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label1" runat="server" Text="Nombre:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label4" runat="server" Text="Funciones:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre" Width="237px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FundanetConnectionString2 %>" SelectCommand="SELECT [nombre] FROM [funcion]"></asp:SqlDataSource>
                        </td>

                        
                    </tr>

                    <tr>
                          <td colspan="1" style="width: 42%" > <asp:Label ID="Label5" runat="server" Text="Funciones Seleccionadas:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:ListBox ID="ListBox1" runat="server" BackColor="#99CCFF" Font-Names="Candara" Font-Size="Medium" Width="199px"></asp:ListBox>

                            
                            <br />

                            
                            <br />

                            
                          </td>

                     </tr>

                     
           
                    <tr colspan:"2">
                        
                         <td colspan="2" style="width: 100%" >
                             <br />
                              <asp:Button ID="Button3" runat="server" Text="Limpiar Lista de Funciones" Width="189px" OnClick="Button3_Click" />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="Button1" runat="server" Text="Agregar Rol" Width="190px" OnClick="Button1_Click" />   
                             <br />
                             <br />
                         </td>
                    </tr>

                    <tr>
                        
                        <td colspan="2" style="width: 42%" > <asp:Label ID="Label2" runat="server" Text="Rol Agregado Correctamente" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" Visible="False"></asp:Label></td>
                                                
                    </tr>
                                        
                </table>
                
            </td>
        </tr>
        
    </table>

</asp:Content>
