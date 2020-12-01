<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdertotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMSysDataSet = New OMSys.OMSysDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.OrderTableAdapter = New OMSys.OMSysDataSetTableAdapters.OrderTableAdapter()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMSysDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.OrdertotalDataGridViewTextBoxColumn, Me.OrderdescriptionDataGridViewTextBoxColumn, Me.OrderstatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(804, 494)
        Me.DataGridView1.TabIndex = 1
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 125
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.Width = 125
        '
        'OrdertotalDataGridViewTextBoxColumn
        '
        Me.OrdertotalDataGridViewTextBoxColumn.DataPropertyName = "Order_total"
        Me.OrdertotalDataGridViewTextBoxColumn.HeaderText = "Order_total"
        Me.OrdertotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrdertotalDataGridViewTextBoxColumn.Name = "OrdertotalDataGridViewTextBoxColumn"
        Me.OrdertotalDataGridViewTextBoxColumn.Width = 125
        '
        'OrderdescriptionDataGridViewTextBoxColumn
        '
        Me.OrderdescriptionDataGridViewTextBoxColumn.DataPropertyName = "Order_description"
        Me.OrderdescriptionDataGridViewTextBoxColumn.HeaderText = "Order_description"
        Me.OrderdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderdescriptionDataGridViewTextBoxColumn.Name = "OrderdescriptionDataGridViewTextBoxColumn"
        Me.OrderdescriptionDataGridViewTextBoxColumn.Width = 125
        '
        'OrderstatusDataGridViewTextBoxColumn
        '
        Me.OrderstatusDataGridViewTextBoxColumn.DataPropertyName = "Order_status"
        Me.OrderstatusDataGridViewTextBoxColumn.HeaderText = "Order_status"
        Me.OrderstatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderstatusDataGridViewTextBoxColumn.Name = "OrderstatusDataGridViewTextBoxColumn"
        Me.OrderstatusDataGridViewTextBoxColumn.Width = 125
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.OMSysDataSet
        '
        'OMSysDataSet
        '
        Me.OMSysDataSet.DataSetName = "OMSysDataSet"
        Me.OMSysDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(907, 644)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ORDER MANAGEMENT SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(858, 542)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 96)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "OMSYS"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnAddOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(860, 475)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(303, 64)
        Me.btnAddOrder.TabIndex = 11
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Customer_ID", True))
        Me.txtCustomerID.Location = New System.Drawing.Point(942, 135)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(94, 23)
        Me.txtCustomerID.TabIndex = 13
        '
        'txtProductID
        '
        Me.txtProductID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Product_ID", True))
        Me.txtProductID.Location = New System.Drawing.Point(942, 180)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(94, 23)
        Me.txtProductID.TabIndex = 14
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Order_total", True))
        Me.txtTotalPrice.Location = New System.Drawing.Point(942, 223)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(138, 23)
        Me.txtTotalPrice.TabIndex = 15
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Order_description", True))
        Me.txtDescription.Location = New System.Drawing.Point(942, 274)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(214, 83)
        Me.txtDescription.TabIndex = 16
        '
        'txtStatus
        '
        Me.txtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderBindingSource, "Order_status", True))
        Me.txtStatus.Location = New System.Drawing.Point(942, 379)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(138, 23)
        Me.txtStatus.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(834, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Customer ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(834, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Product ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(834, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(834, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 19)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Additional note:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(834, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Status:"
        '
        'frmOrderList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1176, 720)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOrderList"
        Me.Text = "4 Persona PH"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMSysDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents OMSysDataSet As OMSysDataSet
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As OMSysDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdertotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
