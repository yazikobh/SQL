<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        btn_Eliminar = New Button()
        TextBox1 = New TextBox()
        btn_Nuevo = New Button()
        btn_Modificar = New Button()
        btn_Insertar = New Button()
        btn_Quitar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btn_Registrar = New Button()
        DataGridView1 = New DataGridView()
        btn_Cancelar = New Button()
        btn_Guardar = New Button()
        Label_codigo = New Label()
        TextBox2_Codigo = New TextBox()
        Label_Nombre = New Label()
        Label_Existencia = New Label()
        TextBox2_Nombre = New TextBox()
        TextBox2_Existencia = New TextBox()
        Imagen = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Imagen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btn_Eliminar
        ' 
        btn_Eliminar.BackColor = SystemColors.ButtonFace
        btn_Eliminar.Location = New Point(359, 441)
        btn_Eliminar.Name = "btn_Eliminar"
        btn_Eliminar.Size = New Size(150, 44)
        btn_Eliminar.TabIndex = 1
        btn_Eliminar.Text = "Eliminar"
        btn_Eliminar.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(22, 400)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(446, 23)
        TextBox1.TabIndex = 2
        ' 
        ' btn_Nuevo
        ' 
        btn_Nuevo.Location = New Point(22, 441)
        btn_Nuevo.Name = "btn_Nuevo"
        btn_Nuevo.Size = New Size(142, 44)
        btn_Nuevo.TabIndex = 3
        btn_Nuevo.Text = "Nuevo"
        btn_Nuevo.UseVisualStyleBackColor = True
        ' 
        ' btn_Modificar
        ' 
        btn_Modificar.Location = New Point(193, 441)
        btn_Modificar.Name = "btn_Modificar"
        btn_Modificar.Size = New Size(142, 44)
        btn_Modificar.TabIndex = 4
        btn_Modificar.Text = "Modificar"
        btn_Modificar.UseVisualStyleBackColor = True
        ' 
        ' btn_Insertar
        ' 
        btn_Insertar.Location = New Point(576, 441)
        btn_Insertar.Name = "btn_Insertar"
        btn_Insertar.Size = New Size(142, 44)
        btn_Insertar.TabIndex = 6
        btn_Insertar.Text = "Insertar"
        btn_Insertar.UseVisualStyleBackColor = True
        ' 
        ' btn_Quitar
        ' 
        btn_Quitar.Location = New Point(707, 441)
        btn_Quitar.Name = "btn_Quitar"
        btn_Quitar.Size = New Size(142, 44)
        btn_Quitar.TabIndex = 7
        btn_Quitar.Text = "Quitar"
        btn_Quitar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 8
        Label1.Text = "Código"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(236, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 9
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(388, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 10
        Label3.Text = "Existencia"
        ' 
        ' btn_Registrar
        ' 
        btn_Registrar.Location = New Point(22, 491)
        btn_Registrar.Name = "btn_Registrar"
        btn_Registrar.Size = New Size(142, 44)
        btn_Registrar.TabIndex = 11
        btn_Registrar.Text = "Registrar"
        btn_Registrar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.ColumnHeadersVisible = False
        DataGridView1.Location = New Point(12, 56)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(520, 290)
        DataGridView1.TabIndex = 0
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.Location = New Point(193, 491)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(142, 44)
        btn_Cancelar.TabIndex = 13
        btn_Cancelar.Text = "Cancelar"
        btn_Cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_Guardar
        ' 
        btn_Guardar.Location = New Point(359, 491)
        btn_Guardar.Name = "btn_Guardar"
        btn_Guardar.Size = New Size(150, 44)
        btn_Guardar.TabIndex = 14
        btn_Guardar.Text = "Guardar"
        btn_Guardar.UseVisualStyleBackColor = True
        ' 
        ' Label_codigo
        ' 
        Label_codigo.AutoSize = True
        Label_codigo.Location = New Point(85, 97)
        Label_codigo.Name = "Label_codigo"
        Label_codigo.Size = New Size(46, 15)
        Label_codigo.TabIndex = 15
        Label_codigo.Text = "Código"
        ' 
        ' TextBox2_Codigo
        ' 
        TextBox2_Codigo.Location = New Point(83, 125)
        TextBox2_Codigo.Name = "TextBox2_Codigo"
        TextBox2_Codigo.Size = New Size(100, 23)
        TextBox2_Codigo.TabIndex = 16
        ' 
        ' Label_Nombre
        ' 
        Label_Nombre.AutoSize = True
        Label_Nombre.Location = New Point(81, 170)
        Label_Nombre.Name = "Label_Nombre"
        Label_Nombre.Size = New Size(51, 15)
        Label_Nombre.TabIndex = 17
        Label_Nombre.Text = "Nombre"
        ' 
        ' Label_Existencia
        ' 
        Label_Existencia.AutoSize = True
        Label_Existencia.Location = New Point(81, 235)
        Label_Existencia.Name = "Label_Existencia"
        Label_Existencia.Size = New Size(59, 15)
        Label_Existencia.TabIndex = 18
        Label_Existencia.Text = "Éxistencia"
        ' 
        ' TextBox2_Nombre
        ' 
        TextBox2_Nombre.Location = New Point(80, 201)
        TextBox2_Nombre.Name = "TextBox2_Nombre"
        TextBox2_Nombre.Size = New Size(100, 23)
        TextBox2_Nombre.TabIndex = 19
        ' 
        ' TextBox2_Existencia
        ' 
        TextBox2_Existencia.Location = New Point(78, 266)
        TextBox2_Existencia.Name = "TextBox2_Existencia"
        TextBox2_Existencia.Size = New Size(100, 23)
        TextBox2_Existencia.TabIndex = 20
        ' 
        ' Imagen
        ' 
        Imagen.Location = New Point(565, 56)
        Imagen.Name = "Imagen"
        Imagen.Size = New Size(254, 290)
        Imagen.TabIndex = 21
        Imagen.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 557)
        Controls.Add(Imagen)
        Controls.Add(TextBox2_Existencia)
        Controls.Add(TextBox2_Nombre)
        Controls.Add(Label_Existencia)
        Controls.Add(Label_Nombre)
        Controls.Add(TextBox2_Codigo)
        Controls.Add(Label_codigo)
        Controls.Add(btn_Guardar)
        Controls.Add(btn_Cancelar)
        Controls.Add(DataGridView1)
        Controls.Add(btn_Registrar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_Quitar)
        Controls.Add(btn_Insertar)
        Controls.Add(btn_Modificar)
        Controls.Add(btn_Nuevo)
        Controls.Add(TextBox1)
        Controls.Add(btn_Eliminar)
        Name = "Form1"
        Text = "Listado de Productos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Imagen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Insertar As Button
    Friend WithEvents btn_Quitar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents Label_codigo As Label
    Friend WithEvents TextBox2_Codigo As TextBox
    Friend WithEvents Label_Nombre As Label
    Friend WithEvents Label_Existencia As Label
    Friend WithEvents TextBox2_Nombre As TextBox
    Friend WithEvents TextBox2_Existencia As TextBox
    Friend WithEvents Imagen As PictureBox
End Class
