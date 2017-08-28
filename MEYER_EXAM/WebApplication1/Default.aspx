<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome to GitHub</h1>

    </div>

    <div class="row">
        <div class="col-md-12">
            <h2>Search user here!</h2>
            <p>
                <asp:TextBox ID="txtSearch" Width="500px" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch" EnableTheming="true" Text="Search" runat="server" OnClick="btnSearch_Click" OnClientClick="" />
                <asp:HiddenField ID="hdfGUID" runat="server" />
            </p>
            <p>
            </p>
            <p>
                <asp:ListView ID="lvResult" runat="server" OnPagePropertiesChanging="OnPagePropertiesChanging"
                    GroupPlaceholderID="groupPlaceHolder1"
                    ItemPlaceholderID="itemPlaceHolder1">
                    <ItemTemplate>
                        <fieldset style="float: left; width: 230px;">
                            <table cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <legend style="margin-top: 30px; margin-bottom: 0px; font-size: medium;"><%# Eval( "login" ) %>
                                        </legend>
                                        <table cellpadding="0" cellspacing="0">

                                            <tr>
                                                <td>
                                                    <a href='<%# Eval("login", "/UserLogin.aspx?Login={0}") %>' target="_blank">
                                                        <img src='<%#Eval("avatar_url") %>' alt="" width="170" height="170" />
                                                    </a>
                                                </td>
                                            </tr>

                                        </table>
                                    </td>
                                </tr>

                            </table>

                        </fieldset>

                    </ItemTemplate>
                    <GroupTemplate>
                        <tr>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
                        </tr>
                    </GroupTemplate>
                    <EmptyDataTemplate>
                        <fieldset style="width: 930px">
                            No users found.
                        </fieldset>
                    </EmptyDataTemplate>
                </asp:ListView>
            </p>

        </div>
    </div>
    <br />
    <asp:DataPager ID="dpListView" runat="server" PagedControlID="lvResult" PageSize="20">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="false" ShowPreviousPageButton="true"
                ShowNextPageButton="false" />
            <asp:NumericPagerField ButtonType="Link" />
            <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="false" ShowPreviousPageButton="false" />
        </Fields>
    </asp:DataPager>
    <asp:Label ID="lbltest" runat="server"></asp:Label>
</asp:Content>
