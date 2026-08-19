<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BGuardar = New Button()
        ImgBTN = New ImageList(components)
        BEliminar = New Button()
        BindingSource1 = New BindingSource(components)
        Label1 = New Label()
        LDni = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LNya = New Label()
        LModificar = New Label()
        TDni = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        LTelefono = New Label()
        TTelefono = New TextBox()
        LTarjeta = New Label()
        CBNaranja = New CheckBox()
        CBVisa = New CheckBox()
        CBMastercard = New CheckBox()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        RBVaron = New RadioButton()
        RBMujer = New RadioButton()
        BSalir = New Button()
        Iconperson = New ImageList(components)
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BGuardar
        ' 
        BGuardar.ImageAlign = ContentAlignment.MiddleLeft
        BGuardar.ImageIndex = 1
        BGuardar.ImageList = ImgBTN
        BGuardar.Location = New Point(53, 455)
        BGuardar.Name = "BGuardar"
        BGuardar.Padding = New Padding(3, 0, 3, 0)
        BGuardar.RightToLeft = RightToLeft.No
        BGuardar.Size = New Size(115, 62)
        BGuardar.TabIndex = 8
        BGuardar.Text = "&Guardar"
        BGuardar.TextAlign = ContentAlignment.MiddleRight
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' ImgBTN
        ' 
        ImgBTN.ColorDepth = ColorDepth.Depth32Bit
        ImgBTN.ImageStream = CType(resources.GetObject("ImgBTN.ImageStream"), ImageListStreamer)
        ImgBTN.TransparentColor = Color.Transparent
        ImgBTN.Images.SetKeyName(0, "eliminar.png")
        ImgBTN.Images.SetKeyName(1, "guardar.png")
        ImgBTN.Images.SetKeyName(2, "salir.png")
        ' 
        ' BEliminar
        ' 
        BEliminar.ImageAlign = ContentAlignment.MiddleLeft
        BEliminar.ImageIndex = 0
        BEliminar.ImageList = ImgBTN
        BEliminar.Location = New Point(211, 455)
        BEliminar.Name = "BEliminar"
        BEliminar.Padding = New Padding(0, 0, 3, 0)
        BEliminar.Size = New Size(111, 62)
        BEliminar.TabIndex = 9
        BEliminar.Text = "&Eliminar"
        BEliminar.TextAlign = ContentAlignment.MiddleRight
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(211, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 32)
        Label1.TabIndex = 10
        Label1.Text = "Nuevo Cliente"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(31, 56)
        LDni.Name = "LDni"
        LDni.Size = New Size(32, 15)
        LDni.TabIndex = 0
        LDni.Text = "*DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(31, 149)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(56, 15)
        LNombre.TabIndex = 1
        LNombre.Text = "*Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(31, 100)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(56, 15)
        LApellido.TabIndex = 2
        LApellido.Text = "*Apellido"
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(16, 18)
        LNya.Name = "LNya"
        LNya.Size = New Size(110, 15)
        LNya.TabIndex = 3
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(147, 18)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 4
        LModificar.Text = "modificar"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(100, 56)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(100, 100)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(100, 146)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 7
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Location = New Point(31, 197)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(46, 15)
        LTelefono.TabIndex = 11
        LTelefono.Text = "Telfono"
        ' 
        ' TTelefono
        ' 
        TTelefono.Location = New Point(100, 194)
        TTelefono.Name = "TTelefono"
        TTelefono.Size = New Size(100, 23)
        TTelefono.TabIndex = 12
        ' 
        ' LTarjeta
        ' 
        LTarjeta.AutoSize = True
        LTarjeta.Location = New Point(31, 242)
        LTarjeta.Name = "LTarjeta"
        LTarjeta.Size = New Size(105, 15)
        LTarjeta.TabIndex = 13
        LTarjeta.Text = "Tarjeta de créditos:"
        ' 
        ' CBNaranja
        ' 
        CBNaranja.AutoSize = True
        CBNaranja.Location = New Point(147, 243)
        CBNaranja.Name = "CBNaranja"
        CBNaranja.Size = New Size(67, 19)
        CBNaranja.TabIndex = 14
        CBNaranja.Text = "Naranja"
        CBNaranja.UseVisualStyleBackColor = True
        ' 
        ' CBVisa
        ' 
        CBVisa.AutoSize = True
        CBVisa.Location = New Point(147, 268)
        CBVisa.Name = "CBVisa"
        CBVisa.Size = New Size(47, 19)
        CBVisa.TabIndex = 15
        CBVisa.Text = "Visa"
        CBVisa.UseVisualStyleBackColor = True
        ' 
        ' CBMastercard
        ' 
        CBMastercard.AutoSize = True
        CBMastercard.Location = New Point(147, 293)
        CBMastercard.Name = "CBMastercard"
        CBMastercard.Size = New Size(85, 19)
        CBMastercard.TabIndex = 16
        CBMastercard.Text = "Mastercard"
        CBMastercard.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightCyan
        Panel1.Controls.Add(CBMastercard)
        Panel1.Controls.Add(CBVisa)
        Panel1.Controls.Add(CBNaranja)
        Panel1.Controls.Add(LTarjeta)
        Panel1.Controls.Add(TTelefono)
        Panel1.Controls.Add(LTelefono)
        Panel1.Controls.Add(TNombre)
        Panel1.Controls.Add(TApellido)
        Panel1.Controls.Add(TDni)
        Panel1.Controls.Add(LModificar)
        Panel1.Controls.Add(LNya)
        Panel1.Controls.Add(LApellido)
        Panel1.Controls.Add(LNombre)
        Panel1.Controls.Add(LDni)
        Panel1.Location = New Point(32, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(315, 331)
        Panel1.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Location = New Point(402, 94)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(128, 128)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' RBVaron
        ' 
        RBVaron.AutoSize = True
        RBVaron.Location = New Point(402, 237)
        RBVaron.Name = "RBVaron"
        RBVaron.Size = New Size(55, 19)
        RBVaron.TabIndex = 19
        RBVaron.Text = "Varon"
        RBVaron.UseVisualStyleBackColor = True
        ' 
        ' RBMujer
        ' 
        RBMujer.AutoSize = True
        RBMujer.Location = New Point(483, 237)
        RBMujer.Name = "RBMujer"
        RBMujer.Size = New Size(56, 19)
        RBMujer.TabIndex = 20
        RBMujer.Text = "Mujer"
        RBMujer.UseVisualStyleBackColor = True
        ' 
        ' BSalir
        ' 
        BSalir.ImageAlign = ContentAlignment.MiddleLeft
        BSalir.ImageIndex = 2
        BSalir.ImageList = ImgBTN
        BSalir.Location = New Point(439, 455)
        BSalir.Name = "BSalir"
        BSalir.Padding = New Padding(3, 0, 3, 0)
        BSalir.Size = New Size(100, 62)
        BSalir.TabIndex = 21
        BSalir.Text = "Salir"
        BSalir.TextAlign = ContentAlignment.MiddleRight
        BSalir.UseVisualStyleBackColor = True
        ' 
        ' Iconperson
        ' 
        Iconperson.ColorDepth = ColorDepth.Depth32Bit
        Iconperson.ImageStream = CType(resources.GetObject("Iconperson.ImageStream"), ImageListStreamer)
        Iconperson.TransparentColor = Color.Transparent
        Iconperson.Images.SetKeyName(0, "hombre.png")
        Iconperson.Images.SetKeyName(1, "mujer.png")
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(584, 561)
        Controls.Add(BSalir)
        Controls.Add(RBMujer)
        Controls.Add(RBVaron)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pequeño Formulario"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents LTelefono As Label
    Friend WithEvents TTelefono As TextBox
    Friend WithEvents LTarjeta As Label
    Friend WithEvents CBNaranja As CheckBox
    Friend WithEvents CBVisa As CheckBox
    Friend WithEvents CBMastercard As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBVaron As RadioButton
    Friend WithEvents RBMujer As RadioButton
    Friend WithEvents ImgBTN As ImageList
    Friend WithEvents BSalir As Button
    Friend WithEvents Iconperson As ImageList

End Class
