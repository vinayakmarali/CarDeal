<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BrandEdit.aspx.cs" Inherits="BrandEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p style="border: thin solid #000000; font-size: xx-large; font-weight: bold;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Brand Edit"></asp:Label>
        &nbsp;</p>
    <asp:Panel ID="Panel1" runat="server" BackColor="White" BorderColor="White" 
        BorderStyle="Solid" GroupingText="Details">
        <p>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Brand"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtboxBrand" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSave" runat="server" Text="Save" 
            onclick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
            onclick="btnCancel_Click" />
        </p>
    </asp:Panel>
    <p>
        <br />
&nbsp;</p>
</asp:Content>

