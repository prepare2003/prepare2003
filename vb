<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style5
        {
            height: 23px;
            margin-left: 120px;
        }
        .style6
        {
            width: 100px;
            text-align:justify;
        }
        .style7
        {
            width: 371px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 50%; margin:auto"border>
            <tr>
                <td class="style6">
                    <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtID" runat="server" Height="25px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtName" runat="server" Height="25px" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                     <asp:Label ID="Label3" runat="server" Text="Roll NO"></asp:Label>
                </td>
                <td class="style7">
                    
                    <asp:TextBox ID="txtRoll" runat="server" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                     <asp:Label ID="Label4" runat="server" Text="Mobile No"></asp:Label></td>
                <td class="style3">
                    <asp:TextBox ID="txtMobile" runat="server" Height="25px"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td class="style6">
                      <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label></td>
                <td class="style7">
                    <asp:RadioButton ID="male" runat="server" Height="25px" GroupName="gender" 
                        Text="Male" />
                    <asp:RadioButton ID="female" runat="server" Height="25px" GroupName="gender" 
                        Text="Female" />
                    <asp:RadioButton ID="other" runat="server" Height="25px" GroupName="gender" 
                        Text="Other" />
                    </td>
            </tr>
            <tr>
                <td class="style6">
                       <asp:Label ID="Label6" runat="server" Text="Subject"></asp:Label></td>
                <td class="style7">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="25px">
                        <asp:ListItem>ASP</asp:ListItem>
                        <asp:ListItem>PHP</asp:ListItem>
                        <asp:ListItem>Unix</asp:ListItem>
                        <asp:ListItem>Network Tech</asp:ListItem>
                        <asp:ListItem>Web Design</asp:ListItem>
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td class="style5" colspan="2" style="text-align:center">
                       <asp:Button ID="Button1" runat="server" Text="Insert" style="margin:5px;padding:10px;background-color:blue;color:white;border-radius: 10px;" />
                       <asp:Button ID="Button2" runat="server" Text="Update" style="margin:5px;padding:10px;background-color:yellow;color:black;border-radius: 10px;" />
                       <asp:Button ID="Button3" runat="server" Text="Delete" style="margin:5px;padding:10px;background-color:red;color:white;border-radius: 10px;"/>
                       <asp:Button ID="Button5" runat="server" Text="Clear" style="margin:5px;padding:10px 18px;background-color:black;color:white;border-radius: 10px;"/>
                </td>
            </tr>
            <tr>
                <td class="style5" colspan="2" style="text-align:center">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtSearch" runat="server" Width="227px" Height="30px" 
                        style="margin-left: 9px"></asp:TextBox>
                       <asp:Button ID="Button4" runat="server" Text="Search" style="margin:5px;padding:10px;background-color:green;color:white;border-radius: 10px;"/>
                </td>
            </tr>
            <tr>
                <td class="style5" colspan="2" style="text-align:center">
                       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                           DataKeyNames="ID" DataSourceID="AccessDataSource1"
                           Width="100%">
                           <Columns>
                               <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                                   ReadOnly="True" SortExpression="ID"/>
                               <asp:BoundField DataField="sname" HeaderText="Name" SortExpression="sname" />
                               <asp:BoundField DataField="srollno" HeaderText="Roll No" 
                                   SortExpression="srollno" />
                               <asp:BoundField DataField="smobileno" HeaderText="Mobile No" 
                                   SortExpression="smobileno" />
                               <asp:BoundField DataField="sgender" HeaderText="Gender" 
                                   SortExpression="sgender" />
                               <asp:BoundField DataField="subject" HeaderText="Subject" 
                                   SortExpression="subject" />
                           </Columns>
                       </asp:GridView>
                       <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
                           DataFile="~/App_Code/Database1.accdb" SelectCommand="SELECT * FROM [student]">
                       </asp:AccessDataSource>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
