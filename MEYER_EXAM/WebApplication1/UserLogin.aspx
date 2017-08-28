<%@ Page Title="UserLogin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="WebApplication.UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .TableLabel {
            font-weight: bold;
        }

        .GridPager a, .GridPager span {
            height: 15px;
            width: 15px;
            font-weight: normal;
            text-align: center;
            text-decoration: none;
        }

        .GridPager a {
            color: #969696;
            border: none;
        }

        .GridPager span {
            color: #000;
            border: none;
        }
    </style>

    <div class="jumbotron" style="line-height: 1.72;">
        <table>
            <tr>
                <td>
                    <img id="imgUserProfile" runat="server" alt="" width="350" height="350" /></td>
                <td></td>
                <td>
                    <asp:Table ID="tblUserProfile" runat="server">
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text="Username : " runat="server" CssClass="TableLabel"></asp:Label>
                                <asp:Label ID="lblUsername" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text="Type : " runat="server" CssClass="TableLabel"></asp:Label>
                                <asp:Label ID="lblType" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text="Location : " runat="server" CssClass="TableLabel"></asp:Label>
                                <asp:Label ID="lblLocation" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text="Public repos : " runat="server" CssClass="TableLabel"></asp:Label>
                                <asp:Label ID="lblPublicRepos" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text=" Public gists : " runat="server" CssClass="TableLabel"></asp:Label>
                                <asp:Label ID="lblPublicGists" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text="Followers : " runat="server" CssClass="TableLabel"></asp:Label>
                                <asp:Label ID="lblFollowers" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text="Following : " runat="server" CssClass="TableLabel"></asp:Label>
                                <asp:Label ID="lblFollowing" runat="server"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell Width="20px">
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Label Text="Open in GitHub : " runat="server" CssClass="TableLabel"></asp:Label>
                                <a href="" id="lnkUserGitHub" runat="server" target="_blank">
                                    <img src="Images/GitHubIcon.ico" title="Open user profile in GitHub" width="32" height="32" /></a>
                            </asp:TableCell>
                        </asp:TableRow>

                        <asp:TableRow>
                            <asp:TableCell>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:Button ID="btnViewRepos" runat="server" Font-Size="18px" Text="View Repository" OnClick="btnViewRepos_Click" />
                                <asp:HiddenField ID="hdfUserLogin" runat="server" />
                                <asp:HiddenField ID="hdfUserHtmlUrl" runat="server" />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="gvUserRepository" Font-Size="Medium" Width="1300px" runat="server" AutoGenerateColumns="False" PageSize="10"
            BorderWidth="1px" BackColor="White" GridLines="Vertical" CellPadding="4" BorderStyle="None" AllowPaging="true"
            BorderColor="#DEDFDE" ForeColor="Black" OnPageIndexChanging="gvUserRepository_PageIndexChanging">
            <PagerStyle ForeColor="#2a6496" HorizontalAlign="Right" BackColor="#eeeeee" CssClass="GridPager"></PagerStyle>
            <HeaderStyle ForeColor="White" Font-Bold="True" BackColor="#6B696B"></HeaderStyle>
            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="id" SortExpression="id" Visible="false"></asp:BoundField>
                <asp:HyperLinkField DataTextField="Name" DataNavigateUrlFields="html_url" DataNavigateUrlFormatString="{0}" Target="_blank"
                    HeaderText="Name" />
                <asp:BoundField HeaderText="Description" DataField="description"></asp:BoundField>
                <asp:BoundField HeaderText="Created Date" DataField="created_at" HeaderStyle-Width="120px" DataFormatString="{0:dd-MMM-yyyy}"></asp:BoundField>
                <asp:BoundField HeaderText="Updated Date" DataField="updated_at" HeaderStyle-Width="120px" DataFormatString="{0:dd-MMM-yyyy}"></asp:BoundField>
            </Columns>
            <RowStyle BackColor="#F7F7DE"></RowStyle>
        </asp:GridView>

    </div>

</asp:Content>
