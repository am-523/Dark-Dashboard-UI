Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Guna2MouseStateHandler1.Add(pn_earn)
        pn_data.BorderColor = Color.Gray
        pn_overview.BorderColor = Color.Gray
        pn_city.BorderColor = Color.Gray
        pn_today.BorderColor = Color.Gray
        pn_earn.BorderColor = Color.Gray
        PN_1.BorderColor = Color.Gray

        CartesianChart2.Series = New SeriesCollection From {
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 10),
                        New ObservablePoint(4, 7),
                        New ObservablePoint(5, 3),
                        New ObservablePoint(7, 6),
                        New ObservablePoint(10, 8)
                    },
                    .PointGeometrySize = 10
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 2),
                        New ObservablePoint(2, 5),
                        New ObservablePoint(3, 6),
                        New ObservablePoint(6, 8),
                        New ObservablePoint(10, 5)
                    },
                    .PointGeometrySize = 15
                },
                New LineSeries With {
                    .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 4),
                        New ObservablePoint(5, 5),
                        New ObservablePoint(7, 7),
                        New ObservablePoint(9, 10),
                        New ObservablePoint(10, 9)
                    },
                    .PointGeometrySize = 15
                }
            }


        CartesianChart1.Series = New SeriesCollection From {
              New LineSeries With {
                  .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 4),
                        New ObservablePoint(5, 5),
                        New ObservablePoint(7, 7),
                        New ObservablePoint(9, 10),
                        New ObservablePoint(10, 9)
                    },
                    .PointGeometrySize = 15
                  }
                  }






    End Sub

    Private Sub Guna2MouseStateHandler1_HoverState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.HoverState
        pn_earn.BorderColor = Color.FromArgb(45, 156, 252)

    End Sub
    Private Sub Guna2MouseStateHandler1_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.IdleState
        pn_earn.BorderColor = Color.Gray

    End Sub
    Private Sub Guna2MouseStateHandler1_PressedState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.PressedState
        pn_earn.BorderColor = Color.Gray

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Application.ExitThread()
    End Sub
End Class
