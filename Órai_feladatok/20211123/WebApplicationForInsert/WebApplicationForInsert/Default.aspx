<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationForInsert._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div>  
        <div>  
            <table width="84%" cellpadding="0" cellspacing="0" style="border: solid 1px #3366CC;">  
                <tr>  
                    <td colspan="4" style="height: 30px; background-color: #f5712b;">  
                        <span class="TextTitle" style="color: #FFFFFF;">Registration Form</span>  
                    </td>  
                </tr>  
                <tr>  
                    <td height="20px" colspan="1">  
                    </td>  
                </tr>  
                <tr>  
                    <td width="50%" valign="top">  
                        <table id="TableLogin" class="HomePageControlBGLightGray" cellpadding="4" cellspacing="4"  
                            runat="server" width="100%">  
                            <tr>  
                                <td colspan="3" align="center">  
                                    <asp:Label ID="LabelMessage" ForeColor="Red" runat="server" EnableViewState="False"  
                                        Visible="False"></asp:Label><br>  
                                </td>  
                            </tr>  
                            <tr style="font-weight: normal; color: #000000">  
                                <td align="right">  
                                    <span>UserName:</span>;  
                                </td>  
                                <td align="left" style="padding-left: 10px;">  
                                    <asp:TextBox ID="TextBoxUserName" runat="server" CssClass="textbox" Width="262px"  
                                        MaxLength="50" Height="34px"></asp:TextBox>  
                                </td>  
                            </tr>  
                            <tr>  
                                <td align="right">  
                                    <span class="TextTitle">Password:</span>  
                                </td>  
                                <td align="left" style="padding-left: 10px;">  
                                    <asp:TextBox ID="TextBoxPassword" runat="server" CssClass="textbox" Width="261px"  
                                        MaxLength="50" Height="34px"></asp:TextBox>  
                                    <br />  
                                </td>  
                            </tr>  
                            <tr>  
                                <td align="right">  
                                    <span class="TextTitle">Country:</span>  
                                </td>  
                                <td align="left" style="padding-left: 10px;">  
                                    <asp:TextBox ID="TextBoxCountry" runat="server" CssClass="textbox" Width="258px"  
                                        MaxLength="50" Height="34px"></asp:TextBox>  
                                    <br />  
                                </td>  
                            </tr>  
                            <tr>  
                                <td align="right">  
                                    <span class="TextTitle">Email:</span>  
                                </td>  
                                <td align="left" style="padding-left: 10px;">  
                                    <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="textbox" Width="258px" MaxLength="50"  
                                        Height="34px"></asp:TextBox>  
                                    <br />  
                                </td>  
                            </tr>  
                            <tr>  
                                <td align="right">  
                                </td>  
                                <td align="left" style="padding-left: 10px;">  
                                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Width="87px" />  
                                    <br />  
                                </td>  
                            </tr>  
                            <tr>  
                                <td>  
                                </td>  
                                <td>  
                                    <asp:GridView ID="CategoriesGridView" runat="server" AutoGenerateColumns="False"  
                                        CellPadding="4" DataKeyNames="UserID" AllowSorting="True" PagerStyle-HorizontalAlign="left"  
                                        Width="100%" BackColor="#FFFFCC">  
                                        <HeaderStyle HorizontalAlign="Left" />  
                                        <Columns>  
                                            <asp:TemplateField HeaderText="UserName ">  
                                                <ItemTemplate>  
                                                    <asp:Label ID="LabelUserName" runat="server" Text='<%#Eval("UserName") %>'></asp:Label>  
                                                </ItemTemplate>  
                                            </asp:TemplateField>  
                                            <asp:TemplateField HeaderText="Password">  
                                                <ItemTemplate>  
                                                    <asp:Label ID="LabelLPassword" runat="server" Text='<%#Eval("Password") %>'></asp:Label>  
                                                </ItemTemplate>  
                                            </asp:TemplateField>  
                                            <asp:TemplateField HeaderText="Country ">  
                                                <ItemTemplate>  
                                                    <asp:Label ID="LabelCountry" runat="server" Text='<%#Eval("Country") %>'></asp:Label>  
                                                </ItemTemplate>  
                                            </asp:TemplateField>  
                                            <asp:TemplateField HeaderText="Email">  
                                                <ItemTemplate>  
                                                    <asp:Label ID="LabelEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>  
                                                </ItemTemplate>  
                                            </asp:TemplateField>  
                                            <asp:TemplateField HeaderText="Edit">  
                                                <ItemTemplate>  
                                                    <asp:ImageButton ID="ImageButtonEdit" runat="server" CausesValidation="false" CommandArgument='<%#Eval("UserId") %>'
OnCommand="CategoryImageButtonEdit_Command" ImageUrl="~/Images/Edit.png"  
                                                        ToolTip="Edit" />  
                                                </ItemTemplate>  
                                                <ItemStyle Width="100px" />  
                                            </asp:TemplateField>  
                                            <asp:TemplateField HeaderText="Delete">  
                                                <ItemStyle Width="100px" HorizontalAlign="Left" />  
                                                <ItemTemplate>  
                                                    <asp:ImageButton ID="ImageButtonDelete" runat="server" CausesValidation="false" CommandArgument='<%#Eval("UserId") %>'  
                                                        CommandName="Delete" OnCommand="CategoryButtonDelete_Command" ImageUrl="~/Images/cross.gif"  
                                                        ToolTip="Delete" />  
                                                </ItemTemplate>  
                                            </asp:TemplateField>  
                                        </Columns>  
                                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />  
                                        <PagerStyle HorizontalAlign="Left"></PagerStyle>  
                                        <RowStyle CssClass="GridItems" />  
                                        <HeaderStyle CssClass="GridHeader" />  
                                    </asp:GridView>  
                                </td>  
                            </tr>  
                        </table>  
                    </td>  
                </tr>  
            </table>  
        </div>  
    </div>  
</asp:Content>