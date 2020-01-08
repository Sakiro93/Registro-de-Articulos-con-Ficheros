Imports System.IO
Public Class FrmEstMan
    Private fotos As OpenFileDialog
    Private numeros As Integer
    Private foto As String
    Dim c As Integer = 0
    Public Sub cargarGrupo()
        CboGrupo.Items.Clear()
        Try 'Para operaciones complejas
            Dim grupo As New StreamReader(paths + "Datos\Grupo.txt", True) 'StreamReader lee archivos- StreamWriter escribe archivos
            Dim gru As String = grupo.ReadToEnd
            Dim datos() As String = Split(gru, ";")
            grupo.Close()
            For i = 0 To datos.Length - 1
                CboGrupo.Items.Add(datos(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Error en la lectura del Archivo Facultad.txt") 'vbcr da un salto de linea
            End
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        grabar = ""
        Me.Close()
    End Sub
    Private Sub FrmEstMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tooltip()
        cargarGrupo()
        ImgFoto.Image = New Bitmap(paths + "imagenes\sinfoto.jpg")
        fotos = New OpenFileDialog()
        fotos.FileName = paths + "imagenes\sinfoto.jpg"
        LimpiarGroupbox(GrpDatos)
        If grabar = "M" Then
            cargarArticulo()
        Else
            TxtCodigo.Text = Val(SiguienteArticulo(paths + "Datos\Articulo.txt")) + 1
        End If
    End Sub
    Private Sub cargarArticulo()
        TxtCodigo.Text = objDatos.codigo
        TxtDescripcion.Text = objDatos.descripcion
        CboGrupo.SelectedIndex = objDatos.grupo
        TxtPrecio.Text = objDatos.precio
        TxtStock.Text = objDatos.stock
        If objDatos.iva = 1 Then
            Op14.Checked = True
        Else
            Op0.Checked = True
        End If
        ChkEstado.Checked = objDatos.estado
        fotos = New OpenFileDialog()
        fotos.FileName = objDatos.foto
        ImgFoto.Image = New Bitmap(paths + "Fotos\" + fotos.FileName)

    End Sub
    Private Sub tooltip() 'Mensaje 
        TooMensaje.SetToolTip(BtnSalir, "Salir Del Formulario")
        TooMensaje.SetToolTip(BtnGuardar, "Guardar Registro")
        TooMensaje.SetToolTip(BtnSubir, "Subir Imagen")
        TooMensaje.ToolTipTitle = "Sistema de Matriculacion"
        TooMensaje.ToolTipIcon = ToolTipIcon.Info
        TooMensaje.BackColor = Color.Tomato
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If MessageBox.Show("Esta Seguro de Grabar el Registro", "Sistema de Matriculacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'If TxtDireccion.Text = "" Then
            '    ErrDatos.SetError(TxtDireccion, "No ha ingresado informacion en: " + TxtDireccion.Name)
            'End If
            ErrDatos.Clear()
            foto = fotos.SafeFileName
            If ValidaEntrada(ErrDatos, GrpDatos) Then
                Dim est As New Articulo(Me.foto, Val(TxtCodigo.Text), TxtDescripcion.Text, CboGrupo.SelectedIndex, Val(TxtPrecio.Text), Val(TxtStock.Text), IIf(Op14.Checked, 1, 0), ChkEstado.Checked)
                If grabar = "N" Then
                    guardarDatos(paths + "Datos\Articulo.txt", est.cargarDatos)
                Else
                    modificarDatos(paths + "Datos\Articulo.txt", est.cargarDatos)
                End If
                MessageBox.Show("Registro Grabado Correctamente")
                grabar = "ok"
                Me.Close()
            Else
                MessageBox.Show("Datos Incorrectos")
            End If
        End If
    End Sub

    Private Sub BtnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubir.Click
        fotos = New OpenFileDialog()
        fotos.DefaultExt = "*.jpg"
        fotos.Multiselect = False
        fotos.InitialDirectory = paths + "Fotos\"
        fotos.Filter = "Tipo (*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp"
        fotos.Title = "Seleccione un Archivo de imagen Articulo "
        If fotos.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImgFoto.Image = New Bitmap(fotos.FileName)
            If Not File.Exists(paths + "Fotos\" + foto) Then
                foto = fotos.SafeFileName
                ImgFoto.Image.Save(paths + "Fotos\" + foto)
            End If
        End If
    End Sub
    Private Sub TxtPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If Not TxtPrecio.Text.Contains(".") Then
            c = 0
        End If
        If e.KeyChar = "." AndAlso Not TxtPrecio.Text.Contains(".") Then
            e.Handled = False
        Else
            If Not Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso Not TxtPrecio.Text.Contains(".") Then
                e.Handled = True
            Else
                If TxtPrecio.Text.Contains(".") Then
                    If Char.IsNumber(e.KeyChar) AndAlso e.KeyChar <> vbBack AndAlso c < 2 Then
                        c += 1
                    Else
                        If e.KeyChar = vbBack Then
                            c -= 1
                        Else
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TxtStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub
End Class