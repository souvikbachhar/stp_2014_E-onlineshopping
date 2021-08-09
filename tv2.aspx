<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="tv2.aspx.cs" Inherits="tv2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            font-size: large;
            font-style: italic;
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="show" runat="server">
            <table align="center" class="style1" style="background-color: #FFFFFF">
                <tr>
                    <td align="left" style="background-color: #FFFFFF">
                            Brand:<br />
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
                            <asp:ListItem>Sony</asp:ListItem>
                            <asp:ListItem>Samsung</asp:ListItem>
                            <asp:ListItem>Lg</asp:ListItem>
                            <asp:ListItem Value="Panasonic"></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td align="center">
                        <asp:Image ID="li1" runat="server" Height="124px" ImageUrl="~/TV/1.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll1" runat="server" onclick="ll1_Click">Sony BRAVIA KLV-32R412B</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li2" runat="server" Height="124px" ImageUrl="~/TV/5.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll2" runat="server" onclick="ll2_Click">Sony BRAVIA KDL- 42W700B</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li3" runat="server" Height="124px" ImageUrl="~/TV/9.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll3" runat="server" onclick="ll3_Click">Sony BRAVIA KDL-48W600B</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li4" runat="server" Height="124px" ImageUrl="~/TV/27.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll4" runat="server" onclick="ll4_Click">Sony BRAVIA KLV-32R482B</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td align="left" style="background-color: #FFFFFF">
                            Price:<br />
                        <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="CheckBoxList2_SelectedIndexChanged">
                            <asp:ListItem Value="1">15000-29999</asp:ListItem>
                            <asp:ListItem Value="2">30000-49999</asp:ListItem>
                            <asp:ListItem Value="3">50000-79999</asp:ListItem>
                            <asp:ListItem Value="4">Above 80000</asp:ListItem>
                        </asp:CheckBoxList>
                        <br />
                    </td>
                    <td align="center">
                        <asp:Image ID="li5" runat="server" Height="124px" ImageUrl="~/TV/17.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll5" runat="server" onclick="ll5_Click">Samsung 51F5500</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li6" runat="server" Height="124px" ImageUrl="~/TV/20.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll6" runat="server" onclick="ll6_Click">Samsung 46F6400</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li7" runat="server" Height="124px" ImageUrl="~/TV/23.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll7" runat="server" onclick="ll7_Click">Samsung 46F5500</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li8" runat="server" Height="124px" ImageUrl="~/TV/13.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll8" runat="server" onclick="ll8_Click">Samsung UA40EH5000R</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td align="left" style="background-color: #FFFFFF">
                            Screen type:<br />
                        <asp:CheckBoxList ID="CheckBoxList3" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="CheckBoxList3_SelectedIndexChanged">
                            <asp:ListItem>LED</asp:ListItem>
                            <asp:ListItem>PLASMA</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td align="center">
                        <asp:Image ID="li9" runat="server" Height="124px" ImageUrl="~/TV/28.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll9" runat="server" onclick="ll9_Click">LG 32LB5820</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li10" runat="server" Height="124px" ImageUrl="~/TV/32.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll10" runat="server" onclick="ll10_Click">LG 42LN5400</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li11" runat="server" Height="124px" ImageUrl="~/TV/36.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll11" runat="server" onclick="ll11_Click">LG 47LB6500</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li12" runat="server" Height="124px" ImageUrl="~/TV/37.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll12" runat="server" onclick="ll12_Click">LG 32LA6200</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td align="left" style="background-color: #FFFFFF">
                            Display type:<br />
                        <asp:CheckBoxList ID="CheckBoxList4" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="CheckBoxList4_SelectedIndexChanged">
                            <asp:ListItem Value="1">32 inches-42 inches</asp:ListItem>
                            <asp:ListItem Value="2">46 inches-51 inches</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td align="center">
                        <asp:Image ID="li13" runat="server" Height="124px" ImageUrl="~/TV/41.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll13" runat="server" onclick="ll13_Click">Panasonic TH-50A410D</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li14" runat="server" Height="124px" ImageUrl="~/TV/45.jpeg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll14" runat="server" onclick="ll14_Click">Panasonic TH-42A410D</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li15" runat="server" Height="124px" ImageUrl="~/TV/49.jpg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll15" runat="server" onclick="ll15_Click">Panasonic TH-42A400D</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li16" runat="server" Height="124px" ImageUrl="~/TV/53.jpg" 
                                Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll16" runat="server" onclick="ll16_Click">Panasonic TH-L42DT50D </asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td align="left" style="background-color: #FFFFFF">
                        <br />
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
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Image ID="Image3" runat="server" Height="224px" 
                ImageUrl="~/music_img/Shure_30.jpg" Width="1239px" 
                style="z-index: 1; left: 97px; top: 902px; position: absolute" />
            <br />
            <br />
            <br />
        </asp:View>
        <asp:View ID="details" runat="server">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Image ID="Image2" runat="server" Height="334px" Width="665px" />
                    &nbsp;<asp:ImageButton ID="ImageButton6" runat="server" Height="63px" 
                        ImageUrl="~/img/buy_now.png" Width="101px" onclick="ImageButton6_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image41" runat="server" Height="231px" ImageUrl="~/img1/4.jpg" 
                        Width="291px" />
                    <br />
                    <br />
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="106px" 
                        onclick="ImageButton1_Click" Width="104px" />
                    &nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="106px" 
                        onclick="ImageButton3_Click" Width="104px" />
                    &nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="106px" 
                        onclick="ImageButton4_Click" Width="104px" />
                    &nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="106px" 
                        onclick="ImageButton5_Click" Width="104px" />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="style3">Click on the image to enlarge.</span><br />
                    <br />
                    <asp:Timer ID="Timer21" runat="server" Interval="1000" ontick="Timer21_Tick">
                    </asp:Timer>
                    <table class="style2" style="width: 495px">
                        <tr>
                            <td align="center">
                                Name :</td>
                            <td align="center">
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                Price :</td>
                            <td align="center">
                                Rs:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                Brand :</td>
                            <td align="center">
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                Screen type :</td>
                            <td align="center">
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                Display size :</td>
                            <td align="center">
                                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                HD Technology &amp; Resolution :</td>
                            <td align="center">
                                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                3D :</td>
                            <td align="center">
                                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                Smart TV :</td>
                            <td align="center">
                                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                HDMI :</td>
                            <td align="center">
                                <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                USB :</td>
                            <td align="center">
                                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                WiFi :</td>
                            <td align="center">
                                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" ForeColor="#3366FF" 
                        onclick="Button1_Click" Text="Back" />
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </asp:View>
    </asp:MultiView>
</asp:Content>

