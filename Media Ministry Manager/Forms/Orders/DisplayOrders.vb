﻿Option Strict On

#Region "Imports"
Imports Media_Ministry.Utils
#End Region

Public Class frm_DisplayOrders
#Region "Globals"
    Private mainForm As frm_Main
#End Region

#Region "Form Subs"
    Public Sub New(ByRef mainForm As frm_Main)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.mainForm = mainForm
    End Sub

    Private Sub frm_DisplayOrders_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'Media_MinistryDataSet.ORDER_SUMMARY' table. You can move, or remove it, as needed.
        Me.ORDER_SUMMARYTableAdapter.Fill(Me.Media_MinistryDataSet.ORDER_SUMMARY)
        For index As Integer = 0 To (dgv_Orders.Rows.Count - 1)
            dgv_Orders.Rows(index).Cells(0).Value = False
        Next
    End Sub

    Private Sub frm_DisplayOrders_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        mainForm.Show()
    End Sub
#End Region

#Region "Buttons"
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Fulfil_Click(sender As Object, e As EventArgs) Handles btn_Fulfil.Click
        Dim phoneNumber As String
        Dim itemIndex, orderNumber, quantity, index As Integer

        Using db As New Database(My.Settings.Username, My.Settings.Password)
            If dgv_Orders.SelectedCells().Count > 0 Then

                'got this idea from these sources
                'how to remove items from the data grid view
                'https://www.youtube.com/watch?v=Yfa1hnpKIzk
                'how to obtain the value from the desired cell from the data grid view
                'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net
                Do
                    If dgv_Orders.Rows(index).Cells(0).Value.Equals("true") Then
                        orderNumber = CInt(dgv_Orders.Rows(index).Cells(1).Value.ToString)
                        phoneNumber = dgv_Orders.Rows(index).Cells(2).Value.ToString
                        itemIndex = db.GetIndexNumber(orderNumber) 'update this to get the item_index number
                        quantity = CInt(dgv_Orders.Rows(index).Cells(4).Value.ToString)
                        Try
                            db.FulfilOrder(orderNumber, phoneNumber, itemIndex, quantity)
                            dgv_Orders.Rows.RemoveAt(index)
                        Catch

                        End Try
                    End If
                    index += 1
                Loop Until (index >= dgv_Orders.Rows.Count)
            End If
        End Using
    End Sub

    Private Sub btn_UpdateOrder_Click(sender As Object, e As EventArgs) Handles btn_UpdateOrder.Click
        Dim orderNumber, quantity, index As Integer
        index = 0

        Using db As New Database(My.Settings.Username, My.Settings.Password)
            If dgv_Orders.SelectedCells().Count > 0 Then

                'got this idea from these sources
                'how to remove items from the data grid view
                'https://www.youtube.com/watch?v=Yfa1hnpKIzk
                'how to obtain the value from the desired cell from the data grid view
                'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net
                Do
                    If dgv_Orders.Rows(index).Cells(0).Value.Equals(True) Then
                        orderNumber = CInt(dgv_Orders.Rows(index).Cells(1).Value.ToString)
                        quantity = CInt(dgv_Orders.Rows(index).Cells(4).Value.ToString)
                        Try
                            db.UpdateOrder(orderNumber, quantity)
                        Catch

                        End Try
                    End If
                    index += 1
                Loop Until (index >= dgv_Orders.Rows.Count)
            End If
        End Using
    End Sub

    Private Sub btn_CancelOrder_Click(sender As Object, e As EventArgs) Handles btn_CancelOrder.Click
        Dim orderNumber, index As Integer
        index = 0

        Using db As New Database(My.Settings.Username, My.Settings.Password)
            If dgv_Orders.SelectedCells().Count > 0 Then

                'got this idea from these sources
                'how to remove items from the data grid view
                'https://www.youtube.com/watch?v=Yfa1hnpKIzk
                'how to obtain the value from the desired cell from the data grid view
                'https://stackoverflow.com/questions/19721984/how-to-get-cell-value-from-datagridview-in-vb-net
                Do
                    If dgv_Orders.Rows(index).Cells(0).Value.Equals(True) Then
                        orderNumber = CInt(dgv_Orders.Rows(index).Cells(1).Value.ToString)
                        Try
                            db.CancelOrder(orderNumber)
                            dgv_Orders.Rows.RemoveAt(index)
                        Catch

                        End Try
                    End If
                    index += 1
                Loop Until (index >= dgv_Orders.Rows.Count)
            End If
        End Using
    End Sub
#End Region
End Class