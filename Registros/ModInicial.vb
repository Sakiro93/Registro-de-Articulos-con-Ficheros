Imports System.IO

Module ModInicial
    Private pos As Integer = Application.StartupPath.ToString.IndexOf("bin")
    Public paths As String = Application.StartupPath.ToString.Substring(0, pos)
    Public grabar As String = ""
    Public varcodigo As Integer
    Public objDatos As Object
    Public Function ValidaEntrada(ByVal err As ErrorProvider, ByVal grp As GroupBox) As Boolean
        Dim er As Boolean = True
        For Each C In grp.Controls 'For que se lo utiliza para leer colecciones
            If TypeOf C Is TextBox And C.Text = "" Then 'TypeOf = tipo
                err.SetError(C, "No ha ingresado informacion en: " + C.Name)
                er = False
            End If
            If TypeOf C Is ComboBox And C.Text = "" Then
                err.SetError(C, "No ha Seleccionado ninguna opcion en: " + C.Name)
                er = False
            End If
        Next
        Return er
    End Function
    Public Sub LimpiarGroupbox(ByVal Grp As GroupBox)
        For Each C In Grp.Controls
            If TypeOf C Is TextBox Then C.Text = ""
            If TypeOf C Is ComboBox Then C.SelectedIndex = 0
        Next
    End Sub
    Public Sub leerArticulo(ByVal fichero As String, ByRef dg As DataGridView)
        ' Abrimos el fichero para leer
        Try
            Dim grupo As New StreamReader(paths + "Datos\Grupo.txt", True)
            Dim grupos() As String = Split(grupo.ReadToEnd, ";")
            Dim articulo As New StreamReader(fichero, True)
            Dim art As String
            grupo.Close()
            dg.Rows.Clear()
            ' recorremos el fichero hasta que no haya nada que leer
            While articulo.Peek <> -1
                art = articulo.ReadLine
                Dim datos() As String = Split(art, ";")
                dg.Rows.Add(New Bitmap(paths + "Fotos\" + datos(0).ToString), datos(1), datos(2), grupos(datos(3)), "$ " + datos(4), datos(5), If(datos(6) = 1, "14%", "0%"), CBool(datos(7)), datos(0))
            End While
            articulo.Close()
        Catch ex As Exception
            MessageBox.Show("Error en el Archivo Articulo")
        End Try
    End Sub
    Public Sub buscarArticulo(ByVal fichero As String, ByRef dg As DataGridView, ByVal buscado As String)
        ' Abrimos el fichero para leer
        Try
            Dim grupo As New StreamReader(paths + "Datos\Grupo.txt", True)
            Dim grupos() As String = Split(grupo.ReadToEnd, ";")
            Dim articulo As New StreamReader(fichero, True)
            Dim art As String
            grupo.Close()
            dg.Rows.Clear()
            ' recorremos el fichero hasta que no haya nada que leer
            While articulo.Peek <> -1
                art = articulo.ReadLine
                Dim datos() As String = Split(art, ";")
                If datos(2).Trim.ToUpper Like "*" + buscado.Trim.ToUpper + "*" Or grupos(datos(3)).Trim.ToUpper Like "*" + buscado.Trim.ToUpper + "*" Or datos(4).Trim.ToUpper Like "*" + buscado.Trim.ToUpper + "*" Then
                    dg.Rows.Add(New Bitmap(paths + "Fotos\" + datos(0).ToString), datos(1), datos(2), grupos(datos(3)), "$ " + datos(4), datos(5), If(datos(6) = 1, "14%", "0%"), CBool(datos(7)), datos(0))
                End If
            End While
            articulo.Close()
        Catch ex As Exception
            MessageBox.Show("No hay datos que consultar")
        End Try
    End Sub
    Public Function buscaArt(ByVal fichero As String, ByVal buscado As String) As Articulo
        ' Abrimos el fichero para leer
        Dim objArt As Articulo = Nothing
        Dim articulos As StreamReader = Nothing
        Try
            articulos = New StreamReader(fichero, True)
            Dim art As String
            Dim enc As Boolean = False
            While articulos.Peek <> -1 And enc = False
                art = articulos.ReadLine
                Dim datos() As String = Split(art, ";")
                If datos(1).Trim.ToUpper.Equals(buscado.Trim.ToUpper) Then
                    enc = True
                    objArt = New Articulo(datos(0).ToString, Val(datos(1)), datos(2), Val(datos(3)), datos(4), Val(datos(5)), Val(datos(6)), CBool(datos(7)))
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("Error en el Archivo de Articulo")
        End Try
        articulos.Close()
        Return objArt
    End Function

    Public Function SiguienteArticulo(ByVal fichero As String) As String
        ' Abrimos el fichero para leer
        Dim codigo As String = "0"
        Try
            Dim articulo As New StreamReader(fichero, True)
            Dim art As String
            ' recorremos el fichero hasta que no haya nada que leer
            While articulo.Peek <> -1
                art = articulo.ReadLine
                Dim datos() As String = Split(art, ";")
                codigo = datos(1)
            End While
            ' cerramos el fichero
            articulo.Close()
        Catch ex As Exception
            MessageBox.Show("Error en el Archivo Articulo")
        End Try
        Return codigo
    End Function
    Public Sub guardarDatos(ByVal fichero As String, ByVal cadena As String)
        ' Abrimos el fichero para escribir, (añadir),
        Dim articulo As StreamWriter = Nothing
        Try
            articulo = New StreamWriter(fichero, True)
            articulo.WriteLine(cadena)
        Catch ex As Exception
            MessageBox.Show("Error en el Archivo Estudiantes")
        End Try
        articulo.Close()
    End Sub
    Public Sub modificarDatos(ByVal fichero As String, ByVal cadena As String)
        Dim datosModificar() As String = Split(cadena, ";")
        Dim archArt As New StreamReader(fichero, True)
        Dim archTemp As New StreamWriter(paths + "Datos\temp.txt", True)
        Dim articulo As String
        While archArt.Peek <> -1
            articulo = archArt.ReadLine
            Dim datos() As String = Split(articulo, ";")
            If datos(1).Trim <> datosModificar(1).Trim Then
                archTemp.WriteLine(articulo)
            Else
                archTemp.WriteLine(cadena)
            End If
        End While
        archArt.Close()
        archTemp.Close()
        File.Delete(fichero)
        File.Move(paths + "Datos\temp.txt", fichero)
    End Sub
    Public Function eliminarDatos(ByVal fichero As String, ByVal codigo As String) As Boolean
        Dim archArt As New StreamReader(fichero, True)
        Dim archTemp As New StreamWriter(paths + "Datos\temp.txt", True)
        Dim articulo As String
        Dim enc As Boolean = False
        While archArt.Peek <> -1
            articulo = archArt.ReadLine
            Dim datos() As String = Split(articulo, ";")
            If datos(1).Trim.Equals(codigo.Trim) Then
                enc = True
            Else
                archTemp.WriteLine(articulo)
            End If
        End While
        ' cerramos el fichero
        archArt.Close()
        archTemp.Close()
        If enc Then
            File.Delete(fichero)
            File.Move(paths + "Datos\temp.txt", fichero)
        End If
        Return enc
    End Function
End Module
