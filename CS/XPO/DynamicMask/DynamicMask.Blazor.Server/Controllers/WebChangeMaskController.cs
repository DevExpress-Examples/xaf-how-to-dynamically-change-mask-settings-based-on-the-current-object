using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DynamicMask.Module.BusinessObjects;
using DynamicMask.Module.Controllers;

namespace ChangeEditMask.Module.Web.Controllers {
    public class BlazorChangeMaskController : ChangeMaskControllerBase {
        protected override void SetControlMaskSettings(DevExpress.ExpressApp.Editors.PropertyEditor propertyEditor, EditMask mask) {
            if (propertyEditor is StringPropertyEditor stringEditor) {

                //    ASPxTextBox textEdit = ((ASPxStringPropertyEditor)propertyEditor).Editor as ASPxTextBox;
                //var t = stringEditor.Control as DxTextBoxAdapter;
                //var t2 = t.ComponentModel;
                //    if (textEdit != null) {
                switch (mask) {
                    case EditMask.Date:
                        stringEditor.EditMask = "MM/dd/yyyy";
                        break;
                    case EditMask.Time:
                        stringEditor.EditMask = "hh:mm tt";
                        break;
                    case EditMask.Numeric:
                        //   stringEditor.EditMask = "(000) 000-0000";
                        stringEditor.Model.EditMask = "(000) 000-0000";
                        View.Refresh();
                        break;
                    case EditMask.String:
                        break;
                }
                //    }
            }
        }
    }
}
