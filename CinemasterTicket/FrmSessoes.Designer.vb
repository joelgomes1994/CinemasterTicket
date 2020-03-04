<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSessoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSessoes))
        Me.DgSessoes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgSessoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgSessoes
        '
        Me.DgSessoes.AllowUserToAddRows = False
        Me.DgSessoes.AllowUserToDeleteRows = False
        Me.DgSessoes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgSessoes.BackgroundColor = System.Drawing.Color.White
        Me.DgSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgSessoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Horario, Me.Sala, Me.Filme, Me.Preco})
        Me.DgSessoes.Location = New System.Drawing.Point(12, 12)
        Me.DgSessoes.Name = "DgSessoes"
        Me.DgSessoes.ReadOnly = True
        Me.DgSessoes.RowHeadersVisible = False
        Me.DgSessoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgSessoes.Size = New System.Drawing.Size(497, 259)
        Me.DgSessoes.TabIndex = 1
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Horario
        '
        Me.Horario.HeaderText = "Horário"
        Me.Horario.Name = "Horario"
        Me.Horario.ReadOnly = True
        Me.Horario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Horario.Width = 60
        '
        'Sala
        '
        Me.Sala.HeaderText = "Sala"
        Me.Sala.Name = "Sala"
        Me.Sala.ReadOnly = True
        '
        'Filme
        '
        Me.Filme.HeaderText = "Filme"
        Me.Filme.Name = "Filme"
        Me.Filme.ReadOnly = True
        Me.Filme.Width = 250
        '
        'Preco
        '
        Me.Preco.HeaderText = "Preço"
        Me.Preco.Name = "Preco"
        Me.Preco.ReadOnly = True
        Me.Preco.Width = 50
        '
        'FrmSessoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(521, 283)
        Me.Controls.Add(Me.DgSessoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSessoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sessões"
        CType(Me.DgSessoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgSessoes As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Horario As DataGridViewTextBoxColumn
    Friend WithEvents Sala As DataGridViewTextBoxColumn
    Friend WithEvents Filme As DataGridViewTextBoxColumn
    Friend WithEvents Preco As DataGridViewTextBoxColumn
End Class
