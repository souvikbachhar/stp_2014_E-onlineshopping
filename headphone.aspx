<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="headphone.aspx.cs" Inherits="headphone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            font-size: large;
            font-style: italic;
            font-weight: bold;
        }
        .style11
        {
            width: 100%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <br />
            <table class="style11">
                <tr>
                    <td>
                        Brand :<br />
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
                            <asp:ListItem>Beats</asp:ListItem>
                            <asp:ListItem>Bose</asp:ListItem>
                            <asp:ListItem>JBL</asp:ListItem>
                            <asp:ListItem>Sennheiser</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td align="center">
                        <asp:Image ID="li1" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/1.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll1" runat="server" onclick="ll1_Click" 
                            style="width: 155px; height: 38px;">Lady Gaga Heartbeats</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li2" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/2.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll3" runat="server" onclick="ll3_Click" 
                            style="width: 172px;">Pro Headphone</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li3" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/3.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll2" runat="server" onclick="ll2_Click" 
                            style="width: 154px; height: 26px;">Beats Tour</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li4" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/4.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll4" runat="server" onclick="ll4_Click" 
                            style="width: 235px;">BeatsStudio Colors</asp:LinkButton>
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
                        <asp:Image ID="li5" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/bose/1.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll5" runat="server" onclick="ll5_Click">Bose IE2</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li6" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/bose/2.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll6" runat="server" onclick="ll6_Click">Bose On-Ear</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li7" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/bose/3.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll7" runat="server" onclick="ll7_Click">Bose OE2 </asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li8" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/bose/4.jpeg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll8" runat="server" onclick="ll8_Click" 
                            style="width: 156px;">Bose AE2w</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td align="center">
                        <asp:Image ID="li9" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/jbl/1.jpg." Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll9" runat="server" onclick="ll9_Click">JBL J01B TEMPO</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li10" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/jbl/2.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll10" runat="server" onclick="ll10_Click">JBL SYNCHROS S200A</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li11" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/jbl/3.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll11" runat="server" onclick="ll11_Click">JBL J88</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li12" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/jbl/4.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll12" runat="server" onclick="ll12_Click" 
                            style="width: 230px; ">JBL Freedom</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td align="center">
                        <asp:Image ID="li13" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/sen/1.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll13" runat="server" onclick="ll15_Click">Sennheiser MX 680 Adidas</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li14" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/sen/2.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll14" runat="server" onclick="ll14_Click">Sennheiser HD 202 II</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li15" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/sen/3.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll15" runat="server" onclick="ll16_Click" 
                            style="width: 228px;">Sennheiser RS 120 II</asp:LinkButton>
                    </td>
                    <td align="center">
                        <asp:Image ID="li16" runat="server" Height="124px" 
                            ImageUrl="~/headphone_img/sen/4.jpg" Width="213px" />
                        <br />
                        <asp:LinkButton ID="ll16" runat="server" onclick="ll13_Click">Sennheiser CX 180 Street II</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <br />
            <br />
            ...........................................................................................................................................................................................................................................................................................................................
        </asp:View>
        <br />
        <asp:View ID="View2" runat="server">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Image ID="Image2" runat="server" Height="334px" Width="665px" />
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="63px" 
                        ImageUrl="~/img/buy_now.png" Width="101px" onclick="ImageButton6_Click1" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image39" runat="server" Height="220px" ImageUrl="~/img1/4.jpg" 
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
                    <asp:Timer ID="Timer9" runat="server" Interval="3000" ontick="Timer9_Tick">
                    </asp:Timer>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="style3">Click on the image to enlarge.</span><br />&nbsp;
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
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Special Specs&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;
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
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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

