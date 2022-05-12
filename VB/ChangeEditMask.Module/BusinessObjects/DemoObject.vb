Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base
Imports DevExpress.Xpo

Namespace ChangeEditMask.Module.BusinessObjects

    <DefaultClassOptions>
    Public Class DemoObject
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private _Mask As EditMask

        <ImmediatePostData>
        Public Property Mask As EditMask
            Get
                Return _Mask
            End Get

            Set(ByVal value As EditMask)
                SetPropertyValue("Mask", _Mask, value)
            End Set
        End Property

        Private _TestString As String

        Public Property TestString As String
            Get
                Return _TestString
            End Get

            Set(ByVal value As String)
                SetPropertyValue("TestString", _TestString, value)
            End Set
        End Property
    End Class

    Public Enum EditMask
        [Date]
        Time
        Numeric
        [String]
    End Enum
End Namespace
