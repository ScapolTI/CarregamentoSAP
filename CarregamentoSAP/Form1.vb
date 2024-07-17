Imports System
Imports System.IO
Imports System.Media
Imports System.Net.Mail
Imports System.Math
Imports System.ConsoleKeyInfo
Imports System.Security.Principal.WindowsIdentity
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Dim oCompany As New SAPbobsCOM.Company
    Dim sErrMsg As String
    Dim lErrCode As Long
    Dim lConexao As Long = 1
    Dim Tipo As String
    Dim tSQL As String

    Dim UsuarioSAP As String
    Dim UserSAP As String
    Dim SenhaSAP As String

    Dim cn As New ADODB.Connection()
    Dim rs As New ADODB.Recordset()
    Dim rsProcedure As New ADODB.Recordset()
    Dim cnStr As String
    Dim cmd As New ADODB.Command()

    Dim ORDR As SAPbobsCOM.Documents

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Aguarde alguns segundos enquanto a conexão é efetuada."
        Label1.Visible = True
        Refresh()

        UsuarioSAP = GetCurrent.Name.Replace("SCAPOL\", "")

        ' string de conexao com o banco
        cnStr = "DSN=hanab1;  UID=SYSTEM; PWD=h1n1Sc1p4l;"

        ' 2. Abre a Conexao
        cn.Open(cnStr)
        'cn.Close()

        tSQL = " Select ""U_usersap"",""U_senhasap"" from SBH_SCAPOL.""@TBUSUARIOS"" t where t.""U_userwindows"" = '" + UsuarioSAP + "' "

        cn.CommandTimeout = 360
        rs = cn.Execute(tSQL)

        If Not rs.EOF Then
            UserSAP = rs.Fields.Item("u_usersap").Value
            SenhaSAP = rs.Fields.Item("u_senhasap").Value
        Else
            MessageBox.Show("Usuario Windows não mapeado com Usuario SAP - SBH_SCAPOL.@TBUSUARIOS")
        End If

        cn.Close()
        '------------------------------------------------------
        ' Conectando no SAP
        '------------------------------------------------------

        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB

        oCompany.Disconnect()
        oCompany.Server = "NDB@hanab1:30013"
        oCompany.UseTrusted = False
        oCompany.DbUserName = "SYSTEM"
        oCompany.DbPassword = "h1n1Sc1p4l"
        oCompany.CompanyDB = "SBH_SCAPOL"
        oCompany.UserName = UserSAP
        oCompany.Password = SenhaSAP

        lConexao = oCompany.Connect

        If lConexao <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox("Não foi possivel estabelecer a conexão!" + Chr(13) + "Por favor tentar novamente! ", MsgBoxStyle.Information, "Erro")
            Label1.Text = "Erro ao Conectar: " & sErrMsg
            Label1.Visible = True
        Else
            Label1.Text = oCompany.CompanyDB

        End If

        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Qry As SAPbobsCOM.Recordset
        Qry = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        tSQL = " select ""DocNum"",v.""DocEntry"", ""U_Num_Pedido"" PEDIDO, ""Volume"", ""CityS"", ""U_Pista"" PISTA, ""U_MsgNF"" MSG, ""Peso"" ,""Serial"",""CardCode"",""CardName"",replace(""U_SeqCarregamento"",99999,'') U_SeqCarregamento,""DocTotal"",""BlockS"" Bairro,""Usuario"",""Rua"" "
        tSQL = tSQL & " from V_CARREGAMENTO V "

        If (TextBox1.Text = 4 Or TextBox1.Text = 5 Or TextBox1.Text = 6) Then
            tSQL = tSQL & " INNER JOIN ""@TBCIDADELEONI"" t ON T.""U_Cidade"" = v.""CityS"" "
        End If

        tSQL = tSQL & " where v.""U_Viagem"" = '" + TextBox1.Text + "' "

        If (TextBox1.Text = 30 Or TextBox1.Text = 31 Or TextBox1.Text = 32 Or TextBox1.Text = 33 Or TextBox1.Text = 34 Or TextBox1.Text = 35 Or TextBox1.Text = 36 Or TextBox1.Text = 37 Or TextBox1.Text = 38 Or TextBox1.Text = 39 Or TextBox1.Text = 47 Or TextBox1.Text = 49 Or TextBox1.Text = 50 Or TextBox1.Text = 51 Or TextBox1.Text = 52 Or TextBox1.Text = 53 Or TextBox1.Text = 54 Or TextBox1.Text = 55 Or TextBox1.Text = 56 Or TextBox1.Text = 57 Or TextBox1.Text = 58 Or TextBox1.Text = 59 Or TextBox1.Text = 9 Or TextBox1.Text = 46 Or TextBox1.Text = 45) Then
            tSQL = tSQL & " order by ""U_SeqCarregamento"", ""CityS"", ""Volume"" Desc "
        ElseIf (TextBox1.Text = 4 Or TextBox1.Text = 5 Or TextBox1.Text = 6) Then
            tSQL = tSQL & " order by ""U_SeqCarregamento"",T.""U_Sequencia"", v.""Volume"" "
        Else
            tSQL = tSQL & " order by ""CityS"",""U_SeqCarregamento"", ""Volume"" Desc "
        End If

        Qry.DoQuery(tSQL)

        DataGridView1.Rows.Clear()


        While Not Qry.EoF

            DataGridView1.Rows.Add(Qry.Fields.Item("DocEntry").Value.ToString, Qry.Fields.Item("PEDIDO").Value.ToString, Qry.Fields.Item("CardCode").Value.ToString + " - " + Qry.Fields.Item("CardName").Value.ToString, Qry.Fields.Item("Bairro").Value.ToString, Qry.Fields.Item("Rua").Value.ToString, Qry.Fields.Item("DocTotal").Value, Qry.Fields.Item("Peso").Value.ToString, Qry.Fields.Item("Volume").Value.ToString, Qry.Fields.Item("CityS").Value.ToString, Qry.Fields.Item("Serial").Value.ToString, Qry.Fields.Item("U_SeqCarregamento").Value.ToString, Qry.Fields.Item("Usuario").Value.ToString)

            Qry.MoveNext()
        End While

        DataGridView1.Refresh()

        tSQL = ""
        tSQL = " select count(distinct ""U_Num_Pedido"") TotalPed from V_CARREGAMENTO where ""U_Viagem"" = '" + TextBox1.Text + "' "
        Qry.DoQuery(tSQL)

        TextBox2.Text = Qry.Fields.Item("TotalPed").Value.ToString

    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ORDR = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders)

        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            If DataGridView1.Rows(i).Cells(10).Value.ToString() <> "" And DataGridView1.Rows(i).Cells(10).Value.ToString() <> "0" Then

                ORDR.GetByKey(DataGridView1.Rows(i).Cells(0).Value.ToString)
                ORDR.UserFields.Fields.Item("U_SeqCarregamento").Value = DataGridView1.Rows(i).Cells(10).Value.ToString
                If ORDR.Update() <> 0 Then
                    MsgBox(oCompany.GetLastErrorDescription)
                End If
            ElseIf DataGridView1.Rows(i).Cells(10).Value.ToString() = "0" Then
                ORDR.GetByKey(DataGridView1.Rows(i).Cells(0).Value.ToString)
                ORDR.UserFields.Fields.Item("U_SeqCarregamento").Value = ""
                If ORDR.Update() <> 0 Then
                    MsgBox(oCompany.GetLastErrorDescription)
                End If
            End If

        Next

        MsgBox("Atualizado!!")

    End Sub
End Class
