<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprarIngressosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerFilmesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSessõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSalasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuárioToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(576, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuárioToolStripMenuItem
        '
        Me.UsuárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntrarToolStripMenuItem, Me.EncerrarSessãoToolStripMenuItem, Me.ToolStripSeparator1, Me.SairToolStripMenuItem})
        Me.UsuárioToolStripMenuItem.Name = "UsuárioToolStripMenuItem"
        Me.UsuárioToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.UsuárioToolStripMenuItem.Text = "Usuário"
        '
        'EntrarToolStripMenuItem
        '
        Me.EntrarToolStripMenuItem.Name = "EntrarToolStripMenuItem"
        Me.EntrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EntrarToolStripMenuItem.Text = "Entrar"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Enabled = False
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar sessão"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprarIngressosToolStripMenuItem, Me.HistóricoDeComprasToolStripMenuItem, Me.VerFilmesToolStripMenuItem, Me.VerSessõesToolStripMenuItem, Me.VerSalasToolStripMenuItem})
        Me.ServiçosToolStripMenuItem.Enabled = False
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'ComprarIngressosToolStripMenuItem
        '
        Me.ComprarIngressosToolStripMenuItem.Name = "ComprarIngressosToolStripMenuItem"
        Me.ComprarIngressosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ComprarIngressosToolStripMenuItem.Text = "Comprar ingressos"
        '
        'HistóricoDeComprasToolStripMenuItem
        '
        Me.HistóricoDeComprasToolStripMenuItem.Name = "HistóricoDeComprasToolStripMenuItem"
        Me.HistóricoDeComprasToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.HistóricoDeComprasToolStripMenuItem.Text = "Histórico de compras"
        '
        'VerFilmesToolStripMenuItem
        '
        Me.VerFilmesToolStripMenuItem.Name = "VerFilmesToolStripMenuItem"
        Me.VerFilmesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.VerFilmesToolStripMenuItem.Text = "Ver filmes"
        '
        'VerSessõesToolStripMenuItem
        '
        Me.VerSessõesToolStripMenuItem.Name = "VerSessõesToolStripMenuItem"
        Me.VerSessõesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.VerSessõesToolStripMenuItem.Text = "Ver sessões"
        '
        'VerSalasToolStripMenuItem
        '
        Me.VerSalasToolStripMenuItem.Name = "VerSalasToolStripMenuItem"
        Me.VerSalasToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.VerSalasToolStripMenuItem.Text = "Ver salas"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(576, 347)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cinemaster Ticket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprarIngressosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerFilmesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerSalasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerSessõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoDeComprasToolStripMenuItem As ToolStripMenuItem
End Class
