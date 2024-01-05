using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DynamicMask.Module.BusinessObjects;
using DevExpress.ExpressApp.Editors;

namespace DynamicMask.Module.Controllers {
    public class ChangeMaskControllerBase : ObjectViewController<DetailView, DemoObject> {
        private PropertyEditor propertyEditor;
        protected override void OnActivated() {
            base.OnActivated();
            View.CustomizeViewItemControl<PropertyEditor>(this, PropertyEditorCreated, nameof(DemoObject.TestString));
            View.CurrentObjectChanged += View_CurrentObjectChanged;
            ObjectSpace.ObjectChanged += ObjectSpace_ObjectChanged;
        }
        void PropertyEditorCreated(PropertyEditor propertyEditor) {
            this.propertyEditor = propertyEditor;
            UpdateMaskSettings(propertyEditor);
        }
        void ObjectSpace_ObjectChanged(object sender, ObjectChangedEventArgs e) {
            if (propertyEditor is not null && e.PropertyName == nameof(DemoObject.Mask)) {
                UpdateMaskSettings(propertyEditor);
            }
        }
        void View_CurrentObjectChanged(object sender, EventArgs e) {
            if (propertyEditor is not null) {
                UpdateMaskSettings(propertyEditor);
            }
        }
        void UpdateMaskSettings(PropertyEditor propertyEditor) {
            if (ViewCurrentObject is not null) {
                SetControlMaskSettings(propertyEditor, ViewCurrentObject.Mask);
            }
        }
        protected virtual void SetControlMaskSettings(PropertyEditor propertyEditor, EditMask mask) { }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            View.CurrentObjectChanged -= View_CurrentObjectChanged;
            ObjectSpace.ObjectChanged -= ObjectSpace_ObjectChanged;
            propertyEditor = null;
        }
    }
}
