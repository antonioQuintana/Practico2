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
        LDni = New Label()
        LNombre = New Label()
        LApellido = New Label()
        LNya = New Label()
        LModificar = New Label()
        TDni = New TextBox()
        TNombre = New TextBox()
        TApellido = New TextBox()
        BGuardar = New Button()
        BEliminar = New Button()
        BindingSource1 = New BindingSource(components)
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(48, 109)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 0
        LDni.Text = "DNI"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(48, 217)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 1
        LNombre.Text = "Nombre"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(48, 168)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 2
        LApellido.Text = "Apellido"
        ' 
        ' LNya
        ' 
        LNya.AutoSize = True
        LNya.Location = New Point(48, 53)
        LNya.Name = "LNya"
        LNya.Size = New Size(110, 15)
        LNya.TabIndex = 3
        LNya.Text = "Nombre y Apellido:"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(179, 53)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 4
        LModificar.Text = "modificar"
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(132, 106)
        TDni.Name = "TDni"
        TDni.Size = New Size(100, 23)
        TDni.TabIndex = 5
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(132, 217)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(100, 23)
        TNombre.TabIndex = 6
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(132, 160)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(100, 23)
        TApellido.TabIndex = 7
        ' 
        ' BGuardar
        ' 
        BGuardar.Location = New Point(83, 287)
        BGuardar.Name = "BGuardar"
        BGuardar.Size = New Size(75, 23)
        BGuardar.TabIndex = 8
        BGuardar.Text = "&Guardar"
        BGuardar.UseVisualStyleBackColor = True
        ' 
        ' BEliminar
        ' 
        BEliminar.Location = New Point(211, 287)
        BEliminar.Name = "BEliminar"
        BEliminar.Size = New Size(75, 23)
        BEliminar.TabIndex = 9
        BEliminar.Text = "&Eliminar"
        BEliminar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 361)
        Controls.Add(BEliminar)
        Controls.Add(BGuardar)
        Controls.Add(TApellido)
        Controls.Add(TNombre)
        Controls.Add(TDni)
        Controls.Add(LModificar)
        Controls.Add(LNya)
        Controls.Add(LApellido)
        Controls.Add(LNombre)
        Controls.Add(LDni)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pequeño Formulario"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDni As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNya As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BindingSource1 As BindingSource

End Class
