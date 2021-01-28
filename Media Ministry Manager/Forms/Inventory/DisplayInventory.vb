﻿Option Strict On

Public Class Frm_DisplayInventory
    Private ReadOnly ProductsTable As New CustomData.InventoryDataTable
    Private Products As ObjectModel.Collection(Of Types.Product)

    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()
        bsProducts.DataSource = ProductsTable
    End Sub

    Private Sub Btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        If AddProductDialog.ShowDialog() = DialogResult.OK Then
            Refresh()
        End If
    End Sub

    Private Shadows Sub Refresh()
        ProductsTable.Clear()
        LoadData()
        FillTable()
    End Sub

    Private Sub Frm_ViewInventory_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim frm As New frm_Main()
        frm.Show()
    End Sub

    Private Sub Dgv_Inventory_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Inventory.CellEndEdit
        Dim column As String = dgv_Inventory.Columns(e.ColumnIndex).DataPropertyName
        Dim value As String = CStr(dgv_Inventory.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

        Dim itemID As Integer = CInt(ProductsTable.Rows(e.RowIndex)("ItemID"))

        Using db As New Database
            db.UpdateInventory(itemID, column, value)
        End Using
    End Sub

    Private Sub Dgv_Inventory_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgv_Inventory.UserDeletingRow
        Dim itemID As Integer = CInt(CType(e.Row.DataBoundItem, DataRowView)("ItemID"))
        Dim available As Boolean = CBool(CType(e.Row.DataBoundItem, DataRowView)("Availablity"))

        Using db As New Database
            db.ChangeAvailability(itemID, Not available)
        End Using

        e.Cancel = True
        Refresh()
    End Sub

    Private Sub LoadData()
        Using db As New Database
            Products = db.GetProducts
        End Using
    End Sub

    Private Sub FillTable()
        Dim row As DataRow
        For Each product As Types.Product In Products
            row = ProductsTable.NewRow
            row("ItemID") = product.Id
            row("ItemName") = product.Name
            row("Stock") = product.Stock
            row("Price") = product.Price
            row("Available") = product.Available
            ProductsTable.Rows.Add(row)
        Next
    End Sub

    Private Sub Chk_ShowUnavailable_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ShowUnavailable.CheckedChanged
        If chk_ShowUnavailable.Checked Then
            bsProducts.Filter = ""
        Else
            bsProducts.Filter = "Available = True"
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Refresh()
    End Sub

    Private Sub Dgv_Inventory_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv_Inventory.MouseDown
        For Each row As DataGridViewRow In dgv_Inventory.Rows
            row.Selected = False
        Next

        If e.Button = MouseButtons.Right Then
            Dim info As DataGridView.HitTestInfo = dgv_Inventory.HitTest(e.X, e.Y)
            If info.RowIndex > -1 Then
                dgv_Inventory.Rows(info.RowIndex).Selected = True
                AvailabilityToolStripMenuItem.Enabled = True
            Else
                AvailabilityToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub AvailabilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailabilityToolStripMenuItem.Click
        For Each row As DataGridViewRow In dgv_Inventory.SelectedRows
            Dim itemID As Integer = CInt(CType(row.DataBoundItem, DataRowView)("ItemID"))
            Dim available As Boolean = CBool(CType(row.DataBoundItem, DataRowView)("Availablity"))

            Using db As New Database
                db.ChangeAvailability(itemID, Not available)
            End Using

            Refresh()
        Next
    End Sub
End Class