Imports System.Data.SqlClient
Public Class Form1
    Dim ep As New Propiedades
    Dim func As New Funciones
    Dim reg As New Propiedades
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = func.Mostrar_Producto
        Mostrar()

    End Sub


    Private Sub Mostrar()
        DataGridView1.Visible = True
        DataGridView1.Columns(3).Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label_codigo.Visible = False
        Label_Nombre.Visible = False
        Label_Existencia.Visible = False

        TextBox1.Visible = False
        TextBox1.Enabled = True
        TextBox2_Codigo.Visible = True
        TextBox2_Existencia.Visible = False
        TextBox2_Nombre.Visible = False

        btn_Cancelar.Visible = False
        btn_Modificar.Visible = True
        btn_Nuevo.Visible = True
        btn_Guardar.Visible = False
        btn_Eliminar.Visible = True

        btn_Insertar.Visible = False
        btn_Quitar.Visible = False

        btn_Registrar.Visible = False


    End Sub
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim result As DialogResult

        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("La tabla esta vacia", "Eliminando Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        result = MessageBox.Show("Serrrrguro que desea eliminar este producto?", "Eliminando producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            If TextBox2_Codigo.Text <> "" Then

                Try
                    reg.cod_prod = TextBox2_Codigo.Text
                    If func.Eliminar_Producto(reg) Then
                        MessageBox.Show("Producto eliminado correctamente", "elimiando producto")
                        DataGridView1.DataSource = func.Mostrar_Producto

                        If DataGridView1.RowCount = 0 Then
                            TextBox2_Codigo.Text = ""
                            TextBox2_Existencia.Text = ""
                            TextBox2_Nombre.Text = ""
                            Imagen.Image = My.Resources.kaneki

                        End If
                    Else
                        MessageBox.Show("Producto nos encontrado", "eliminando Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If DataGridView1.Rows.Count = 0 Then
            TextBox2_Codigo.Text = ""
            TextBox2_Nombre.Text = ""
            TextBox2_Existencia.Text = ""
            Exit Sub
        Else
            TextBox2_Codigo.Text = DataGridView1.SelectedCells.Item(0).Value
            TextBox2_Nombre.Text = DataGridView1.SelectedCells.Item(1).Value
            TextBox2_Existencia.Text = DataGridView1.SelectedCells.Item(2).Value
            Imagen.BackgroundImage = Nothing
            Dim i() As Byte = DataGridView1.SelectedCells.Item(3).Value
            Dim ms As New IO.MemoryStream(i)
            Imagen.Image = Image.FromStream(ms)
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub DataGridview1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox2_Codigo.Text = DataGridView1.SelectedCells.Item(0).Value
        TextBox2_Nombre.Text = DataGridView1.SelectedCells.Item(1).Value
        TextBox2_Existencia.Text = DataGridView1.SelectedCells.Item(2).Value

        Imagen.BackgroundImage = Nothing
        Dim i() As Byte = DataGridView1.SelectedCells.Item(3).Value
        Dim ms As New IO.MemoryStream(i)
        Imagen.Image = Image.FromStream(ms)
        Imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub Button2_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click

        Imagen.Image = My.Resources.kaneki

        DataGridView1.Visible = False
        DataGridView1.Columns(3).Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label_codigo.Visible = True
        Label_Nombre.Visible = True
        Label_Existencia.Visible = True

        TextBox1.Visible = True
        TextBox1.Enabled = True
        TextBox2_Codigo.Visible = True
        TextBox2_Existencia.Visible = True
        TextBox2_Nombre.Visible = True
        TextBox2_Codigo.Text = ""
        TextBox2_Nombre.Text = ""
        TextBox2_Existencia.Text = ""


        btn_Nuevo.Visible = True
        btn_Registrar.Visible = True
        btn_Modificar.Visible = False
        btn_Eliminar.Visible = False
        btn_Cancelar.Visible = True


        btn_Insertar.Visible = True
        btn_Guardar.Visible = False
        btn_Quitar.Visible = True



        TextBox1.Focus()
    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Mostrar()
    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label_codigo.Click

    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        If Me.ValidateChildren = True And TextBox2_Codigo.Text <> "" And TextBox2_Existencia.Text <> "" And TextBox2_Nombre.Text <> "" Then
            Try
                reg.cod_prod = TextBox2_Codigo.Text
                reg.nombre = TextBox2_Nombre.Text
                reg.existencia = TextBox2_Existencia.Text

                Dim ms As New IO.MemoryStream()

                If Not Imagen.Image Is Nothing Then
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image = My.Resources.kaneki
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If
                reg.imagen = ms.GetBuffer


                If func.Registrar_Producto(reg) Then
                    MessageBox.Show("Producto Guardado Correctamente", "Guardando Producto")
                    DataGridView1.DataSource = func.Mostrar_Producto
                    Mostrar()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe rellenar todos los campos", "Guardando Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("La tabla esta vacia", "Modificando Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        DataGridView1.Visible = False

        DataGridView1.Columns(3).Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label_codigo.Visible = True
        Label_Nombre.Visible = True
        Label_Existencia.Visible = True

        TextBox1.Visible = False
        TextBox2_Codigo.Enabled = False
        TextBox2_Codigo.Visible = True
        TextBox2_Existencia.Visible = True
        TextBox2_Nombre.Visible = True



        btn_Nuevo.Visible = False
        btn_Registrar.Visible = False
        btn_Modificar.Visible = False
        btn_Eliminar.Visible = False
        btn_Cancelar.Visible = True


        btn_Insertar.Visible = True
        btn_Guardar.Visible = True
        btn_Quitar.Visible = True
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        If Me.ValidateChildren = True And TextBox2_Codigo.Text <> "" And TextBox2_Existencia.Text <> "" And TextBox2_Nombre.Text <> "" Then
            Try
                reg.cod_prod = TextBox2_Codigo.Text
                reg.nombre = TextBox2_Nombre.Text
                reg.existencia = TextBox2_Existencia.Text

                Dim ms As New IO.MemoryStream()

                If Not Imagen.Image Is Nothing Then
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image = My.Resources.kaneki
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If
                reg.imagen = ms.GetBuffer

                If func.Modificar_Producto(reg) Then
                    MessageBox.Show("Producto Modificado correctamente", "Modificadondo Producto")
                    DataGridView1.DataSource = func.Mostrar_Producto
                    Mostrar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe rellenar todos los campos", "Modificando Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Insertar_Click(sender As Object, e As EventArgs) Handles btn_Insertar.Click


    End Sub
End Class
