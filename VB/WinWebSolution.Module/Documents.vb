Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

Namespace WinWebSolution.Module
	<DefaultClassOptions, System.ComponentModel.DisplayName("Documents"), DefaultProperty("Name")> _
	Public MustInherit Class DocumentBase
		Inherits Note
		Protected Const AssignedToContactCriteriaBase As String = "Active=True"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		<VisibleInDetailView(False), VisibleInListView(False), VisibleInLookupListView(False)> _
		Public Shadows Property Author() As String
			Get
				Return MyBase.Author
			End Get
			Set(ByVal value As String)
				MyBase.Author = value
			End Set
		End Property
		Private nameCore As String
		<RuleRequiredField(Nothing, DefaultContexts.Save)> _
		Public Property Name() As String
			Get
				Return nameCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Name", nameCore, value)
			End Set
		End Property
		Private assignedToCore As ContactBase
		<DataSourceCriteria(AssignedToContactCriteriaBase)> _
		Public Property AssignedTo() As ContactBase
			Get
				Return assignedToCore
			End Get
			Set(ByVal value As ContactBase)
				SetPropertyValue("AssignedTo", assignedToCore, value)
			End Set
		End Property
		<RuleFromBoolProperty(Nothing, DefaultContexts.Save, UsedProperties := "AssignedTo", CustomMessageTemplate := "The type of assigned contact should correspond to the type of the document."), Browsable(False)> _
		Public MustOverride ReadOnly Property AssignedToValidationRuleProperty() As Boolean
	End Class
	Public Class DocumentType1
		Inherits DocumentBase
		Protected Const AssignedToContactCriteria1 As String = "ObjectType.TypeName='WinWebSolution.Module.ContactType1'"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private documentType1PropertyCore As String
		Public Property DocumentType1Property() As String
			Get
				Return documentType1PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("DocumentType1Property", documentType1PropertyCore, value)
			End Set
		End Property
		<System.ComponentModel.DisplayName("Document Of Type 1 Name")> _
		Public Shadows Property Name() As String
			Get
				Return MyBase.Name
			End Get
			Set(ByVal value As String)
				MyBase.Name = value
			End Set
		End Property
		<DataSourceCriteria(AssignedToContactCriteriaBase & " AND " & AssignedToContactCriteria1)> _
		Public Shadows Property AssignedTo() As ContactBase
			Get
				Return MyBase.AssignedTo
			End Get
			Set(ByVal value As ContactBase)
				MyBase.AssignedTo = value
			End Set
		End Property
		Public Overrides ReadOnly Property AssignedToValidationRuleProperty() As Boolean
			Get
				If AssignedTo IsNot Nothing Then
					Return AssignedTo.GetType() Is GetType(ContactType1)
				End If
				Return True
			End Get
		End Property
	End Class
	Public Class DocumentType2
		Inherits DocumentBase
		Protected Const AssignedToContactCriteria2 As String = "ObjectType.TypeName='WinWebSolution.Module.ContactType2'"
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private documentType2PropertyCore As String
		Public Property DocumentType2Property() As String
			Get
				Return documentType2PropertyCore
			End Get
			Set(ByVal value As String)
				SetPropertyValue("DocumentType2Property", documentType2PropertyCore, value)
			End Set
		End Property
		<System.ComponentModel.DisplayName("Document Of Type 2 Name")> _
		Public Shadows Property Name() As String
			Get
				Return MyBase.Name
			End Get
			Set(ByVal value As String)
				MyBase.Name = value
			End Set
		End Property
		<DataSourceCriteria(AssignedToContactCriteriaBase & " AND " & AssignedToContactCriteria2)> _
		Public Shadows Property AssignedTo() As ContactBase
			Get
				Return MyBase.AssignedTo
			End Get
			Set(ByVal value As ContactBase)
				MyBase.AssignedTo = value
			End Set
		End Property
		<RuleRequiredField(Nothing, DefaultContexts.Save), VisibleInDetailView(True), VisibleInListView(True), VisibleInLookupListView(True)> _
		Public Shadows Property Author() As String
			Get
				Return MyBase.Author
			End Get
			Set(ByVal value As String)
				MyBase.Author = value
			End Set
		End Property
		Public Overrides ReadOnly Property AssignedToValidationRuleProperty() As Boolean
			Get
				If AssignedTo IsNot Nothing Then
					Return AssignedTo.GetType() Is GetType(ContactType2)
				End If
				Return True
			End Get
		End Property
	End Class
End Namespace