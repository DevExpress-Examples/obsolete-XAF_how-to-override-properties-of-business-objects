namespace WinWebSolution.Module {
    partial class ShowAssignedDocumentsDetailViewController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.popupWindowShowAction1 = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // popupWindowShowAction1
            // 
            this.popupWindowShowAction1.AcceptButtonCaption = null;
            this.popupWindowShowAction1.CancelButtonCaption = "Close";
            this.popupWindowShowAction1.Caption = "Show Assigned Documents";
            this.popupWindowShowAction1.Category = "View";
            this.popupWindowShowAction1.Id = "9e20d370-8103-46f8-9dea-7e4a5d7d536e";
            this.popupWindowShowAction1.ImageName = "BO_Note";
            this.popupWindowShowAction1.PaintStyle = DevExpress.ExpressApp.Templates.ActionItemPaintStyle.Image;
            this.popupWindowShowAction1.Tag = null;
            this.popupWindowShowAction1.ToolTip = "Show assigned documents";
            this.popupWindowShowAction1.TypeOfView = null;
            this.popupWindowShowAction1.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);
            // 
            // ShowAssignedDocumentsDetailViewController
            // 
            this.TargetObjectType = typeof(WinWebSolution.Module.ContactBase);
            this.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root;
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction1;

    }
}
