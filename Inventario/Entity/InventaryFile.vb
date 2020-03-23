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

    Property EId As String

    Property IdClient As String

    Property ProveedorServicio As String

    Property ProveedorComercial As String

    ReadOnly Property Fnc_ins_inventario_primerpaso As String
        Get
            Dim insert = String.Format("SELECT * FROM operativo.fnc_ins_inventario_primerpaso({0}, {1}, {2}, 0, {3}, '{4}', 0, '{5}', 0, {6}, {7}, {8}, 0, Null, Null, {9}, '0', '{10}', '0', '0', '0',Null);", IdClient, IdCategory, IdType, IdBrand, SafeSubstring(Model, 50), SafeSubstring(Serial, 50), IdAppertain, IdLocation, IdSubLocation, IdStatus, SafeSubstring(EId, 50))
            Dim update = String.Format("UPDATE operativo.inventario Set cod_proveedor_servicio = {9}, cod_proveedor_comercial = {10} where cod_cliente = {0} And cod_categoria = {1} And cod_tipo_activo = {2} And serie = '{4}' And cod_marca = {5} And cod_ubicacion = {6} And cod_sub_ubicacion = {7} estatus = {8};", IdClient, IdCategory, IdType, SafeSubstring(Model, 50), IdBrand, IdLocation, IdSubLocation, IdStatus, ProveedorServicio, ProveedorComercial)

            Return insert + " " + update

        End Get
    End Property

    Function SafeSubstring(orig As String, length As Int32) As String
        Return orig.Substring(0, IIf(orig.Length >= length, length, orig.Length))
    End Function

End Class
