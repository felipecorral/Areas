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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox_Seleccion = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel_Seleccion = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox_Cuadrado = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Rectangulo = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Circulo = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Triangulo = New System.Windows.Forms.PictureBox()
        Me.RadioButton_Cuadrado = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Rectangulo = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Circulo = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Triangulo = New System.Windows.Forms.RadioButton()
        Me.GroupBox_Datos = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Base = New System.Windows.Forms.Label()
        Me.Label_Altura = New System.Windows.Forms.Label()
        Me.Label_Radio = New System.Windows.Forms.Label()
        Me.TextBox_Base = New System.Windows.Forms.TextBox()
        Me.TextBox_Altura = New System.Windows.Forms.TextBox()
        Me.TextBox_Radio = New System.Windows.Forms.TextBox()
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.Label_Resultado = New System.Windows.Forms.Label()
        Me.Label_ResultadoFinal = New System.Windows.Forms.Label()
        Me.GroupBox_Seleccion.SuspendLayout()
        Me.TableLayoutPanel_Seleccion.SuspendLayout()
        CType(Me.PictureBox_Cuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Rectangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Circulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Triangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Datos.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Seleccion
        '
        Me.GroupBox_Seleccion.Controls.Add(Me.TableLayoutPanel_Seleccion)
        Me.GroupBox_Seleccion.Location = New System.Drawing.Point(47, 46)
        Me.GroupBox_Seleccion.Name = "GroupBox_Seleccion"
        Me.GroupBox_Seleccion.Size = New System.Drawing.Size(306, 207)
        Me.GroupBox_Seleccion.TabIndex = 0
        Me.GroupBox_Seleccion.TabStop = False
        Me.GroupBox_Seleccion.Text = "Seleccionar Figura"
        '
        'TableLayoutPanel_Seleccion
        '
        Me.TableLayoutPanel_Seleccion.ColumnCount = 2
        Me.TableLayoutPanel_Seleccion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel_Seleccion.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.PictureBox_Cuadrado, 0, 0)
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.PictureBox_Rectangulo, 0, 1)
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.PictureBox_Circulo, 0, 2)
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.PictureBox_Triangulo, 0, 3)
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.RadioButton_Cuadrado, 1, 0)
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.RadioButton_Rectangulo, 1, 1)
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.RadioButton_Circulo, 1, 2)
        Me.TableLayoutPanel_Seleccion.Controls.Add(Me.RadioButton_Triangulo, 1, 3)
        Me.TableLayoutPanel_Seleccion.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel_Seleccion.Name = "TableLayoutPanel_Seleccion"
        Me.TableLayoutPanel_Seleccion.RowCount = 4
        Me.TableLayoutPanel_Seleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_Seleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_Seleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_Seleccion.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_Seleccion.Size = New System.Drawing.Size(294, 182)
        Me.TableLayoutPanel_Seleccion.TabIndex = 0
        '
        'PictureBox_Cuadrado
        '
        Me.PictureBox_Cuadrado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Cuadrado.Image = CType(resources.GetObject("PictureBox_Cuadrado.Image"), System.Drawing.Image)
        Me.PictureBox_Cuadrado.Location = New System.Drawing.Point(22, 3)
        Me.PictureBox_Cuadrado.Name = "PictureBox_Cuadrado"
        Me.PictureBox_Cuadrado.Size = New System.Drawing.Size(72, 39)
        Me.PictureBox_Cuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Cuadrado.TabIndex = 0
        Me.PictureBox_Cuadrado.TabStop = False
        '
        'PictureBox_Rectangulo
        '
        Me.PictureBox_Rectangulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Rectangulo.Image = CType(resources.GetObject("PictureBox_Rectangulo.Image"), System.Drawing.Image)
        Me.PictureBox_Rectangulo.Location = New System.Drawing.Point(24, 48)
        Me.PictureBox_Rectangulo.Name = "PictureBox_Rectangulo"
        Me.PictureBox_Rectangulo.Size = New System.Drawing.Size(68, 39)
        Me.PictureBox_Rectangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Rectangulo.TabIndex = 1
        Me.PictureBox_Rectangulo.TabStop = False
        '
        'PictureBox_Circulo
        '
        Me.PictureBox_Circulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Circulo.Image = CType(resources.GetObject("PictureBox_Circulo.Image"), System.Drawing.Image)
        Me.PictureBox_Circulo.Location = New System.Drawing.Point(25, 93)
        Me.PictureBox_Circulo.Name = "PictureBox_Circulo"
        Me.PictureBox_Circulo.Size = New System.Drawing.Size(67, 39)
        Me.PictureBox_Circulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Circulo.TabIndex = 2
        Me.PictureBox_Circulo.TabStop = False
        '
        'PictureBox_Triangulo
        '
        Me.PictureBox_Triangulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox_Triangulo.Image = CType(resources.GetObject("PictureBox_Triangulo.Image"), System.Drawing.Image)
        Me.PictureBox_Triangulo.Location = New System.Drawing.Point(25, 138)
        Me.PictureBox_Triangulo.Name = "PictureBox_Triangulo"
        Me.PictureBox_Triangulo.Size = New System.Drawing.Size(66, 41)
        Me.PictureBox_Triangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_Triangulo.TabIndex = 3
        Me.PictureBox_Triangulo.TabStop = False
        '
        'RadioButton_Cuadrado
        '
        Me.RadioButton_Cuadrado.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButton_Cuadrado.AutoSize = True
        Me.RadioButton_Cuadrado.Checked = True
        Me.RadioButton_Cuadrado.Location = New System.Drawing.Point(120, 14)
        Me.RadioButton_Cuadrado.Name = "RadioButton_Cuadrado"
        Me.RadioButton_Cuadrado.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton_Cuadrado.TabIndex = 4
        Me.RadioButton_Cuadrado.TabStop = True
        Me.RadioButton_Cuadrado.Text = "Cuadrado"
        Me.RadioButton_Cuadrado.UseVisualStyleBackColor = True
        '
        'RadioButton_Rectangulo
        '
        Me.RadioButton_Rectangulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButton_Rectangulo.AutoSize = True
        Me.RadioButton_Rectangulo.Location = New System.Drawing.Point(120, 59)
        Me.RadioButton_Rectangulo.Name = "RadioButton_Rectangulo"
        Me.RadioButton_Rectangulo.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton_Rectangulo.TabIndex = 5
        Me.RadioButton_Rectangulo.TabStop = True
        Me.RadioButton_Rectangulo.Text = "Rectángulo"
        Me.RadioButton_Rectangulo.UseVisualStyleBackColor = True
        '
        'RadioButton_Circulo
        '
        Me.RadioButton_Circulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButton_Circulo.AutoSize = True
        Me.RadioButton_Circulo.Location = New System.Drawing.Point(120, 104)
        Me.RadioButton_Circulo.Name = "RadioButton_Circulo"
        Me.RadioButton_Circulo.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton_Circulo.TabIndex = 6
        Me.RadioButton_Circulo.TabStop = True
        Me.RadioButton_Circulo.Text = "Círculo"
        Me.RadioButton_Circulo.UseVisualStyleBackColor = True
        '
        'RadioButton_Triangulo
        '
        Me.RadioButton_Triangulo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RadioButton_Triangulo.AutoSize = True
        Me.RadioButton_Triangulo.Location = New System.Drawing.Point(120, 150)
        Me.RadioButton_Triangulo.Name = "RadioButton_Triangulo"
        Me.RadioButton_Triangulo.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton_Triangulo.TabIndex = 7
        Me.RadioButton_Triangulo.TabStop = True
        Me.RadioButton_Triangulo.Text = "Triángulo"
        Me.RadioButton_Triangulo.UseVisualStyleBackColor = True
        '
        'GroupBox_Datos
        '
        Me.GroupBox_Datos.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox_Datos.Location = New System.Drawing.Point(623, 46)
        Me.GroupBox_Datos.Name = "GroupBox_Datos"
        Me.GroupBox_Datos.Size = New System.Drawing.Size(372, 207)
        Me.GroupBox_Datos.TabIndex = 1
        Me.GroupBox_Datos.TabStop = False
        Me.GroupBox_Datos.Text = "Datos"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Base, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Altura, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label_Radio, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Base, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Altura, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox_Radio, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(360, 182)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label_Base
        '
        Me.Label_Base.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Base.AutoSize = True
        Me.Label_Base.Location = New System.Drawing.Point(30, 23)
        Me.Label_Base.Name = "Label_Base"
        Me.Label_Base.Size = New System.Drawing.Size(60, 13)
        Me.Label_Base.TabIndex = 0
        Me.Label_Base.Text = "Base (cm.):"
        '
        'Label_Altura
        '
        Me.Label_Altura.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Altura.AutoSize = True
        Me.Label_Altura.Location = New System.Drawing.Point(28, 83)
        Me.Label_Altura.Name = "Label_Altura"
        Me.Label_Altura.Size = New System.Drawing.Size(63, 13)
        Me.Label_Altura.TabIndex = 1
        Me.Label_Altura.Text = "Altura (cm.):"
        Me.Label_Altura.Visible = False
        '
        'Label_Radio
        '
        Me.Label_Radio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label_Radio.AutoSize = True
        Me.Label_Radio.Location = New System.Drawing.Point(28, 144)
        Me.Label_Radio.Name = "Label_Radio"
        Me.Label_Radio.Size = New System.Drawing.Size(64, 13)
        Me.Label_Radio.TabIndex = 2
        Me.Label_Radio.Text = "Radio (cm.):"
        Me.Label_Radio.Visible = False
        '
        'TextBox_Base
        '
        Me.TextBox_Base.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox_Base.Location = New System.Drawing.Point(123, 20)
        Me.TextBox_Base.Name = "TextBox_Base"
        Me.TextBox_Base.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Base.TabIndex = 3
        '
        'TextBox_Altura
        '
        Me.TextBox_Altura.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox_Altura.Location = New System.Drawing.Point(123, 80)
        Me.TextBox_Altura.Name = "TextBox_Altura"
        Me.TextBox_Altura.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Altura.TabIndex = 4
        Me.TextBox_Altura.Visible = False
        '
        'TextBox_Radio
        '
        Me.TextBox_Radio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox_Radio.Location = New System.Drawing.Point(123, 141)
        Me.TextBox_Radio.Name = "TextBox_Radio"
        Me.TextBox_Radio.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Radio.TabIndex = 5
        Me.TextBox_Radio.Visible = False
        '
        'Button_Calcular
        '
        Me.Button_Calcular.Location = New System.Drawing.Point(725, 278)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(148, 23)
        Me.Button_Calcular.TabIndex = 2
        Me.Button_Calcular.Text = "Calcular Área"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'Label_Resultado
        '
        Me.Label_Resultado.AutoSize = True
        Me.Label_Resultado.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label_Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultado.Location = New System.Drawing.Point(284, 354)
        Me.Label_Resultado.Name = "Label_Resultado"
        Me.Label_Resultado.Size = New System.Drawing.Size(327, 44)
        Me.Label_Resultado.TabIndex = 3
        Me.Label_Resultado.Text = "Resultado (cm2):"
        '
        'Label_ResultadoFinal
        '
        Me.Label_ResultadoFinal.AutoSize = True
        Me.Label_ResultadoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ResultadoFinal.Location = New System.Drawing.Point(617, 354)
        Me.Label_ResultadoFinal.Name = "Label_ResultadoFinal"
        Me.Label_ResultadoFinal.Size = New System.Drawing.Size(0, 44)
        Me.Label_ResultadoFinal.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 444)
        Me.Controls.Add(Me.Label_ResultadoFinal)
        Me.Controls.Add(Me.Label_Resultado)
        Me.Controls.Add(Me.Button_Calcular)
        Me.Controls.Add(Me.GroupBox_Datos)
        Me.Controls.Add(Me.GroupBox_Seleccion)
        Me.Name = "Form1"
        Me.Text = "Areas"
        Me.GroupBox_Seleccion.ResumeLayout(False)
        Me.TableLayoutPanel_Seleccion.ResumeLayout(False)
        Me.TableLayoutPanel_Seleccion.PerformLayout()
        CType(Me.PictureBox_Cuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Rectangulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Circulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Triangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Datos.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_Seleccion As GroupBox
    Friend WithEvents TableLayoutPanel_Seleccion As TableLayoutPanel
    Friend WithEvents PictureBox_Cuadrado As PictureBox
    Friend WithEvents PictureBox_Rectangulo As PictureBox
    Friend WithEvents PictureBox_Circulo As PictureBox
    Friend WithEvents PictureBox_Triangulo As PictureBox
    Friend WithEvents RadioButton_Cuadrado As RadioButton
    Friend WithEvents RadioButton_Rectangulo As RadioButton
    Friend WithEvents RadioButton_Circulo As RadioButton
    Friend WithEvents RadioButton_Triangulo As RadioButton
    Friend WithEvents GroupBox_Datos As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label_Base As Label
    Friend WithEvents Label_Altura As Label
    Friend WithEvents Label_Radio As Label
    Friend WithEvents TextBox_Base As TextBox
    Friend WithEvents TextBox_Altura As TextBox
    Friend WithEvents TextBox_Radio As TextBox
    Friend WithEvents Button_Calcular As Button
    Friend WithEvents Label_Resultado As Label
    Friend WithEvents Label_ResultadoFinal As Label
End Class
