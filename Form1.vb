﻿Imports System.IO
Public Class Form1


    Dim classes() As String = {"Alchemist", "Armorer", "Blacksmith", "Carpenter", "Culinarian", "Goldsmith", "Leatherworker", " Weaver"} ' Delcaring Classes 
    Dim level() As String = {"1-10", "11-20", "21-30", "31-40"} 'Declaring Jobs

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Declarations 


        For Each job As String In classes
            lstJobs.Items.Add(job) ' Add Classes String to List back for each job
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstJobs.SelectedIndex = -1
        lstLevel.Items.Clear()
        lstRecipe.Items.Clear()
        lblCrafting.Text = ""

    End Sub

    Private Sub lstJobs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstJobs.SelectedIndexChanged
        Dim selectedClassIndex As Integer = lstJobs.SelectedIndex
        lstLevel.SelectedIndex = -1


        If lstLevel.Items.Count < 4 Then
            If selectedClassIndex > -1 Then ' If there is a selected item in the list box 
                For Each leve As String In level ' Load levels into box 
                    lstLevel.Items.Add(leve)

                Next

            End If
        End If

    End Sub

    Private Sub lstRecipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecipe.SelectedIndexChanged

    End Sub
End Class
