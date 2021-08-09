<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="laptop.aspx.cs" Inherits="laptop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            font-size: large;
            font-style: italic;
            font-weight: bold;
        }
    .style4
    {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <asp:Timer ID="Timer2" runat="server" Interval="1000" >
                    </asp:Timer>
                    <table class="style4">
                        <tr>
                            <td>
                                Brand :<br />
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
                                    <asp:ListItem>Apple</asp:ListItem>
                                    <asp:ListItem>Dell</asp:ListItem>
                                    <asp:ListItem>Hp</asp:ListItem>
                                    <asp:ListItem>Lenevo</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li1" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/apple/1.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll1" runat="server" onclick="ll1_Click" 
                                    style="width: 155px;">Apple MD760HN/A MacBook Air</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li2" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/apple/1.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll3" runat="server" onclick="ll3_Click" 
                                    style="width: 172px;">Apple MD711HN/A Macbook Air</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li3" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/apple/3.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll2" runat="server" onclick="ll2_Click" 
                                    style="width: 154px; height: 26px;">Apple MD761HN/A Macbook Air</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li4" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/apple/4.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll4" runat="server" onclick="ll4_Click" 
                                    style="width: 235px;">Apple MacBook Pro Mac MD101HN/A</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Price :<br />
                                <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList2_SelectedIndexChanged">
                                    <asp:ListItem Value="15000' and '29999">15000-29999</asp:ListItem>
                                    <asp:ListItem Value="30000' and '49999">30000-49999</asp:ListItem>
                                    <asp:ListItem Value="50000' and '79999">50000-79999</asp:ListItem>
                                    <asp:ListItem Value="80000' and '99999">Above 80000</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li5" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/dell/1.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll5" runat="server" onclick="ll5_Click">Dell Vostro</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li6" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/dell/2.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll6" runat="server" onclick="ll6_Click">Dell Vostro 2520 </asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li7" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/dell/3.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll7" runat="server" onclick="ll7_Click">Dell Alienware 17</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li8" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/dell/4.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll8" runat="server" onclick="ll8_Click" 
                                    style="width: 156px;">Dell Inspiron 14 7437</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Processor :<br />
                                <asp:CheckBoxList ID="CheckBoxList3" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList3_SelectedIndexChanged">
                                    <asp:ListItem>Dual core</asp:ListItem>
                                    <asp:ListItem>Quad core</asp:ListItem>
                                    <asp:ListItem>Core i3(3rd gen)</asp:ListItem>
                                    <asp:ListItem>Core i3(4th gen)</asp:ListItem>
                                    <asp:ListItem>Core i5(3rd gen)</asp:ListItem>
                                    <asp:ListItem>Core i5(4th gen)</asp:ListItem>
                                    <asp:ListItem>Core i7(4th gen)</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li9" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/hp/1.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll9" runat="server" onclick="ll9_Click">HP E1Q79PA</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li10" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/hp/2.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll10" runat="server" onclick="ll10_Click">HP Envy 15-j110TX </asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li11" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/hp/3a.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll11" runat="server" onclick="ll11_Click">HP Pavilion 15-N259TX</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li12" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/hp/4.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll12" runat="server" onclick="ll12_Click" 
                                    style="width: 230px; margin-top: 0px;">HP Pavilion 15-n208TX</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                HDD :<br />
                                <asp:CheckBoxList ID="CheckBoxList4" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList4_SelectedIndexChanged">
                                    <asp:ListItem>16 GB SSD</asp:ListItem>
                                    <asp:ListItem>128 GB SSD</asp:ListItem>
                                    <asp:ListItem>256 GB SSD</asp:ListItem>
                                    <asp:ListItem>500 GB HDD</asp:ListItem>
                                    <asp:ListItem>750 GB HDD</asp:ListItem>
                                    <asp:ListItem>1 TB HDD</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li13" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/lenevo/1.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll13" runat="server" onclick="ll13_Click">Lenovo Essential B490LL</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li14" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/lenevo/2.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll14" runat="server" onclick="ll14_Click">Lenovo Ideapad Y510</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li15" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/lenevo/4.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll15" runat="server" onclick="ll15_Click">Lenovo Ideapad Y510P</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li16" runat="server" Height="124px" 
                                    ImageUrl="~/lap_img/lenevo/3.jpeg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll16" runat="server" onclick="ll16_Click" 
                                    style="width: 228px;">Lenovo IdeaPad A10</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                RAM :<br />
                                <asp:CheckBoxList ID="CheckBoxList5" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList5_SelectedIndexChanged">
                                    <asp:ListItem>1GB DDR3</asp:ListItem>
                                    <asp:ListItem>2GB DDR3</asp:ListItem>
                                    <asp:ListItem>4GB DDR3</asp:ListItem>
                                    <asp:ListItem>8GB DDR3</asp:ListItem>
                                    <asp:ListItem>16GB DDR3</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                Graphics :<br />
                                <asp:CheckBoxList ID="CheckBoxList6" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList6_SelectedIndexChanged">
                                    <asp:ListItem>1 GB</asp:ListItem>
                                    <asp:ListItem>2 GB</asp:ListItem>
                                    <asp:ListItem>3 GB</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center">
                                &nbsp;</td>
                            <td align="center">
                                &nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </asp:View>
                <br />
                <asp:View ID="View2" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Image ID="Image2" runat="server" Height="334px" Width="665px" />
                            <asp:ImageButton ID="ImageButton6" runat="server" Height="63px" 
                                ImageUrl="~/img/buy_now.png" Width="101px" onclick="ImageButton6_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Image ID="Image3" runat="server" Height="191px" ImageUrl="~/img1/4.jpg" 
                                Width="256px" />
                            <asp:Timer ID="Timer3" runat="server" Interval="1000" ontick="Timer3_Tick">
                            </asp:Timer>
                            <br />
                            <br />
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="106px" 
                                onclick="ImageButton1_Click" Width="104px" />
                            &nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton3" runat="server" Height="106px" 
                                onclick="ImageButton3_Click" Width="104px" />
                            &nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton4" runat="server" Height="106px" 
                                onclick="ImageButton4_Click" Width="104px" />
                            &nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton5" runat="server" Height="106px" 
                                onclick="ImageButton5_Click" Width="104px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="style3">Click on the image to enlarge.</span><br />&nbsp;
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;Rs:&nbsp;
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Brand&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Processor&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HDD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Graphics&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
                            <br />
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />
                    <br />
                </asp:View>
                <br />
                <br />
                <br />
            </asp:MultiView>
            <br />
            <br />
            <br />
            <br />
            ............................................................................................................................................................................................................................................................................................................................................<br />
            <br />
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

