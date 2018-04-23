Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			tbl.Columns.Add("ParentID", GetType(Integer))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i + 1, 3 - i, DateTime.Now.AddDays(i), i Mod 3 })
			Next i
			Return tbl
		End Function

		Private hideCheckBoxHelper As HideCheckBoxHelper
        Public Property Helper() As HideCheckBoxHelper
            Get
                If hideCheckBoxHelper Is Nothing Then
                    hideCheckBoxHelper = New HideCheckBoxHelper(treeList1)
                End If
                Return hideCheckBoxHelper
            End Get
            Set(ByVal value As HideCheckBoxHelper)
                hideCheckBoxHelper = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            treeList1.DataSource = CreateTable(30)
            treeList1.ExpandAll()
        End Sub

        Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles spinEdit1.EditValueChanged
            Helper.Level = Convert.ToInt16(spinEdit1.Value)
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            Helper.NeedHide = checkEdit1.Checked
        End Sub
    End Class

	Public Class HideCheckBoxHelper

		Public Sub New(ByVal treeList As TreeList)
			_TreeList = treeList
			AddHandler treeList.CustomDrawNodeCheckBox, AddressOf treeList_CustomDrawNodeCheckBox
			AddHandler treeList.BeforeCheckNode, AddressOf treeList_BeforeCheckNode
		End Sub

		Private _Level As Integer = -1
		Private _TreeList As TreeList
		Public Property Level() As Integer
			Get
				Return _Level
			End Get
			Set(ByVal value As Integer)
				_Level = value
				_TreeList.Refresh()
			End Set
		End Property

		Private _Hide As Boolean = True
		Public Property NeedHide() As Boolean
			Get
				Return _Hide
			End Get
			Set(ByVal value As Boolean)
				_Hide = value
				_TreeList.Refresh()
			End Set
		End Property

		Private Function CanCheckNode(ByVal node As TreeListNode) As Boolean
			If Level = -1 Then
				Return True
			End If
			Return node.Level = Level
		End Function

		Private Sub treeList_BeforeCheckNode(ByVal sender As Object, ByVal e As CheckNodeEventArgs)
			e.CanCheck = CanCheckNode(e.Node)
		End Sub

		Private Sub treeList_CustomDrawNodeCheckBox(ByVal sender As Object, ByVal e As CustomDrawNodeCheckBoxEventArgs)
			Dim canCheckNode As Boolean = Me.CanCheckNode(e.Node)
			If canCheckNode Then
				Return
			End If
			e.ObjectArgs.State = DevExpress.Utils.Drawing.ObjectState.Disabled
			e.Handled = NeedHide
		End Sub
	End Class
End Namespace