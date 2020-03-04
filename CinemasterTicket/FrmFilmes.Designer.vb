<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilmes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFilmes))
        Me.DgFilmes = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sinopse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Poster = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgFilmes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgFilmes
        '
        Me.DgFilmes.AllowUserToAddRows = False
        Me.DgFilmes.AllowUserToDeleteRows = False
        Me.DgFilmes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgFilmes.BackgroundColor = System.Drawing.Color.White
        Me.DgFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgFilmes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nome, Me.Sinopse, Me.Duracao, Me.Poster})
        Me.DgFilmes.Location = New System.Drawing.Point(12, 12)
        Me.DgFilmes.Name = "DgFilmes"
        Me.DgFilmes.ReadOnly = True
        Me.DgFilmes.RowHeadersVisible = False
        Me.DgFilmes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgFilmes.Size = New System.Drawing.Size(626, 262)
        Me.DgFilmes.TabIndex = 1
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Nome
        '
        Me.Nome.HeaderText = "Título"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        Me.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Nome.Width = 200
        '
        'Sinopse
        '
        Me.Sinopse.HeaderText = "Sinopse"
        Me.Sinopse.Name = "Sinopse"
        Me.Sinopse.ReadOnly = True
        Me.Sinopse.Width = 200
        '
        'Duracao
        '
        Me.Duracao.HeaderText = "Duração"
        Me.Duracao.Name = "Duracao"
        Me.Duracao.ReadOnly = True
        Me.Duracao.Width = 50
        '
        'Poster
        '
        Me.Poster.HeaderText = "Poster"
        Me.Poster.Name = "Poster"
        Me.Poster.ReadOnly = True
        Me.Poster.Width = 150
        '
        'FrmFilmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 286)
        Me.Controls.Add(Me.DgFilmes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFilmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filmes"
        CType(Me.DgFilmes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgFilmes As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Sinopse As DataGridViewTextBoxColumn
    Friend WithEvents Duracao As DataGridViewTextBoxColumn
    Friend WithEvents Poster As DataGridViewTextBoxColumn
End Class
