Imports Npgsql

Public Class InventaryData

    Private _codClient As Integer

    Private _listlocations As List(Of Location)
    Private _listclients As List(Of Client)
    Private _listInventary As List(Of InventaryObject)
    Private _listStatus As List(Of InventaryStatus)
    Private _listType As List(Of InventaryType)
    Private _listAppertain As List(Of InventaryAppertain)
    Private _listBrand As List(Of Brand)

    Private appSettingReader As New Configuration.AppSettingsReader

    ReadOnly Property Clients As List(Of Client)
        Get
            Return _listclients
        End Get
    End Property

    ReadOnly Property Locations As List(Of Location)
        Get
            Return _listlocations
        End Get
    End Property

    ReadOnly Property Inventory As List(Of InventaryObject)
        Get
            Return _listInventary
        End Get
    End Property

    ReadOnly Property InventoryStatus As List(Of InventaryStatus)
        Get
            Return _listStatus
        End Get
    End Property

    ReadOnly Property InventoryType As List(Of InventaryType)
        Get
            Return _listType
        End Get
    End Property

    ReadOnly Property InventoryAppertain As List(Of InventaryAppertain)
        Get
            Return _listAppertain
        End Get
    End Property

    ReadOnly Property Brands As List(Of Brand)
        Get
            Return _listBrand
        End Get
    End Property

    Public Sub New()
        LoadClients()
        LoadInventaryStatus()
        LoadInventaryAppertain()
        LoadInventoryType()
        LoadBrands()
    End Sub

    Public Sub LoadDataByClient(codCliente As Integer)
        _codClient = codCliente
        LoadLocations()
        LoadInventory()
    End Sub

    Private Function LoadClients()
        _listclients = New List(Of Client)
               
        Dim query = appSettingReader.GetValue("LoadClients", GetType(String))


        query = EliminarSaltosLinea(query)
        Using conn As New NpgsqlConnection(My.Resources.connectionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            _listclients.Add(New Client With {
                                                            .Id = reader.GetInt32(0),
                                                            .Name = reader.GetString(1).Trim()
                                                        })
                        End While
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error in Connection")
            End Try
        End Using

        Return _listclients
    End Function

    Public Sub LoadLocations()
        _listlocations = New List(Of Location)

        Dim query = String.Format(appSettingReader.GetValue("LoadLocations", GetType(String)))

        query = EliminarSaltosLinea(query)
        Using conn As New NpgsqlConnection(My.Resources.connectionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            _listlocations.Add(New Location With {
                                                            .IdLocation = reader.GetInt32(0),
                                                            .Location = reader.GetString(1).Trim(),
                                                            .IdSubLocation = reader.GetInt32(2),
                                                            .SubLocation = reader.GetString(3).Trim()
                                                        })
                        End While
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error in Connection")
            End Try
        End Using
    End Sub

    Private Sub LoadInventory()
        _listInventary = New List(Of InventaryObject)
        Dim query = appSettingReader.GetValue("LoadInventory", GetType(String))

        query = EliminarSaltosLinea(query)
        Using conn As New NpgsqlConnection(My.Resources.connectionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()

                            Try
                                Dim inventary = New InventaryObject()
                                inventary.IdClient = reader.GetInt32(0)
                                inventary.Client = reader.GetString(1).Trim()
                                inventary.IdLocation = reader.GetInt32(2)
                                inventary.Location = reader.GetString(3).Trim()
                                inventary.IdSubLocation = reader.GetInt32(4)
                                inventary.SubLocation = reader.GetString(5).Trim()
                                inventary.IdType = reader.GetInt32(6)
                                inventary.Type = reader.GetString(7).Trim()

                                inventary.IdBrand = reader.GetInt32(8)
                                inventary.Brand = reader.GetString(9).Trim()


                                inventary.IdModel = reader.GetInt32(10)
                                inventary.Model = reader.GetString(11).Trim()
                                inventary.IdNumberSerie = reader.GetInt32(12)
                                inventary.NumberSerie = reader.GetString(13).Trim()
                                inventary.IdStatus = reader.GetInt32(14)
                                inventary.Status = reader.GetString(15).Trim()
                                inventary.IdAppertain = reader.GetInt32(16)
                                inventary.Appertain = reader.GetString(17).Trim()
                                inventary.IdCodCategoria = reader.GetInt32(18)

                                _listInventary.Add(inventary)

                            Catch ex As Exception

                            End Try
                        End While
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error In Connection")
            End Try
        End Using
    End Sub

    Private Sub LoadInventoryType()
        _listType = New List(Of InventaryType)
        Dim query = appSettingReader.GetValue("LoadInventoryType", GetType(String))

        query = EliminarSaltosLinea(query)
        Using conn As New NpgsqlConnection(My.Resources.connectionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            _listType.Add(New InventaryType With {
                                                            .IdType = reader.GetInt32(0),
                                                            .Type = reader.GetString(1).Trim(),
                                                            .IdCategory = reader.GetInt32(2)
                                                        })
                        End While
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error In Connection")
            End Try
        End Using
    End Sub

    Public Sub LoadInventaryStatus()
        _listStatus = New List(Of InventaryStatus)

        'Dim query = String.Format("Select
        '                            COALESCE(codigo,0),
        '                            COALESCE(nombre,'')
        '                        from general.v_catalogo_master 
        '                        where estatus = 1 And codcat In ('INV_ESTADO')")

        Dim query = appSettingReader.GetValue("LoadInventoryStatus", GetType(String))

        query = EliminarSaltosLinea(query)
        Using conn As New NpgsqlConnection(My.Resources.connectionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            _listStatus.Add(New InventaryStatus With {
                                                            .Id = reader.GetInt32(0),
                                                            .Name = reader.GetString(1).Trim()
                                                        })
                        End While
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error in Connection")
            End Try
        End Using
    End Sub

    Public Sub LoadInventaryAppertain()
        _listAppertain = New List(Of InventaryAppertain)

        'Dim query = String.Format("Select
        '                            COALESCE(codigo,0),
        '                            COALESCE(nombre,'')
        '                        from general.v_catalogo_master 
        '                        where estatus = 1 And codcat In ('PERTENENCIA')")


        Dim query = appSettingReader.GetValue("LoadAppertain", GetType(String))

        query = EliminarSaltosLinea(query)
        Using conn As New NpgsqlConnection(My.Resources.connectionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            _listAppertain.Add(New InventaryAppertain With {
                                                            .Id = reader.GetInt32(0),
                                                            .Name = reader.GetString(1).Trim()
                                                        })
                        End While
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error in Connection")
            End Try
        End Using
    End Sub

    Public Sub LoadBrands()
        _listBrand = New List(Of Brand)

        Dim query = appSettingReader.GetValue("LoadBrands", GetType(String))

        query = EliminarSaltosLinea(query)
        Using conn As New NpgsqlConnection(My.Resources.connectionString)
            Try
                conn.Open()
                Using cmd As New NpgsqlCommand(query, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            _listBrand.Add(New Brand With {
                                                            .Id = reader.GetInt32(0),
                                                            .Name = reader.GetString(1).Trim()
                                                        })
                        End While
                    End Using
                End Using
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error in Connection")
            End Try
        End Using
    End Sub

    Private Function EliminarSaltosLinea(ByVal texto As String) As String
        EliminarSaltosLinea = Replace(Replace(texto, Chr(10), ""), Chr(13), "")
    End Function

End Class
