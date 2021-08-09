<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="camera.aspx.cs" Inherits="laptop" %>

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
                    <asp:Timer ID="Timer2" runat="server" Interval="1000" ontick="Timer2_Tick1">
                    </asp:Timer>
                    <table class="style4">
                        <tr>
                            <td>
                                Brand :<br />
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
                                    <asp:ListItem>Canon</asp:ListItem>
                                    <asp:ListItem>Nikon</asp:ListItem>
                                    <asp:ListItem>Sony</asp:ListItem>
                                    <asp:ListItem>Panasonic</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li1" runat="server" ImageUrl="~/cam_img/canon/eos.jpeg" 
                                    style="height: 124px; width: 213px" />
                                <br />
                                <asp:LinkButton ID="ll1" runat="server" onclick="ll1_Click" 
                                    style="width: 155px;">Canon EOS</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li2" runat="server" ImageUrl="~/cam_img/canon/hs.jpeg" 
                                    style="height: 124px; width: 212px" />
                                <br />
                                <asp:LinkButton ID="ll3" runat="server" onclick="ll3_Click" 
                                    style="width: 172px;">Canon HS</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li3" runat="server" ImageUrl="~/cam_img/canon/ps.jpeg" 
                                    style="height: 124px; width: 215px" />
                                <br />
                                <asp:LinkButton ID="ll2" runat="server" onclick="ll2_Click" 
                                    style="width: 154px; height: 26px;">Canon PS</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li4" runat="server" ImageUrl="~/cam_img/canon/psi.jpeg" 
                                    style="height: 163px; width: 93px" />
                                <br />
                                <asp:LinkButton ID="ll4" runat="server" onclick="ll4_Click" 
                                    style="width: 235px;">Canon PSI</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Price :<br />
                                <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList2_SelectedIndexChanged">
                                    <asp:ListItem Value="5000' and '9999">5000-9999</asp:ListItem>
                                    <asp:ListItem Value="10000' and '14999">10000-14999</asp:ListItem>
                                    <asp:ListItem Value="15000' and '19999">15000-19999</asp:ListItem>
                                    <asp:ListItem Value="20000' and '30000">Above 20000</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li5" runat="server" ImageUrl="~/cam_img/nikon/dslr.jpeg" 
                                    style="height: 119px; width: 209px;" />
                                <br />
                                <asp:LinkButton ID="ll5" runat="server" onclick="ll5_Click" 
                                    style="width: 82px;">Nikon DSLR</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li6" runat="server" ImageUrl="~/cam_img/nikon/l29.jpeg" 
                                    style="height: 119px; width: 217px;" />
                                <br />
                                <asp:LinkButton ID="ll6" runat="server" onclick="ll6_Click">Nikon Coolpix L29</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li7" runat="server" ImageUrl="~/cam_img/nikon/l83.jpeg" 
                                    style="height: 119px; width: 186px;" />
                                <br />
                                <asp:LinkButton ID="ll7" runat="server" onclick="ll7_Click">Nikon L83</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li8" runat="server" ImageUrl="~/cam_img/nikon/s36.jpeg" 
                                    style="height: 119px; width: 174px;" />
                                <br />
                                <asp:LinkButton ID="ll8" runat="server" onclick="ll8_Click" 
                                    style="width: 156px;">Nikon Coolpix S36</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Quality :<br />
                                <asp:CheckBoxList ID="CheckBoxList3" runat="server" AutoPostBack="True" 
                                    OnSelectedIndexChanged="CheckBoxList3_SelectedIndexChanged">
                                    <asp:ListItem>12 MP</asp:ListItem>
                                    <asp:ListItem>16 MP</asp:ListItem>
                                    <asp:ListItem>20 MP</asp:ListItem>
                                    <asp:ListItem>32 MP</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li9" runat="server" ImageUrl="~/cam_img/sony/dsc.jpeg" 
                                    style="height: 119px; width: 201px;" />
                                <br />
                                <asp:LinkButton ID="ll9" runat="server" onclick="ll9_Click">Sony Cybershot DSC</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li10" runat="server" ImageUrl="~/cam_img/sony/dslr.jpeg" 
                                    style="height: 119px; width: 187px;" />
                                <br />
                                <asp:LinkButton ID="ll10" runat="server" onclick="ll10_Click">Sony DSLR</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li11" runat="server" ImageUrl="~/cam_img/sony/gold.jpeg" 
                                    style="height: 119px; width: 181px;" />
                                <br />
                                <asp:LinkButton ID="ll11" runat="server" onclick="ll11_Click">Sony Cybershot Gold</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li12" runat="server" ImageUrl="~/cam_img/sony/point.jpeg" 
                                    style="height: 119px; width: 185px;" />
                                <br />
                                <asp:LinkButton ID="ll12" runat="server" onclick="ll12_Click" 
                                    style="width: 230px; margin-top: 0px;">Sony Point Shoot</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Type :<br />
                                <asp:CheckBoxList ID="CheckBoxList4" runat="server" AutoPostBack="True" 
                                    OnSelectedIndexChanged="CheckBoxList4_SelectedIndexChanged">
                                    <asp:ListItem>Digital Cam</asp:ListItem>
                                    <asp:ListItem>DSLR</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li13" runat="server" ImageUrl="~/cam_img/panasonic/dmc.jpeg" 
                                    style="height: 119px; width: 198px;" />
                                <br />
                                <asp:LinkButton ID="ll13" runat="server" onclick="ll13_Click">Panasonic DMC</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li14" runat="server" ImageUrl="~/cam_img/panasonic/fx.jpeg" 
                                    style="height: 119px; width: 194px;" />
                                <br />
                                <asp:LinkButton ID="ll14" runat="server" onclick="ll14_Click">Panasonic FX</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li15" runat="server" ImageUrl="~/cam_img/panasonic/fz40.jpeg" 
                                    style="height: 119px; width: 197px;" />
                                <br />
                                <asp:LinkButton ID="ll15" runat="server" onclick="ll15_Click">Panasonic FZ40</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li16" runat="server" ImageUrl="~/cam_img/panasonic/lumix.jpeg" 
                                    style="height: 119px; width: 197px;" />
                                <br />
                                <asp:LinkButton ID="ll16" runat="server" onclick="ll16_Click" 
                                    style="width: 228px;">Panasonic LUMIX</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </asp:View>
                <br />
                <asp:View ID="View2" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Image ID="Image2" runat="server" Height="334px" Width="665px" />
                            <asp:ImageButton ID="ImageButton6" runat="server" Height="63px" 
                                ImageUrl="~/img/buy_now.png" Width="101px" onclick="ImageButton6_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Image ID="Imag3" runat="server" Height="273px" ImageUrl="~/img1/4.jpg" 
                                Width="289px" />
                            <br />
                            <br />
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="108px" 
                                onclick="ImageButton1_Click" Width="136px" />
                            &nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton3" runat="server" Height="106px" 
                                onclick="ImageButton3_Click" Width="141px" />
                            &nbsp; &nbsp;
                            <asp:ImageButton ID="ImageButton4" runat="server" Height="106px" 
                                onclick="ImageButton4_Click" Width="145px" />
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton5" runat="server" Height="106px" 
                                onclick="ImageButton5_Click" Width="141px" />
                            <br />
                            <asp:Timer ID="Time3" runat="server" Interval="1000" ontick="Time3_Tick">
                            </asp:Timer>
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="style3">Click on the image to enlarge.</span><br />&nbsp;
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Brand&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;Rs:&nbsp;
                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quality&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Type &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
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

