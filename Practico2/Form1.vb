Public Class Form1
    Private Sub LDni_Click(sender As Object, e As EventArgs) Handles LDni.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RBVaron.Checked = True
    End Sub

    ' Validar solo números en TDni
    Private Sub TDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancela el caracter ingresado
        End If
    End Sub

    ' Validar solo letras en TApellido
    Private Sub TApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Validar solo letras en TNombre
    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        ' 7) Validar si algún campo está vacío con el operador Or
        If TDni.Text.Trim() = "" Or TNombre.Text.Trim() = "" Or TApellido.Text.Trim() = "" Then
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        ' 8) crear una variable
        Dim ask As MsgBoxResult

        '9) preguntar confirmacion
        ask = MsgBox("Seguro que desea insertar un nuevo Cliente?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmar Insercion")

        If ask = MsgBoxResult.Yes Then
            ' 6) Si pasó la validación, modificar el label
            LModificar.Text = TApellido.Text & " " & TNombre.Text
            MsgBox("El cliente: " & LModificar.Text & " se inserto correctamente", MsgBoxStyle.Information, "Guardar")
        End If


    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If TDni.Text.Trim() = "" Or TNombre.Text.Trim() = "" Or TApellido.Text.Trim() = "" Then
            MsgBox("Debe Completar todos los campos", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        LModificar.Text = TApellido.Text & " " & TNombre.Text
        Dim ask As MsgBoxResult
        ask = MsgBox("Seguro que desea eliminar el Cliente:" & LModificar.Text, MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Confirmar Eliminacion")

        If ask = MsgBoxResult.Yes Then


            MsgBox("El cliente: " & LModificar.Text & " se eliminó correctamente", MsgBoxStyle.Information, "Eliminar")
            LModificar.Text = "modificar"
            TDni.Clear()
            TNombre.Clear()
            TApellido.Clear()

        End If

    End Sub

    Private Sub RBVaron_CheckedChanged(sender As Object, e As EventArgs) Handles RBVaron.CheckedChanged
        ' 7) Si se selecciona Varón, muestra el ícono en la posición 0 de la lista
        If RBVaron.Checked Then
            PictureBox1.Image = Iconperson.Images(0)
        End If
    End Sub

    Private Sub RBMujer_CheckedChanged(sender As Object, e As EventArgs) Handles RBMujer.CheckedChanged
        ' 7) Si se selecciona Mujer, muestra el ícono en la posición 1 de la lista
        If RBMujer.Checked Then
            PictureBox1.Image = Iconperson.Images(1)
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Me.Close()
    End Sub

    Private Sub TTelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TTelefono.TextChanged
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Cancela el caracter ingresado
        End If
    End Sub
End Class
