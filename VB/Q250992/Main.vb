Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            recordBindingSource.DataSource = DataHelper.GetData(10)
        End Sub

        Private Sub OnGridViewDragObjectDrop(ByVal sender As Object, ByVal e As DragObjectDropEventArgs) Handles gridView1.DragObjectDrop
            Dim location As Point = MousePosition
            If Not (TypeOf e.DragObject Is GridColumn) Then
                Return
            End If
            Dim hitInfo As PivotGridHitInfo = pivot.CalcHitInfo(pivot.PointToClient(location))
            If Nothing Is hitInfo.HeadersAreaInfo Then
                Return
            End If
            pivot.Fields.Add(CType(e.DragObject, GridColumn).FieldName, hitInfo.HeadersAreaInfo.Area)
        End Sub

        Private Sub OnGridViewDragObjectOver(ByVal sender As Object, ByVal e As DragObjectOverEventArgs) Handles gridView1.DragObjectOver
            Dim location As Point = MousePosition
            If Not (TypeOf e.DragObject Is GridColumn) Then
                Return
            End If
            e.DropInfo.Valid = GetChildAtPoint(PointToClient(location)) IsNot pivot
        End Sub
    End Class
End Namespace