Imports Microsoft.VisualBasic
Imports System
Namespace WinWebSolution.Module
	Partial Public Class ShowAssignedDocumentsDetailViewController
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

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.popupWindowShowAction1 = New DevExpress.ExpressApp.Actions.PopupWindowShowAction(Me.components)
			' 
			' popupWindowShowAction1
			' 
			Me.popupWindowShowAction1.AcceptButtonCaption = Nothing
			Me.popupWindowShowAction1.CancelButtonCaption = "Close"
			Me.popupWindowShowAction1.Caption = "Show Assigned Documents"
			Me.popupWindowShowAction1.Category = "View"
			Me.popupWindowShowAction1.Id = "9e20d370-8103-46f8-9dea-7e4a5d7d536e"
			Me.popupWindowShowAction1.ImageName = "BO_Note"
			Me.popupWindowShowAction1.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.Image
			Me.popupWindowShowAction1.Tag = Nothing
			Me.popupWindowShowAction1.ToolTip = "Show assigned documents"
			Me.popupWindowShowAction1.TypeOfView = Nothing
'			Me.popupWindowShowAction1.CustomizePopupWindowParams += New DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(Me.popupWindowShowAction1_CustomizePopupWindowParams);
			' 
			' ShowAssignedDocumentsDetailViewController
			' 
			Me.TargetObjectType = GetType(WinWebSolution.Module.ContactBase)
			Me.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root
			Me.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView
			Me.TypeOfView = GetType(DevExpress.ExpressApp.DetailView)

		End Sub

		#End Region

		Private WithEvents popupWindowShowAction1 As DevExpress.ExpressApp.Actions.PopupWindowShowAction

	End Class
End Namespace
