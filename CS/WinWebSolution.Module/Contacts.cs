using System;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("Contacts")]
    public abstract class ContactBase : Person {
        protected const string DocumentAssignedToContactCriteriaBase = "AssignedTo=?";
        public ContactBase(Session session) : base(session) { }
        [Browsable(false)]
        public virtual CriteriaOperator AssignedDocumentsCriteria {
            get {
                return CriteriaOperator.Parse(DocumentAssignedToContactCriteriaBase, this);
            }
        }
        private bool activeCore;
        public bool Active {
            get { return activeCore; }
            set { SetPropertyValue("Active", ref activeCore, value); }
        }
    }
    public class ContactType1 : ContactBase {
        protected const string DocumentAssignedToContactCriteria1 = "ObjectType.TypeName='WinWebSolution.Module.DocumentType1'";
        public ContactType1(Session session) : base(session) { }
        private string contactType1PropertyCore;
        public string ContactType1Property {
            get { return contactType1PropertyCore; }
            set { SetPropertyValue("ContactType1Property", ref contactType1PropertyCore, value); }
        }
        public override CriteriaOperator AssignedDocumentsCriteria {
            get {
                return base.AssignedDocumentsCriteria & CriteriaOperator.Parse(DocumentAssignedToContactCriteria1);
            }
        }
    }
    public class ContactType2 : ContactBase {
        protected const string DocumentAssignedToContactCriteria2 = "ObjectType.TypeName='WinWebSolution.Module.DocumentType2'";
        public ContactType2(Session session) : base(session) { }
        private string contactType2PropertyCore;
        public string ContactType2Property {
            get { return contactType2PropertyCore; }
            set { SetPropertyValue("ContactType2Property", ref contactType2PropertyCore, value); }
        }
        public override CriteriaOperator AssignedDocumentsCriteria {
            get {
                return base.AssignedDocumentsCriteria & CriteriaOperator.Parse(DocumentAssignedToContactCriteria2);
            }
        }
    }
}