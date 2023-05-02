using DevExpress.ExpressApp.Blazor.Editors;
using DynamicMask.Module.BusinessObjects;
using DynamicMask.Module.Controllers;

namespace ChangeEditMask.Module.Web.Controllers {
    public class BlazorChangeMaskController : ChangeMaskControllerBase {
        protected override void SetControlMaskSettings(DevExpress.ExpressApp.Editors.PropertyEditor propertyEditor, EditMask mask) {
            if (propertyEditor is StringPropertyEditor stringEditor) {

                //    ASPxTextBox textEdit = ((ASPxStringPropertyEditor)propertyEditor).Editor as ASPxTextBox;
                //    if (textEdit != null) {
                switch (mask) {
                    case EditMask.Date:
                        stringEditor.EditMask = "MM/dd/yyyy";
                        break;
                    case EditMask.Time:
                        stringEditor.EditMask = "hh:mm tt";
                        break;
                    case EditMask.Numeric:
                        stringEditor.EditMask = "(000) 000-0000";
                        break;
                    case EditMask.String:
                        break;
                }
                //    }
            }
        }
    }
}
