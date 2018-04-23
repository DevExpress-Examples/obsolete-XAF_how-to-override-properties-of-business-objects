Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace WinWebSolution.Module
	<DefaultClassOptions, System.ComponentModel.DisplayName("Contacts")> _
	Public MustInherit Class ContactBase
		Inherits Person
		Protected Const DocumentAssignedToContactCriteriaBase As String = "AssignedTo=?"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		<Browsable(False)> _
		Public Overridable ReadOnly Property AssignedDocumentsCriteria() As CriteriaOperator
			Get
				Return CriteriaOperator.Parse(DocumentAssignedToContactCriteriaBase, Me)
			End Get
		End Property
		Private activeCore As Boolean
		Public Property Active() As Boolean
			Get
				Return activeCore
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue("Active", activeCore, value)
			End Set
		End Property
	End Class
	Public Class ContactType1
		Inherits ContactBase
		Protected Const DocumentAssignedToContactCriteria1 As String = "ObjectType.TypeName='WinWebSolution.Module.DocumentType1'"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private contactType1PropertyCore As String
		Public Property ContactType1Property() As String
			Get
				Return contactType1PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("ContactType1Property", contactType1PropertyCore, value)
			End Set
		End Property
		Public Overrides ReadOnly Property AssignedDocumentsCriteria() As CriteriaOperator
			Get
				Return MyBase.AssignedDocumentsCriteria And CriteriaOperator.Parse(DocumentAssignedToContactCriteria1)
			End Get
		End Property
	End Class
	Public Class ContactType2
		Inherits ContactBase
		Protected Const DocumentAssignedToContactCriteria2 As String = "ObjectType.TypeName='WinWebSolution.Module.DocumentType2'"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private contactType2PropertyCore As String
		Public Property ContactType2Property() As String
			Get
				Return contactType2PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("ContactType2Property", contactType2PropertyCore, value)
			End Set
		End Property
		Public Overrides ReadOnly Property AssignedDocumentsCriteria() As CriteriaOperator
			Get
				Return MyBase.AssignedDocumentsCriteria And CriteriaOperator.Parse(DocumentAssignedToContactCriteria2)
			End Get
		End Property
	End Class
End Namespace