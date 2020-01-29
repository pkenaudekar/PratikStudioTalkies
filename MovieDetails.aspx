<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MovieDetails.aspx.cs" Inherits="PratikStudioTalkies.MovieDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <div class="container">
      <table class="table table-striped">
        <tr>
            <td>Movie Name</td>
            <td>
                <asp:Label ID="lblMovieName" runat="server" Text=""></asp:Label>
            </td>            
        </tr>
        <tr>
            <td>Date of Release</td>
            <td>
                <asp:Label ID="lblDateOfRelease" runat="server" Text=""></asp:Label>
            </td>            
        </tr>
        <tr>
            <td>Genre</td>
            <td>
                <asp:Label ID="lblGenre" runat="server" Text=""></asp:Label>
            </td>            
        </tr>
        <tr>
            <td>Rating</td>
            <td>
                <asp:Label ID="lblRating" runat="server" Text=""></asp:Label>
            </td>            
        </tr>
        <tr>
            <td>Description</td>
            <td>
                <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label>
            </td>            
        </tr>
    </table>
  </div>
    <asp:GridView ID="gvwMovieDetails" runat="server" AutoGenerateColumns="False" AllowPaging="True"  PageSize="4" HorizontalAlign="Center">
        <Columns>
            <asp:BoundField DataField="ActorId" HeaderText="Actor ID" Visible="False" />
            <asp:BoundField DataField="ActorName" HeaderText="Actor Name" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
            <asp:BoundField DataField="Role" HeaderText="Role" />
        </Columns>
    </asp:GridView>
    <center><asp:Label ID="lblError" runat="server"></asp:Label></center>
</asp:Content>
