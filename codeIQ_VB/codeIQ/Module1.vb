Imports System.Xml.Linq

Module Module1

    Sub Main()
        Dim line As String
        While True
            line = Console.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            Console.WriteLine(Prosecc(line).ToUpper())
        End While

    End Sub

    Public Function Prosecc(line As String) As String
        Dim res As New List(Of String)
        Dim 二進数 As String = Int64.Parse(Convert.ToString(Int32.Parse(line), 2)).ToString("000000000000")

        Dim IsFirst As Boolean = True
        Dim first頂点 As Integer = 0
        Dim 頂点 As Integer = 0
        Dim 直線判定Cnt As Integer = 1
        Dim first直線判定Cnt As Integer = 0
        For i As Integer = 11 To 0 Step -1
            Dim str As String = 二進数.Substring(i, 1)
            If str = "1" Then
                If 直線判定Cnt <> 6 Then
                    頂点 += 1
                End If

                If IsFirst = False Then
                    res.Add(頂点.ToString() + 1)
                    頂点 = 1
                    直線判定Cnt = 1
                Else
                    first頂点 = 頂点
                    頂点 = 1
                    first直線判定Cnt = 直線判定Cnt
                    直線判定Cnt = 1
                    IsFirst = False
                End If
            Else
                直線判定Cnt += 1
                If i Mod 2 = 1 Then
                    頂点 += 1
                End If

            End If

        Next

        If first直線判定Cnt + 直線判定Cnt = 6 Then
            res.Add((頂点 + first頂点).ToString())
        Else
            res.Add((頂点 + first頂点 + 1).ToString())
        End If

        Return String.Join(",", res.OrderBy(Function(n) n))
    End Function

End Module
