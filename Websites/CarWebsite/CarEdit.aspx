<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CarEdit.aspx.cs" Inherits="CarEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p style="font-size: xx-large; font-weight: bold; border: thin solid #000000">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Car Edit</p>
    <asp:Panel ID="Panel1" runat="server" GroupingText="Details">
        &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Model"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Brand"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlBrand" runat="server" 
            DataSourceID="BrandDataSource" DataTextField="BrandName" 
            DataValueField="BrandId">
        </asp:DropDownList>
        <asp:EntityDataSource ID="BrandDataSource" runat="server" 
            ConnectionString="name=CarsInfoEntities" 
            DefaultContainerName="CarsInfoEntities" EnableFlattening="False" 
            EntitySetName="Brands" EntityTypeFilter="Brand">
        </asp:EntityDataSource>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Costs"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCosts" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtSave" runat="server" Text="Save" onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtCancel" runat="server" Text="Cancel" 
            onclick="Button2_Click" />
    </asp:Panel>
</asp:Content>

