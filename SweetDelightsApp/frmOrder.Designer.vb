<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.cmbCake = New System.Windows.Forms.ComboBox()
        Me.cmbIcing = New System.Windows.Forms.ComboBox()
        Me.cmbTopping = New System.Windows.Forms.ComboBox()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(91, 49)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(257, 21)
        Me.cmbCustomer.TabIndex = 0
        '
        'cmbCake
        '
        Me.cmbCake.FormattingEnabled = True
        Me.cmbCake.Location = New System.Drawing.Point(91, 86)
        Me.cmbCake.Name = "cmbCake"
        Me.cmbCake.Size = New System.Drawing.Size(257, 21)
        Me.cmbCake.TabIndex = 1
        '
        'cmbIcing
        '
        Me.cmbIcing.FormattingEnabled = True
        Me.cmbIcing.Location = New System.Drawing.Point(91, 128)
        Me.cmbIcing.Name = "cmbIcing"
        Me.cmbIcing.Size = New System.Drawing.Size(257, 21)
        Me.cmbIcing.TabIndex = 2
        '
        'cmbTopping
        '
        Me.cmbTopping.FormattingEnabled = True
        Me.cmbTopping.Location = New System.Drawing.Point(91, 170)
        Me.cmbTopping.Name = "cmbTopping"
        Me.cmbTopping.Size = New System.Drawing.Size(257, 21)
        Me.cmbTopping.TabIndex = 3
        '
        'numQuantity
        '
        Me.numQuantity.Location = New System.Drawing.Point(91, 208)
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(92, 20)
        Me.numQuantity.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "CUSTOMER:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(73, 20)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "CAKE:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 128)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(73, 20)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "ICING:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 171)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(73, 20)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "TOPPING:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(12, 208)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(73, 20)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "QUANTITY:"
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderDetails.Location = New System.Drawing.Point(371, 49)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.Size = New System.Drawing.Size(427, 199)
        Me.dgvOrderDetails.TabIndex = 10
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddItem.Location = New System.Drawing.Point(12, 246)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(132, 23)
        Me.btnAddItem.TabIndex = 11
        Me.btnAddItem.Text = "ADD ITEM"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(428, 269)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(91, 23)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(368, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TOTAL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemoveItem.Location = New System.Drawing.Point(371, 351)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(132, 49)
        Me.btnRemoveItem.TabIndex = 14
        Me.btnRemoveItem.Text = "REMOVE ITEM"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPlaceOrder.Location = New System.Drawing.Point(634, 351)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(132, 49)
        Me.btnPlaceOrder.TabIndex = 15
        Me.btnPlaceOrder.Text = "PLACE ORDER"
        Me.btnPlaceOrder.UseVisualStyleBackColor = False
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvOrderDetails)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.numQuantity)
        Me.Controls.Add(Me.cmbTopping)
        Me.Controls.Add(Me.cmbIcing)
        Me.Controls.Add(Me.cmbCake)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Name = "frmOrder"
        Me.Text = "Order"
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents cmbCake As ComboBox
    Friend WithEvents cmbIcing As ComboBox
    Friend WithEvents cmbTopping As ComboBox
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnPlaceOrder As Button
End Class
