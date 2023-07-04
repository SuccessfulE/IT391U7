<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IT391U7.aspx.cs"
Inherits="IT391_U7.IT391U7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<title>Student Grades</title>
<style>
body{
  border: solid;
  width: 500px;
  padding: 3px;
}
table {
  table-layout: fixed;
  font-family: arial, sans-serif;
  border-collapse: collapse;
}

td, th {
  border: 1px solid #000f;
  padding: 4px;
  text-align:center;
}

tr:nth-child(even) {
  background-color: #dddddd;
}

</style>
</head>
    <body><center>
        <h1>Student Grades</h1>   
        <p>Course: Math 100</p>
        <p>Instructor: Ms. Jones</p>

        <form id="form1" runat="server">
        <p>Click the button to view the Average, Highest, and Lowest Grades.</p>
        <asp:Button id="Button1"
               Text="View Grades"
               OnClick="Button1_Click" 
               runat="server"/>
        <asp:Button id="Button2"
               Text="Hide Grades"
               OnClick="Button1_Click" 
               runat="server"/>
        <br /><br />
        <table>
            <tr>
                <th>Type</th>
                <th>Grades</th>
            </tr>
            <tr>
                <td>Average Grade:</td>
                <td><asp:TextBox ID="txtAverageGrade" runat="server" Visible="false" ReadOnly="true" Width="15px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Highest Grade:</td>
                <td><asp:TextBox ID="txtHighestGrade" runat="server" Visible="false" ReadOnly="true" Width="15px"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Lowest Grade:</td>
                <td><asp:TextBox ID="txtLowestGrade" runat="server" Visible="false" ReadOnly="true" Width="15px"></asp:TextBox></td>
            </tr>
        </table>
        </form>
    </center></body>
</html>