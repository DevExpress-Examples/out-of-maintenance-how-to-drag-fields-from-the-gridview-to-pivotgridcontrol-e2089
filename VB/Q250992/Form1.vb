Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraGrid.Columns

Namespace Q250992
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

		End Sub

		Private Sub OnGridViewDragObjectDrop(ByVal sender As Object, ByVal e As DragObjectDropEventArgs) Handles gridView1.DragObjectDrop
			Dim location As Point = MousePosition
			If Not(TypeOf e.DragObject Is GridColumn) Then
				Return
			End If
			Dim hitInfo As PivotGridHitInfo = pivot.CalcHitInfo(pivot.PointToClient(location))
			If Nothing Is hitInfo.HeadersAreaInfo Then
				Return
			End If
			pivot.Fields.Add((CType(e.DragObject, GridColumn)).FieldName, hitInfo.HeadersAreaInfo.Area)
		End Sub

		Private Sub OnGridViewDragObjectOver(ByVal sender As Object, ByVal e As DragObjectOverEventArgs) Handles gridView1.DragObjectOver
			Dim location As Point = MousePosition
			If Not(TypeOf e.DragObject Is GridColumn) Then
				Return
			End If
			e.DropInfo.Valid = GetChildAtPoint(PointToClient(location)) IsNot pivot
		End Sub
	End Class
End Namespace