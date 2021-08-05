Public Class Form3
    Dim random As Random
    Dim dice1, dice2, dice3 As Integer
    Dim TurtleMonkWeapon1 As Integer = 3
    Dim TurtleMonkWeapon2 As Integer = 4
    Dim TurtleMonkHealth As Integer = 4




    Private Sub SimplaButton1_Click(sender As Object, e As EventArgs) Handles SimplaButton1.Click
        TimerRoll.Start()
    End Sub

    Private Sub RadioButtonTake1_Click(sender As Object, e As EventArgs) Handles RadioButtonTake1.Click
        TurtleMonkHealth -= 1
        If TurtleMonkHealth <= 0 Then
            TurtleMonkHealth = 0
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have taken 1 damage ! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Critical, "DUNGEON DRUDGE")
    End Sub
    Private Sub RadioButtonTake2_Click(sender As Object, e As EventArgs) Handles RadioButtonTake2.Click
        TurtleMonkHealth -= 2
        If TurtleMonkHealth <= 0 Then
            TurtleMonkHealth = 0
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have taken 2 damage! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Critical, "DUNGEON DRUDGE")
    End Sub
    Private Sub RadioButtonTake3_Click(sender As Object, e As EventArgs) Handles RadioButtonTake3.Click
        TurtleMonkHealth -= 3
        If TurtleMonkHealth <= 0 Then
            TurtleMonkHealth = 0
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have taken 3 damage! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Critical, "DUNGEON DRUDGE")
    End Sub
    Private Sub RadioButtonTake4_Click(sender As Object, e As EventArgs) Handles RadioButtonTake4.Click
        TurtleMonkHealth -= 4
        If TurtleMonkHealth <= 0 Then
            TurtleMonkHealth = 0
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have taken 4 damage! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Critical, "DUNGEON DRUDGE")
    End Sub
    Private Sub RadioButtonGain1_Click(sender As Object, e As EventArgs) Handles RadioButtonGain1.Click
        TurtleMonkHealth += 1
        If TurtleMonkHealth >= 4 Then
            TurtleMonkHealth = 4
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have gained 1 health ! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Information, "DUNGEON DRUDGE")
    End Sub
    Private Sub RadioButtonGain2_Click(sender As Object, e As EventArgs) Handles RadioButtonGain2.Click
        TurtleMonkHealth += 2
        If TurtleMonkHealth >= 4 Then
            TurtleMonkHealth = 4
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have gained 2 health ! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Information, "DUNGEON DRUDGE")
    End Sub
    Private Sub RadioButtonGain3_Click(sender As Object, e As EventArgs) Handles RadioButtonGain3.Click
        TurtleMonkHealth += 3
        If TurtleMonkHealth >= 4 Then
            TurtleMonkHealth = 4
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have gained 3 health ! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Information, "DUNGEON DRUDGE")
    End Sub
    Private Sub RadioButtonGain4_Click(sender As Object, e As EventArgs) Handles RadioButtonGain4.Click
        TurtleMonkHealth += 4
        If TurtleMonkHealth >= 4 Then
            TurtleMonkHealth = 4
        End If
        Labelhealth.Text = TurtleMonkHealth
        SimplaProgressBar1.Value = TurtleMonkHealth
        MsgBox("You have gained 4 health ! Your health is now " & TurtleMonkHealth & "/4", MsgBoxStyle.Information, "DUNGEON DRUDGE")
    End Sub

    Private Sub SimplaButton2_Click(sender As Object, e As EventArgs) Handles SimplaButton2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub SimplaCheckBox1_Click(sender As Object, e As EventArgs) Handles SimplaCheckBox1.Click
        random = New Random
        Dim number As Integer = random.Next(1, 7)
        If (number >= 4) Then
            MsgBox("You have rolled a 4+ ! Your armor save has been activated! ", MsgBoxStyle.Information, "DUNGEON DRUDGE")
        Else
            MsgBox("You have not rolled a 4+ ! Your armor save failed! ", MsgBoxStyle.Critical, "DUNGEON DRUDGE")
        End If
    End Sub

    Private Sub TimerRoll_Tick(sender As Object, e As EventArgs) Handles TimerRoll.Tick
        diceroll()
    End Sub

    Private Sub diceroll()
        random = New Random

        SimplaProgressBar4.Value += 5

        If SimplaProgressBar4.Value = 100 Then
            TimerRoll.Stop()

            SimplaProgressBar4.Value = 0
        Else
            dice1 = random.Next(1, 7)
            dice2 = random.Next(1, 7)
            dice3 = random.Next(1, 7)
            If dice1 = 1 Then
                PictureBox1.Image = My.Resources.Dice1
            ElseIf dice1 = 2 Then
                PictureBox1.Image = My.Resources.Dice2
            ElseIf dice1 = 3 Then
                PictureBox1.Image = My.Resources.Dice3
            ElseIf dice1 = 4 Then
                PictureBox1.Image = My.Resources.Dice4
            ElseIf dice1 = 5 Then
                PictureBox1.Image = My.Resources.Dice5
            ElseIf dice1 = 6 Then
                PictureBox1.Image = My.Resources.Dice6
            End If






            If dice2 = 1 Then
                PictureBox2.Image = My.Resources.Dice1
            ElseIf dice2 = 2 Then
                PictureBox1.Image = My.Resources.Dice2
            ElseIf dice2 = 3 Then
                PictureBox2.Image = My.Resources.Dice3
            ElseIf dice2 = 4 Then
                PictureBox2.Image = My.Resources.Dice4
            ElseIf dice2 = 5 Then
                PictureBox2.Image = My.Resources.Dice5
            ElseIf dice2 = 6 Then
                PictureBox2.Image = My.Resources.Dice6
            End If





            If dice3 = 1 Then
                PictureBox3.Image = My.Resources.Dice1
            ElseIf dice3 = 2 Then
                PictureBox3.Image = My.Resources.Dice2
            ElseIf dice3 = 3 Then
                PictureBox3.Image = My.Resources.Dice3
            ElseIf dice3 = 4 Then
                PictureBox3.Image = My.Resources.Dice4
            ElseIf dice3 = 5 Then
                PictureBox3.Image = My.Resources.Dice5
            ElseIf dice3 = 6 Then
                PictureBox3.Image = My.Resources.Dice6
            End If



        End If





        If dice1 >= TurtleMonkWeapon1 Then
            PicStatusWound.Image = My.Resources.allowed
        ElseIf dice2 >= TurtleMonkWeapon1 Then
            PicStatusWound.Image = My.Resources.allowed
        ElseIf dice3 >= TurtleMonkWeapon1 Then
            PicStatusWound.Image = My.Resources.allowed
        Else
            PicStatusWound.Image = My.Resources.notallow

        End If

        If dice1 >= TurtleMonkWeapon2 Then
            PicStatusMove.Image = My.Resources.allowed
        ElseIf dice2 >= TurtleMonkWeapon2 Then
            PicStatusMove.Image = My.Resources.allowed
        ElseIf dice3 >= TurtleMonkWeapon2 Then
            PicStatusMove.Image = My.Resources.allowed
        Else
            PicStatusMove.Image = My.Resources.notallow

        End If

    End Sub
End Class