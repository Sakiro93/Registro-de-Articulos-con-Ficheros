Public Class FrmEstCon

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmEstCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            tooltip()
            leerArticulo(paths + "Datos\Articulo.txt", Dg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub
    Private Sub tooltip()
        TooMensaje.SetToolTip(BtnSalir, "Salir Del Formulario")
        TooMensaje.SetToolTip(BtnNuevo, "Nuevo Registro")
        TooMensaje.ToolTipTitle = "Sistema de Matriculacion"
        TooMensaje.ToolTipIcon = ToolTipIcon.Info
        TooMensaje.BackColor = Color.Tomato
    End Sub

    Private Sub TxtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBuscar.TextChanged
        buscarArticulo(paths + "Datos\Articulo.txt", Dg, TxtBuscar.Text.Trim)
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        grabar = "N"
        FrmEstMan.ShowDialog()
    End Sub

    Private Sub BtnNuevo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNuevo.GotFocus
        If grabar.Equals("ok") Then
            leerArticulo(paths + "Datos\Articulo.txt", Dg)
        End If
    End Sub
    Private Sub Dg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dg.Click
        If Dg.CurrentCell.ColumnIndex = 8 Then
            modifica()
        Else
            If Dg.CurrentCell.ColumnIndex = 9 Then
                elimina()
            End If
        End If
    End Sub
    Sub modifica()
        Dim i As Integer = Dg.CurrentRow.Index
        Dim codigo As String = Val(Dg.Rows(i).Cells(1).Value.ToString)
        objDatos = buscaArt(paths + "Datos\Articulo.txt", codigo)
        If objDatos Is Nothing Then
            MessageBox.Show("Error-->Articulo no se encuentra")
        Else
            grabar = "M"
            FrmEstMan.ShowDialog()
            If grabar.Equals("ok") Then
                leerArticulo(paths + "Datos\Articulo.txt", Dg)
            End If
        End If
    End Sub
    Sub elimina()
        Dim i As Integer = Dg.CurrentRow.Index
        Dim cad As String = Dg.Rows(i).Cells(2).Value.ToString
        Dim codbuscar As String = Dg.Rows(i).Cells(1).Value.ToString
        If MessageBox.Show("Esta Seguro De Eliminar El Articulo" + Chr(13) + Chr(13) + cad, "Sistema de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            If eliminarDatos(paths + "Datos\Articulo.txt", codbuscar) Then
                MessageBox.Show("Registro Eliminado Correctamente")
                leerArticulo(paths + "Datos\Articulo.txt", Dg)
            Else
                MessageBox.Show("Articulo No Se Encuentra Registrado")
            End If
        Else
            MessageBox.Show("Operacion Cancelada")
        End If
    End Sub
End Class
