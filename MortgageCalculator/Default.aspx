<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MortgageCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <table style="text-align: left; width: 100%;" border="1"
 cellpadding="2" cellspacing="2">
  <tbody>
    <tr>
      <td style="width:30%;"></td>
      <td style="width:30%;">


          Mortgage Calculator</td>
      <td style="width:30%;"></td>
    </tr>
       <tr>
      <td style="width:30%;"></td>
      <td style="width:30%;">


          <asp:Panel ID="Panel1" runat="server" Height="425px">
              <table style="text-align: left; width: 100%;" border="1"
                  cellpadding="2" cellspacing="2">
                  <tbody>
                      <tr>
                          <td style="text-align:right;width:50%;">
                              <asp:Label ID="Label1" runat="server" Text="Total Loan Amount"></asp:Label>
                          </td>
                            <td style="text-align:left;">
                                <asp:TextBox ID="txtPrincipalAmount" runat="server" Width="212px"></asp:TextBox>
                          </td>
                      </tr>
                      <tr>
                           <td style="text-align:right;width:50%;">
                              <asp:Label ID="Label2" runat="server" Text="Interest Rate %"></asp:Label>
                          </td>
                          <td style="text-align:left;">
                              <asp:TextBox ID="txtInterestRate" runat="server" Width="212px"></asp:TextBox>
                           </td>
                      </tr>
                      <tr>
                           <td style="text-align:right;width:50%;">
                              <asp:Label ID="Label3" runat="server" Text="Term"></asp:Label>
                          </td>
                          <td style="text-align:left;">
                              <asp:DropDownList ID="ddlLoanTerm" runat="server" Height="16px" Width="214px">
                                  <asp:ListItem>60</asp:ListItem>
                                  <asp:ListItem>120</asp:ListItem>
                                  <asp:ListItem>240</asp:ListItem>
                              </asp:DropDownList>
                           </td>
                      </tr>
                      <tr>
                          <td style="text-align:right;width:50%;">
                              <asp:Label ID="Label7" runat="server" Text="Additional Amount"></asp:Label>
                          </td>
                          <td style="text-align:left;">
                              <asp:TextBox ID="txtAdditionalAmount" runat="server" Width="212px">0</asp:TextBox>
                          </td>
                      </tr>
                      <tr>
                           <td style="text-align:right;width:50%;">
                               &nbsp;</td>
                          <td style="text-align:left;">
                              <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                           </td>
                      </tr>
                      <tr>
                           <td style="text-align:right;width:50%;">
                              <asp:Label ID="Label6" runat="server" Text="Result"></asp:Label>
                          </td>
                          <td style="text-align:left;">
                              <asp:TextBox ID="txtResult" runat="server" Width="212px"></asp:TextBox>
                           </td>
                      </tr>
                  </tbody>
</table>

          </asp:Panel>


      </td>
      <td style="width:30%;"></td>
    </tr>
  </tbody>
</table>

        </div>
    </form>
    </form>
</body>
</html>
