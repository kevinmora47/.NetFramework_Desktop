Public Class Categoria

#Region "Atributos"
    Private _idcategoria As Integer
    Private _nombre As String
    Private _descripcion As String
    Private _estado As Boolean
#End Region

#Region "Propiedades"
    Public Property Idcategoria As Integer
        Get
            Return _idcategoria
        End Get
        Set(value As Integer)
            _idcategoria = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

#End Region

End Class

