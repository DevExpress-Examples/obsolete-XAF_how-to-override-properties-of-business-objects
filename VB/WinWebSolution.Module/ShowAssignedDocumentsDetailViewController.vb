Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.SystemModule

Namespace WinWebSolution.Module
	Partial Public Class ShowAssignedDocumentsDetailViewController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub popupWindowShowAction1_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs) Handles popupWindowShowAction1.CustomizePopupWindowParams
			Dim obj As ContactBase = TryCast(View.CurrentObject, ContactBase)
			If obj Is Nothing Then
				Throw New ArgumentNullException("View.CurrentObject")
			End If
			Dim lv As ListView = Application.CreateListView(View.ObjectSpace, GetType(DocumentBase), False)
			lv.CollectionSource.Criteria("AssignedDocuments") = obj.AssignedDocumentsCriteria
			e.View = lv
			e.DialogController.SaveOnAccept = False
			AddHandler e.DialogController.FrameAssigned, AddressOf DialogController_FrameAssigned

		End Sub
		Private Sub DialogController_FrameAssigned(ByVal sender As Object, ByVal e As EventArgs)
			Dim dc As DialogController = CType(sender, DialogController)
			dc.AcceptAction.Active("AssignedDocuments") = False
			dc.Frame.GetController(Of NewObjectViewController)().NewObjectAction.Active("AssignedDocuments") = False
		End Sub
	End Class
End Namespace