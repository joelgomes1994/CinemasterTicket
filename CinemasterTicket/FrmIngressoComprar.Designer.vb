<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngressoComprar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngressoComprar))
        Me.DgSalaAssentos = New System.Windows.Forms.DataGridView()
        Me.Linhas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.A = New System.Windows.Forms.DataGridViewImageColumn()
        Me.B = New System.Windows.Forms.DataGridViewImageColumn()
        Me.C = New System.Windows.Forms.DataGridViewImageColumn()
        Me.D = New System.Windows.Forms.DataGridViewImageColumn()
        Me.E = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CorredorH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F = New System.Windows.Forms.DataGridViewImageColumn()
        Me.G = New System.Windows.Forms.DataGridViewImageColumn()
        Me.H = New System.Windows.Forms.DataGridViewImageColumn()
        Me.I = New System.Windows.Forms.DataGridViewImageColumn()
        Me.J = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbSessao = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbSala = New System.Windows.Forms.ComboBox()
        Me.CmbIngressoTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAssento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnComprar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSinopse = New System.Windows.Forms.TextBox()
        Me.ImgPoster = New System.Windows.Forms.PictureBox()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDuracao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DgSalaAssentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImgPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgSalaAssentos
        '
        Me.DgSalaAssentos.AllowUserToAddRows = False
        Me.DgSalaAssentos.AllowUserToDeleteRows = False
        Me.DgSalaAssentos.AllowUserToResizeColumns = False
        Me.DgSalaAssentos.AllowUserToResizeRows = False
        Me.DgSalaAssentos.BackgroundColor = System.Drawing.Color.White
        Me.DgSalaAssentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DgSalaAssentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSalaAssentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Linhas, Me.A, Me.B, Me.C, Me.D, Me.E, Me.CorredorH, Me.F, Me.G, Me.H, Me.I, Me.J})
        Me.DgSalaAssentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DgSalaAssentos.GridColor = System.Drawing.Color.White
        Me.DgSalaAssentos.Location = New System.Drawing.Point(421, 36)
        Me.DgSalaAssentos.MultiSelect = False
        Me.DgSalaAssentos.Name = "DgSalaAssentos"
        Me.DgSalaAssentos.ReadOnly = True
        Me.DgSalaAssentos.RowHeadersVisible = False
        Me.DgSalaAssentos.RowHeadersWidth = 30
        Me.DgSalaAssentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgSalaAssentos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DgSalaAssentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgSalaAssentos.ShowCellToolTips = False
        Me.DgSalaAssentos.ShowEditingIcon = False
        Me.DgSalaAssentos.Size = New System.Drawing.Size(346, 351)
        Me.DgSalaAssentos.TabIndex = 0
        '
        'Linhas
        '
        Me.Linhas.HeaderText = " "
        Me.Linhas.Name = "Linhas"
        Me.Linhas.ReadOnly = True
        Me.Linhas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Linhas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Linhas.Width = 22
        '
        'A
        '
        Me.A.HeaderText = "A"
        Me.A.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.A.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.A.Name = "A"
        Me.A.ReadOnly = True
        Me.A.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.A.Width = 30
        '
        'B
        '
        Me.B.HeaderText = "B"
        Me.B.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.B.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.B.Name = "B"
        Me.B.ReadOnly = True
        Me.B.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.B.Width = 30
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.C.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.C.Name = "C"
        Me.C.ReadOnly = True
        Me.C.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.C.Width = 30
        '
        'D
        '
        Me.D.HeaderText = "D"
        Me.D.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.D.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.D.Name = "D"
        Me.D.ReadOnly = True
        Me.D.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D.Width = 30
        '
        'E
        '
        Me.E.HeaderText = "E"
        Me.E.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.E.Name = "E"
        Me.E.ReadOnly = True
        Me.E.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.E.Width = 30
        '
        'CorredorH
        '
        Me.CorredorH.HeaderText = " "
        Me.CorredorH.Name = "CorredorH"
        Me.CorredorH.ReadOnly = True
        Me.CorredorH.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CorredorH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CorredorH.Width = 22
        '
        'F
        '
        Me.F.HeaderText = "F"
        Me.F.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.F.Name = "F"
        Me.F.ReadOnly = True
        Me.F.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.F.Width = 30
        '
        'G
        '
        Me.G.HeaderText = "G"
        Me.G.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.G.Name = "G"
        Me.G.ReadOnly = True
        Me.G.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.G.Width = 30
        '
        'H
        '
        Me.H.HeaderText = "H"
        Me.H.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.H.Name = "H"
        Me.H.ReadOnly = True
        Me.H.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.H.Width = 30
        '
        'I
        '
        Me.I.HeaderText = "I"
        Me.I.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.I.Name = "I"
        Me.I.ReadOnly = True
        Me.I.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.I.Width = 30
        '
        'J
        '
        Me.J.HeaderText = "J"
        Me.J.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.J.Name = "J"
        Me.J.ReadOnly = True
        Me.J.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.J.Width = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbSessao)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CmbSala)
        Me.GroupBox1.Controls.Add(Me.CmbIngressoTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 86)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra de ingressos"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Location = New System.Drawing.Point(297, 19)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(90, 20)
        Me.TxtTotal.TabIndex = 14
        Me.TxtTotal.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(243, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total R$"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sessão"
        '
        'CmbSessao
        '
        Me.CmbSessao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSessao.FormattingEnabled = True
        Me.CmbSessao.Location = New System.Drawing.Point(297, 48)
        Me.CmbSessao.Name = "CmbSessao"
        Me.CmbSessao.Size = New System.Drawing.Size(90, 21)
        Me.CmbSessao.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sala"
        '
        'CmbSala
        '
        Me.CmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSala.FormattingEnabled = True
        Me.CmbSala.Location = New System.Drawing.Point(51, 48)
        Me.CmbSala.Name = "CmbSala"
        Me.CmbSala.Size = New System.Drawing.Size(150, 21)
        Me.CmbSala.TabIndex = 2
        '
        'CmbIngressoTipo
        '
        Me.CmbIngressoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIngressoTipo.FormattingEnabled = True
        Me.CmbIngressoTipo.Items.AddRange(New Object() {"Inteira", "Meia"})
        Me.CmbIngressoTipo.Location = New System.Drawing.Point(51, 19)
        Me.CmbIngressoTipo.Name = "CmbIngressoTipo"
        Me.CmbIngressoTipo.Size = New System.Drawing.Size(150, 21)
        Me.CmbIngressoTipo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo"
        '
        'TxtAssento
        '
        Me.TxtAssento.BackColor = System.Drawing.Color.White
        Me.TxtAssento.Location = New System.Drawing.Point(700, 10)
        Me.TxtAssento.Name = "TxtAssento"
        Me.TxtAssento.ReadOnly = True
        Me.TxtAssento.Size = New System.Drawing.Size(67, 20)
        Me.TxtAssento.TabIndex = 16
        Me.TxtAssento.Text = "A1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(649, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Assento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cadeiras disponíveis"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnComprar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtSinopse)
        Me.GroupBox2.Controls.Add(Me.ImgPoster)
        Me.GroupBox2.Controls.Add(Me.TxtTitulo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtDuracao)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 282)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações do filme"
        '
        'BtnComprar
        '
        Me.BtnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnComprar.Location = New System.Drawing.Point(176, 243)
        Me.BtnComprar.Name = "BtnComprar"
        Me.BtnComprar.Size = New System.Drawing.Size(217, 33)
        Me.BtnComprar.TabIndex = 21
        Me.BtnComprar.Text = "Comprar"
        Me.BtnComprar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Título"
        '
        'TxtSinopse
        '
        Me.TxtSinopse.BackColor = System.Drawing.Color.White
        Me.TxtSinopse.Location = New System.Drawing.Point(176, 58)
        Me.TxtSinopse.Multiline = True
        Me.TxtSinopse.Name = "TxtSinopse"
        Me.TxtSinopse.ReadOnly = True
        Me.TxtSinopse.Size = New System.Drawing.Size(217, 179)
        Me.TxtSinopse.TabIndex = 20
        Me.TxtSinopse.Text = "(Sinopse de até 255 caracteres)"
        '
        'ImgPoster
        '
        Me.ImgPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgPoster.ErrorImage = Nothing
        Me.ImgPoster.Image = CType(resources.GetObject("ImgPoster.Image"), System.Drawing.Image)
        Me.ImgPoster.InitialImage = Nothing
        Me.ImgPoster.Location = New System.Drawing.Point(9, 58)
        Me.ImgPoster.Name = "ImgPoster"
        Me.ImgPoster.Size = New System.Drawing.Size(161, 218)
        Me.ImgPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPoster.TabIndex = 13
        Me.ImgPoster.TabStop = False
        '
        'TxtTitulo
        '
        Me.TxtTitulo.BackColor = System.Drawing.Color.White
        Me.TxtTitulo.Location = New System.Drawing.Point(9, 32)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.ReadOnly = True
        Me.TxtTitulo.Size = New System.Drawing.Size(282, 20)
        Me.TxtTitulo.TabIndex = 15
        Me.TxtTitulo.Text = "(Título do filme)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Duração"
        '
        'TxtDuracao
        '
        Me.TxtDuracao.BackColor = System.Drawing.Color.White
        Me.TxtDuracao.Location = New System.Drawing.Point(297, 32)
        Me.TxtDuracao.Name = "TxtDuracao"
        Me.TxtDuracao.ReadOnly = True
        Me.TxtDuracao.Size = New System.Drawing.Size(45, 20)
        Me.TxtDuracao.TabIndex = 17
        Me.TxtDuracao.Text = "000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "minutos"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "A"
        Me.DataGridViewImageColumn1.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 30
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "B"
        Me.DataGridViewImageColumn2.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.Width = 30
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "C"
        Me.DataGridViewImageColumn3.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn3.Width = 30
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = "D"
        Me.DataGridViewImageColumn4.Image = Global.CinemasterTicket.My.Resources.Resources.Cadeira
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.ReadOnly = True
        Me.DataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn4.Width = 30
        '
        'FrmIngressoComprar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(777, 397)
        Me.Controls.Add(Me.TxtAssento)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgSalaAssentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIngressoComprar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de ingressos"
        CType(Me.DgSalaAssentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ImgPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgSalaAssentos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbSala As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbSessao As ComboBox
    Friend WithEvents CmbIngressoTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents Linhas As DataGridViewTextBoxColumn
    Friend WithEvents A As DataGridViewImageColumn
    Friend WithEvents B As DataGridViewImageColumn
    Friend WithEvents C As DataGridViewImageColumn
    Friend WithEvents D As DataGridViewImageColumn
    Friend WithEvents E As DataGridViewImageColumn
    Friend WithEvents CorredorH As DataGridViewTextBoxColumn
    Friend WithEvents F As DataGridViewImageColumn
    Friend WithEvents G As DataGridViewImageColumn
    Friend WithEvents H As DataGridViewImageColumn
    Friend WithEvents I As DataGridViewImageColumn
    Friend WithEvents J As DataGridViewImageColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAssento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnComprar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSinopse As TextBox
    Friend WithEvents ImgPoster As PictureBox
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtDuracao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotal As TextBox
End Class
