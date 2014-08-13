Imports System.IO
Imports System.Windows.Forms.ListView

Public Class Prac04

    Private listViewItems As ListViewItemCollection

    Private Sub btnAddContact_Click(sender As Object, e As EventArgs) Handles btnAddContact.Click

        Dim lstViewText(3) As String

        lstViewText(0) = txtName.Text
        txtName.Text = ""
        lstViewText(1) = txtPhoneNumber.Text
        txtPhoneNumber.Text = ""
        lstViewText(2) = txtCategory.Text
        txtCategory.Text = ""

        lstView.Items.Add(New ListViewItem(lstViewText))
        listViewItems.Add(New ListViewItem(lstViewText))
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim writer As StreamWriter

        saveFileDialog.ShowDialog()


        writer = New StreamWriter(saveFileDialog.FileName, False)

        Dim item As ListViewItem

        For Each item In lstView.Items
            writer.WriteLine(item.SubItems(0).Text + "," + item.SubItems(1).Text + "," + item.SubItems(2).Text)
        Next item
        

    End Sub

    Private Sub LoadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem1.Click

        openFileDialog.ShowDialog()

        Dim reader As New StreamReader(openFileDialog.FileName, False)

        Try
            Dim lstViewText(3) As String

            Dim line As String
            Dim pos As Integer

            Do
                line = reader.ReadLine()
                If line Is Nothing Then Exit Do

                pos = 0
                For Each item In line.Split(",")
                    lstViewText(pos) = item
                    pos += 1
                Next

                lstView.Items.Add(New ListViewItem(lstViewText))
            Loop

            For Each item In lstView.Items
                listViewItems.Add(item)
            Next item
        Catch ex As IOException
            MsgBox(ex.ToString)
        Finally
            reader.Close()
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim searchText As String
        Dim item As ListViewItem

        searchText = txtSearch.Text

        Try
            MsgBox(Len(searchText))

            If Len(searchText) > 0 Then
                For Each item In listViewItems
                    If Not (searchText = item.SubItems(0).Text) Then
                        lstView.Items.Remove(item)
                    End If
                Next item
            Else
                For Each item In listViewItems
                    MsgBox(lstView.Items.IndexOf(item))
                    If (lstView.Items.IndexOf(item) > 0) Then
                        lstView.Items.Add(item)
                    End If
                Next item
            End If
        Catch nullRefEx As NullReferenceException
            MsgBox(nullRefEx.ToString)
        End Try


    End Sub
End Class
