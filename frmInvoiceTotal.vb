Public Class frmInvoiceTotal

    Dim numberOfInvoices As Integer
    Dim totalOfInvoices As Decimal
    Dim invoiceAverage As Decimal
    Dim largestInvoice As Decimal
    Dim smallestInvoice As Decimal
    Dim midPoint As Decimal

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Dim subtotal As Decimal = CDec(txtEnterSubtotal.Text)
        Dim discountPercent As Decimal = 0.25D
        Dim discountAmount As Decimal =
            Math.Round(subtotal * discountPercent, 2)
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        txtSubtotal.Text = FormatCurrency(subtotal)
        txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
        txtDiscountAmount.Text = FormatCurrency(discountAmount)
        txtTotal.Text = FormatCurrency(invoiceTotal)

        numberOfInvoices += 1
        totalOfInvoices += invoiceTotal
        invoiceAverage = totalOfInvoices / numberOfInvoices

        txtNumberOfInvoices.Text = numberOfInvoices.ToString
        txtTotalOfInvoices.Text = FormatCurrency(totalOfInvoices)
        txtInvoiceAverage.Text = FormatCurrency(invoiceAverage)

        txtEnterSubtotal.Text = ""

        If invoiceTotal >= largestInvoice Then
            largestInvoice = invoiceTotal
        End If
        txtLargestInvoice.Text = FormatCurrency(largestInvoice)

        If smallestInvoice = Nothing Then
            smallestInvoice = invoiceTotal
        End If

        If invoiceTotal <= smallestInvoice Then
            smallestInvoice = invoiceTotal
        End If
        txtSmallestInvoice.Text = FormatCurrency(smallestInvoice)

        midPoint = (largestInvoice + smallestInvoice) / 2
        txtMidPoint.Text = FormatCurrency(midPoint)

        txtEnterSubtotal.Select()

    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtEnterSubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtEnterSubtotal.TextChanged

    End Sub

    Private Sub btnClearTotals_Click(sender As Object, e As EventArgs) Handles btnClearTotals.Click

        numberOfInvoices = 0
        totalOfInvoices = 0
        invoiceAverage = 0

        largestInvoice = 0
        smallestInvoice = 0
        midPoint = 0

        txtNumberOfInvoices.Text = "0"
        txtTotalOfInvoices.Text = "$0.00"
        txtInvoiceAverage.Text = "$0.00"

        txtLargestInvoice.Text = Nothing
        txtSmallestInvoice.Text = Nothing
        txtMidPoint.Text = Nothing

        txtEnterSubtotal.Select()

    End Sub

    Private Sub txtNumberOfInvoices_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfInvoices.TextChanged

    End Sub
End Class