<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:Timer ID="Timer2" runat="server" Interval="1000" ontick="Timer2_Tick">
            </asp:Timer>
            <asp:Image ID="hi3" runat="server" ImageUrl="~/img/5.jpg" 
                style="top: 754px; left: 173px; position: absolute; height: 133px; width: 965px" 
                Width="100%" />
            <asp:Image ID="hi2" runat="server" ImageUrl="~/img/8.jpg" 
                
                style="top: 409px; left: 168px; position: absolute; height: 133px; width: 969px" />
            <asp:Image ID="hil2" runat="server" 
                
                style="z-index: 1; left: 487px; top: 557px; position: absolute; height: 157px; width: 218px" 
                ImageUrl="~/lap_img/dell/3.jpeg" />
            <asp:Image ID="hi1" runat="server" Height="1943px" ImageUrl="~/img1/Quickr_120x600_side-gutters_left.jpg" 
                Width="153px" />
            <asp:Image ID="hil4" runat="server" 
                
                style="z-index: 1; left: 944px; top: 557px; position: absolute; height: 157px; width: 197px" 
                ImageUrl="~/lap_img/lenevo/1.jpeg" />
            <asp:Image ID="hil1" runat="server" 
                
                style="z-index: 1; left: 206px; top: 558px; position: absolute; height: 165px; width: 260px" 
                ImageUrl="~/lap_img/apple/1.jpeg" />
            <asp:Image ID="hil3" runat="server" 
                
                style="z-index: 1; left: 726px; top: 556px; position: absolute; height: 157px; width: 199px" 
                ImageUrl="~/lap_img/hp/3a.jpeg" />
            <asp:Image ID="him1" runat="server" 
                
                style="z-index: 1; left: 210px; top: 900px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/mob_img/nokia/XL.jpg" />
            <asp:Image ID="hi5" runat="server" ImageUrl="~/img/2.jpg" 
                style="top: 1105px; left: 173px; position: absolute; height: 133px; width: 956px" 
                Width="100%" />
            <asp:Image ID="his5" runat="server" 
                
                style="z-index: 1; left: 210px; top: 1267px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/headphone_img/bose/1c.jpg" />
            <asp:Image ID="hit1" runat="server" 
                
                style="z-index: 1; left: 721px; top: 2000px; position: absolute; height: 157px; width: 238px" 
                ImageUrl="~/tv/20.jpeg" />
            <asp:Image ID="hic3" runat="server" 
                
                style="z-index: 1; left: 610px; top: 1630px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/cam_img/panasonic/dmc.jpeg" />
            <asp:Image ID="hic4" runat="server" 
                
                style="z-index: 1; left: 815px; top: 1630px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/cam_img/sony/dsc.jpeg" />
            <asp:Image ID="hi6" runat="server" ImageUrl="~/img/9.jpg" 
                style="top: 2216px; left: 173px; position: absolute; height: 133px; width: 963px" 
                Width="100%" />
            <asp:Image ID="hic2" runat="server" 
                
                style="z-index: 1; left: 210px; top: 1630px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/cam_img/canon/eos.jpeg" />
            <asp:Image ID="hit2" runat="server" 
                
                style="z-index: 1; left: 210px; top: 2000px; position: absolute; height: 157px; width: 224px" 
                ImageUrl="~/tv/1.jpeg" />
            <asp:Image ID="hit3" runat="server" 
                
                style="z-index: 1; left: 462px; top: 2000px; position: absolute; height: 157px; width: 229px" 
                ImageUrl="~/tv/10.jpeg" />
            <asp:Image ID="hit4" runat="server" 
                
                style="z-index: 1; left: 989px; top: 2000px; position: absolute; height: 157px; width: 239px" 
                ImageUrl="~/tv/5.jpeg" />
            <asp:Image ID="hi7" runat="server" ImageUrl="~/img/1.jpg" 
                style="top: 1839px; left: 173px; position: absolute; height: 133px; width: 956px" 
                Width="100%" />
            <asp:Label ID="Label1" runat="server" 
                style="z-index: 1; left: 751px; top: 723px; position: absolute; width: 158px;" 
                Text="HP Pavilion 15-N259TX"></asp:Label>
            <asp:Label ID="Label2" runat="server" 
                style="z-index: 1; left: 227px; top: 726px; position: absolute" 
                Text="Apple MD760HN/A Macbook Air"></asp:Label>
            <asp:Label ID="Label3" runat="server" 
                style="z-index: 1; left: 549px; top: 723px; position: absolute" 
                Text="Dell Alienware M17"></asp:Label>
            <asp:Label ID="Label4" runat="server" 
                style="z-index: 1; left: 966px; top: 723px; position: absolute; width: 150px;" 
                Text="Lenovo Essential B490LL"></asp:Label>
            <asp:Label ID="Label6" runat="server" 
                style="z-index: 1; left: 871px; top: 1424px; position: absolute; right: 192px" 
                Text="Sennheiser HD"></asp:Label>
            <asp:Label ID="Label7" runat="server" 
                style="z-index: 1; left: 665px; top: 1424px; position: absolute; right: 210px" 
                Text="DLS D3"></asp:Label>
            <asp:Label ID="Label8" runat="server" 
                style="z-index: 1; left: 633px; top: 1069px; position: absolute; right: 577px" 
                Text="Xperia C"></asp:Label>
            <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click" 
                style="z-index: 1; left: 1021px; top: 1422px; position: absolute; width: 80px">See More</asp:LinkButton>
            <asp:Label ID="Label9" runat="server" 
                style="z-index: 1; left: 426px; top: 1794px; position: absolute; right: 784px" 
                Text="Nikon DSLR"></asp:Label>
            <asp:Label ID="Label10" runat="server" 
                style="z-index: 1; left: 632px; top: 1792px; position: absolute; right: 528px" 
                Text="Sony Cybershot DSC"></asp:Label>
            <asp:Label ID="Label12" runat="server" 
                style="z-index: 1; left: 843px; top: 1793px; position: absolute; right: 367px" 
                Text="Panasonic FX"></asp:Label>
            <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton8_Click" 
                PostBackUrl="tv2.aspx" 
                
                style="z-index: 1; left: 1216px; top: 2176px; position: absolute; width: 80px">See More</asp:LinkButton>
            <asp:Label ID="Label13" runat="server" 
                style="z-index: 1; left: 432px; top: 1052px; position: absolute; right: 778px" 
                Text="Samsung Galaxy Win"></asp:Label>
            <asp:Label ID="Label14" runat="server" 
                style="z-index: 1; left: 838px; top: 1071px; position: absolute; right: 372px" 
                Text="Samsung Galaxy Trend"></asp:Label>
            <asp:Label ID="Label15" runat="server" 
                style="z-index: 1; left: 243px; top: 1069px; position: absolute; right: 967px" 
                Text="Nokia XL"></asp:Label>
            <asp:Label ID="Label16" runat="server" 
                style="z-index: 1; left: 243px; top: 1424px; position: absolute; right: 967px" 
                Text="Bose IE2"></asp:Label>
            <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton8_Click" 
                PostBackUrl="mobile.aspx" 
                style="z-index: 1; left: 1021px; top: 1055px; position: absolute; width: 80px">See More</asp:LinkButton>
            <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton8_Click" 
                PostBackUrl="camera.aspx" 
                style="z-index: 1; left: 1021px; top: 1793px; position: absolute; width: 80px">See More</asp:LinkButton>
            <asp:Label ID="Label20" runat="server" 
                style="z-index: 1; left: 243px; top: 1798px; position: absolute; right: 967px" 
                Text="Canon EOS"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click" 
                style="z-index: 1; left: 1125px; top: 725px; position: absolute; width: 86px">See More</asp:LinkButton>
            <asp:Label ID="Label5" runat="server" 
                style="z-index: 1; left: 422px; top: 1424px; position: absolute; right: 350px" 
                Text="JBL Onstage Micro 2 "></asp:Label>
            <asp:Image ID="Image2" runat="server" 
                
                style="z-index: 1; left: 1161px; top: 398px; position: absolute; height: 167px; width: 167px" 
                ImageUrl="~/img1/4.jpg" />
            <hr color="red"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DESIGNED AND DEVELOPED BY<br /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            ABHIRUP,BISWAJIT and SOUVIK<br />
            ..............................................................................................................................................................................................................................................................................................................................................<br />
            <asp:Image ID="him3" runat="server" 
                
                style="z-index: 1; left: 605px; top: 903px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/mob_img/sony/C.jpg" />
            <asp:Image ID="him4" runat="server" 
                
                style="z-index: 1; left: 806px; top: 901px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/mob_img/samsung/T.jpg" />
            <br />
            <asp:Image ID="him2" runat="server" 
                
                style="z-index: 1; left: 404px; top: 899px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/mob_img/samsung/W.jpg" />
            
            <asp:Image ID="hic1" runat="server" 
                
                style="z-index: 1; left: 404px; top: 1630px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/cam_img/nikon/dslr.jpeg" />
            <asp:Image ID="his2" runat="server" 
                
                style="z-index: 1; left: 404px; top: 1263px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/speaker_img/dock/4b.jpg" />
            <br />
           <asp:Image ID="his3" runat="server" 
                
                style="z-index: 1; left: 609px; top: 1263px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/speaker_img/floorstanding/4.jpg" />
            <br />
            <asp:Image ID="his4" runat="server" 
                
                style="z-index: 1; left: 812px; top: 1263px; position: absolute; height: 157px; width: 135px" 
                ImageUrl="~/headphone_img/sen/2b.jpg" />
           
            <asp:Image ID="hi4" runat="server" ImageUrl="~/img/3.jpg" 
                style="top: 1463px; left: 173px; position: absolute; height: 133px; width: 959px" 
                Width="100%" />
            <br />
           
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    </asp:Content>

