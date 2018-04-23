Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace WinWebSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
			MyBase.New(objectSpace, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Dim ct1 As ContactType1 = ObjectSpace.CreateObject(Of ContactType1)()
			ct1.FirstName = "Contact 1 (Type 1)"
			ct1.Active = True

			Dim ct2 As ContactType2 = ObjectSpace.CreateObject(Of ContactType2)()
			ct2.FirstName = "Contact 2 (Type 2)"
			ct2.Active = True

			Dim ct3 As ContactType2 = ObjectSpace.CreateObject(Of ContactType2)()
			ct3.FirstName = "Contact 3 (Type 2)"
			ct3.Active = False

			Dim dt1 As DocumentType1 = ObjectSpace.CreateObject(Of DocumentType1)()
			dt1.Name = "Document 1 (Type 1)"
			dt1.AssignedTo = ct1

			Dim dt2 As DocumentType2 = ObjectSpace.CreateObject(Of DocumentType2)()
			dt2.Name = "Document 2 (Type 2)"
			dt2.Author = "Author 1 (Type 2)"
			dt2.AssignedTo = ct2
		End Sub
	End Class
End Namespace
