<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NrPedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rua = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Volume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NrPedido, Me.Pedido, Me.Cliente, Me.Bairro, Me.Rua, Me.Valor, Me.Peso, Me.Volume, Me.Cidade, Me.NF, Me.Seq, Me.Usuario})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 98)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(1795, 459)
        Me.DataGridView1.TabIndex = 1
        '
        'NrPedido
        '
        Me.NrPedido.HeaderText = "Nr Pedido"
        Me.NrPedido.MinimumWidth = 6
        Me.NrPedido.Name = "NrPedido"
        Me.NrPedido.Visible = False
        Me.NrPedido.Width = 125
        '
        'Pedido
        '
        Me.Pedido.HeaderText = "Pedido"
        Me.Pedido.MinimumWidth = 6
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Width = 125
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.MinimumWidth = 6
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 77
        '
        'Bairro
        '
        Me.Bairro.HeaderText = "Bairro"
        Me.Bairro.MinimumWidth = 6
        Me.Bairro.Name = "Bairro"
        Me.Bairro.Width = 125
        '
        'Rua
        '
        Me.Rua.HeaderText = "Rua"
        Me.Rua.MinimumWidth = 6
        Me.Rua.Name = "Rua"
        Me.Rua.ReadOnly = True
        Me.Rua.Width = 125
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.MinimumWidth = 6
        Me.Valor.Name = "Valor"
        Me.Valor.Width = 125
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.MinimumWidth = 6
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 125
        '
        'Volume
        '
        Me.Volume.HeaderText = "Volume"
        Me.Volume.MinimumWidth = 6
        Me.Volume.Name = "Volume"
        Me.Volume.Width = 125
        '
        'Cidade
        '
        Me.Cidade.HeaderText = "Cidade"
        Me.Cidade.MinimumWidth = 6
        Me.Cidade.Name = "Cidade"
        Me.Cidade.Width = 125
        '
        'NF
        '
        Me.NF.HeaderText = "NF"
        Me.NF.MinimumWidth = 6
        Me.NF.Name = "NF"
        Me.NF.Width = 125
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.MinimumWidth = 6
        Me.Seq.Name = "Seq"
        Me.Seq.Width = 125
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.MinimumWidth = 6
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 125
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 63)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 65)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Viagem:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 565)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 571)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(615, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Obs.: Para apagar uma sequência, didite 0 ""Zero"" no campo e clique em ""Atualizar""" &
    ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantidade de Pedidos: "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(441, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1827, 623)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "CARREGAMENTO - 17/07/2024"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NrPedido As DataGridViewTextBoxColumn
    Friend WithEvents Pedido As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Bairro As DataGridViewTextBoxColumn
    Friend WithEvents Rua As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Volume As DataGridViewTextBoxColumn
    Friend WithEvents Cidade As DataGridViewTextBoxColumn
    Friend WithEvents NF As DataGridViewTextBoxColumn
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
