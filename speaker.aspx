<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="speaker.aspx.cs" Inherits="speaker" %>

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
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <table class="style4">
                <tr>
                    <td>
                        Brand :<br />
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
                            <asp:ListItem>JBL</asp:ListItem>
                            <asp:ListItem>Logitech</asp:ListItem>
                            <asp:ListItem>Skullcandy</asp:ListItem>
                            <asp:ListItem>Audioengine</asp:ListItem>
                            <asp:ListItem>Dvee</asp:ListItem>
                            <asp:ListItem>iHome</asp:ListItem>
                            <asp:ListItem>F&amp;D</asp:ListItem>
                            <asp:ListItem>Intex</asp:ListItem>
                            <asp:ListItem>DLS</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td align="center">
                        <asp:Image ID="li1" runat="server" ImageUrl="~/speaker_img/bluetooth/1.jpg" 
                            style="height: 182px; width: 148px" />
                        <br />
                        <asp:LinkButton ID="ll1" runat="server" onclick="ll1_Click" 
                            style="width: 155px; height: 38px;">JBL On Tour SoundFlip</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li2" runat="server" ImageUrl="~/speaker_img/bluetooth/2.jpg" 
                            style="height: 180px; width: 147px" />
                        <br />
                        <asp:LinkButton ID="ll3" runat="server" onclick="ll3_Click" 
                            style="width: 172px;">Logitech UE Boombox-Black</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li3" runat="server" ImageUrl="~/speaker_img/bluetooth/3.jpg" 
                            style="height: 181px; width: 139px" />
                        <br />
                        <asp:LinkButton ID="ll2" runat="server" onclick="ll2_Click" 
                            style="width: 154px; height: 26px;">JBL Flip 2</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li4" runat="server" ImageUrl="~/speaker_img/bluetooth/4.jpg" 
                            style="height: 184px; width: 149px" />
                        <br />
                        <asp:LinkButton ID="ll4" runat="server" onclick="ll4_Click" 
                            style="width: 235px;">Skullcandy Ringer 2XL</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        Price :<br />
                        <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="CheckBoxList2_SelectedIndexChanged">
                            <asp:ListItem Value="1">Low priced</asp:ListItem>
                            <asp:ListItem Value="2">Medium priced</asp:ListItem>
                            <asp:ListItem Value="3">High priced</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td align="center">
                        <asp:Image ID="li5" runat="server" ImageUrl="~/speaker_img/bookshelf/1.jpg" 
                            style="height: 190px; width: 136px;" />
                        <br />
                        <asp:LinkButton ID="ll5" runat="server" onclick="ll5_Click">Audioengine A5</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li6" runat="server" ImageUrl="~/speaker_img/bookshelf/2.jpg" 
                            style="height: 184px; width: 139px;" />
                        <br />
                        <asp:LinkButton ID="ll6" runat="server" onclick="ll6_Click">Dvee Bookshelf</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li7" runat="server" ImageUrl="~/speaker_img/bookshelf/3.jpg" 
                            style="height: 166px; width: 124px;" />
                        <br />
                        <asp:LinkButton ID="ll7" runat="server" onclick="ll7_Click">Dvee fire starter</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li8" runat="server" ImageUrl="~/speaker_img/bookshelf/4.jpg" 
                            style="height: 160px; width: 133px;" />
                        <br />
                        <asp:LinkButton ID="ll8" runat="server" onclick="ll8_Click" 
                            style="width: 156px;">Audioengine A5+</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        Type :<br />
                        <asp:CheckBoxList ID="CheckBoxList4" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="CheckBoxList4_SelectedIndexChanged">
                            <asp:ListItem>Bluetooth</asp:ListItem>
                            <asp:ListItem>BookShelf</asp:ListItem>
                            <asp:ListItem>Dock</asp:ListItem>
                            <asp:ListItem>FloorStanding</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td align="center">
                        <asp:Image ID="li9" runat="server" ImageUrl="~/speaker_img/dock/1.jpg" 
                            style="height: 179px; width: 150px;" />
                        <br />
                        <asp:LinkButton ID="ll9" runat="server" onclick="ll9_Click">JBL On Time 200P</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li10" runat="server" ImageUrl="~/speaker_img/dock/2.jpg" 
                            style="height: 172px; width: 144px;" />
                        <br />
                        <asp:LinkButton ID="ll10" runat="server" onclick="ll10_Click">iHome iA100</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li11" runat="server" ImageUrl="~/speaker_img/dock/3.jpg" 
                            style="height: 169px; width: 152px;" />
                        <br />
                        <asp:LinkButton ID="ll11" runat="server" onclick="ll11_Click">JBL Onstage 4 </asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li12" runat="server" ImageUrl="~/speaker_img/dock/4.jpg" 
                            style="height: 169px; width: 149px;" />
                        <br />
                        <asp:LinkButton ID="ll12" runat="server" onclick="ll12_Click" 
                            style="width: 230px; ">JBL Onstage Micro 2 </asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td align="center">
                        <asp:Image ID="li13" runat="server" 
                            ImageUrl="~/speaker_img/floorstanding/1.jpg" 
                            style="height: 185px; width: 138px;" />
                        <br />
                        <asp:LinkButton ID="ll13" runat="server" onclick="ll13_Click">F&amp;D T-80U Soundbar</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li14" runat="server" 
                            ImageUrl="~/speaker_img/floorstanding/2.jpg" 
                            style="height: 192px; width: 151px;" />
                        <br />
                        <asp:LinkButton ID="ll14" runat="server" onclick="ll14_Click" 
                            style="width: 146px;">INTEX Computer M/m speaker it-12800</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li15" runat="server" 
                            ImageUrl="~/speaker_img/floorstanding/3.jpg" 
                            style="height: 186px; width: 137px;" />
                        <br />
                        <asp:LinkButton ID="ll15" runat="server" onclick="ll15_Click">Esika Tower speakers</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li16" runat="server" 
                            ImageUrl="~/speaker_img/floorstanding/4.jpg" 
                            style="height: 186px; width: 136px;" />
                        <br />
                        <asp:LinkButton ID="ll16" runat="server" onclick="ll16_Click" 
                            style="width: 228px;">DLS D3</asp:LinkButton>
                    </td>
                </tr>
            </table>
            ...........................................................................................................................................................................................................................................................................................................................
        </asp:View>
        <br />
        <asp:View ID="View2" runat="server">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Image ID="Image2" runat="server" Height="334px" Width="665px" />
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="63px" 
                        ImageUrl="~/img/buy_now.png" Width="101px" onclick="ImageButton6_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image38" runat="server" Height="220px" ImageUrl="~/img1/4.jpg" 
                        Width="232px" />
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
                    <asp:Timer ID="Timer11" runat="server" Interval="3000" ontick="Timer11_Tick">
                    </asp:Timer>
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
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; :&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Special Specs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <br />
            <br />
        </asp:View>
        <br />
    </asp:MultiView>
</asp:Content>

