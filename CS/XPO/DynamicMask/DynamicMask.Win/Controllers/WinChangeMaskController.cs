using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DynamicMask.Module.BusinessObjects;
using DynamicMask.Module.Controllers;

namespace DynamicMask.Module.Win.Controllers {
    public class WinChangeMaskController : ChangeMaskControllerBase {
        protected override void SetControlMaskSettings(PropertyEditor propertyEditor, EditMask mask) {
            if (propertyEditor is StringPropertyEditor) {
                TextEdit textEdit = ((StringPropertyEditor)propertyEditor).Control;
                switch (mask) {
                    case EditMask.Date:
                        textEdit.Properties.Mask.MaskType = MaskType.DateTime;
                        textEdit.Properties.Mask.EditMask = "d";
                        break;
                    case EditMask.Time:
                        textEdit.Properties.Mask.MaskType = MaskType.DateTime;
                        textEdit.Properties.Mask.EditMask = "t";
                        break;
                    case EditMask.Numeric:
                        textEdit.Properties.Mask.MaskType = MaskType.Numeric;
                        textEdit.Properties.Mask.EditMask = "d";
                        break;
                    case EditMask.String:
                        textEdit.Properties.Mask.MaskType = MaskType.None;
                        textEdit.Properties.Mask.EditMask = "";
                        break;
                }
            }
        }
    }
}
