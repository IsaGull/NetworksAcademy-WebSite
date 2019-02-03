<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="GenerarRecibo.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModGenerar.GenerarRecibo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/ConsultarRol.png" class="img" />
            </td>


            <td style="width: 454px">


                <table style="width:100%; text-align:center;">
                    <tr>
                        <td colspan="2" style="width: 42%" > <asp:Label ID="Label3" runat="server" Text="Generar Recibo de Pago" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                       
                        
                    </tr>
                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label1" runat="server" Text="Cedula: " CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                        
                    </tr>

                    <tr>

                        <td colspan="1" style="width: 42%" >

                            <br />

                            <asp:Label ID="Label6" runat="server" Text="Curso: " Font-Names="Candara" Font-Size="Medium" Font-Bold="True"></asp:Label>

                            <br />

                        </td>

                        <td>


                            <br />


                            <asp:DropDownList ID="DropDownList1" runat="server" Width="168px"></asp:DropDownList>


                            <br />


                            <br />


                        </td>

                    </tr>        

                      <tr>
                        <td colspan="2" style="width: 42%" ><asp:Button ID="Button1" runat="server" Text="Generar Recibo De Pago" OnClick="Button1_Click" style="height: 29px" /></td>
                          
                        
                    </tr>


               
                </table>


            </td>
        </tr>
        


    </table>



</asp:Content>
