<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedido
    Inherits ControleDeVendas2.frmModeloCadastro

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
        Me.grbPedido = New System.Windows.Forms.GroupBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.lblData = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.grbItem = New System.Windows.Forms.GroupBox()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.btnBuscarProduto = New System.Windows.Forms.Button()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnAdicionarItem = New System.Windows.Forms.Button()
        Me.btnRemoverItem = New System.Windows.Forms.Button()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.grpCampos.SuspendLayout()
        Me.grbPedido.SuspendLayout()
        Me.grbItem.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCampos
        '
        Me.grpCampos.Controls.Add(Me.grbItem)
        Me.grpCampos.Controls.Add(Me.grbPedido)
        Me.grpCampos.Size = New System.Drawing.Size(591, 363)
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(447, 392)
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(528, 392)
        '
        'grbPedido
        '
        Me.grbPedido.Controls.Add(Me.btnAdicionar)
        Me.grbPedido.Controls.Add(Me.btnBuscarCliente)
        Me.grbPedido.Controls.Add(Me.dtpData)
        Me.grbPedido.Controls.Add(Me.txtCliente)
        Me.grbPedido.Controls.Add(Me.lblCliente)
        Me.grbPedido.Controls.Add(Me.lblData)
        Me.grbPedido.Location = New System.Drawing.Point(6, 22)
        Me.grbPedido.Name = "grbPedido"
        Me.grbPedido.Size = New System.Drawing.Size(579, 126)
        Me.grbPedido.TabIndex = 2
        Me.grbPedido.TabStop = False
        Me.grbPedido.Text = "Pedido"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(7, 30)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(55, 27)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(411, 20)
        Me.txtCliente.TabIndex = 3
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(472, 25)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCliente.TabIndex = 4
        Me.btnBuscarCliente.Text = "Buscar:"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(16, 57)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 5
        Me.lblData.Text = "Data:"
        '
        'dtpData
        '
        Me.dtpData.CustomFormat = "dd/MM/yyyy"
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpData.Location = New System.Drawing.Point(55, 53)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(112, 20)
        Me.dtpData.TabIndex = 6
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(472, 97)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 3
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'grbItem
        '
        Me.grbItem.Controls.Add(Me.dgvItem)
        Me.grbItem.Controls.Add(Me.btnRemoverItem)
        Me.grbItem.Controls.Add(Me.btnAdicionarItem)
        Me.grbItem.Controls.Add(Me.txtValor)
        Me.grbItem.Controls.Add(Me.lblValor)
        Me.grbItem.Controls.Add(Me.txtQuantidade)
        Me.grbItem.Controls.Add(Me.lblQuantidade)
        Me.grbItem.Controls.Add(Me.btnBuscarProduto)
        Me.grbItem.Controls.Add(Me.txtProduto)
        Me.grbItem.Controls.Add(Me.lblProduto)
        Me.grbItem.Location = New System.Drawing.Point(6, 154)
        Me.grbItem.Name = "grbItem"
        Me.grbItem.Size = New System.Drawing.Size(579, 203)
        Me.grbItem.TabIndex = 3
        Me.grbItem.TabStop = False
        Me.grbItem.Text = "Item"
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(6, 25)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(47, 13)
        Me.lblProduto.TabIndex = 0
        Me.lblProduto.Text = "Produto:"
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(67, 22)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.ReadOnly = True
        Me.txtProduto.Size = New System.Drawing.Size(411, 20)
        Me.txtProduto.TabIndex = 1
        '
        'btnBuscarProduto
        '
        Me.btnBuscarProduto.Location = New System.Drawing.Point(484, 22)
        Me.btnBuscarProduto.Name = "btnBuscarProduto"
        Me.btnBuscarProduto.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarProduto.TabIndex = 2
        Me.btnBuscarProduto.Text = "Buscar"
        Me.btnBuscarProduto.UseVisualStyleBackColor = True
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(7, 58)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(65, 13)
        Me.lblQuantidade.TabIndex = 3
        Me.lblQuantidade.Text = "Quantidade:"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(78, 55)
        Me.txtQuantidade.MaxLength = 5
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantidade.TabIndex = 4
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(184, 58)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(34, 13)
        Me.lblValor.TabIndex = 5
        Me.lblValor.Text = "Valor:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(222, 55)
        Me.txtValor.MaxLength = 10
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 6
        '
        'btnAdicionarItem
        '
        Me.btnAdicionarItem.Location = New System.Drawing.Point(328, 53)
        Me.btnAdicionarItem.Name = "btnAdicionarItem"
        Me.btnAdicionarItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarItem.TabIndex = 7
        Me.btnAdicionarItem.Text = "Adicionar"
        Me.btnAdicionarItem.UseVisualStyleBackColor = True
        '
        'btnRemoverItem
        '
        Me.btnRemoverItem.Location = New System.Drawing.Point(409, 53)
        Me.btnRemoverItem.Name = "btnRemoverItem"
        Me.btnRemoverItem.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoverItem.TabIndex = 8
        Me.btnRemoverItem.Text = "Remover"
        Me.btnRemoverItem.UseVisualStyleBackColor = True
        '
        'dgvItem
        '
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Location = New System.Drawing.Point(9, 81)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.Size = New System.Drawing.Size(564, 115)
        Me.dgvItem.TabIndex = 9
        '
        'frmPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(607, 420)
        Me.Name = "frmPedido"
        Me.Text = "Pedidos"
        Me.grpCampos.ResumeLayout(False)
        Me.grbPedido.ResumeLayout(False)
        Me.grbPedido.PerformLayout()
        Me.grbItem.ResumeLayout(False)
        Me.grbItem.PerformLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbItem As GroupBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents lblValor As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents btnBuscarProduto As Button
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents lblProduto As Label
    Friend WithEvents grbPedido As GroupBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents dtpData As DateTimePicker
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblData As Label
    Friend WithEvents dgvItem As DataGridView
    Friend WithEvents btnRemoverItem As Button
    Friend WithEvents btnAdicionarItem As Button
End Class
