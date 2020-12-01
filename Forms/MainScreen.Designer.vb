<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAllOrders = New System.Windows.Forms.Button()
        Me.btnSearchOrder = New System.Windows.Forms.Button()
        Me.txtSearchOrder = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtTPrice = New System.Windows.Forms.TextBox()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.txtCId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnDeleteOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdertotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysDataSet2 = New OMSys.OMSysDataSet2()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAllStocks = New System.Windows.Forms.Button()
        Me.btnSearchStock = New System.Windows.Forms.Button()
        Me.txtSearchStock = New System.Windows.Forms.TextBox()
        Me.btnDeleteStock = New System.Windows.Forms.Button()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.txtPQuantity = New System.Windows.Forms.TextBox()
        Me.txtPprice = New System.Windows.Forms.TextBox()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.txtPType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProducttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysDataSet3 = New OMSys.OMSysDataSet3()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAllCustomers = New System.Windows.Forms.Button()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerfirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomermiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerlastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeremailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomercontactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysDataSet6 = New OMSys.OMSysDataSet6()
        Me.OrdersTableAdapter = New OMSys.OMSysDataSet2TableAdapters.OrdersTableAdapter()
        Me.StockTableAdapter = New OMSys.OMSysDataSet3TableAdapters.StockTableAdapter()
        Me.OMSysDataSet4 = New OMSys.OMSysDataSet4()
        Me.StockBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter1 = New OMSys.OMSysDataSet4TableAdapters.StockTableAdapter()
        Me.OMSysDataSet5 = New OMSys.OMSysDataSet5()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New OMSys.OMSysDataSet5TableAdapters.CustomerTableAdapter()
        Me.CustomerTableAdapter1 = New OMSys.OMSysDataSet6TableAdapters.CustomerTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1206, 634)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.btnAllOrders)
        Me.TabPage1.Controls.Add(Me.btnSearchOrder)
        Me.TabPage1.Controls.Add(Me.txtSearchOrder)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.btnAddOrder)
        Me.TabPage1.Controls.Add(Me.txtDesc)
        Me.TabPage1.Controls.Add(Me.txtTPrice)
        Me.TabPage1.Controls.Add(Me.txtPid)
        Me.TabPage1.Controls.Add(Me.txtCId)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.btnDeleteOrder)
        Me.TabPage1.Controls.Add(Me.btnUpdateOrder)
        Me.TabPage1.Controls.Add(Me.dgvOrder)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1198, 604)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Orders"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(858, 454)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 19)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Customer ID:"
        '
        'btnAllOrders
        '
        Me.btnAllOrders.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAllOrders.ForeColor = System.Drawing.Color.White
        Me.btnAllOrders.Location = New System.Drawing.Point(1091, 537)
        Me.btnAllOrders.Name = "btnAllOrders"
        Me.btnAllOrders.Size = New System.Drawing.Size(84, 32)
        Me.btnAllOrders.TabIndex = 37
        Me.btnAllOrders.Text = "All Orders"
        Me.btnAllOrders.UseVisualStyleBackColor = False
        '
        'btnSearchOrder
        '
        Me.btnSearchOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearchOrder.ForeColor = System.Drawing.Color.White
        Me.btnSearchOrder.Location = New System.Drawing.Point(1091, 481)
        Me.btnSearchOrder.Name = "btnSearchOrder"
        Me.btnSearchOrder.Size = New System.Drawing.Size(84, 32)
        Me.btnSearchOrder.TabIndex = 36
        Me.btnSearchOrder.Text = "Search"
        Me.btnSearchOrder.UseVisualStyleBackColor = False
        '
        'txtSearchOrder
        '
        Me.txtSearchOrder.Location = New System.Drawing.Point(862, 486)
        Me.txtSearchOrder.Name = "txtSearchOrder"
        Me.txtSearchOrder.Size = New System.Drawing.Size(199, 23)
        Me.txtSearchOrder.TabIndex = 35
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"PENDING", "PAID", "ACCEPTED"})
        Me.cboStatus.Location = New System.Drawing.Point(1023, 294)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(152, 25)
        Me.cboStatus.TabIndex = 34
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(1092, 379)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(84, 32)
        Me.btnAddOrder.TabIndex = 33
        Me.btnAddOrder.Text = "Add"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(961, 172)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(215, 103)
        Me.txtDesc.TabIndex = 31
        '
        'txtTPrice
        '
        Me.txtTPrice.Location = New System.Drawing.Point(1048, 122)
        Me.txtTPrice.Name = "txtTPrice"
        Me.txtTPrice.Size = New System.Drawing.Size(128, 23)
        Me.txtTPrice.TabIndex = 30
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(1048, 72)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(128, 23)
        Me.txtPid.TabIndex = 29
        '
        'txtCId
        '
        Me.txtCId.Location = New System.Drawing.Point(1048, 22)
        Me.txtCId.Name = "txtCId"
        Me.txtCId.Size = New System.Drawing.Size(128, 23)
        Me.txtCId.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(837, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Status:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(837, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Description:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(837, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 19)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Total Price( to change):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(837, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 19)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Product ID:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(837, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 19)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Customer ID:"
        '
        'btnDeleteOrder
        '
        Me.btnDeleteOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeleteOrder.ForeColor = System.Drawing.Color.White
        Me.btnDeleteOrder.Location = New System.Drawing.Point(862, 379)
        Me.btnDeleteOrder.Name = "btnDeleteOrder"
        Me.btnDeleteOrder.Size = New System.Drawing.Size(84, 32)
        Me.btnDeleteOrder.TabIndex = 11
        Me.btnDeleteOrder.Text = "Delete"
        Me.btnDeleteOrder.UseVisualStyleBackColor = False
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUpdateOrder.ForeColor = System.Drawing.Color.White
        Me.btnUpdateOrder.Location = New System.Drawing.Point(977, 379)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(84, 32)
        Me.btnUpdateOrder.TabIndex = 10
        Me.btnUpdateOrder.Text = "Update"
        Me.btnUpdateOrder.UseVisualStyleBackColor = False
        '
        'dgvOrder
        '
        Me.dgvOrder.AutoGenerateColumns = False
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.OrdertotalDataGridViewTextBoxColumn, Me.OrderdescriptionDataGridViewTextBoxColumn, Me.OrderstatusDataGridViewTextBoxColumn})
        Me.dgvOrder.DataSource = Me.OrdersBindingSource
        Me.dgvOrder.Location = New System.Drawing.Point(6, 6)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.RowHeadersWidth = 51
        Me.dgvOrder.RowTemplate.Height = 24
        Me.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrder.Size = New System.Drawing.Size(814, 533)
        Me.dgvOrder.TabIndex = 2
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.OrderIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderIDDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 125
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.Width = 110
        '
        'OrdertotalDataGridViewTextBoxColumn
        '
        Me.OrdertotalDataGridViewTextBoxColumn.DataPropertyName = "Order_total"
        Me.OrdertotalDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.OrdertotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrdertotalDataGridViewTextBoxColumn.Name = "OrdertotalDataGridViewTextBoxColumn"
        Me.OrdertotalDataGridViewTextBoxColumn.Width = 125
        '
        'OrderdescriptionDataGridViewTextBoxColumn
        '
        Me.OrderdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Order_description"
        Me.OrderdescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.OrderdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderdescriptionDataGridViewTextBoxColumn.Name = "OrderdescriptionDataGridViewTextBoxColumn"
        Me.OrderdescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'OrderstatusDataGridViewTextBoxColumn
        '
        Me.OrderstatusDataGridViewTextBoxColumn.DataPropertyName = "Order_status"
        Me.OrderstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.OrderstatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderstatusDataGridViewTextBoxColumn.Name = "OrderstatusDataGridViewTextBoxColumn"
        Me.OrderstatusDataGridViewTextBoxColumn.Width = 125
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.OMSysDataSet2
        '
        'OMSysDataSet2
        '
        Me.OMSysDataSet2.DataSetName = "OMSysDataSet2"
        Me.OMSysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.btnAllStocks)
        Me.TabPage2.Controls.Add(Me.btnSearchStock)
        Me.TabPage2.Controls.Add(Me.txtSearchStock)
        Me.TabPage2.Controls.Add(Me.btnDeleteStock)
        Me.TabPage2.Controls.Add(Me.btnUpdateStock)
        Me.TabPage2.Controls.Add(Me.btnAddStock)
        Me.TabPage2.Controls.Add(Me.txtPQuantity)
        Me.TabPage2.Controls.Add(Me.txtPprice)
        Me.TabPage2.Controls.Add(Me.txtPname)
        Me.TabPage2.Controls.Add(Me.txtPType)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.dgvStock)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1198, 604)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stocks"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(859, 392)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 27)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Product name:"
        '
        'btnAllStocks
        '
        Me.btnAllStocks.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAllStocks.ForeColor = System.Drawing.Color.White
        Me.btnAllStocks.Location = New System.Drawing.Point(1092, 473)
        Me.btnAllStocks.Name = "btnAllStocks"
        Me.btnAllStocks.Size = New System.Drawing.Size(84, 32)
        Me.btnAllStocks.TabIndex = 40
        Me.btnAllStocks.Text = "All Stocks"
        Me.btnAllStocks.UseVisualStyleBackColor = False
        '
        'btnSearchStock
        '
        Me.btnSearchStock.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearchStock.ForeColor = System.Drawing.Color.White
        Me.btnSearchStock.Location = New System.Drawing.Point(1092, 417)
        Me.btnSearchStock.Name = "btnSearchStock"
        Me.btnSearchStock.Size = New System.Drawing.Size(84, 32)
        Me.btnSearchStock.TabIndex = 39
        Me.btnSearchStock.Text = "Search"
        Me.btnSearchStock.UseVisualStyleBackColor = False
        '
        'txtSearchStock
        '
        Me.txtSearchStock.Location = New System.Drawing.Point(863, 422)
        Me.txtSearchStock.Name = "txtSearchStock"
        Me.txtSearchStock.Size = New System.Drawing.Size(199, 23)
        Me.txtSearchStock.TabIndex = 38
        '
        'btnDeleteStock
        '
        Me.btnDeleteStock.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeleteStock.ForeColor = System.Drawing.Color.White
        Me.btnDeleteStock.Location = New System.Drawing.Point(865, 295)
        Me.btnDeleteStock.Name = "btnDeleteStock"
        Me.btnDeleteStock.Size = New System.Drawing.Size(84, 32)
        Me.btnDeleteStock.TabIndex = 35
        Me.btnDeleteStock.Text = "Delete"
        Me.btnDeleteStock.UseVisualStyleBackColor = False
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUpdateStock.ForeColor = System.Drawing.Color.White
        Me.btnUpdateStock.Location = New System.Drawing.Point(978, 295)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(84, 32)
        Me.btnUpdateStock.TabIndex = 34
        Me.btnUpdateStock.Text = "Update"
        Me.btnUpdateStock.UseVisualStyleBackColor = False
        '
        'btnAddStock
        '
        Me.btnAddStock.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddStock.ForeColor = System.Drawing.Color.White
        Me.btnAddStock.Location = New System.Drawing.Point(1091, 295)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(84, 32)
        Me.btnAddStock.TabIndex = 33
        Me.btnAddStock.Text = "Add"
        Me.btnAddStock.UseVisualStyleBackColor = False
        '
        'txtPQuantity
        '
        Me.txtPQuantity.Location = New System.Drawing.Point(1005, 229)
        Me.txtPQuantity.Name = "txtPQuantity"
        Me.txtPQuantity.Size = New System.Drawing.Size(170, 23)
        Me.txtPQuantity.TabIndex = 31
        '
        'txtPprice
        '
        Me.txtPprice.Location = New System.Drawing.Point(1005, 179)
        Me.txtPprice.Name = "txtPprice"
        Me.txtPprice.Size = New System.Drawing.Size(170, 23)
        Me.txtPprice.TabIndex = 30
        '
        'txtPname
        '
        Me.txtPname.Location = New System.Drawing.Point(1005, 129)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(170, 23)
        Me.txtPname.TabIndex = 29
        '
        'txtPType
        '
        Me.txtPType.Location = New System.Drawing.Point(1005, 79)
        Me.txtPType.Name = "txtPType"
        Me.txtPType.Size = New System.Drawing.Size(170, 23)
        Me.txtPType.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(834, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(834, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 19)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(834, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Product name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(834, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 19)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Product type:"
        '
        'dgvStock
        '
        Me.dgvStock.AutoGenerateColumns = False
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn1, Me.ProducttypeDataGridViewTextBoxColumn, Me.ProductnameDataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.dgvStock.DataSource = Me.StockBindingSource
        Me.dgvStock.Location = New System.Drawing.Point(6, 6)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.RowHeadersWidth = 51
        Me.dgvStock.RowTemplate.Height = 24
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(805, 533)
        Me.dgvStock.TabIndex = 6
        '
        'ProductIDDataGridViewTextBoxColumn1
        '
        Me.ProductIDDataGridViewTextBoxColumn1.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.ProductIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn1.Name = "ProductIDDataGridViewTextBoxColumn1"
        Me.ProductIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn1.Width = 125
        '
        'ProducttypeDataGridViewTextBoxColumn
        '
        Me.ProducttypeDataGridViewTextBoxColumn.DataPropertyName = "Product_type"
        Me.ProducttypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.ProducttypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProducttypeDataGridViewTextBoxColumn.Name = "ProducttypeDataGridViewTextBoxColumn"
        Me.ProducttypeDataGridViewTextBoxColumn.Width = 150
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "Product_name"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ProductnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        Me.ProductnameDataGridViewTextBoxColumn.Width = 250
        '
        'ProductpriceDataGridViewTextBoxColumn
        '
        Me.ProductpriceDataGridViewTextBoxColumn.DataPropertyName = "Product_price"
        Me.ProductpriceDataGridViewTextBoxColumn.HeaderText = "Price"
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
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.OMSysDataSet3
        '
        'OMSysDataSet3
        '
        Me.OMSysDataSet3.DataSetName = "OMSysDataSet3"
        Me.OMSysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.btnAllCustomers)
        Me.TabPage3.Controls.Add(Me.btnSearchCustomer)
        Me.TabPage3.Controls.Add(Me.txtSearchCustomer)
        Me.TabPage3.Controls.Add(Me.btnDeleteCustomer)
        Me.TabPage3.Controls.Add(Me.btnUpdateCustomer)
        Me.TabPage3.Controls.Add(Me.btnAddCustomer)
        Me.TabPage3.Controls.Add(Me.txtContactNo)
        Me.TabPage3.Controls.Add(Me.txtEmail)
        Me.TabPage3.Controls.Add(Me.txtLname)
        Me.TabPage3.Controls.Add(Me.txtMname)
        Me.TabPage3.Controls.Add(Me.txtFname)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.dgvCustomer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1198, 604)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Customers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(839, 406)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 19)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "First name:"
        '
        'btnAllCustomers
        '
        Me.btnAllCustomers.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAllCustomers.ForeColor = System.Drawing.Color.White
        Me.btnAllCustomers.Location = New System.Drawing.Point(1039, 488)
        Me.btnAllCustomers.Name = "btnAllCustomers"
        Me.btnAllCustomers.Size = New System.Drawing.Size(117, 32)
        Me.btnAllCustomers.TabIndex = 40
        Me.btnAllCustomers.Text = "All Customers"
        Me.btnAllCustomers.UseVisualStyleBackColor = False
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSearchCustomer.ForeColor = System.Drawing.Color.White
        Me.btnSearchCustomer.Location = New System.Drawing.Point(1072, 432)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(84, 32)
        Me.btnSearchCustomer.TabIndex = 39
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = False
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Location = New System.Drawing.Point(843, 437)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(199, 23)
        Me.txtSearchCustomer.TabIndex = 38
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnDeleteCustomer.ForeColor = System.Drawing.Color.White
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(842, 336)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(84, 32)
        Me.btnDeleteCustomer.TabIndex = 24
        Me.btnDeleteCustomer.Text = "Delete"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = False
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnUpdateCustomer.ForeColor = System.Drawing.Color.White
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(957, 336)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(84, 32)
        Me.btnUpdateCustomer.TabIndex = 23
        Me.btnUpdateCustomer.Text = "Update"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = False
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.White
        Me.btnAddCustomer.Location = New System.Drawing.Point(1072, 336)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(84, 32)
        Me.btnAddCustomer.TabIndex = 22
        Me.btnAddCustomer.Text = "Add"
        Me.btnAddCustomer.UseVisualStyleBackColor = False
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(927, 251)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(229, 23)
        Me.txtContactNo.TabIndex = 21
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(927, 201)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(229, 23)
        Me.txtEmail.TabIndex = 20
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(927, 151)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(229, 23)
        Me.txtLname.TabIndex = 19
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(927, 101)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(229, 23)
        Me.txtMname.TabIndex = 18
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(927, 51)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(229, 23)
        Me.txtFname.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(778, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Contact Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(778, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Email address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(778, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Last name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(778, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Middle name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(778, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "First name:"
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AutoGenerateColumns = False
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn1, Me.CustomerfirstNameDataGridViewTextBoxColumn, Me.CustomermiddleNameDataGridViewTextBoxColumn, Me.CustomerlastNameDataGridViewTextBoxColumn, Me.CustomeremailDataGridViewTextBoxColumn, Me.CustomercontactNoDataGridViewTextBoxColumn})
        Me.dgvCustomer.DataSource = Me.CustomerBindingSource1
        Me.dgvCustomer.Location = New System.Drawing.Point(6, 6)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersWidth = 51
        Me.dgvCustomer.RowTemplate.Height = 24
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(756, 533)
        Me.dgvCustomer.TabIndex = 6
        '
        'CustomerIDDataGridViewTextBoxColumn1
        '
        Me.CustomerIDDataGridViewTextBoxColumn1.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.CustomerIDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn1.Name = "CustomerIDDataGridViewTextBoxColumn1"
        Me.CustomerIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn1.Width = 125
        '
        'CustomerfirstNameDataGridViewTextBoxColumn
        '
        Me.CustomerfirstNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_firstName"
        Me.CustomerfirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.CustomerfirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerfirstNameDataGridViewTextBoxColumn.Name = "CustomerfirstNameDataGridViewTextBoxColumn"
        Me.CustomerfirstNameDataGridViewTextBoxColumn.Width = 200
        '
        'CustomermiddleNameDataGridViewTextBoxColumn
        '
        Me.CustomermiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_middleName"
        Me.CustomermiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.CustomermiddleNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomermiddleNameDataGridViewTextBoxColumn.Name = "CustomermiddleNameDataGridViewTextBoxColumn"
        Me.CustomermiddleNameDataGridViewTextBoxColumn.Width = 200
        '
        'CustomerlastNameDataGridViewTextBoxColumn
        '
        Me.CustomerlastNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_lastName"
        Me.CustomerlastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.CustomerlastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerlastNameDataGridViewTextBoxColumn.Name = "CustomerlastNameDataGridViewTextBoxColumn"
        Me.CustomerlastNameDataGridViewTextBoxColumn.Width = 200
        '
        'CustomeremailDataGridViewTextBoxColumn
        '
        Me.CustomeremailDataGridViewTextBoxColumn.DataPropertyName = "Customer_email"
        Me.CustomeremailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.CustomeremailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomeremailDataGridViewTextBoxColumn.Name = "CustomeremailDataGridViewTextBoxColumn"
        Me.CustomeremailDataGridViewTextBoxColumn.Width = 200
        '
        'CustomercontactNoDataGridViewTextBoxColumn
        '
        Me.CustomercontactNoDataGridViewTextBoxColumn.DataPropertyName = "Customer_contactNo"
        Me.CustomercontactNoDataGridViewTextBoxColumn.HeaderText = "Contact Number"
        Me.CustomercontactNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomercontactNoDataGridViewTextBoxColumn.Name = "CustomercontactNoDataGridViewTextBoxColumn"
        Me.CustomercontactNoDataGridViewTextBoxColumn.Width = 200
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.OMSysDataSet6
        '
        'OMSysDataSet6
        '
        Me.OMSysDataSet6.DataSetName = "OMSysDataSet6"
        Me.OMSysDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'OMSysDataSet4
        '
        Me.OMSysDataSet4.DataSetName = "OMSysDataSet4"
        Me.OMSysDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource1
        '
        Me.StockBindingSource1.DataMember = "Stock"
        Me.StockBindingSource1.DataSource = Me.OMSysDataSet4
        '
        'StockTableAdapter1
        '
        Me.StockTableAdapter1.ClearBeforeFill = True
        '
        'OMSysDataSet5
        '
        Me.OMSysDataSet5.DataSetName = "OMSysDataSet5"
        Me.OMSysDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.OMSysDataSet5
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1230, 658)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OMSys"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents OMSysDataSet2 As OMSysDataSet2
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As OMSysDataSet2TableAdapters.OrdersTableAdapter
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents OMSysDataSet3 As OMSysDataSet3
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As OMSysDataSet3TableAdapters.StockTableAdapter
    Friend WithEvents OMSysDataSet4 As OMSysDataSet4
    Friend WithEvents StockBindingSource1 As BindingSource
    Friend WithEvents StockTableAdapter1 As OMSysDataSet4TableAdapters.StockTableAdapter
    Friend WithEvents OMSysDataSet5 As OMSysDataSet5
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As OMSysDataSet5TableAdapters.CustomerTableAdapter
    Friend WithEvents dgvStock As DataGridView
    Friend WithEvents OMSysDataSet6 As OMSysDataSet6
    Friend WithEvents CustomerBindingSource1 As BindingSource
    Friend WithEvents CustomerTableAdapter1 As OMSysDataSet6TableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerfirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomermiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerlastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomeremailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomercontactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProducttypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdertotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Public WithEvents dgvCustomer As DataGridView
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddStock As Button
    Friend WithEvents txtPQuantity As TextBox
    Friend WithEvents txtPprice As TextBox
    Friend WithEvents txtPname As TextBox
    Friend WithEvents txtPType As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtTPrice As TextBox
    Friend WithEvents txtPid As TextBox
    Friend WithEvents txtCId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnDeleteStock As Button
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents btnUpdateCustomer As Button
    Friend WithEvents btnSearchOrder As Button
    Friend WithEvents txtSearchOrder As TextBox
    Friend WithEvents btnAllOrders As Button
    Friend WithEvents btnAllStocks As Button
    Friend WithEvents btnSearchStock As Button
    Friend WithEvents txtSearchStock As TextBox
    Friend WithEvents btnAllCustomers As Button
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
