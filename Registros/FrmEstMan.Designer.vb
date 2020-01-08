<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstMan
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstMan))
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.GrpDatos = New System.Windows.Forms.GroupBox()
        Me.CboGrupo = New System.Windows.Forms.ComboBox()
        Me.BtnSubir = New System.Windows.Forms.Button()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.GboIva = New System.Windows.Forms.GroupBox()
        Me.Op0 = New System.Windows.Forms.RadioButton()
        Me.Op14 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ImgFoto = New System.Windows.Forms.PictureBox()
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TooMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpDatos.SuspendLayout()
        Me.GboIva.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(33, 424)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(128, 39)
        Me.BtnGuardar.TabIndex = 78
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Khaki
        Me.Label8.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 21)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Codigo"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Black
        Me.TxtCodigo.Location = New System.Drawing.Point(131, 18)
        Me.TxtCodigo.MaxLength = 10
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(216, 26)
        Me.TxtCodigo.TabIndex = 0
        Me.TxtCodigo.Text = "Codigo Automatico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Goldenrod
        Me.Label1.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Descripcion"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(130, 54)
        Me.TxtDescripcion.MaxLength = 19
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(217, 26)
        Me.TxtDescripcion.TabIndex = 1
        '
        'GrpDatos
        '
        Me.GrpDatos.BackColor = System.Drawing.Color.Transparent
        Me.GrpDatos.Controls.Add(Me.CboGrupo)
        Me.GrpDatos.Controls.Add(Me.BtnSubir)
        Me.GrpDatos.Controls.Add(Me.TxtStock)
        Me.GrpDatos.Controls.Add(Me.GboIva)
        Me.GrpDatos.Controls.Add(Me.GroupBox4)
        Me.GrpDatos.Controls.Add(Me.ChkEstado)
        Me.GrpDatos.Controls.Add(Me.Label6)
        Me.GrpDatos.Controls.Add(Me.Label5)
        Me.GrpDatos.Controls.Add(Me.Label4)
        Me.GrpDatos.Controls.Add(Me.TxtPrecio)
        Me.GrpDatos.Controls.Add(Me.Label3)
        Me.GrpDatos.Controls.Add(Me.Label2)
        Me.GrpDatos.Controls.Add(Me.TxtDescripcion)
        Me.GrpDatos.Controls.Add(Me.Label1)
        Me.GrpDatos.Controls.Add(Me.TxtCodigo)
        Me.GrpDatos.Controls.Add(Me.Label8)
        Me.GrpDatos.ForeColor = System.Drawing.Color.Black
        Me.GrpDatos.Location = New System.Drawing.Point(21, 62)
        Me.GrpDatos.Name = "GrpDatos"
        Me.GrpDatos.Size = New System.Drawing.Size(839, 356)
        Me.GrpDatos.TabIndex = 78
        Me.GrpDatos.TabStop = False
        '
        'CboGrupo
        '
        Me.CboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGrupo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic)
        Me.CboGrupo.FormattingEnabled = True
        Me.CboGrupo.Location = New System.Drawing.Point(130, 96)
        Me.CboGrupo.Name = "CboGrupo"
        Me.CboGrupo.Size = New System.Drawing.Size(217, 27)
        Me.CboGrupo.TabIndex = 5
        '
        'BtnSubir
        '
        Me.BtnSubir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubir.Location = New System.Drawing.Point(568, 324)
        Me.BtnSubir.Name = "BtnSubir"
        Me.BtnSubir.Size = New System.Drawing.Size(128, 26)
        Me.BtnSubir.TabIndex = 86
        Me.BtnSubir.Text = "SUBIR"
        Me.BtnSubir.UseVisualStyleBackColor = False
        '
        'TxtStock
        '
        Me.TxtStock.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStock.Location = New System.Drawing.Point(131, 170)
        Me.TxtStock.MaxLength = 4
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(124, 26)
        Me.TxtStock.TabIndex = 77
        '
        'GboIva
        '
        Me.GboIva.BackColor = System.Drawing.Color.Cornsilk
        Me.GboIva.Controls.Add(Me.Op0)
        Me.GboIva.Controls.Add(Me.Op14)
        Me.GboIva.Location = New System.Drawing.Point(130, 216)
        Me.GboIva.Name = "GboIva"
        Me.GboIva.Size = New System.Drawing.Size(289, 50)
        Me.GboIva.TabIndex = 62
        Me.GboIva.TabStop = False
        '
        'Op0
        '
        Me.Op0.AutoSize = True
        Me.Op0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Op0.Checked = True
        Me.Op0.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Op0.Location = New System.Drawing.Point(169, 13)
        Me.Op0.Name = "Op0"
        Me.Op0.Size = New System.Drawing.Size(50, 23)
        Me.Op0.TabIndex = 0
        Me.Op0.TabStop = True
        Me.Op0.Text = "0%"
        Me.Op0.UseVisualStyleBackColor = False
        '
        'Op14
        '
        Me.Op14.AutoSize = True
        Me.Op14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Op14.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Op14.Location = New System.Drawing.Point(42, 13)
        Me.Op14.Name = "Op14"
        Me.Op14.Size = New System.Drawing.Size(60, 23)
        Me.Op14.TabIndex = 1
        Me.Op14.Text = "14%"
        Me.Op14.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ImgFoto)
        Me.GroupBox4.Font = New System.Drawing.Font("Mistral", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(453, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(347, 300)
        Me.GroupBox4.TabIndex = 66
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Foto"
        '
        'ImgFoto
        '
        Me.ImgFoto.Image = CType(resources.GetObject("ImgFoto.Image"), System.Drawing.Image)
        Me.ImgFoto.Location = New System.Drawing.Point(9, 24)
        Me.ImgFoto.Name = "ImgFoto"
        Me.ImgFoto.Size = New System.Drawing.Size(332, 256)
        Me.ImgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgFoto.TabIndex = 0
        Me.ImgFoto.TabStop = False
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoSize = True
        Me.ChkEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkEstado.Checked = True
        Me.ChkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEstado.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstado.Location = New System.Drawing.Point(130, 279)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(80, 25)
        Me.ChkEstado.TabIndex = 1
        Me.ChkEstado.Text = "Activo"
        Me.ChkEstado.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Goldenrod
        Me.Label5.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 21)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Goldenrod
        Me.Label4.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Stock"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(130, 131)
        Me.TxtPrecio.MaxLength = 7
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(124, 26)
        Me.TxtPrecio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Goldenrod
        Me.Label3.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Goldenrod
        Me.Label2.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Grupo"
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(474, 393)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(0, 29)
        Me.TxtBuscar.TabIndex = 81
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(771, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(89, 44)
        Me.BtnSalir.TabIndex = 83
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Wheat
        Me.Label9.Font = New System.Drawing.Font("Goudy Stout", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(16, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(650, 28)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "MANTENIMIENTO DE ARTICULOS"
        '
        'FrmEstMan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(873, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.GrpDatos)
        Me.Controls.Add(Me.BtnSalir)
        Me.MaximizeBox = False
        Me.Name = "FrmEstMan"
        Me.Text = "Mantenimiento"
        Me.GrpDatos.ResumeLayout(False)
        Me.GrpDatos.PerformLayout()
        Me.GboIva.ResumeLayout(False)
        Me.GboIva.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GrpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents CboGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSubir As System.Windows.Forms.Button
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents GboIva As System.Windows.Forms.GroupBox
    Friend WithEvents Op0 As System.Windows.Forms.RadioButton
    Friend WithEvents Op14 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ImgFoto As System.Windows.Forms.PictureBox
    Friend WithEvents ChkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TooMensaje As System.Windows.Forms.ToolTip
End Class
