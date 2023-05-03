using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Blazor.Editors.Adapters;
using DynamicMask.Module.BusinessObjects;
using DynamicMask.Module.Controllers;

namespace ChangeEditMask.Module.Web.Controllers {
    public class BlazorChangeMaskController : ChangeMaskControllerBase {
        protected override void SetControlMaskSettings(DevExpress.ExpressApp.Editors.PropertyEditor propertyEditor, EditMask mask) {
            if (propertyEditor is StringPropertyEditor stringEditor && stringEditor.Control is DxMaskedInputAdapter adapter) {
                var componentModel = adapter.ComponentModel;
                switch (mask) {
                    case EditMask.Date:
                        componentModel.MaskMode = DevExpress.Blazor.MaskMode.DateTime;
                        componentModel.Mask = "MM/dd/yyyy";
                        break;
                    case EditMask.Time:
                        componentModel.MaskMode = DevExpress.Blazor.MaskMode.DateTime;
                        componentModel.Mask = "hh:mm tt";
                        break;
                    case EditMask.Numeric:
                        componentModel.MaskMode = DevExpress.Blazor.MaskMode.Numeric;
                        componentModel.Mask = "(000) 000-0000";
                        break;
                    case EditMask.String:
                        componentModel.MaskMode = DevExpress.Blazor.MaskMode.Auto;
                        componentModel.Mask = "";
                        break;
                }
            }
        }
    }
}
