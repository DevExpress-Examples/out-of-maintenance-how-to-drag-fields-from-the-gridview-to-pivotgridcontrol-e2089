﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591


Imports Microsoft.VisualBasic
Imports System
Namespace Q250992


	''' <summary>
	'''Represents a strongly typed in-memory cache of data.
	'''</summary>
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.Serializable(), Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"), Global.System.Xml.Serialization.XmlRootAttribute("nwindDataSet"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")> _
	Partial Public Class nwindDataSet
		Inherits System.Data.DataSet

		Private tableSalesPerson As SalesPersonDataTable

		Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Sub New()
			Me.BeginInit()
			Me.InitClass()
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
			MyBase.New(info, context, False)
			If (Me.IsBinarySerialized(info, context) = True) Then
				Me.InitVars(False)
				Dim schemaChangedHandler1 As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
				AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
				AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
				Return
			End If
			Dim strSchema As String = (CStr(info.GetValue("XmlSchema", GetType(String))))
			If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
				If (ds.Tables("SalesPerson") IsNot Nothing) Then
					MyBase.Tables.Add(New SalesPersonDataTable(ds.Tables("SalesPerson")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
			End If
			Me.GetSerializationData(info, context)
			Dim schemaChangedHandler As New Global.System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
			AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Browsable(False), Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property SalesPerson() As SalesPersonDataTable
			Get
				Return Me.tableSalesPerson
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.BrowsableAttribute(True), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)> _
		Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(ByVal value As System.Data.SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
		Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub InitializeDerivedDataSet()
			Me.BeginInit()
			Me.InitClass()
			Me.EndInit()
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Overrides Function Clone() As Global.System.Data.DataSet
			Dim cln As nwindDataSet = (CType(MyBase.Clone(), nwindDataSet))
			cln.InitVars()
			cln.SchemaSerializationMode = Me.SchemaSerializationMode
			Return cln
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
			If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
				Me.Reset()
				Dim ds As New Global.System.Data.DataSet()
				ds.ReadXml(reader)
				If (ds.Tables("SalesPerson") IsNot Nothing) Then
					MyBase.Tables.Add(New SalesPersonDataTable(ds.Tables("SalesPerson")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
			Dim stream As New Global.System.IO.MemoryStream()
			Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
			stream.Position = 0
			Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Sub InitVars(ByVal initTable As Boolean)
			Me.tableSalesPerson = (CType(MyBase.Tables("SalesPerson"), SalesPersonDataTable))
			If (initTable = True) Then
				If (Me.tableSalesPerson IsNot Nothing) Then
					Me.tableSalesPerson.InitVars()
				End If
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitClass()
			Me.DataSetName = "nwindDataSet"
			Me.Prefix = ""
			Me.Namespace = "http://tempuri.org/nwindDataSet.xsd"
			Me.EnforceConstraints = True
			Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
			Me.tableSalesPerson = New SalesPersonDataTable()
			MyBase.Tables.Add(Me.tableSalesPerson)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Function ShouldSerializeSalesPerson() As Boolean
			Return False
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
			If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
			Dim ds As New nwindDataSet()
			Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
			Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
			Dim any As New Global.System.Xml.Schema.XmlSchemaAny()
			any.Namespace = ds.Namespace
			sequence.Items.Add(any)
			type.Particle = sequence
			Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
			If xs.Contains(dsSchema.TargetNamespace) Then
				Dim s1 As New Global.System.IO.MemoryStream()
				Dim s2 As New Global.System.IO.MemoryStream()
				Try
					Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
					dsSchema.Write(s1)
					Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
					Do While schemas.MoveNext()
						schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
						s2.SetLength(0)
						schema.Write(s2)
						If (s1.Length = s2.Length) Then
							s1.Position = 0
							s2.Position = 0
							Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

							Loop
							If (s1.Position = s1.Length) Then
								Return type
							End If
						End If
					Loop
				Finally
					If (s1 IsNot Nothing) Then
						s1.Close()
					End If
					If (s2 IsNot Nothing) Then
						s2.Close()
					End If
				End Try
			End If
			xs.Add(dsSchema)
			Return type
		End Function

		Public Delegate Sub SalesPersonRowChangeEventHandler(ByVal sender As Object, ByVal e As SalesPersonRowChangeEvent)

		''' <summary>
		'''Represents the strongly named DataTable class.
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.Serializable(), Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
		Partial Public Class SalesPersonDataTable
			Inherits System.Data.DataTable
			Implements System.Collections.IEnumerable

			Private columnCategoryName As Global.System.Data.DataColumn

			Private columnExtended_Price As Global.System.Data.DataColumn

			Private columnSales_Person As Global.System.Data.DataColumn

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New()
				Me.TableName = "SalesPerson"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal table As Global.System.Data.DataTable)
				Me.TableName = table.TableName
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property CategoryNameColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnCategoryName
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Extended_PriceColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnExtended_Price
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Sales_PersonColumn() As Global.System.Data.DataColumn
				Get
					Return Me.columnSales_Person
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Default Public ReadOnly Property Item(ByVal index As Integer) As SalesPersonRow
				Get
					Return (CType(Me.Rows(index), SalesPersonRow))
				End Get
			End Property

			Public Event SalesPersonRowChanging As SalesPersonRowChangeEventHandler

			Public Event SalesPersonRowChanged As SalesPersonRowChangeEventHandler

			Public Event SalesPersonRowDeleting As SalesPersonRowChangeEventHandler

			Public Event SalesPersonRowDeleted As SalesPersonRowChangeEventHandler

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub AddSalesPersonRow(ByVal row As SalesPersonRow)
				Me.Rows.Add(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function AddSalesPersonRow(ByVal CategoryName As String, ByVal Extended_Price As Decimal, ByVal Sales_Person As String) As SalesPersonRow
				Dim rowSalesPersonRow As SalesPersonRow = (CType(Me.NewRow(), SalesPersonRow))
				Dim columnValuesArray() As Object = { CategoryName, Extended_Price, Sales_Person}
				rowSalesPersonRow.ItemArray = columnValuesArray
				Me.Rows.Add(rowSalesPersonRow)
				Return rowSalesPersonRow
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overridable Function GetEnumerator() As Global.System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Overrides Function Clone() As Global.System.Data.DataTable
				Dim cln As SalesPersonDataTable = (CType(MyBase.Clone(), SalesPersonDataTable))
				cln.InitVars()
				Return cln
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
				Return New SalesPersonDataTable()
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub InitVars()
				Me.columnCategoryName = MyBase.Columns("CategoryName")
				Me.columnExtended_Price = MyBase.Columns("Extended Price")
				Me.columnSales_Person = MyBase.Columns("Sales Person")
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Private Sub InitClass()
				Me.columnCategoryName = New Global.System.Data.DataColumn("CategoryName", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnCategoryName)
				Me.columnExtended_Price = New Global.System.Data.DataColumn("Extended Price", GetType(Decimal), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnExtended_Price)
				Me.columnSales_Person = New Global.System.Data.DataColumn("Sales Person", GetType(String), Nothing, Global.System.Data.MappingType.Element)
				MyBase.Columns.Add(Me.columnSales_Person)
				Me.columnCategoryName.MaxLength = 15
				Me.columnExtended_Price.ReadOnly = True
				Me.columnSales_Person.ReadOnly = True
				Me.columnSales_Person.MaxLength = 255
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function NewSalesPersonRow() As SalesPersonRow
				Return (CType(Me.NewRow(), SalesPersonRow))
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
				Return New SalesPersonRow(builder)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Function GetRowType() As Global.System.Type
				Return GetType(SalesPersonRow)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Me.SalesPersonRowChangedEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowChanged(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Me.SalesPersonRowChangingEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowChanging(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Me.SalesPersonRowDeletedEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowDeleted(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Me.SalesPersonRowDeletingEvent IsNot Nothing) Then
					RaiseEvent SalesPersonRowDeleting(Me, New SalesPersonRowChangeEvent((CType(e.Row, SalesPersonRow)), e.Action))
				End If
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub RemoveSalesPersonRow(ByVal row As SalesPersonRow)
				Me.Rows.Remove(row)
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
				Dim type As New Global.System.Xml.Schema.XmlSchemaComplexType()
				Dim sequence As New Global.System.Xml.Schema.XmlSchemaSequence()
				Dim ds As New nwindDataSet()
				Dim any1 As New Global.System.Xml.Schema.XmlSchemaAny()
				any1.Namespace = "http://www.w3.org/2001/XMLSchema"
				any1.MinOccurs = New Decimal(0)
				any1.MaxOccurs = Decimal.MaxValue
				any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any1)
				Dim any2 As New Global.System.Xml.Schema.XmlSchemaAny()
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				any2.MinOccurs = New Decimal(1)
				any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
				sequence.Items.Add(any2)
				Dim attribute1 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute1.Name = "namespace"
				attribute1.FixedValue = ds.Namespace
				type.Attributes.Add(attribute1)
				Dim attribute2 As New Global.System.Xml.Schema.XmlSchemaAttribute()
				attribute2.Name = "tableTypeName"
				attribute2.FixedValue = "SalesPersonDataTable"
				type.Attributes.Add(attribute2)
				type.Particle = sequence
				Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable()
				If xs.Contains(dsSchema.TargetNamespace) Then
					Dim s1 As New Global.System.IO.MemoryStream()
					Dim s2 As New Global.System.IO.MemoryStream()
					Try
						Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
						dsSchema.Write(s1)
						Dim schemas As System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator()
						Do While schemas.MoveNext()
							schema = (CType(schemas.Current, Global.System.Xml.Schema.XmlSchema))
							s2.SetLength(0)
							schema.Write(s2)
							If (s1.Length = s2.Length) Then
								s1.Position = 0
								s2.Position = 0
								Do While ((s1.Position <> s1.Length) AndAlso (s1.ReadByte() = s2.ReadByte()))

								Loop
								If (s1.Position = s1.Length) Then
									Return type
								End If
							End If
						Loop
					Finally
						If (s1 IsNot Nothing) Then
							s1.Close()
						End If
						If (s2 IsNot Nothing) Then
							s2.Close()
						End If
					End Try
				End If
				xs.Add(dsSchema)
				Return type
			End Function
		End Class

		''' <summary>
		'''Represents strongly named DataRow class.
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Partial Public Class SalesPersonRow
			Inherits System.Data.DataRow

			Private tableSalesPerson As SalesPersonDataTable

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
				MyBase.New(rb)
				Me.tableSalesPerson = (CType(Me.Table, SalesPersonDataTable))
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property CategoryName() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.CategoryNameColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'CategoryName' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.CategoryNameColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property Extended_Price() As Decimal
				Get
					Try
						Return (CDec(Me(Me.tableSalesPerson.Extended_PriceColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Extended Price' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As Decimal)
					Me(Me.tableSalesPerson.Extended_PriceColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Property Sales_Person() As String
				Get
					Try
						Return (CStr(Me(Me.tableSalesPerson.Sales_PersonColumn)))
					Catch e As Global.System.InvalidCastException
						Throw New Global.System.Data.StrongTypingException("The value for column 'Sales Person' in table 'SalesPerson' is DBNull.", e)
					End Try
				End Get
				Set(ByVal value As String)
					Me(Me.tableSalesPerson.Sales_PersonColumn) = value
				End Set
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsCategoryNameNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.CategoryNameColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetCategoryNameNull()
				Me(Me.tableSalesPerson.CategoryNameColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsExtended_PriceNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.Extended_PriceColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetExtended_PriceNull()
				Me(Me.tableSalesPerson.Extended_PriceColumn) = Global.System.Convert.DBNull
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Function IsSales_PersonNull() As Boolean
				Return Me.IsNull(Me.tableSalesPerson.Sales_PersonColumn)
			End Function

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub SetSales_PersonNull()
				Me(Me.tableSalesPerson.Sales_PersonColumn) = Global.System.Convert.DBNull
			End Sub
		End Class

		''' <summary>
		'''Row event argument class
		'''</summary>
		<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0")> _
		Public Class SalesPersonRowChangeEvent
			Inherits System.EventArgs

			Private eventRow As SalesPersonRow

			Private eventAction As Global.System.Data.DataRowAction

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public Sub New(ByVal row As SalesPersonRow, ByVal action As Global.System.Data.DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Row() As SalesPersonRow
				Get
					Return Me.eventRow
				End Get
			End Property

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
			Public ReadOnly Property Action() As Global.System.Data.DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class
	End Class
End Namespace
Namespace Q250992.nwindDataSetTableAdapters


	''' <summary>
	'''Represents the connection and commands used to retrieve and save data.
	'''</summary>
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "2.0.0.0"), Global.System.ComponentModel.DesignerCategoryAttribute("code"), Global.System.ComponentModel.ToolboxItem(True), Global.System.ComponentModel.DataObjectAttribute(True), Global.System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner" & ", Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")> _
	Partial Public Class SalesPersonTableAdapter
		Inherits System.ComponentModel.Component

		Private _adapter As Global.System.Data.OleDb.OleDbDataAdapter

		Private _connection As Global.System.Data.OleDb.OleDbConnection

		Private _commandCollection() As Global.System.Data.OleDb.OleDbCommand

		Private _clearBeforeFill As Boolean

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Sub New()
			Me.ClearBeforeFill = True
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private ReadOnly Property Adapter() As Global.System.Data.OleDb.OleDbDataAdapter
			Get
				If (Me._adapter Is Nothing) Then
					Me.InitAdapter()
				End If
				Return Me._adapter
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Friend Property Connection() As Global.System.Data.OleDb.OleDbConnection
			Get
				If (Me._connection Is Nothing) Then
					Me.InitConnection()
				End If
				Return Me._connection
			End Get
			Set(ByVal value As System.Data.OleDb.OleDbConnection)
				Me._connection = value
				If (Me.Adapter.InsertCommand IsNot Nothing) Then
					Me.Adapter.InsertCommand.Connection = value
				End If
				If (Me.Adapter.DeleteCommand IsNot Nothing) Then
					Me.Adapter.DeleteCommand.Connection = value
				End If
				If (Me.Adapter.UpdateCommand IsNot Nothing) Then
					Me.Adapter.UpdateCommand.Connection = value
				End If
				Dim i As Integer = 0
				Do While (i < Me.CommandCollection.Length)
					If (Me.CommandCollection(i) IsNot Nothing) Then
						CType(Me.CommandCollection(i), Global.System.Data.OleDb.OleDbCommand).Connection = value
					End If
					i = (i + 1)
				Loop
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Protected ReadOnly Property CommandCollection() As Global.System.Data.OleDb.OleDbCommand()
			Get
				If (Me._commandCollection Is Nothing) Then
					Me.InitCommandCollection()
				End If
				Return Me._commandCollection
			End Get
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Public Property ClearBeforeFill() As Boolean
			Get
				Return Me._clearBeforeFill
			End Get
			Set(ByVal value As Boolean)
				Me._clearBeforeFill = value
			End Set
		End Property

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitAdapter()
			Me._adapter = New Global.System.Data.OleDb.OleDbDataAdapter()
			Dim tableMapping As New Global.System.Data.Common.DataTableMapping()
			tableMapping.SourceTable = "Table"
			tableMapping.DataSetTable = "SalesPerson"
			tableMapping.ColumnMappings.Add("CategoryName", "CategoryName")
			tableMapping.ColumnMappings.Add("Extended Price", "Extended Price")
			tableMapping.ColumnMappings.Add("Sales Person", "Sales Person")
			Me._adapter.TableMappings.Add(tableMapping)
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitConnection()
			Me._connection = New Global.System.Data.OleDb.OleDbConnection()
			Me._connection.ConnectionString = My.Settings.Default.nwindConnectionString
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
		Private Sub InitCommandCollection()
			Me._commandCollection = New Global.System.Data.OleDb.OleDbCommand(0){}
			Me._commandCollection(0) = New Global.System.Data.OleDb.OleDbCommand()
			Me._commandCollection(0).Connection = Me.Connection
			Me._commandCollection(0).CommandText = "SELECT CategoryName, [Extended Price], [Sales Person] FROM SalesPerson"
			Me._commandCollection(0).CommandType = Global.System.Data.CommandType.Text
		End Sub

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Fill, True)> _
		Public Overridable Function Fill(ByVal dataTable As nwindDataSet.SalesPersonDataTable) As Integer
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			If (Me.ClearBeforeFill = True) Then
				dataTable.Clear()
			End If
			Dim returnValue As Integer = Me.Adapter.Fill(dataTable)
			Return returnValue
		End Function

		<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter"), Global.System.ComponentModel.DataObjectMethodAttribute(Global.System.ComponentModel.DataObjectMethodType.Select, True)> _
		Public Overridable Function GetData() As nwindDataSet.SalesPersonDataTable
			Me.Adapter.SelectCommand = Me.CommandCollection(0)
			Dim dataTable As New nwindDataSet.SalesPersonDataTable()
			Me.Adapter.Fill(dataTable)
			Return dataTable
		End Function
	End Class
End Namespace

'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591