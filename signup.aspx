<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style6
        {
            width: 182px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;&nbsp;&nbsp; 
        <asp:Panel ID="Panel3" runat="server" 
            
            style="z-index: 1; left: 327px; top: 8px; position: relative; height: 429px; width: 505px" 
            
            
        BackImageUrl="~/img1/rainbow_dash_login_background__series_1__by_mateo_thefox-d5tozbc.jpg">
            <br />
            <asp:Image ID="Image7" runat="server" Height="52px" ImageUrl="~/img1/index.jpg" 
                Width="225px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table ID="r" >
                <tr>
                    <td align="center" class="style6">
                        Email ID</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBox3" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="TextBox3" ErrorMessage="* ex@example.com" ForeColor="Red" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style6">
                        Gender</td>
                    <td>
                        <asp:RadioButtonList ID="rb_reg_gender" runat="server" 
                            RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" class="style6">
                        Password</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="TextBox4" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style6">
                        Confirm Password</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" 
                            ControlToCompare="TextBox4" ControlToValidate="TextBox5" 
                            ErrorMessage="Password does not match" ForeColor="Red"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="TextBox5" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style6">
                        Security Question</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Whats is your Petname?</asp:ListItem>
                            <asp:ListItem>What is your first mobile number?</asp:ListItem>
                            <asp:ListItem>What is your best freind&#39;s name?</asp:ListItem>
                            <asp:ListItem>What is your favourite TV show?</asp:ListItem>
                            <asp:ListItem>What is your favourite game?</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="DropDownList1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style6">
                        Security Answer</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ControlToValidate="TextBox6" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style6">
                        <asp:Button ID="b_newlog" runat="server" Text="Submit" 
                            onclick="b_newlog_Click" />
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" 
                            Text="You have been registered sucessfully. Now login in Members Zone" 
                            Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
    <asp:Image ID="Image8" runat="server" Height="179px" 
        ImageUrl="~/img1/30daylong.gif" Width="1238px" />
    &nbsp;
</asp:Content>

