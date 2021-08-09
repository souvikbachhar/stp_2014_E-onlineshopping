<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="mobile.aspx.cs" Inherits="laptop" %>

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
                    <br />
                    <table class="style4">
                        <tr>
                            <td>
                                Brand :<br />
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
                                    <asp:ListItem>Nokia</asp:ListItem>
                                    <asp:ListItem>Samsung</asp:ListItem>
                                    <asp:ListItem>Sony</asp:ListItem>
                                    <asp:ListItem>Budget</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li1" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/budget_phones/C.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll1" runat="server" onclick="ll1_Click" 
                                    style="width: 155px;">Celkon C9 Jumbo</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li2" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/budget_phones/H.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll3" runat="server" onclick="ll3_Click" 
                                    style="width: 172px;">Hitech Micra</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li3" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/budget_phones/I.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll2" runat="server" onclick="ll2_Click" 
                                    style="width: 154px; height: 26px;">Iball i162</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li4" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/budget_phones/P.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll4" runat="server" onclick="ll4_Click" 
                                    style="width: 235px;">Penta Bharat Phone</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Price :<br />
                                <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="CheckBoxList2_SelectedIndexChanged">
                                    <asp:ListItem Value="750' and '2000">750-2000</asp:ListItem>
                                    <asp:ListItem Value="2001' and '7500">2001-7500</asp:ListItem>
                                    <asp:ListItem Value="7501' and '15000">7501-15000</asp:ListItem>
                                    <asp:ListItem Value="15001' and '30000">Above 15000</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li5" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/nokia/XL.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll5" runat="server" onclick="ll5_Click">Nokia XL</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li6" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/nokia/630.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll6" runat="server" onclick="ll6_Click">Nokia Lumia 630</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li7" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/nokia/220.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll7" runat="server" onclick="ll7_Click">Nokia 220 Dual Sim</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li8" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/nokia/520.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll8" runat="server" onclick="ll8_Click" 
                                    style="width: 156px;">Nokia Lumia 520</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Processor :<br />
                                <asp:CheckBoxList ID="CheckBoxList3" runat="server" AutoPostBack="True" 
                                    OnSelectedIndexChanged="CheckBoxList3_SelectedIndexChanged">
                                    <asp:ListItem>Basic</asp:ListItem>
                                    <asp:ListItem>1 GHz Dual core</asp:ListItem>
                                    <asp:ListItem>1.2 GHz Dual core</asp:ListItem>
                                    <asp:ListItem>Quad Core</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li9" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/samsung/N.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll9" runat="server" onclick="ll9_Click">Samsung Grand Neo</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li10" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/samsung/S.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll10" runat="server" onclick="ll10_Click">Samsung Star Pro</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li11" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/samsung/T.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll11" runat="server" onclick="ll11_Click">Samsung Galaxy Trend</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li12" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/samsung/W.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll12" runat="server" onclick="ll12_Click" 
                                    style="width: 230px; margin-top: 0px;">Samsung Galaxy Win</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Type :<br />
                                <asp:CheckBoxList ID="CheckBoxList4" runat="server" AutoPostBack="True" 
                                    OnSelectedIndexChanged="CheckBoxList4_SelectedIndexChanged">
                                    <asp:ListItem>Bar</asp:ListItem>
                                    <asp:ListItem>TouchScreen</asp:ListItem>
                                    <asp:ListItem>Qwerty</asp:ListItem>
                                    <asp:ListItem>Touch and Type</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                            <td align="center">
                                <asp:Image ID="li13" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/sony/C.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll13" runat="server" onclick="ll13_Click">Sony Xperia C</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li14" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/sony/L.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll14" runat="server" onclick="ll14_Click">Sony Xperia L</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li15" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/sony/M.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll15" runat="server" onclick="ll15_Click">Sony Xperia M</asp:LinkButton>
                            </td>
                            <td align="center">
                                <asp:Image ID="li16" runat="server" Height="124px" 
                                    ImageUrl="~/mob_img/sony/Z.jpg" Width="213px" />
                                <br />
                                <asp:LinkButton ID="ll16" runat="server" onclick="ll16_Click" 
                                    style="width: 228px;">Sony Xperia Z</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                RAM :<br />
                                <asp:CheckBoxList ID="CheckBoxList5" runat="server" AutoPostBack="True" 
                                    OnSelectedIndexChanged="CheckBoxList5_SelectedIndexChanged">
                                    <asp:ListItem>Basic</asp:ListItem>
                                    <asp:ListItem>512 MB</asp:ListItem>
                                    <asp:ListItem>768 MB</asp:ListItem>
                                    <asp:ListItem>1 GB</asp:ListItem>
                                    <asp:ListItem>1.5 GB</asp:ListItem>
                                    <asp:ListItem>2 GB</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Image ID="Image3" runat="server" ImageUrl="~/music_img/Crusher_15.jpg" 
                        
                        style="z-index: 1; left: 273px; top: 931px; position: absolute; height: 200px; width: 904px" />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </asp:View>
                <br />
                <asp:View ID="View2" runat="server">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Image ID="Image2" runat="server" Height="506px" Width="460px" />
                            <asp:ImageButton ID="ImageButton6" runat="server" Height="63px" 
                                ImageUrl="~/img/buy_now.png" Width="101px" onclick="ImageButton6_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Image ID="Image313" runat="server" Height="293px" ImageUrl="~/img1/4.jpg" 
                                Width="335px" />
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
                            <asp:Timer ID="Timer3334" runat="server" Interval="1000" 
                                ontick="Timer3333_Tick">
                            </asp:Timer>
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
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Type &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RAM&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            <br />
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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

