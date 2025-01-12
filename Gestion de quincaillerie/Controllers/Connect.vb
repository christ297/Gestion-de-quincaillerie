Public Class Connect

    Private mainForm As Form
    Private secondForm As Form


    Public Sub New(form As Form, form1 As Form)
        Me.mainForm = form
        Me.secondForm = form1
    End Sub

    Public Sub open1()
        mainForm.TopLevel = False
        mainForm.FormBorderStyle = FormBorderStyle.None
        mainForm.Dock = DockStyle.Fill

        secondForm.TopLevel = False
        secondForm.FormBorderStyle = FormBorderStyle.None
        secondForm.Dock = DockStyle.Fill


        mainForm.Controls.Clear()
        mainForm.Controls.Add(secondForm)
        secondForm.Refresh()



        secondForm.Show()
    End Sub

End Class