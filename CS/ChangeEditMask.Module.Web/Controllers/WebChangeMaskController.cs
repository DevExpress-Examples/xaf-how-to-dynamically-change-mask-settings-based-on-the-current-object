using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChangeEditMask.Module.Controllers;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Web;

namespace ChangeEditMask.Module.Win.Controllers {
    public class WinChangeMaskController : ChangeMaskControllerBase {
        protected override void SetControlMaskSettings(DevExpress.ExpressApp.Editors.PropertyEditor propertyEditor, BusinessObjects.EditMask mask) {
            if (propertyEditor is ASPxStringPropertyEditor) {
                ASPxTextBox textEdit = ((ASPxStringPropertyEditor)propertyEditor).Editor as ASPxTextBox;
                if (textEdit != null) {
                    switch (mask) {
                        case BusinessObjects.EditMask.Date:
                            textEdit.MaskSettings.Mask = "MM/dd/yyyy";
                            break;
                        case BusinessObjects.EditMask.Time:
                            textEdit.MaskSettings.Mask = "hh:mm tt";
                            break;
                        case BusinessObjects.EditMask.Numeric:
                            textEdit.MaskSettings.Mask = "0999999999";
                            break;
                        case BusinessObjects.EditMask.String:
                            textEdit.MaskSettings.Mask = "";
                            break;
                    }
                }
            }
        }
    }
}
