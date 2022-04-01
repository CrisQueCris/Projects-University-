Imports System.IO

Public Class Database

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'DG_Material.ColumnCount = 2
        'DG_Material.RowCount = 50
        'DG_Material.ColumnHeadersHeight = 20

        '-------------------- configurate the material table ----------------

        With DG_Material
            .ColumnCount = 2
            .RowCount = 50
            .ColumnHeadersHeight = 20
            .Columns(0).Width = 200
            .Columns(1).Width = 100
            .Columns(0).HeaderText = "Cover Material"
            .Columns(1).HeaderText = "U-Value"
            For i = 0 To 49
                .Rows(i).HeaderCell.Value = (i + 1).ToString
            Next
        End With

        Try
            'load the material data from the material.par file
            'Dim fs As FileStream
            Dim fs = New FileStream("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\material.csv", FileMode.Open)
            Dim sr = New StreamReader(fs)

            Dim linecounter = 0
            Dim dummy As String
            Dim part As String()
            Do Until sr.Peek() = -1
                dummy = sr.ReadLine
                part = dummy.Split(";")
                DG_Material.Rows(linecounter).Cells(0).Value = part(0)
                DG_Material.Rows(linecounter).Cells(1).Value = part(1)
                linecounter = linecounter + 1
            Loop
            sr.Close()
        Catch ex As Exception

            MsgBox("the material-file is not available." & Chr(13) & " Maybe it is used by an other program", MsgBoxStyle.OkOnly, "error")
            'MsgBox(ex.Message, MsgBoxStyle.OkOnly, "error")
        End Try


        '--------------- configurate the screen table ----------------------
        With DG_screen
            .ColumnCount = 2
            .RowCount = 50
            .ColumnHeadersHeight = 20
            .Columns(0).Width = 200
            .Columns(1).Width = 100
            .Columns(0).HeaderText = "Cover Material"
            .Columns(1).HeaderText = "U-Value"
            For i = 0 To 49
                .Rows(i).HeaderCell.Value = (i + 1).ToString
            Next
        End With



        Try
            'load the screen data from the screen.csv file
            'Dim fs As FileStream
            Dim fs1 = New FileStream("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\screen.csv", FileMode.Open)
            Dim sr1 = New StreamReader(fs1)

            Dim linecounter1 = 0
            Dim dummy1 As String
            Dim part1 As String()
            Do Until sr1.Peek() = -1
                dummy1 = sr1.ReadLine
                part1 = dummy1.Split(";")
                DG_screen.Rows(linecounter1).Cells(0).Value = part1(0)
                DG_screen.Rows(linecounter1).Cells(1).Value = part1(1)
                linecounter1 = linecounter1 + 1
            Loop
            sr1.Close()
        Catch ex As Exception

            'MsgBox("the material-file is not available." & Chr(13) & " Maybe it is used by an other program", MsgBoxStyle.OkOnly, "error")
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "error")
        End Try

        'Configure Isolationmaterial
        With DG_Isomaterial
            .ColumnCount = 2
            .RowCount = 50
            .ColumnHeadersHeight = 20
            .Columns(0).Width = 200
            .Columns(1).Width = 100
            .Columns(0).HeaderText = "Isolation Material"
            .Columns(1).HeaderText = "U-Value"
            For i = 0 To 9
                .Rows(i).HeaderCell.Value = (i + 1).ToString
            Next
        End With

        Try
            'load the Iso data from the isolation.csv file
            'Dim fs As FileStream
            Dim fs3 = New FileStream("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\isolation.csv", FileMode.Open)
            Dim sr3 = New StreamReader(fs3)

            Dim linecounter = 0
            Dim dummy As String
            Dim part As String()
            Do Until sr3.Peek() = -1
                dummy = sr3.ReadLine
                part = dummy.Split(";")
                DG_Isomaterial.Rows(linecounter).Cells(0).Value = part(0)
                DG_Isomaterial.Rows(linecounter).Cells(1).Value = part(1)
                linecounter = linecounter + 1
            Loop
            sr3.Close()
        Catch ex As Exception

            MsgBox("the material-file is not available." & Chr(13) & " Maybe it is used by an other program", MsgBoxStyle.OkOnly, "error")
            'MsgBox(ex.Message, MsgBoxStyle.OkOnly, "error")
        End Try


        'Configure Burningmaterial

        With DG_burningmaterial
            .ColumnCount = 2
            .RowCount = 50
            .ColumnHeadersHeight = 20
            .Columns(0).Width = 200
            .Columns(1).Width = 100
            .Columns(0).HeaderText = "Heat Material"
            .Columns(1).HeaderText = "calorific value [MJ/kg]"
            For i = 0 To 9
                .Rows(i).HeaderCell.Value = (i + 1).ToString
            Next
        End With

        Try
            'load the material data from the burningmaterial.csv file
            'Dim fs As FileStream
            Dim fs2 = New FileStream("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\burningmaterial.csv", FileMode.Open)
            Dim sr2 = New StreamReader(fs2)

            Dim linecounter2 = 0
            Dim dummy As String
            Dim part As String()
            Do Until sr2.Peek() = -1
                dummy = sr2.ReadLine
                part = dummy.Split(";")
                DG_burningmaterial.Rows(linecounter2).Cells(0).Value = part(0)
                DG_burningmaterial.Rows(linecounter2).Cells(1).Value = part(1)
                linecounter2 = linecounter2 + 1
            Loop
            sr2.Close()
        Catch ex As Exception

            MsgBox("the burningmaterial-file is not available." & Chr(13) & " Maybe it is used by an other program", MsgBoxStyle.OkOnly, "error")
            'MsgBox(ex.Message, MsgBoxStyle.OkOnly, "error")
        End Try


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        '----------------- write new data to material file -------------------------
        Dim sw As StreamWriter = New StreamWriter("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\material.csv")
        For i = 0 To 20
            sw.Write(DG_Material.Rows(i).Cells(0).Value + ";")
            sw.Write(DG_Material.Rows(i).Cells(1).Value)
            sw.Write(vbCrLf)
        Next i
        sw.Close()
        '------------------ write new data to screen file ---------------------------
        Dim sw1 As StreamWriter = New StreamWriter("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\screen.csv")
        For i = 0 To 20
            sw1.Write(DG_screen.Rows(i).Cells(0).Value + ";")
            sw1.Write(DG_screen.Rows(i).Cells(1).Value)
            sw1.Write(vbCrLf)
        Next i
        sw1.Close()

        '------------------ write new data to burning material file ---------------------------
        Dim sw2 As StreamWriter = New StreamWriter("C:\Users\Christoph\Droapbox\Dropbox\Studium\Master\Semester 3\IKT\greenhouse_calculator\_Energy\burningmaterial.csv")
        For i = 0 To 9
            sw2.Write(DG_burningmaterial.Rows(i).Cells(0).Value + ";")
            sw2.Write(DG_burningmaterial.Rows(i).Cells(1).Value)
            sw2.Write(vbCrLf)
        Next i
        sw2.Close()
    End Sub

    'Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs) Handles TabPage2.Click

    'End Sub

    'Private Sub TabPage1_Click(sender As System.Object, e As System.EventArgs) Handles TabPage1.Click

    'End Sub

    'Private Sub DG_Material_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Material.CellContentClick

    'End Sub

    'Private Sub TabPage3_Click(sender As System.Object, e As System.EventArgs) Handles TabPage3.Click

    'End Sub


End Class