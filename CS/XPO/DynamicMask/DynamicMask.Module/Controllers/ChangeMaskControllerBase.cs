using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DynamicMask.Module.BusinessObjects;
using DevExpress.ExpressApp.Editors;

namespace DynamicMask.Module.Controllers {
    public class ChangeMaskControllerBase : ObjectViewController<DetailView, DemoObject> {
        protected override void OnActivated() {
            base.OnActivated();
            View.CurrentObjectChanged += View_CurrentObjectChanged;
            ObjectSpace.ObjectChanged += ObjectSpace_ObjectChanged;
            View.FindItem("TestString").ControlCreated += ChangeMaskControllerBase_ControlCreated;
        }

        void ChangeMaskControllerBase_ControlCreated(object sender, EventArgs e) {
            UpdateMaskSettings();
        }

        void ObjectSpace_ObjectChanged(object sender, ObjectChangedEventArgs e) {
            if (e.PropertyName == "Mask" && e.NewValue != e.OldValue) {
                UpdateMaskSettings();
            }
        }

        void View_CurrentObjectChanged(object sender, EventArgs e) {
            UpdateMaskSettings();
        }

        private void UpdateMaskSettings() {
            if (ViewCurrentObject != null) {
                SetControlMaskSettings((PropertyEditor)View.FindItem("TestString"), ViewCurrentObject.Mask);
            }
        }

        protected virtual void SetControlMaskSettings(PropertyEditor propertyEditor, EditMask mask) { }

        protected override void OnDeactivated() {
            base.OnDeactivated();
            View.CurrentObjectChanged -= View_CurrentObjectChanged;
            ObjectSpace.ObjectChanged -= ObjectSpace_ObjectChanged;
            View.FindItem("TestString").ControlCreated -= ChangeMaskControllerBase_ControlCreated;
        }
    }
}
