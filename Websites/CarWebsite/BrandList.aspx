<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BrandList.aspx.cs" Inherits="BrandList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p style="border: thin solid #000000; font-size: xx-large; font-weight: bold">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Brand List"></asp:Label>
    </p>
    <asp:Panel ID="Panel1" runat="server" GroupingText="Search">
        <p>
            &nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" 
            Text="Brand"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" 
                onclick="Button1_Click" />
            </p>
    </asp:Panel>
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="BrandName"
            onrowediting="GridView1_RowEditing1" onrowdeleting="GridView1_RowDeleting" 
            CellPadding="5" Width="800px">
            <AlternatingRowStyle BackColor="#AFDCEC" />
            <Columns>
                <asp:CommandField ShowCancelButton="False" ShowEditButton="True" 
                    HeaderText="Actions" ShowDeleteButton="True" />
            </Columns>
            <EmptyDataTemplate>
                No records found
            </EmptyDataTemplate>
            <HeaderStyle BackColor="#465C71" ForeColor="White" />
        </asp:GridView>
    </p>
    <p>
        <asp:GridView ID="GridView2" runat="server" DataKeyNames="BrandName"
            onrowdeleting="GridView2_RowDeleting" onrowediting="GridView2_RowEditing" 
            CellPadding="5" Width="800px">
            <AlternatingRowStyle BackColor="#AFDCEC" />
            <Columns>
                <asp:CommandField ShowCancelButton="False" ShowEditButton="True" 
                    HeaderText="Actions" ShowDeleteButton="True" />
            </Columns>
            <HeaderStyle BackColor="#465C71" ForeColor="White" />
        </asp:GridView>
    </p>
</asp:Content>

