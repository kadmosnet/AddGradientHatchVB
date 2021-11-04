Imports DXFReaderNET
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dxfReaderNETControl1.NewDrawing()
        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim k As Integer
        Dim j As Integer
        Dim n As Integer = 0
        dxfReaderNETControl1.NewDrawing()
        dxfReaderNETControl1.SetLimits(New Vector2(-1, -1), New Vector2(31, 31))
        k = 0
        Do While (k <= 2)
            j = 0
            Do While (j <= 2)
                Dim polyVertexes As List(Of DXFReaderNET.Entities.LwPolylineVertex) = New List(Of DXFReaderNET.Entities.LwPolylineVertex)
                polyVertexes.Add(New DXFReaderNET.Entities.LwPolylineVertex(j * 10, k * 10))
                polyVertexes.Add(New DXFReaderNET.Entities.LwPolylineVertex(j * 10 + 9, k * 10))
                polyVertexes.Add(New DXFReaderNET.Entities.LwPolylineVertex(j * 10 + 9, k * 10 + 9))
                polyVertexes.Add(New DXFReaderNET.Entities.LwPolylineVertex(j * 10, k * 10 + 9))
                Dim Boundary As List(Of DXFReaderNET.Entities.EntityObject) = New List(Of DXFReaderNET.Entities.EntityObject)
                Boundary.Add(dxfReaderNETControl1.AddLightWeightPolyline(polyVertexes, True))
                Dim hgType As DXFReaderNET.Entities.HatchGradientPatternType = CType(n, DXFReaderNET.Entities.HatchGradientPatternType)
                n = (n + 1)
                Dim Position As Vector3 = (polyVertexes(3).Position.ToVector3 + New Vector3(0, 0.2, 0))
                dxfReaderNETControl1.AddText(hgType.ToString, Position, Position, 0.7)
                dxfReaderNETControl1.AddGradientHatch(hgType, Boundary)
                j = (j + 1)
            Loop

            k = (k + 1)
        Loop

        dxfReaderNETControl1.ZoomLimits()
        dxfReaderNETControl1.Refresh()
    End Sub
End Class
