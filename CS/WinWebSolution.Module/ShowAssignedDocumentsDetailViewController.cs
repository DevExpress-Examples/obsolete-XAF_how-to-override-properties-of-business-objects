using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.SystemModule;

namespace WinWebSolution.Module {
    public partial class ShowAssignedDocumentsDetailViewController : ViewController {
        public ShowAssignedDocumentsDetailViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            ContactBase obj = View.CurrentObject as ContactBase;
            if (obj == null) {
                throw new ArgumentNullException("View.CurrentObject");
            }
            ListView lv = Application.CreateListView(View.ObjectSpace, typeof(DocumentBase), false);
            lv.CollectionSource.Criteria["AssignedDocuments"] = obj.AssignedDocumentsCriteria;
            e.View = lv;
            e.DialogController.SaveOnAccept = false;
            e.DialogController.FrameAssigned +=new EventHandler(DialogController_FrameAssigned);

        }
        private void DialogController_FrameAssigned(object sender, EventArgs e) {
            DialogController dc = (DialogController)sender;
            dc.AcceptAction.Active["AssignedDocuments"] = false;
            dc.Frame.GetController<NewObjectViewController>().NewObjectAction.Active["AssignedDocuments"] = false;
        }
    }
}