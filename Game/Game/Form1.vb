Imports System.ComponentModel.Design.Serialization
Imports System.Data.Common
Imports System.Data.SqlTypes
Imports System.Media
Imports System.Threading
Imports System.Windows.Forms.Design

Public Class Form1
    Dim P1HP, P2HP, P1AP, P2AP, P1Potion, P2Potion, Attack, P1Resistance, P2Resistance, Damage, P1MaxHP, P1MaxAP, P2MaxHP, P2MaxAP As Integer
    Dim P1Confusion, P2Confusion, Game As Boolean

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If P1Turn = True Then
            If P1AP >= 4 Then
                P1AP = P1AP - 4
                P2HP = P2HP - 15
                P1HP = P1HP + 10
                ListBox1.Items.Add(Form2.P1User & " cast lifesteal, stealing 15 hit points from " & Form2.P2User)
                ListBox1.Items.Add("")
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If

        UpdateLabels()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If P1Turn = False Then
            If P2AP >= 4 Then
                P2AP = P2AP - 4
                P1HP = P1HP - 15
                P2HP = P2HP + 10
                ListBox1.Items.Add(Form2.P2User & " cast lifesteal, stealing 15 hit points from " & Form2.P1User)
                ListBox1.Items.Add("")
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If

        UpdateLabels()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If P1Turn = True Then
            If P1AP >= 5 Then
                P1AP = P1AP - 5
                Damage = r.Next(25, 46)
                P2HP = P2HP - Damage
                ListBox1.Items.Add(Form2.P1User & " cast fireball dealing " & Damage & " damage to " & Form2.P2User)
                ListBox1.Items.Add("")
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If

        UpdateLabels()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If P1Turn = False Then
            If P2AP >= 5 Then
                P2AP = P2AP - 5
                Damage = r.Next(25, 46)
                P1HP = P1HP - Damage
                ListBox1.Items.Add(Form2.P2User & " cast fireball dealing " & Damage & " damage to " & Form2.P1User)
                ListBox1.Items.Add("")
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If

        UpdateLabels()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form2.Close()
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If P1Turn = False Then
            If P2AP >= 3 Then
                P2AP = P2AP - 3
                P2Confusion = True
                ListBox1.Items.Add(Form2.P2User & " cast confusion on " & Form2.P1User)
                ListBox1.Items.Add("")
                Button10.Visible = False
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If
        UpdateLabels()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Game = True Then
            If P2HP <= 0 Then
                Game = False
                GameEnd(Form2.P1User & " wins!")
            ElseIf P1HP <= 0 Then
                Game = False
                GameEnd(Form2.P2User & " wins!")
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If P1Turn = True Then
            If P1AP >= 3 Then
                P1AP = P1AP - 3
                P2Confusion = True
                ListBox1.Items.Add(Form2.P1User & " cast confusion on " & Form2.P2User)
                ListBox1.Items.Add("")
                Button7.Visible = False
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If
        UpdateLabels()
    End Sub

    Dim r As New Random
    Dim P1Turn As Boolean



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If P1Turn = False Then
            If P2AP >= 3 Then
                P2AP = P2AP - 3
                P2Resistance = P2Resistance + 2
                ListBox1.Items.Add(Form2.P2User & " cast resistance on themselves. +2 Resistance")
                ListBox1.Items.Add("")
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If

        UpdateLabels()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Atack()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If P1Turn = True Then
            If P1AP >= 3 Then
                P1AP = P1AP - 3
                P1Resistance = P1Resistance + 2
                ListBox1.Items.Add(Form2.P1User & " cast resistance on themselves. +2 Resistance")
                ListBox1.Items.Add("")
                TurnChange()
            Else
                MsgBox("Not enough action points")
            End If
        End If

        UpdateLabels()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Atack()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Heal()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P1HP = 100 + (Form2.P1HPModifer * 10)
        P1MaxHP = P1HP
        P2HP = 100 + (Form2.P2HPModifier * 10)
        P2MaxHP = P2HP
        P1AP = 10 + Form2.P1APModifier
        P1MaxAP = P1AP
        P2AP = 10 + Form2.P2APModifier
        P2MaxAP = P2AP
        P1Potion = 3
        P2Potion = 3
        P1Confusion = False
        P2Confusion = False
        P1Turn = True
        Game = True
        Label9.Text = "Player One's Turn"
        Label1.Text = Form2.P1User
        Label2.Text = Form2.P2User
        Timer1.Start()
        UpdateLabels()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Heal()
    End Sub

    Sub Atack()

        If P1Turn = True Then
            Attack = r.Next(1, 101)
            If Attack > 0 And Attack <= 8 Then
                Damage = 25 - P2Resistance + (Form2.P1DamModifier * 2)
                P2HP = P2HP - Damage
                Label4.Text = "Health: " & P2HP & "/100"
                ListBox1.Items.Add(Form2.P1User & " got a critical hit! " & Damage & " Damage!")
                ListBox1.Items.Add("")
            ElseIf Attack > 15 And Attack <= 23 Then
                ListBox1.Items.Add(Form2.P2User & " dodged the attack!")
                ListBox1.Items.Add("")
                Label4.Text = "Health:  " & P2HP & "/100"
            ElseIf Attack > 90 And Attack <= 100 And P1Confusion = True Then
                Damage = 10 - P1Resistance + (Form2.P1DamModifier * 2)
                P1HP = P1HP - Damage
                Label3.Text = "Health: " & P1HP & "/100"
                ListBox1.Items.Add(Form2.P1User & " got confused and hit themselves for " & Damage & " Damage!")
                ListBox1.Items.Add("")
            Else
                Damage = 10 - P2Resistance + (Form2.P1DamModifier * 2)
                P2HP = P2HP - Damage
                Label4.Text = "Health: " & P2HP & "/100"
                ListBox1.Items.Add(Form2.P1User & " landed a blow on " & Form2.P2User & " for " & Damage & " Damage")
                ListBox1.Items.Add("")
            End If
            TurnChange()
        Else
            Attack = r.Next(1, 101)
            If Attack > 0 And Attack <= 8 Then
                Damage = 25 - P1Resistance + (Form2.P2DamModifier * 2)
                P1HP = P1HP - Damage
                Label3.Text = "Health: " & P1HP & "/100"
                ListBox1.Items.Add("Player Two got a critical hit! " & Damage & " Damage!")
                ListBox1.Items.Add("")
            ElseIf Attack > 15 And Attack <= 23 Then
                ListBox1.Items.Add(Form2.P1User & " dodged the attack!")
                ListBox1.Items.Add("")
                Label3.Text = "Health: " & P1HP & "/100"
            ElseIf Attack > 90 And Attack <= 100 And P2Confusion = True Then
                Damage = 10 - P2Resistance + (Form2.P2DamModifier * 2)
                P2HP = P2HP - Damage
                Label4.Text = "Health: " & P2HP & "/100"
                ListBox1.Items.Add(Form2.P2User & " got confused and hit themselves for " & Damage & " Damage!")
                ListBox1.Items.Add("")
            Else
                Damage = 10 - P1Resistance + (Form2.P2DamModifier * 2)
                P1HP = P1HP - Damage
                Label3.Text = "Health: " & P1HP & "/100"
                ListBox1.Items.Add(Form2.P2User & " landed a blow on " & Form2.P1User & " for " & Damage & " Damage")
                ListBox1.Items.Add("")
            End If
            TurnChange()
        End If

        UpdateLabels()

    End Sub

    Sub Heal()

        If P1Turn = True Then
            If P1Potion > 0 Then
                P1Potion = P1Potion - 1
                P1HP = P1HP + 35
                If P1HP > P1MaxHP Then
                    P1HP = P1MaxHP
                End If
                TurnChange()
                ListBox1.Items.Add(Form2.P1User & " used a health potion for 35 hit points")
                ListBox1.Items.Add("")
            Else
                MsgBox("Out Of Potions")
            End If
        Else
            If P2Potion > 0 Then
                P2Potion = P2Potion - 1
                P2HP = P2HP + 35
                If P2HP > P2MaxHP Then
                    P2HP = P2MaxHP
                End If
                TurnChange()
                ListBox1.Items.Add(Form2.P2User & " used a health potion for 35 hit points")
                ListBox1.Items.Add("")
            Else
                MsgBox("Out Of Potions")
            End If
        End If

        UpdateLabels()

    End Sub

    Sub TurnChange()

        If P1Turn = True Then
            P1Turn = False
        Else
            P1Turn = True
        End If
        UpdateLabels()
    End Sub

    Sub UpdateLabels()
        'Player One
        Label3.Text = "HP: " & P1HP & "/" & P1MaxHP
        Label5.Text = "AP: " & P1AP & "/" & P1MaxAP
        Label7.Text = "Potions: " & P1Potion
        'Player Two
        Label4.Text = "HP: " & P2HP & "/" & P2MaxHP
        Label6.Text = "AP: " & P2AP & "/" & P2MaxAP
        Label8.Text = "Potions: " & P2Potion


        If P1Turn = True Then
            Label9.Text = Form2.P1User & "'s Turn"
        Else
            Label9.Text = Form2.P2User & "'s Turn"
        End If
    End Sub

    Sub GameEnd(Win As String)
        MsgBox(Win)
        Form2.Close()
        Me.Close()
    End Sub
End Class
