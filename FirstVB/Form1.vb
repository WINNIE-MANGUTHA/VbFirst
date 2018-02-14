Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ComboBox1.Items.Add("MIS 302A")
        Me.ComboBox1.Items.Add("MIS 211B")
        Me.ComboBox1.Items.Add("MIS 322A")
        Me.Courses.Items.Add("MIS 302A")
        Me.Courses.Items.Add("MIS 211A")
        Me.Courses.Items.Add("MIS 322A")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTextSelect.Click
        ListBox1.Items.Add(TextBox1.Text)
        ListBox1.Items.Add(ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Add(ComboBox1.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Add(Courses.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = InputBox("enter selected course", "selected course")
    End Sub
End Class
