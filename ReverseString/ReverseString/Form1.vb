Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim st As String = txtInput.Text
        Dim st2 As String = ""
        Dim i As Integer

        For i = st.Length() - 1 To 0 Step -1

            st2 += st.Chars(i)

        Next

        txtOutput.Text = st2

    End Sub
End Class
