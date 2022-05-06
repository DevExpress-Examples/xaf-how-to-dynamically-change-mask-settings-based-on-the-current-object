Imports ChangeEditMask.Module.Controllers
Imports DevExpress.ExpressApp.Web.Editors.ASPx
Imports DevExpress.Web

Namespace ChangeEditMask.Module.Web.Controllers

    Public Class WebChangeMaskController
        Inherits ChangeMaskControllerBase

        Protected Overrides Sub SetControlMaskSettings(ByVal propertyEditor As DevExpress.ExpressApp.Editors.PropertyEditor, ByVal mask As BusinessObjects.EditMask)
            If TypeOf propertyEditor Is ASPxStringPropertyEditor Then
                Dim textEdit As ASPxTextBox = TryCast(CType(propertyEditor, ASPxStringPropertyEditor).Editor, ASPxTextBox)
                If textEdit IsNot Nothing Then
                    Select Case mask
                        Case BusinessObjects.EditMask.Date
                            textEdit.MaskSettings.Mask = "MM/dd/yyyy"
                        Case BusinessObjects.EditMask.Time
                            textEdit.MaskSettings.Mask = "hh:mm tt"
                        Case BusinessObjects.EditMask.Numeric
                            textEdit.MaskSettings.Mask = "0999999999"
                        Case BusinessObjects.EditMask.String
                            textEdit.MaskSettings.Mask = ""
                    End Select
                End If
            End If
        End Sub
    End Class
End Namespace
