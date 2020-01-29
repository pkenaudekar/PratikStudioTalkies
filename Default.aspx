<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PratikStudioTalkies.WebForm1" %>
<%@ Register src="GenerUserControl1.ascx" tagname="GenerUserControl1" tagprefix="uc3" %>
<%@ Register src="RatingUserControl1.ascx" tagname="RatingUserControl1" tagprefix="uc4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h5>Hello User! Welcome to Pratik Movie Studio</h5>
    <br /><br />
<h3>Please Enter Search Details</h3>
<div class="container">
  <div class="table-responsive">
      <table class="table table-striped">
        <tbody>
          <tr>
            <td>Movie Title</td>
            <td><asp:TextBox class="form-control" ID="txtMovieTitle" runat="server"></asp:TextBox></td>        
          </tr>
          <tr>
            <td>Genre</td>
            <td>
                <uc3:GenerUserControl1 ID="GenerUserControl11" runat="server" />
            </td>   
          </tr>
          <tr>
            <td>Date of Release</td>
            <td><asp:TextBox class="form-control" ID="txtDateOfRelease" runat="server"></asp:TextBox></td>        
          </tr>
          <tr>
            <td>Rating</td>
            <td>                
                <uc4:RatingUserControl1 ID="RatingUserControl11" runat="server" />
              </td>        
          </tr>
          <tr>
            <td></td>
            <td>                
                <asp:Button ID="btnSearch" class="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Search" />                
            </td>        
          </tr>
        </tbody>
      </table>
  </div>
</div>
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
<br />
    <asp:GridView ID="gvwMovies" runat="server" AutoGenerateColumns="False" AllowPaging="True" OnSelectedIndexChanged="Page_Load" OnPageIndexChanging="GridView_PageIndexChanging" PageSize="4" HorizontalAlign="Center" DataKeyNames="MovieId" OnSelectedIndexChanging="gvwMovies_SelectedIndexChanging">
        <Columns>
            <asp:BoundField HeaderText="MovieID" DataField="MovieId" />
            <asp:BoundField HeaderText="Title" DataField="Title">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Genre" DataField="GenreName">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Date of Release" DataField="DateOfRelease">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField HeaderText="Rating" DataField="RatingName">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <EmptyDataTemplate>
            No Matching Results Found
        </EmptyDataTemplate>
    </asp:GridView>

    <br />
    
</asp:Content>
