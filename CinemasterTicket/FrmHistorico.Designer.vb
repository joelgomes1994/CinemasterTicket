<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistorico))
        Me.DgHistorico = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sessao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Assento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgHistorico
        '
        Me.DgHistorico.AllowUserToAddRows = False
        Me.DgHistorico.AllowUserToDeleteRows = False
        Me.DgHistorico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgHistorico.BackgroundColor = System.Drawing.Color.White
        Me.DgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgHistorico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Data, Me.Sessao, Me.Filme, Me.Assento, Me.Tipo})
        Me.DgHistorico.Location = New System.Drawing.Point(12, 12)
        Me.DgHistorico.Name = "DgHistorico"
        Me.DgHistorico.ReadOnly = True
        Me.DgHistorico.RowHeadersVisible = False
        Me.DgHistorico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgHistorico.Size = New System.Drawing.Size(661, 295)
        Me.DgHistorico.TabIndex = 2
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data.Width = 120
        '
        'Sessao
        '
        Me.Sessao.HeaderText = "Sessão"
        Me.Sessao.Name = "Sessao"
        Me.Sessao.ReadOnly = True
        Me.Sessao.Width = 60
        '
        'Filme
        '
        Me.Filme.HeaderText = "Filme"
        Me.Filme.Name = "Filme"
        Me.Filme.ReadOnly = True
        Me.Filme.Width = 200
        '
        'Assento
        '
        Me.Assento.HeaderText = "Assento"
        Me.Assento.Name = "Assento"
        Me.Assento.ReadOnly = True
        Me.Assento.Width = 90
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Width = 70
        '
        'FrmHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 319)
        Me.Controls.Add(Me.DgHistorico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHistorico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico de compras"
        CType(Me.DgHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgHistorico As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Sessao As DataGridViewTextBoxColumn
    Friend WithEvents Filme As DataGridViewTextBoxColumn
    Friend WithEvents Assento As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
End Class
