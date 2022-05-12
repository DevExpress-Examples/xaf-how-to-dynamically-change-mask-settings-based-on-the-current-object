Imports ChangeEditMask.Module.Controllers
Imports DevExpress.ExpressApp.Win.Editors
Imports DevExpress.XtraEditors

Namespace ChangeEditMask.Module.Win.Controllers

    Public Class WinChangeMaskController
        Inherits ChangeMaskControllerBase

        Protected Overrides Sub SetControlMaskSettings(ByVal propertyEditor As DevExpress.ExpressApp.Editors.PropertyEditor, ByVal mask As BusinessObjects.EditMask)
            If TypeOf propertyEditor Is StringPropertyEditor Then
                Dim textEdit As TextEdit = CType(propertyEditor, StringPropertyEditor).Control
                Select Case mask
                    Case BusinessObjects.EditMask.Date
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                        textEdit.Properties.Mask.EditMask = "d"
                    Case BusinessObjects.EditMask.Time
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
                        textEdit.Properties.Mask.EditMask = "t"
                    Case BusinessObjects.EditMask.Numeric
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                        textEdit.Properties.Mask.EditMask = "d"
                    Case BusinessObjects.EditMask.String
                        textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
                        textEdit.Properties.Mask.EditMask = ""
                End Select
            End If
        End Sub
    End Class
End Namespace
