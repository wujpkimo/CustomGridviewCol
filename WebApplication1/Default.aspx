<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>CustomGridView</h2>

            <asp:GridView ID="GdvTest" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                    <asp:BoundField DataField="SupplierName" HeaderText="Supplier Name" />
                    <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
                    <asp:BoundField DataField="QuantityPerUnit" HeaderText="Qty/Unit" />
                    <asp:BoundField DataField="CreateDate" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Create Date"
                        HtmlEncode="False" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>