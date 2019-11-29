Imports System.IO
Imports System.Threading
Imports Microsoft.Office.Interop
Imports Npgsql

Public Class Form1

    Private _listInventary As New List(Of InventaryObject)
    Private _waitForm As LoadingData
    Private _inventaryData As InventaryData
    Private _idClientSelected As String

    Private _listDataOBject As New List(Of InventaryObject)

    WithEvents _bindigExist As New BindingSource()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _waitForm = New LoadingData
        _listDataOBject = New List(Of InventaryObject)
        _inventaryData = New InventaryData()
        cbx_LoadType.SelectedIndex = 0

        LoadClients()

    End Sub

    Private Sub LoadClients()
        cbx_Client.ValueMember = "Id"
        cbx_Client.DisplayMember = "Name"
        Dim clients = _inventaryData.Clients

        cbx_Client.Items.Add(New MenuItemObj With {.Id = "0", .Name = "Selecciona un Cliente"})
        For Each client In clients
            cbx_Client.Items.Add(New MenuItemObj With {.Id = client.Id, .Name = client.Name})
        Next
        cbx_Client.SelectedIndex = 0
    End Sub

    Private Sub Btn_Load_File_Click(sender As Object, e As EventArgs) Handles tbx_File.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            tbx_File.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Btn_LoadFile_Click(sender As Object, e As EventArgs) Handles btn_LoadFile.Click
        Dim tDialog = New Thread(New ThreadStart(AddressOf ShowWait))
        tDialog.Start()

        Dim listIventory = LoadFile(tbx_File.Text)

        For Each item In listIventory.Where(Function(x) x.IdBrand <> "0" AndAlso x.IdType <> "0" AndAlso x.IdLocation <> "0")
            tbx_Script.Text += item.Fnc_ins_inventario_primerpaso + vbCrLf
        Next

        LoadMissedData(listIventory)

        tDialog.Abort()

    End Sub

    Private Sub ShowWait()
        _waitForm.ShowDialog()
    End Sub

    Public Function LoadFile(Path As String) As List(Of InventaryFile)
        Dim inventaryList As New List(Of InventaryFile)
        Try
            Dim xlApp = New Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook = xlApp.Workbooks.Open(Path)
            Dim xlWorkSheet = xlWorkBook.Worksheets(1)
            Dim idx As Int32 = 0
            Dim lastUsedRow = xlWorkSheet.Cells.Find("*", Reflection.Missing.Value, Reflection.Missing.Value, Reflection.Missing.Value, Microsoft.Office.Interop.Excel.XlSearchOrder.xlByRows, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious, False, Reflection.Missing.Value, Reflection.Missing.Value).Row
            Dim lastUsedColumn = xlWorkSheet.Cells.Find("*", Reflection.Missing.Value, Reflection.Missing.Value, Reflection.Missing.Value, Microsoft.Office.Interop.Excel.XlSearchOrder.xlByColumns, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious, False, Reflection.Missing.Value, Reflection.Missing.Value).Column


            For idRow = 3 To lastUsedRow
                If idRow = 60 Then
                    Dim c = 0
                End If

                Dim inventary = New InventaryFile With {
                    .IdRow = idRow,
                    .NoInvetory = ParseValueObtained(xlWorkSheet.Cells(idRow, "A").Value),
                    .Location = ParseValueObtained(xlWorkSheet.Cells(idRow, "C").Value),
                    .IdClient = _idClientSelected
                }
                inventary.IdLocation = GetLocationId(ParseValueObtained(inventary.Location))

                inventary.SubLocation = ParseValueObtained(xlWorkSheet.Cells(idRow, "D").Value)
                inventary.IdSubLocation = GetSubLocationId(inventary.IdLocation, inventary.SubLocation)

                inventary.Type = ParseValueObtained(xlWorkSheet.Cells(idRow, "E").Value)

                GetCategoryType(inventary.Type, inventary.IdCategory, inventary.IdType)

                inventary.Brand = ParseValueObtained(xlWorkSheet.Cells(idRow, "F").Value)
                inventary.IdBrand = GetBrand(inventary.Brand)


                inventary.Model = ParseValueObtained(xlWorkSheet.Cells(idRow, "G").Value)
                inventary.Serial = ParseValueObtained(xlWorkSheet.Cells(idRow, "H").Value)

                inventary.Status = ParseValueObtained(xlWorkSheet.Cells(idRow, "I").Value)
                inventary.IdStatus = GetInventoryStatus(inventary.Status)

                inventary.Appertain = ParseValueObtained(xlWorkSheet.Cells(idRow, "J").Value)
                inventary.IdAppertain = GetInventoryAppertain(inventary.Appertain)

                inventary.GR = ParseValueObtained(xlWorkSheet.Cells(idRow, "K").Value)

                inventary.EId = ParseValueObtained(xlWorkSheet.Cells(idRow, "L").Value)

                inventaryList.Add(inventary)
            Next
            xlApp.Workbooks.Close()
            Return inventaryList
        Catch ex As Exception
            Return inventaryList
        End Try
    End Function

    Public Function GetLocationId(location As String) As String
        Dim locationObtained = _inventaryData.Locations.FirstOrDefault(Function(x) x.Location.ToUpper() = location.ToUpper())
        If IsNothing(locationObtained) Then
            Return "0"
        Else
            Return locationObtained.IdLocation.ToString().Trim()
        End If
    End Function

    Public Function GetSubLocationId(idLocation As Integer, sublocation As String) As String
        Dim sublocationObtained = _inventaryData.Locations.FirstOrDefault(Function(x) x.IdLocation = idLocation AndAlso x.SubLocation.ToUpper() = sublocation.ToUpper())
        If IsNothing(sublocationObtained) Then
            Return "0"
        Else
            Return sublocationObtained.IdSubLocation.ToString().Trim()
        End If
    End Function

    Public Sub GetCategoryType(type As String, ByRef idCategory As String, ByRef idType As String)
        Dim typeObtained = _inventaryData.InventoryType.FirstOrDefault(Function(x) x.Type.ToUpper() = type.ToUpper())
        If IsNothing(typeObtained) Then
            idCategory = "0"
            idType = "0"
        Else
            idCategory = typeObtained.IdCategory
            idType = typeObtained.IdType
        End If
    End Sub

    Public Function GetBrand(brand As String) As String
        Dim brandObtained = _inventaryData.Brands.FirstOrDefault(Function(x) x.Name.ToUpper() = brand.ToUpper())
        If IsNothing(brandObtained) Then
            Return 0
        Else
            Return brandObtained.Id
        End If
    End Function

    Public Function GetInventoryStatus(Status As String) As String
        Dim statusObtained = _inventaryData.InventoryStatus.FirstOrDefault(Function(x) x.Name.ToUpper() = Status.ToUpper())
        If IsNothing(statusObtained) Then
            Return 0
        Else
            Return statusObtained.Id
        End If
    End Function

    Public Function GetInventoryAppertain(Appertain As String) As String
        Dim appertainObtained = _inventaryData.InventoryAppertain.FirstOrDefault(Function(x) x.Name.ToUpper() = Appertain.ToUpper())
        If IsNothing(appertainObtained) Then
            Return 0
        Else
            Return appertainObtained.Id
        End If
    End Function

    Public Function ParseValueObtained(valueToParse As Object) As String
        If Not IsNothing(valueToParse) Then
            Return valueToParse.ToString().Trim().ToUpper()
        Else
            Return ""
        End If
    End Function

    Private Sub Cbx_Client_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_Client.SelectedIndexChanged
        Dim selectedClient = DirectCast(DirectCast(sender, ComboBox).SelectedItem, MenuItemObj)
        If selectedClient.Id = 0 Then
            Return
        End If
        _idClientSelected = selectedClient.Id
        _inventaryData.LoadDataByClient(selectedClient.Id)
        gb_Load.Enabled = True
    End Sub

    Private Sub LoadMissedData(listInventary As List(Of InventaryFile))
        dgv_Brand.Rows.Clear()
        dgv_Type.Rows.Clear()
        dgv_Location.Rows.Clear()
        dgv_SubLocation.Rows.Clear()

        For Each item In listInventary.Where(Function(x) x.IdBrand = "0").Select(Function(x) x.Brand).Distinct()
            dgv_Brand.Rows.Add(False, item)
        Next

        For Each item In listInventary.Where(Function(x) x.IdType = "0").Select(Function(x) x.Type).Distinct()
            dgv_Type.Rows.Add(False, item)
        Next

        For Each item In listInventary.Where(Function(x) x.IdLocation = "0").Select(Function(x) x.Location).Distinct()
            dgv_Location.Rows.Add(False, item)
        Next

        For Each item In listInventary.Where(Function(x) x.IdSubLocation = "0").Select(Function(x) x.SubLocation).Distinct()
            dgv_SubLocation.Rows.Add(False, item)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class


