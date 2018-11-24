<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbfemenino = New System.Windows.Forms.RadioButton()
        Me.rdbmasculino = New System.Windows.Forms.RadioButton()
        Me.txtnota = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnlistar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpromedio = New System.Windows.Forms.TextBox()
        Me.txtmayornota = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtnota)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.rdbfemenino)
        Me.GroupBox2.Controls.Add(Me.rdbmasculino)
        Me.GroupBox2.Location = New System.Drawing.Point(236, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sexo"
        '
        'rdbfemenino
        '
        Me.rdbfemenino.AutoSize = True
        Me.rdbfemenino.Location = New System.Drawing.Point(20, 52)
        Me.rdbfemenino.Name = "rdbfemenino"
        Me.rdbfemenino.Size = New System.Drawing.Size(96, 23)
        Me.rdbfemenino.TabIndex = 0
        Me.rdbfemenino.TabStop = True
        Me.rdbfemenino.Text = "Femenino"
        Me.rdbfemenino.UseVisualStyleBackColor = True
        '
        'rdbmasculino
        '
        Me.rdbmasculino.AutoSize = True
        Me.rdbmasculino.Checked = True
        Me.rdbmasculino.Location = New System.Drawing.Point(20, 29)
        Me.rdbmasculino.Name = "rdbmasculino"
        Me.rdbmasculino.Size = New System.Drawing.Size(96, 23)
        Me.rdbmasculino.TabIndex = 0
        Me.rdbmasculino.TabStop = True
        Me.rdbmasculino.Text = "Masculino"
        Me.rdbmasculino.UseVisualStyleBackColor = True
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(336, 31)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(100, 27)
        Me.txtnota.TabIndex = 1
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(90, 74)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(188, 27)
        Me.txtapellido.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(90, 39)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(188, 27)
        Me.txtnombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Snow
        Me.GroupBox3.Controls.Add(Me.btnsalir)
        Me.GroupBox3.Controls.Add(Me.btnlistar)
        Me.GroupBox3.Controls.Add(Me.btnguardar)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(495, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 225)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mantenimiento"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsalir.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Location = New System.Drawing.Point(23, 153)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(157, 54)
        Me.btnsalir.TabIndex = 0
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnlistar
        '
        Me.btnlistar.BackColor = System.Drawing.Color.LightGray
        Me.btnlistar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlistar.Location = New System.Drawing.Point(23, 93)
        Me.btnlistar.Name = "btnlistar"
        Me.btnlistar.Size = New System.Drawing.Size(157, 54)
        Me.btnlistar.TabIndex = 0
        Me.btnlistar.Text = "Listar Datos"
        Me.btnlistar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnguardar.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(23, 33)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(157, 54)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar Datos"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nombre, Me.Apellido, Me.Sexo, Me.Nota})
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(30, 260)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(665, 153)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        Me.nombre.Width = 179
        '
        'Apellido
        '
        Me.Apellido.Text = "Apellido"
        Me.Apellido.Width = 210
        '
        'Sexo
        '
        Me.Sexo.Text = "Sexo"
        Me.Sexo.Width = 157
        '
        'Nota
        '
        Me.Nota.Text = "Nota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Promedio Notas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 476)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mayor Nota:"
        '
        'txtpromedio
        '
        Me.txtpromedio.Location = New System.Drawing.Point(565, 441)
        Me.txtpromedio.Multiline = True
        Me.txtpromedio.Name = "txtpromedio"
        Me.txtpromedio.Size = New System.Drawing.Size(130, 29)
        Me.txtpromedio.TabIndex = 1
        '
        'txtmayornota
        '
        Me.txtmayornota.Location = New System.Drawing.Point(565, 476)
        Me.txtmayornota.Multiline = True
        Me.txtmayornota.Name = "txtmayornota"
        Me.txtmayornota.Size = New System.Drawing.Size(130, 29)
        Me.txtmayornota.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 541)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtmayornota)
        Me.Controls.Add(Me.txtpromedio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbfemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdbmasculino As System.Windows.Forms.RadioButton
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnlistar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpromedio As System.Windows.Forms.TextBox
    Friend WithEvents txtmayornota As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Apellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sexo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nota As System.Windows.Forms.ColumnHeader

End Class
