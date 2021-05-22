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
        Me.NumericUpDownAlto = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownAncho = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMinas = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonCargar = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownAlto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownAncho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMinas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDownAlto
        '
        Me.NumericUpDownAlto.Location = New System.Drawing.Point(59, 28)
        Me.NumericUpDownAlto.Name = "NumericUpDownAlto"
        Me.NumericUpDownAlto.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDownAlto.TabIndex = 0
        Me.NumericUpDownAlto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDownAncho
        '
        Me.NumericUpDownAncho.Location = New System.Drawing.Point(293, 28)
        Me.NumericUpDownAncho.Name = "NumericUpDownAncho"
        Me.NumericUpDownAncho.Size = New System.Drawing.Size(105, 20)
        Me.NumericUpDownAncho.TabIndex = 1
        Me.NumericUpDownAncho.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumericUpDownMinas
        '
        Me.NumericUpDownMinas.Location = New System.Drawing.Point(490, 28)
        Me.NumericUpDownMinas.Name = "NumericUpDownMinas"
        Me.NumericUpDownMinas.Size = New System.Drawing.Size(106, 20)
        Me.NumericUpDownMinas.TabIndex = 2
        Me.NumericUpDownMinas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ancho"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(59, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 359)
        Me.Panel1.TabIndex = 4
        '
        'ButtonCargar
        '
        Me.ButtonCargar.Location = New System.Drawing.Point(643, 30)
        Me.ButtonCargar.Name = "ButtonCargar"
        Me.ButtonCargar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCargar.TabIndex = 0
        Me.ButtonCargar.Text = "Cargar"
        Me.ButtonCargar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonCargar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownMinas)
        Me.Controls.Add(Me.NumericUpDownAncho)
        Me.Controls.Add(Me.NumericUpDownAlto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Buscaminas 2021 Anderson Yeisd Parra Florez"
        CType(Me.NumericUpDownAlto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownAncho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMinas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDownAlto As NumericUpDown
    Friend WithEvents NumericUpDownAncho As NumericUpDown
    Friend WithEvents NumericUpDownMinas As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonCargar As Button
End Class
