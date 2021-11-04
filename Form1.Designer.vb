<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DxfDocument1 As DXFReaderNET.DxfDocument = New DXFReaderNET.DxfDocument()
        Dim AciColor1 As DXFReaderNET.AciColor = New DXFReaderNET.AciColor()
        Dim RasterVariables1 As DXFReaderNET.Objects.RasterVariables = New DXFReaderNET.Objects.RasterVariables()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.button1 = New System.Windows.Forms.Button()
        Me.dxfReaderNETControl1 = New DXFReaderNET.DXFReaderNETControl()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(841, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(194, 43)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Add gradient hatches"
        Me.button1.UseVisualStyleBackColor = True
        '
        'dxfReaderNETControl1
        '
        Me.dxfReaderNETControl1.AutoSize = True
        Me.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None
        DxfDocument1.ActiveLayout = "Model"
        DxfDocument1.Comments = Nothing
        AciColor1.Index = CType(256, Short)
        AciColor1.IsByBlock = False
        AciColor1.IsByLayer = True
        AciColor1.UseTrueColor = False
        DxfDocument1.CurrentColor = AciColor1
        DxfDocument1.CurrentElevation = 0R
        DxfDocument1.CurrentLayer = "0"
        DxfDocument1.CurrentLineTypeName = "ByLayer"
        DxfDocument1.CurrentLineTypeScale = 1.0R
        DxfDocument1.CurrentTextSize = 2.5R
        DxfDocument1.CurrentTextStyle = "STANDARD"
        DxfDocument1.CurrentThickness = 0R
        DxfDocument1.DateCreated = New Date(2020, 1, 29, 10, 6, 0, 657)
        DxfDocument1.DateLastEdited = New Date(2020, 1, 29, 10, 6, 0, 657)
        DxfDocument1.Handle = "0"
        DxfDocument1.IsBinary = False
        DxfDocument1.Modified = False
        DxfDocument1.Name = Nothing
        DxfDocument1.Owner = Nothing
        RasterVariables1.DisplayFrame = True
        RasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High
        RasterVariables1.Handle = "2D"
        RasterVariables1.Owner = Nothing
        RasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless
        DxfDocument1.RasterVariables = RasterVariables1
        DxfDocument1.ThumbnailImage = Nothing
        DxfDocument1.TotalEditTime = New Date(2020, 1, 29, 0, 0, 0, 0)
        DxfDocument1.TotalEditTimeDays = 0
        DxfDocument1.UserTimer = New Date(2020, 1, 29, 0, 0, 0, 0)
        DxfDocument1.UserTimerDays = 0
        Me.dxfReaderNETControl1.DXF = DxfDocument1
        Me.dxfReaderNETControl1.FileName = Nothing
        Me.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta
        Me.dxfReaderNETControl1.Location = New System.Drawing.Point(12, 12)
        Me.dxfReaderNETControl1.Name = "dxfReaderNETControl1"
        Me.dxfReaderNETControl1.ShowGridRuler = False
        Me.dxfReaderNETControl1.Size = New System.Drawing.Size(814, 619)
        Me.dxfReaderNETControl1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 650)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.dxfReaderNETControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DXFReader.NET Component - AddGradientHatch Sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents dxfReaderNETControl1 As DXFReaderNET.DXFReaderNETControl
End Class
