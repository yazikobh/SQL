Public Class Propiedades
    Private _CODPROD As String
    Private _NOMBRE As String
    Private _EXISTENCIA As Integer
    Private _IMAGEN() As Byte

    Public Property cod_prod As String
        Get
            Return _CODPROD
        End Get
        Set(value As String)
            _CODPROD = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _NOMBRE
        End Get
        Set(value As String)
            _NOMBRE = value
        End Set
    End Property

    Public Property existencia As Integer
        Get
            Return _EXISTENCIA
        End Get
        Set(value As Integer)
            _EXISTENCIA = value
        End Set
    End Property

    Public Property imagen
        Get
            Return _IMAGEN
        End Get
        Set(value)
            _IMAGEN = value
        End Set
    End Property
End Class
