using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChangeEditMask.Module.Controllers;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors;

namespace ChangeEditMask.Module.Win.Controllers {
    public class WinChangeMaskController : ChangeMaskControllerBase {
        protected override void SetControlMaskSettings(DevExpress.ExpressApp.Editors.PropertyEditor propertyEditor, BusinessObjects.EditMask mask) {
            if (propertyEditor is StringPropertyEditor) {
                TextEdit textEdit = ((StringPropertyEditor)propertyEditor).Control;
                switch (mask) {
                    case BusinessObjects.EditMask.Date:
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                        textEdit.Properties.Mask.EditMask = "d";
                        break;
                    case BusinessObjects.EditMask.Time:
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                        textEdit.Properties.Mask.EditMask = "t";
                        break;
                    case BusinessObjects.EditMask.Numeric:
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                        textEdit.Properties.Mask.EditMask = "d";
                        break;
                    case BusinessObjects.EditMask.String:
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                        textEdit.Properties.Mask.EditMask = "";
                        break;
                }
            }
        }
    }
}
