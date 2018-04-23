Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Updating

Namespace WinWebSolution.Module
	Public Class Updater
		Inherits ModuleUpdater
		Public Sub New(ByVal session As Session, ByVal currentDBVersion As Version)
			MyBase.New(session, currentDBVersion)
		End Sub
		Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
			MyBase.UpdateDatabaseAfterUpdateSchema()
			Using uow As New UnitOfWork(Session.DataLayer)
				Dim ct1 As New ContactType1(uow)
				ct1.FirstName = "Contact 1 (Type 1)"
				ct1.Active = True

				Dim ct2 As New ContactType2(uow)
				ct2.FirstName = "Contact 2 (Type 2)"
				ct2.Active = True

				Dim ct3 As New ContactType2(uow)
				ct3.FirstName = "Contact 3 (Type 2)"
				ct3.Active = False

				Dim dt1 As New DocumentType1(uow)
				dt1.Name = "Document 1 (Type 1)"
				dt1.AssignedTo = ct1

				Dim dt2 As New DocumentType2(uow)
				dt2.Name = "Document 2 (Type 2)"
				dt2.Author = "Author 1 (Type 2)"
				dt2.AssignedTo = ct2

				uow.CommitChanges()
			End Using
		End Sub
	End Class
End Namespace
