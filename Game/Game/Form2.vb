Public Class Form2
    Public Shared P1HPModifer, P2HPModifier, P1DamModifier, P2DamModifier, P1APModifier, P2APModifier As Integer
    Public Shared P1User, P2User As String

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Health(3, 1)
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Health(4, 1)
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Health(5, 1)
        End If
    End Sub

    Private Sub RadioButton36_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton36.CheckedChanged
        If RadioButton36.Checked Then
            Health(0, 2)
        End If
    End Sub

    Private Sub RadioButton35_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton35.CheckedChanged
        If RadioButton35.Checked Then
            Health(1, 2)
        End If
    End Sub

    Private Sub RadioButton34_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton34.CheckedChanged
        If RadioButton34.Checked Then
            Health(2, 2)
        End If
    End Sub

    Private Sub RadioButton33_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton33.CheckedChanged
        If RadioButton33.Checked Then
            Health(3, 2)
        End If
    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        If RadioButton32.Checked Then
            Health(4, 2)
        End If
    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        If RadioButton31.Checked Then
            Health(5, 2)
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P1Points = 10
        P2Points = 10
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "" Then
            P1User = "Player One"
        Else
            P1User = TextBox1.Text
        End If

        If TextBox2.Text = "" Then
            P2User = "Player Two"
        Else
            P2User = TextBox2.Text
        End If

        If CheckBox1.Checked And CheckBox2.Checked Then
            Form1.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Health(2, 1)
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked Then
            Damage(0, 1)
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked Then
            Damage(1, 1)
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked Then
            Damage(2, 1)
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked Then
            Damage(3, 1)
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            Damage(4, 1)
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Damage(5, 1)
        End If
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        If RadioButton30.Checked Then
            Damage(0, 2)
        End If
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        If RadioButton29.Checked Then
            Damage(1, 2)
        End If
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        If RadioButton28.Checked Then
            Damage(2, 2)
        End If
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        If RadioButton27.Checked Then
            Damage(3, 2)
        End If
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked Then
            Damage(4, 2)
        End If
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        If RadioButton25.Checked Then
            Damage(5, 2)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        MsgBox("P1 Points: " & P1Points & vbCrLf & "P2 Points: " & P2Points)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Health(0, 1)
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked Then
            Magic(0, 1)
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked Then
            Magic(1, 1)
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked Then
            Magic(2, 1)
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked Then
            Magic(3, 1)
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked Then
            Magic(4, 1)
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked Then
            Magic(5, 1)
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked Then
            Magic(0, 2)
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked Then
            Magic(1, 2)
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked Then
            Magic(2, 2)
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked Then
            Magic(3, 2)
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked Then
            Magic(4, 2)
        End If
    End Sub
    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked Then
            Magic(5, 2)
        End If
    End Sub

    Private Sub RadioButton2_Checked(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Health(1, 1)
        End If
    End Sub

    Dim P1Points, P2Points As Integer
    Sub Health(Modifier As Integer, Player As Integer)

        If Player = 1 Then
            If P1Points >= Modifier Then
                P1HPModifer = Modifier
                P1Points = 10 - P1HPModifer - P1DamModifier - P1APModifier
                Label3.Text = "Points: " & P1Points & "/10"
            End If
        End If

        If Player = 2 Then
            If P2Points >= Modifier Then
                P2HPModifier = Modifier
                P2Points = 10 - P2HPModifier - P2DamModifier - P2APModifier
                Label4.Text = "Points: " & P2Points & "/10"
            End If

        End If

    End Sub
    Sub Damage(Modifier As Integer, Player As Integer)

        If Player = 1 Then
            If P1Points >= Modifier Then
                P1DamModifier = Modifier
                P1Points = 10 - P1HPModifer - P1DamModifier - P1APModifier
                Label3.Text = "Points: " & P1Points & "/10"
            End If
        End If

        If Player = 2 Then
            If P2Points >= Modifier Then
                P2DamModifier = Modifier
                P2Points = 10 - P2HPModifier - P2DamModifier - P2APModifier
                Label4.Text = "Points: " & P2Points & "/10"
            End If
        End If

    End Sub
    Sub Magic(Modifier As Integer, Player As Integer)

        If Player = 1 Then
            If P1Points >= Modifier Then
                P1APModifier = Modifier
                P1Points = 10 - P1HPModifer - P1DamModifier - P1APModifier
                Label3.Text = "Points: " & P1Points & "/10"
            End If
        End If

        If Player = 2 Then
            If P2Points >= Modifier Then
                P2APModifier = Modifier
                P2Points = 10 - P2HPModifier - P2DamModifier - P2APModifier
                Label4.Text = "Points: " & P2Points & "/10"
            End If
        End If

    End Sub
End Class