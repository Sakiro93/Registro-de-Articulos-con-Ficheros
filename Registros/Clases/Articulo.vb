Public Class Articulo
    Private _foto As String
    Private _codigo As String
    Private _descripcion As String
    Private _grupo As Integer
    Private _precio As Double
    Private _stock As Integer
    Private _iva As Integer
    Private _estado As Boolean
    ' constructor sobrecargado
    Sub New()
        _foto = String.Empty
        _codigo = 0
        _descripcion = ""
        _grupo = 0
        _precio = 0
        _stock = 0
        _iva = 0
        _estado = True
    End Sub
    Sub New(ByVal fot As String, ByVal _codigo As Integer, ByVal desc As String, ByVal grup As Integer, ByVal pre As Double, ByVal sto As Integer, ByVal iva As Integer, ByVal est As Boolean)
        _foto = fot
        Me._codigo = _codigo
        _descripcion = desc
        _grupo = grup
        _precio = pre
        _stock = sto
        _iva = iva
        _estado = est
    End Sub
    Public Property foto() As String
        Get
            Return _foto
        End Get
        Set(ByVal value As String)
            _foto = value
        End Set
    End Property

    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Public Property grupo() As Integer
        Get
            Return _grupo
        End Get
        Set(ByVal value As Integer)
            _grupo = value
        End Set
    End Property
    Public Property precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = value
        End Set
    End Property
    Public Property stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
        End Set
    End Property
    Public Property iva() As Integer
        Get
            Return _iva
        End Get
        Set(ByVal value As Integer)
            _iva = value
        End Set
    End Property
    Public Property estado() As Boolean
        Get
            Return _estado
        End Get
        Set(ByVal value As Boolean)
            _estado = value
        End Set
    End Property
    Function cargarDatos() As String
        Dim cadena As String
        cadena = _foto + ";" + _codigo.ToString + ";" + _descripcion + ";" + _grupo.ToString + ";" + _precio.ToString + ";" + _stock.ToString + ";" + _iva.ToString + ";" + _
        _estado.ToString()
        Return cadena
    End Function
End Class
