<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceTotal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblEnterSubtotal = New System.Windows.Forms.Label()
        Me.btnClearTotals = New System.Windows.Forms.Button()
        Me.txtEnterSubtotal = New System.Windows.Forms.TextBox()
        Me.lblNumberOfInvoices = New System.Windows.Forms.Label()
        Me.lblTotalOfInvoices = New System.Windows.Forms.Label()
        Me.lblinvoiceAverage = New System.Windows.Forms.Label()
        Me.txtNumberOfInvoices = New System.Windows.Forms.TextBox()
        Me.txtTotalOfInvoices = New System.Windows.Forms.TextBox()
        Me.txtInvoiceAverage = New System.Windows.Forms.TextBox()
        Me.lblLargestInvoice = New System.Windows.Forms.Label()
        Me.lblSmallestInvoice = New System.Windows.Forms.Label()
        Me.lblMidPoint = New System.Windows.Forms.Label()
        Me.txtLargestInvoice = New System.Windows.Forms.TextBox()
        Me.txtSmallestInvoice = New System.Windows.Forms.TextBox()
        Me.txtMidPoint = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(853, 210)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(602, 210)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 28)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(154, 64)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(132, 22)
        Me.txtSubtotal.TabIndex = 96
        Me.txtSubtotal.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Discount Amount:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Subtotal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Discount Percent:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Location = New System.Drawing.Point(154, 97)
        Me.txtDiscountPercent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.ReadOnly = True
        Me.txtDiscountPercent.Size = New System.Drawing.Size(132, 22)
        Me.txtDiscountPercent.TabIndex = 5
        Me.txtDiscountPercent.TabStop = False
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.Location = New System.Drawing.Point(154, 130)
        Me.txtDiscountAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.ReadOnly = True
        Me.txtDiscountAmount.Size = New System.Drawing.Size(132, 22)
        Me.txtDiscountAmount.TabIndex = 7
        Me.txtDiscountAmount.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(154, 163)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TabStop = False
        '
        'lblEnterSubtotal
        '
        Me.lblEnterSubtotal.AutoSize = True
        Me.lblEnterSubtotal.Location = New System.Drawing.Point(23, 33)
        Me.lblEnterSubtotal.Name = "lblEnterSubtotal"
        Me.lblEnterSubtotal.Size = New System.Drawing.Size(102, 17)
        Me.lblEnterSubtotal.TabIndex = 10
        Me.lblEnterSubtotal.Text = "Enter Subtotal:"
        '
        'btnClearTotals
        '
        Me.btnClearTotals.Location = New System.Drawing.Point(722, 210)
        Me.btnClearTotals.Name = "btnClearTotals"
        Me.btnClearTotals.Size = New System.Drawing.Size(113, 28)
        Me.btnClearTotals.TabIndex = 3
        Me.btnClearTotals.Text = "Clear Totals"
        Me.btnClearTotals.UseVisualStyleBackColor = True
        '
        'txtEnterSubtotal
        '
        Me.txtEnterSubtotal.Location = New System.Drawing.Point(154, 30)
        Me.txtEnterSubtotal.Name = "txtEnterSubtotal"
        Me.txtEnterSubtotal.Size = New System.Drawing.Size(132, 22)
        Me.txtEnterSubtotal.TabIndex = 1
        '
        'lblNumberOfInvoices
        '
        Me.lblNumberOfInvoices.AutoSize = True
        Me.lblNumberOfInvoices.Location = New System.Drawing.Point(342, 67)
        Me.lblNumberOfInvoices.Name = "lblNumberOfInvoices"
        Me.lblNumberOfInvoices.Size = New System.Drawing.Size(133, 17)
        Me.lblNumberOfInvoices.TabIndex = 13
        Me.lblNumberOfInvoices.Text = "Number of invoices:"
        '
        'lblTotalOfInvoices
        '
        Me.lblTotalOfInvoices.AutoSize = True
        Me.lblTotalOfInvoices.Location = New System.Drawing.Point(342, 101)
        Me.lblTotalOfInvoices.Name = "lblTotalOfInvoices"
        Me.lblTotalOfInvoices.Size = New System.Drawing.Size(115, 17)
        Me.lblTotalOfInvoices.TabIndex = 14
        Me.lblTotalOfInvoices.Text = "Total of invoices:"
        '
        'lblinvoiceAverage
        '
        Me.lblinvoiceAverage.AutoSize = True
        Me.lblinvoiceAverage.Location = New System.Drawing.Point(342, 134)
        Me.lblinvoiceAverage.Name = "lblinvoiceAverage"
        Me.lblinvoiceAverage.Size = New System.Drawing.Size(112, 17)
        Me.lblinvoiceAverage.TabIndex = 15
        Me.lblinvoiceAverage.Text = "Invoice average:"
        '
        'txtNumberOfInvoices
        '
        Me.txtNumberOfInvoices.Location = New System.Drawing.Point(490, 64)
        Me.txtNumberOfInvoices.Name = "txtNumberOfInvoices"
        Me.txtNumberOfInvoices.ReadOnly = True
        Me.txtNumberOfInvoices.Size = New System.Drawing.Size(135, 22)
        Me.txtNumberOfInvoices.TabIndex = 16
        Me.txtNumberOfInvoices.TabStop = False
        '
        'txtTotalOfInvoices
        '
        Me.txtTotalOfInvoices.Location = New System.Drawing.Point(490, 98)
        Me.txtTotalOfInvoices.Name = "txtTotalOfInvoices"
        Me.txtTotalOfInvoices.ReadOnly = True
        Me.txtTotalOfInvoices.Size = New System.Drawing.Size(135, 22)
        Me.txtTotalOfInvoices.TabIndex = 17
        Me.txtTotalOfInvoices.TabStop = False
        '
        'txtInvoiceAverage
        '
        Me.txtInvoiceAverage.Location = New System.Drawing.Point(491, 131)
        Me.txtInvoiceAverage.Name = "txtInvoiceAverage"
        Me.txtInvoiceAverage.ReadOnly = True
        Me.txtInvoiceAverage.Size = New System.Drawing.Size(135, 22)
        Me.txtInvoiceAverage.TabIndex = 18
        Me.txtInvoiceAverage.TabStop = False
        '
        'lblLargestInvoice
        '
        Me.lblLargestInvoice.AutoSize = True
        Me.lblLargestInvoice.Location = New System.Drawing.Point(679, 67)
        Me.lblLargestInvoice.Name = "lblLargestInvoice"
        Me.lblLargestInvoice.Size = New System.Drawing.Size(108, 17)
        Me.lblLargestInvoice.TabIndex = 97
        Me.lblLargestInvoice.Text = "Largest invoice:"
        '
        'lblSmallestInvoice
        '
        Me.lblSmallestInvoice.AutoSize = True
        Me.lblSmallestInvoice.Location = New System.Drawing.Point(679, 100)
        Me.lblSmallestInvoice.Name = "lblSmallestInvoice"
        Me.lblSmallestInvoice.Size = New System.Drawing.Size(113, 17)
        Me.lblSmallestInvoice.TabIndex = 98
        Me.lblSmallestInvoice.Text = "Smallest invoice:"
        '
        'lblMidPoint
        '
        Me.lblMidPoint.AutoSize = True
        Me.lblMidPoint.Location = New System.Drawing.Point(679, 133)
        Me.lblMidPoint.Name = "lblMidPoint"
        Me.lblMidPoint.Size = New System.Drawing.Size(69, 17)
        Me.lblMidPoint.TabIndex = 99
        Me.lblMidPoint.Text = "Mid point:"
        '
        'txtLargestInvoice
        '
        Me.txtLargestInvoice.Location = New System.Drawing.Point(829, 63)
        Me.txtLargestInvoice.Name = "txtLargestInvoice"
        Me.txtLargestInvoice.ReadOnly = True
        Me.txtLargestInvoice.Size = New System.Drawing.Size(124, 22)
        Me.txtLargestInvoice.TabIndex = 100
        Me.txtLargestInvoice.TabStop = False
        '
        'txtSmallestInvoice
        '
        Me.txtSmallestInvoice.Location = New System.Drawing.Point(829, 98)
        Me.txtSmallestInvoice.Name = "txtSmallestInvoice"
        Me.txtSmallestInvoice.ReadOnly = True
        Me.txtSmallestInvoice.Size = New System.Drawing.Size(124, 22)
        Me.txtSmallestInvoice.TabIndex = 101
        Me.txtSmallestInvoice.TabStop = False
        '
        'txtMidPoint
        '
        Me.txtMidPoint.Location = New System.Drawing.Point(829, 131)
        Me.txtMidPoint.Name = "txtMidPoint"
        Me.txtMidPoint.ReadOnly = True
        Me.txtMidPoint.Size = New System.Drawing.Size(124, 22)
        Me.txtMidPoint.TabIndex = 102
        Me.txtMidPoint.TabStop = False
        '
        'frmInvoiceTotal
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(972, 269)
        Me.Controls.Add(Me.txtMidPoint)
        Me.Controls.Add(Me.txtSmallestInvoice)
        Me.Controls.Add(Me.txtLargestInvoice)
        Me.Controls.Add(Me.lblMidPoint)
        Me.Controls.Add(Me.lblSmallestInvoice)
        Me.Controls.Add(Me.lblLargestInvoice)
        Me.Controls.Add(Me.txtInvoiceAverage)
        Me.Controls.Add(Me.txtTotalOfInvoices)
        Me.Controls.Add(Me.txtNumberOfInvoices)
        Me.Controls.Add(Me.lblinvoiceAverage)
        Me.Controls.Add(Me.lblTotalOfInvoices)
        Me.Controls.Add(Me.lblNumberOfInvoices)
        Me.Controls.Add(Me.txtEnterSubtotal)
        Me.Controls.Add(Me.btnClearTotals)
        Me.Controls.Add(Me.lblEnterSubtotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiscountAmount)
        Me.Controls.Add(Me.txtDiscountPercent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmInvoiceTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Total"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterSubtotal As Label
    Friend WithEvents btnClearTotals As Button
    Friend WithEvents txtEnterSubtotal As TextBox
    Friend WithEvents lblNumberOfInvoices As Label
    Friend WithEvents lblTotalOfInvoices As Label
    Friend WithEvents lblinvoiceAverage As Label
    Friend WithEvents txtNumberOfInvoices As TextBox
    Friend WithEvents txtTotalOfInvoices As TextBox
    Friend WithEvents txtInvoiceAverage As TextBox
    Friend WithEvents lblLargestInvoice As Label
    Friend WithEvents lblSmallestInvoice As Label
    Friend WithEvents lblMidPoint As Label
    Friend WithEvents txtLargestInvoice As TextBox
    Friend WithEvents txtSmallestInvoice As TextBox
    Friend WithEvents txtMidPoint As TextBox
End Class
