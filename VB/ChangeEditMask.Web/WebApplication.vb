Imports System
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Xpo

Namespace ChangeEditMask.Web

    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
    Public Partial Class ChangeEditMaskAspNetApplication
        Inherits WebApplication

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule

        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule

        Private module3 As ChangeEditMask.Module.ChangeEditMaskModule

        Private module4 As ChangeEditMask.Module.Web.ChangeEditMaskAspNetModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection, True)
        End Sub

        Private Sub ChangeEditMaskAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DatabaseVersionMismatchEventArgs)
#If EASYTEST
            e.Updater.Update();
            e.Handled = true;
#Else
            If System.Diagnostics.Debugger.IsAttached Then
                e.Updater.Update()
                e.Handled = True
            Else
                Dim message As String = "The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Microsoft.VisualBasic.Constants.vbCrLf & "This error occurred  because the automatic database update was disabled when the application was started without debugging." & Microsoft.VisualBasic.Constants.vbCrLf & "To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool." & Microsoft.VisualBasic.Constants.vbCrLf & "Anyway, refer to the following help topics for more detailed information:" & Microsoft.VisualBasic.Constants.vbCrLf & "'Update Application and Database Versions' at http://help.devexpress.com/#Xaf/CustomDocument2795" & Microsoft.VisualBasic.Constants.vbCrLf & "'Database Security References' at http://help.devexpress.com/#Xaf/CustomDocument3237" & Microsoft.VisualBasic.Constants.vbCrLf & "If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/"
                If e.CompatibilityError IsNot Nothing AndAlso e.CompatibilityError.Exception IsNot Nothing Then
                    message += Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & "Inner exception: " & e.CompatibilityError.Exception.Message
                End If

                Throw New InvalidOperationException(message)
            End If
#End If
        End Sub

        Private Sub InitializeComponent()
            module1 = New SystemModule.SystemModule()
            module2 = New SystemModule.SystemAspNetModule()
            module3 = New ChangeEditMask.Module.ChangeEditMaskModule()
            module4 = New ChangeEditMask.Module.Web.ChangeEditMaskAspNetModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' ChangeEditMaskAspNetApplication
            ' 
            ApplicationName = "ChangeEditMask"
            CollectionsEditMode = Editors.ViewEditMode.Edit
            Modules.Add(module1)
            Modules.Add(module2)
            Modules.Add(module3)
            Modules.Add(module4)
            AddHandler DatabaseVersionMismatch, New EventHandler(Of DatabaseVersionMismatchEventArgs)(AddressOf Me.ChangeEditMaskAspNetApplication_DatabaseVersionMismatch)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
