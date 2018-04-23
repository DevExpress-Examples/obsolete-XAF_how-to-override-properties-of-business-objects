using System;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinWebSolution.Module {
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("Documents")]
    [DefaultProperty("Name")]
    public abstract class DocumentBase : Note {
        protected const string AssignedToContactCriteriaBase = "Active=True";
        public DocumentBase(Session session) : base(session) { }
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        public new string Author {
            get { return base.Author; }
            set { base.Author = value; }
        }
        private string nameCore;
        [RuleRequiredField(null, DefaultContexts.Save)]
        public string Name {
            get { return nameCore; }
            set { SetPropertyValue("Name", ref nameCore, value); }
        }
        private ContactBase assignedToCore;
        [DataSourceCriteria(AssignedToContactCriteriaBase)]
        public ContactBase AssignedTo {
            get { return assignedToCore; }
            set { SetPropertyValue("AssignedTo", ref assignedToCore, value); }
        }
        [RuleFromBoolProperty(null, DefaultContexts.Save, UsedProperties = "AssignedTo", CustomMessageTemplate = "The type of assigned contact should correspond to the type of the document."), Browsable(false)]
        public abstract bool AssignedToValidationRuleProperty { get;}
    }
    public class DocumentType1 : DocumentBase {
        protected const string AssignedToContactCriteria1 = "ObjectType.TypeName='WinWebSolution.Module.ContactType1'";
        public DocumentType1(Session session) : base(session) { }
        private string documentType1PropertyCore;
        public string DocumentType1Property {
            get { return documentType1PropertyCore; }
            set { SetPropertyValue("DocumentType1Property", ref documentType1PropertyCore, value); }
        }
        [System.ComponentModel.DisplayName("Document Of Type 1 Name")]
        public new string Name {
            get { return base.Name; }
            set { base.Name = value; }
        }
        [DataSourceCriteria(AssignedToContactCriteriaBase + " AND " + AssignedToContactCriteria1)]
        public new ContactBase AssignedTo {
            get { return base.AssignedTo; }
            set { base.AssignedTo = value; }
        }
        public override bool AssignedToValidationRuleProperty {
            get {
                if (AssignedTo != null) {
                    return AssignedTo.GetType() == typeof(ContactType1);
                }
                return true;
            }
        }
    }
    public class DocumentType2 : DocumentBase {
        protected const string AssignedToContactCriteria2 = "ObjectType.TypeName='WinWebSolution.Module.ContactType2'";
        public DocumentType2(Session session) : base(session) { }
        private string documentType2PropertyCore;
        public string DocumentType2Property {
            get { return documentType2PropertyCore; }
            set { SetPropertyValue("DocumentType2Property", ref documentType2PropertyCore, value); }
        }
        [System.ComponentModel.DisplayName("Document Of Type 2 Name")]
        public new string Name {
            get { return base.Name; }
            set { base.Name = value; }
        }
        [DataSourceCriteria(AssignedToContactCriteriaBase + " AND " + AssignedToContactCriteria2)]
        public new ContactBase AssignedTo {
            get { return base.AssignedTo; }
            set { base.AssignedTo = value; }
        }
        [RuleRequiredField(null, DefaultContexts.Save)]
        [VisibleInDetailView(true)]
        [VisibleInListView(true)]
        [VisibleInLookupListView(true)]
        public new string Author {
            get { return base.Author; }
            set { base.Author = value; }
        }
        public override bool AssignedToValidationRuleProperty {
            get {
                if (AssignedTo != null) {
                    return AssignedTo.GetType() == typeof(ContactType2);
                }
                return true;
            }
        }
    }
}