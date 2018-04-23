using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Updating;

namespace WinWebSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            using (UnitOfWork uow = new UnitOfWork(Session.DataLayer)) {
                ContactType1 ct1 = new ContactType1(uow);
                ct1.FirstName = "Contact 1 (Type 1)";
                ct1.Active = true;

                ContactType2 ct2 = new ContactType2(uow);
                ct2.FirstName = "Contact 2 (Type 2)";
                ct2.Active = true;

                ContactType2 ct3 = new ContactType2(uow);
                ct3.FirstName = "Contact 3 (Type 2)";
                ct3.Active = false;

                DocumentType1 dt1 = new DocumentType1(uow);
                dt1.Name = "Document 1 (Type 1)";
                dt1.AssignedTo = ct1;

                DocumentType2 dt2 = new DocumentType2(uow);
                dt2.Name = "Document 2 (Type 2)";
                dt2.Author = "Author 1 (Type 2)";
                dt2.AssignedTo = ct2;
                
                uow.CommitChanges();
            }
        }
    }
}
