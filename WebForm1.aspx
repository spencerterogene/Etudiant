<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Etudiant.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 758px; margin-left: 240px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblNom" runat="server" Text="Nom"></asp:Label>
            <asp:TextBox ID="TextBoxNom" runat="server" style="margin-left: 63px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPrenom" runat="server" Text="Prenom1"></asp:Label>
            <asp:TextBox ID="TextBoxPrenom_1" runat="server" style="margin-left: 37px" Width="156px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNom0" runat="server" Text="Prenom2"></asp:Label>
            <asp:TextBox ID="TextBoxPrenom_2" runat="server" style="margin-left: 37px" Width="154px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="TextBoxAge" runat="server" style="margin-left: 67px" Width="156px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNationalite0" runat="server" Text="Nationalite"></asp:Label>
            <asp:TextBox ID="TextBoxNationalite" runat="server" style="margin-left: 27px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAdresse0" runat="server" Text="Adresse-Rue"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxAdresse" runat="server" style="margin-left: 10px" Width="156px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblVille" runat="server" Text="Ville"></asp:Label>
            <asp:TextBox ID="TextBoxVille" runat="server" style="margin-left: 64px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPays" runat="server" Text="Pays"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPays" runat="server" style="margin-left: 62px" Width="156px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTelephone" runat="server" Text="Telephone"></asp:Label>
            <asp:TextBox ID="TextBoxTelephone" runat="server" style="margin-left: 28px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="lblDateCreer" runat="server" Text="DateCreer"></asp:Label>
            <asp:TextBox ID="TextBoxDateCreer" runat="server" style="margin-left: 28px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            <br />
            <asp:GridView ID="GridView" runat="server" Height="246px" Width="754px">
            </asp:GridView>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnSave" runat="server" Height="24px" OnClick="BtnSave_Click" style="margin-left: 0px" Text="Save" Width="63px" />
            <asp:Button ID="BtnCancel" runat="server" OnClick="BtnCancel_Click" style="margin-left: 605px" Text="Cancel" />
        </div>
    </form>
</body>
</html>
