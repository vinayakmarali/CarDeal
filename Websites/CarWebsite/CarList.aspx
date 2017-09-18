<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CarList.aspx.cs" Inherits="CarList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p style="border: thin solid #000000; font-size: xx-large; font-weight: bold">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Car List"></asp:Label>
        &nbsp;</p>
    <asp:Panel ID="Panel1" runat="server" BorderColor="White" GroupingText="Search" 
        ToolTip="Search">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Model"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtSearch" runat="server" Text="Search" 
            onclick="Button1_Click" />
    </asp:Panel>
    <p>
        <asp:GridView ID="GridView1" runat="server"  DataKeyNames="Model"
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing1" 
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
        <asp:GridView ID="GridView2" runat="server" DataKeyNames="Model"
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

