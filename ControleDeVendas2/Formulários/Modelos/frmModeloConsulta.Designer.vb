<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModeloConsulta
    Inherits ControleDeVendas2.frmModelo

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpGrupo = New System.Windows.Forms.GroupBox()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.dgdGrid = New System.Windows.Forms.DataGridView()
        Me.Código = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.grpGrupo.SuspendLayout()
        CType(Me.dgdGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGrupo
        '
        Me.grpGrupo.Controls.Add(Me.btnPesquisar)
        Me.grpGrupo.Controls.Add(Me.lblDescricao)
        Me.grpGrupo.Location = New System.Drawing.Point(10, 8)
        Me.grpGrupo.Name = "grpGrupo"
        Me.grpGrupo.Size = New System.Drawing.Size(488, 66)
        Me.grpGrupo.TabIndex = 0
        Me.grpGrupo.TabStop = False
        Me.grpGrupo.Text = "Filtros"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(6, 21)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(58, 13)
        Me.lblDescricao.TabIndex = 0
        Me.lblDescricao.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(87, 26)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(297, 20)
        Me.txtDescricao.TabIndex = 1
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(393, 13)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(80, 28)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'dgdGrid
        '
        Me.dgdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Código, Me.Descrição})
        Me.dgdGrid.Location = New System.Drawing.Point(10, 80)
        Me.dgdGrid.Name = "dgdGrid"
        Me.dgdGrid.Size = New System.Drawing.Size(482, 220)
        Me.dgdGrid.TabIndex = 2
        '
        'Código
        '
        Me.Código.DataPropertyName = "Código"
        Me.Código.HeaderText = "Código"
        Me.Código.Name = "Código"
        Me.Código.Width = 70
        '
        'Descrição
        '
        Me.Descrição.DataPropertyName = "Descrição"
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.Name = "Descrição"
        Me.Descrição.Width = 350
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(167, 312)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 3
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(248, 312)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 4
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(329, 312)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(417, 312)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmModeloConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(504, 347)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dgdGrid)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.grpGrupo)
        Me.Name = "frmModeloConsulta"
        Me.grpGrupo.ResumeLayout(False)
        Me.grpGrupo.PerformLayout()
        CType(Me.dgdGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpGrupo As GroupBox
    Friend WithEvents lblDescricao As Label
    Friend WithEvents txtDescricao As TextBox
    Public WithEvents btnPesquisar As Button
    Public WithEvents dgdGrid As DataGridView
    Friend WithEvents Código As DataGridViewTextBoxColumn
    Friend WithEvents Descrição As DataGridViewTextBoxColumn
    Public WithEvents btnNovo As Button
    Public WithEvents btnAlterar As Button
    Public WithEvents btnExcluir As Button
    Public WithEvents btnSair As Button
End Class
