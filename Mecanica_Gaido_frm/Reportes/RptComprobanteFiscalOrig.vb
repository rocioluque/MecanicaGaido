Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class RptComprobanteFiscalOrig


    Inherits Telerik.Reporting.Report
    Dim Suma As Integer

    Public Sub New()
        InitializeComponent()

        Suma = 0 'Convert.ToInt16(pageHeaderSection1.Height.Value) + Convert.ToInt16(ReportHeaderSection1.Height.Value)

        'Dim Dir As String = My.Application.Info.DirectoryPath
        'PictureBox1.Value = Image.FromFile(Dir & "\Img\LogoEmpresa2.png")


        'ReportFooterSection1.Height = Unit.Mm(220 - Suma)

        ' Dim Dir As String = My.Application.Info.DirectoryPath
        TxtLetraTotal.Value = G_ImpLet
        'Select Case G_EmpresaID
        '    Case 1
        '        PictureBox1.Value = My.Resources.Resource2.logo_2
        '    Case 2
        '        PictureBox1.Value = My.Resources.Resource2.logo_2

        '        'Case 1
        '        '    PictureBox1.Value = Image.FromFile(Dir & "\Img\1.png")
        '        'Case 2
        '        '    PictureBox1.Value = Image.FromFile(Dir & "\Img\2.png")

        'End Select




    End Sub


    Private Sub detail_ItemDataBinding(sender As Object, e As System.EventArgs) Handles detail.ItemDataBinding
        Suma = Suma + Convert.ToInt16(10)
        'Shape20.Height = Unit.Mm(150 - Suma)
        ReportFooterSection1.Height = Unit.Mm(140 - Suma)

    End Sub

    'Private Sub TxtQR_ItemDataBound(sender As Object, e As EventArgs) Handles TxtQR.ItemDataBound
    '    'If ContadorQR = False Then
    '    '    Dim tb = TryCast(sender, Telerik.Reporting.Processing.TextBox)
    '    '    Dim CadenaB64 = TryCast(Telerik.Reporting.Processing.ElementTreeHelper.FindChildByName(tb.Report, "TxtQR", True)(0), Telerik.Reporting.Processing.TextBox)
    '    '    QR = CadenaB64.Value
    '    '    ContadorQR = True
    '    'End If
    'End Sub

    'Private Sub Pbqr_ItemDataBound(sender As Object, e As EventArgs) Handles Pbqr.ItemDataBound
    '    'If ContadorImg = False Then
    '    '    Dim imagen As Image = GetImageFromBase64String(QR)



    '    '    Me.Pbqr.Value = imagen
    '    '    ContadorImg = True
    '    'End If
    '    'Application.DoEvents()
    'End Sub

    Private Sub PageFooterSection1_ItemDataBound(sender As Object, e As EventArgs) Handles PageFooterSection1.ItemDataBound
        'If ContadorImg = False Then
        '    Dim imagen As Image = GetImageFromBase64String(QR)



        '    Me.Pbqr.Value = imagen
        '    ContadorImg = True
        'End If
        'Application.DoEvents()

    End Sub

    Private Sub TxtQR_ItemDataBound(sender As Object, e As EventArgs) Handles TxtQR.ItemDataBound
        Dim QR As String = ""
        Dim tb = TryCast(sender, Telerik.Reporting.Processing.TextBox)
        Dim CadenaB64 = TryCast(Telerik.Reporting.Processing.ElementTreeHelper.FindChildByName(tb.Report, "TxtQR", True)(0), Telerik.Reporting.Processing.TextBox)
        QR = CadenaB64.Value
        Dim imagen As Image = GetImageFromBase64String(QR)
        Me.PictureBox3.Value = imagen
    End Sub
End Class