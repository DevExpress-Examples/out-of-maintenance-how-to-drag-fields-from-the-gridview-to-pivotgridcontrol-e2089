Imports Microsoft.VisualBasic
Imports System
Namespace Q250992
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q250992.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colExtendedPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSalesPerson = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.pivot = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.salesPersonTableAdapter = New Q250992.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pivot, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.salesPersonBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(400, 200)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryName, Me.colExtendedPrice, Me.colSalesPerson})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.DragObjectOver += New DevExpress.XtraGrid.Views.Base.DragObjectOverEventHandler(Me.OnGridViewDragObjectOver);
'			Me.gridView1.DragObjectDrop += New DevExpress.XtraGrid.Views.Base.DragObjectDropEventHandler(Me.OnGridViewDragObjectDrop);
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 0
			' 
			' colExtendedPrice
			' 
			Me.colExtendedPrice.FieldName = "Extended Price"
			Me.colExtendedPrice.Name = "colExtendedPrice"
			Me.colExtendedPrice.OptionsColumn.ReadOnly = True
			Me.colExtendedPrice.Visible = True
			Me.colExtendedPrice.VisibleIndex = 1
			' 
			' colSalesPerson
			' 
			Me.colSalesPerson.FieldName = "Sales Person"
			Me.colSalesPerson.Name = "colSalesPerson"
			Me.colSalesPerson.OptionsColumn.ReadOnly = True
			Me.colSalesPerson.Visible = True
			Me.colSalesPerson.VisibleIndex = 2
			' 
			' pivot
			' 
			Me.pivot.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivot.DataSource = Me.salesPersonBindingSource
			Me.pivot.Location = New System.Drawing.Point(0, 206)
			Me.pivot.Name = "pivot"
			Me.pivot.Size = New System.Drawing.Size(400, 200)
			Me.pivot.TabIndex = 1
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(401, 406)
			Me.Controls.Add(Me.pivot)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pivot, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private pivot As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As Q250992.nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colExtendedPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colSalesPerson As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

