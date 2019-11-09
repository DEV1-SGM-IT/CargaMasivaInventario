Public Class InventaryFile

    Property IdRow As Integer

    Property NoInvetory As String

    Property Location As String

    Property IdLocation As String

    Property SubLocation As String

    Property IdSubLocation As String

    Property IdCategory As String

    Property IdType As String

    Property Type As String

    Property IdBrand As String

    Property Brand As String

    Property Model As String

    Property Serial As String

    Property IdStatus As String

    Property Status As String

    Property IdAppertain As String

    Property Appertain As String

    Property GR As String

    Property IdClient As String

    ReadOnly Property Fnc_ins_inventario_primerpaso As String
        Get
            Return String.Format("SELECT * FROM operativo.fnc_ins_inventario_primerpaso({0}, {1}, {2}, 2033, {3}, '{4}', 0, '{5}', 0, {6}, {7}, {8}, 0, Null, Null, {9}, '0', 'N/A', '0', '0', '0');", IdClient, IdCategory, IdType, IdBrand, Model, Serial, IdAppertain, IdLocation, IdSubLocation, IdStatus)
        End Get
    End Property


    'Private Function GetInsertfnc_ins_inventario_primerpaso()
    '    Dim sQuery As String = String.Empty

    '    sQuery = String.Format("SELECT * FROM operativo.fnc_ins_inventario_primerpaso({0}, {1}, {2}, 2033, {3}, {4}, 0, {5}, 0, {6}, {7}, {8}, 0, Null, Null, {9}, '0', 'N/A', '0', '0', '0');", IdClient, IdCategory, IdType, IdBrand, Brand, Serial, IdAppertain, IdLocation, IdSubLocation, IdStatus)

    '    Return sQuery
    'End Function

End Class
