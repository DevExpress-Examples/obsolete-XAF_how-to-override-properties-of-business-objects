using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            ContactType1 ct1 = ObjectSpace.CreateObject<ContactType1>();
            ct1.FirstName = "Contact 1 (Type 1)";
            ct1.Active = true;

            ContactType2 ct2 = ObjectSpace.CreateObject<ContactType2>();
            ct2.FirstName = "Contact 2 (Type 2)";
            ct2.Active = true;

            ContactType2 ct3 = ObjectSpace.CreateObject<ContactType2>();
            ct3.FirstName = "Contact 3 (Type 2)";
            ct3.Active = false;

            DocumentType1 dt1 = ObjectSpace.CreateObject<DocumentType1>();
            dt1.Name = "Document 1 (Type 1)";
            dt1.AssignedTo = ct1;

            DocumentType2 dt2 = ObjectSpace.CreateObject<DocumentType2>();
            dt2.Name = "Document 2 (Type 2)";
            dt2.Author = "Author 1 (Type 2)";
            dt2.AssignedTo = ct2;
        }
    }
}
