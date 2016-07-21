<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webEntityOkul.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: right;
            height: 181px;
        }
        .auto-style2 {
            height: 551px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">

            <asp:Label ID="Label1" runat="server" Text="Sınıf Seçiniz"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSinifler" runat="server" AutoPostBack="True" DataTextField="SinifAd" DataValueField="ID" OnSelectedIndexChanged="ddlSinifler_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gvOgrenciler" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="ID" Width="615px" OnSelectedIndexChanged="gvOgrenciler_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField SelectText="Seç" ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <br />
            <br />
            <asp:LinkButton ID="lbEkle" runat="server" OnClick="lbEkle_Click">Yeni Öğrenci Ekle</asp:LinkButton>
            <asp:Label ID="lblOgrenciID" runat="server" Visible="false"></asp:Label>
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="260px" Visible="False">
                <table>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" Text="Ad"></asp:Label>&nbsp;<asp:TextBox ID="txtAd" runat="server"></asp:TextBox><br />
                            <asp:Label ID="Label4" runat="server" Text="Soyad"></asp:Label>&nbsp;<asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox><br />
                            <asp:Label ID="Label3" runat="server" Text="Telefon"></asp:Label>&nbsp;<asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox><br />
                            <asp:Label ID="Label5" runat="server" Text="Adres"></asp:Label>&nbsp;<asp:TextBox ID="txtAdres" runat="server"></asp:TextBox><br />
                            <asp:Label ID="Label6" runat="server" Text="TC-No"></asp:Label>&nbsp;<asp:TextBox ID="txtTcNo" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="rfvTcNo" runat="server" ErrorMessage="TC No Boş Geçilemez" ControlToValidate="txtTcNo" ForeColor="Red">*</asp:RequiredFieldValidator><br />
                            <asp:Label ID="Label7" runat="server" Text="TaksitSayısı"></asp:Label>&nbsp;<asp:TextBox ID="txtTaksit" runat="server"></asp:TextBox><br />
                            <asp:Label ID="Label8" runat="server" Text="TaksitTutarı"></asp:Label> &nbsp;<asp:TextBox ID="txtTutar" runat="server"></asp:TextBox><br />
                            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" /><asp:Button ID="btnDegistir" runat="server" Text="Değiştir" OnClick="btnDegistir_Click" /><asp:Button ID="btnSil" runat="server" Text="Sil" OnClick="btnSil_Click" OnClientClick="return confirm('Silmek İstiyor musunuz?')"/><br />
                             <asp:Label ID="lblMesaj" runat="server" Text=""></asp:Label>
                            <br />
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>

        </div>
    </form>
</body>
</html>
