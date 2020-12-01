<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockList
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
        Me.components = New System.ComponentModel.Container()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnManageOrder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OMSysDataSet = New OMSys.OMSysDataSet()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New OMSys.OMSysDataSetTableAdapters.OrderTableAdapter()
        Me.OMSysDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysDataSet1 = New OMSys.OMSysDataSet1()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New OMSys.OMSysDataSet1TableAdapters.StockTableAdapter()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProducttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(815, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Search"
        '
        'btnManageOrder
        '
        Me.btnManageOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnManageOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageOrder.ForeColor = System.Drawing.Color.White
        Me.btnManageOrder.Location = New System.Drawing.Point(815, 378)
        Me.btnManageOrder.Name = "btnManageOrder"
        Me.btnManageOrder.Size = New System.Drawing.Size(303, 60)
        Me.btnManageOrder.TabIndex = 19
        Me.btnManageOrder.Text = "Add Stock"
        Me.btnManageOrder.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(861, 574)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(812, 478)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 96)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "OMSYS"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1006, 99)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 29)
        Me.ComboBox1.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(815, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(185, 30)
        Me.TextBox1.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProducttypeDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StockBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(51, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(679, 406)
        Me.DataGridView1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 58)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Stock"
        '
        'OMSysDataSet
        '
        Me.OMSysDataSet.DataSetName = "OMSysDataSet"
        Me.OMSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.OMSysDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'OMSysDataSetBindingSource
        '
        Me.OMSysDataSetBindingSource.DataSource = Me.OMSysDataSet
        Me.OMSysDataSetBindingSource.Position = 0
        '
        'OMSysDataSet1
        '
        Me.OMSysDataSet1.DataSetName = "OMSysDataSet1"
        Me.OMSysDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.OMSysDataSet1
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.Width = 125
        '
        'ProducttypeDataGridViewTextBoxColumn
        '
        Me.ProducttypeDataGridViewTextBoxColumn.DataPropertyName = "Product_type"
        Me.ProducttypeDataGridViewTextBoxColumn.HeaderText = "Product_type"
        Me.ProducttypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProducttypeDataGridViewTextBoxColumn.Name = "ProducttypeDataGridViewTextBoxColumn"
        Me.ProducttypeDataGridViewTextBoxColumn.Width = 125
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "Product_name"
        Me.ProductnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        Me.ProductnameDataGridViewTextBoxColumn.Width = 125
        '
        'ProductpriceDataGridViewTextBoxColumn
        '
        Me.ProductpriceDataGridViewTextBoxColumn.DataPropertyName = "Product_price"
        Me.ProductpriceDataGridViewTextBoxColumn.HeaderText = "Product_price"
        Me.ProductpriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductpriceDataGridViewTextBoxColumn.Name = "ProductpriceDataGridViewTextBoxColumn"
        Me.ProductpriceDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 125
        '
        'frmStockList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1169, 632)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnManageOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStockList"
        Me.Text = "StockList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnManageOrder As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents OMSysDataSet As OMSysDataSet
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As OMSysDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents OMSysDataSetBindingSource As BindingSource
    Friend WithEvents OMSysDataSet1 As OMSysDataSet1
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As OMSysDataSet1TableAdapters.StockTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProducttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
