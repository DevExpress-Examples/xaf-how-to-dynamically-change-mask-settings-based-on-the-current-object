Imports System
Imports DevExpress.ExpressApp
Imports ChangeEditMask.Module.BusinessObjects
Imports DevExpress.ExpressApp.Editors

Namespace ChangeEditMask.Module.Controllers

    Public Class ChangeMaskControllerBase
        Inherits ObjectViewController(Of DetailView, DemoObject)

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler View.CurrentObjectChanged, AddressOf View_CurrentObjectChanged
            AddHandler ObjectSpace.ObjectChanged, AddressOf ObjectSpace_ObjectChanged
            AddHandler View.FindItem("TestString").ControlCreated, AddressOf Me.ChangeMaskControllerBase_ControlCreated
        End Sub

        Private Sub ChangeMaskControllerBase_ControlCreated(ByVal sender As Object, ByVal e As EventArgs)
            UpdateMaskSettings()
        End Sub

        Private Sub ObjectSpace_ObjectChanged(ByVal sender As Object, ByVal e As ObjectChangedEventArgs)
            If Equals(e.PropertyName, "Mask") AndAlso e.NewValue IsNot e.OldValue Then
                UpdateMaskSettings()
            End If
        End Sub

        Private Sub View_CurrentObjectChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateMaskSettings()
        End Sub

        Private Sub UpdateMaskSettings()
            If ViewCurrentObject IsNot Nothing Then
                SetControlMaskSettings(CType(View.FindItem("TestString"), PropertyEditor), ViewCurrentObject.Mask)
            End If
        End Sub

        Protected Overridable Sub SetControlMaskSettings(ByVal propertyEditor As PropertyEditor, ByVal mask As EditMask)
        End Sub

        Protected Overrides Sub OnDeactivated()
            MyBase.OnDeactivated()
            RemoveHandler View.CurrentObjectChanged, AddressOf View_CurrentObjectChanged
            RemoveHandler ObjectSpace.ObjectChanged, AddressOf ObjectSpace_ObjectChanged
            RemoveHandler View.FindItem("TestString").ControlCreated, AddressOf Me.ChangeMaskControllerBase_ControlCreated
        End Sub
    End Class
End Namespace
