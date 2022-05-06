Namespace ChangeEditMask.Win

    Partial Class ChangeEditMaskWindowsFormsApplication

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New ChangeEditMask.[Module].ChangeEditMaskModule()
            Me.module4 = New ChangeEditMask.[Module].Win.ChangeEditMaskWindowsFormsModule()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' ChangeEditMaskWindowsFormsApplication
            ' 
            Me.ApplicationName = "ChangeEditMask"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.UseOldTemplates = False
            AddHandler Me.DatabaseVersionMismatch, New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(AddressOf Me.ChangeEditMaskWindowsFormsApplication_DatabaseVersionMismatch)
            AddHandler Me.CustomizeLanguagesList, New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(AddressOf Me.ChangeEditMaskWindowsFormsApplication_CustomizeLanguagesList)
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule

        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule

        Private module3 As ChangeEditMask.[Module].ChangeEditMaskModule

        Private module4 As ChangeEditMask.[Module].Win.ChangeEditMaskWindowsFormsModule
    End Class
End Namespace
