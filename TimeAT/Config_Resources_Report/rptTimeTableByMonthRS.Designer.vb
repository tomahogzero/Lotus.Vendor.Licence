﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class rptTimeTableByMonthRS
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("TimeAttendance.rptTimeTableByMonthRS", GetType(rptTimeTableByMonthRS).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;ขาด&apos;.
        '''</summary>
        Friend Shared ReadOnly Property Abs() As String
            Get
                Return ResourceManager.GetString("Abs", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;มา&apos;.
        '''</summary>
        Friend Shared ReadOnly Property Come() As String
            Get
                Return ResourceManager.GetString("Come", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;บริษัท ไถ่เชียงวัสดุก่อสร้าง จำกัด&apos;.
        '''</summary>
        Friend Shared ReadOnly Property CompanyName() As String
            Get
                Return ResourceManager.GetString("CompanyName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;เดือนกันยายน&apos;.
        '''</summary>
        Friend Shared ReadOnly Property H_Month() As String
            Get
                Return ResourceManager.GetString("H_Month", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ประจำเดือน.
        '''</summary>
        Friend Shared ReadOnly Property Head_F_Month() As String
            Get
                Return ResourceManager.GetString("Head_F_Month", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ตั้งแต่วันที่.
        '''</summary>
        Friend Shared ReadOnly Property Head_F_Month2() As String
            Get
                Return ResourceManager.GetString("Head_F_Month2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;รหัส&apos;.
        '''</summary>
        Friend Shared ReadOnly Property ID() As String
            Get
                Return ResourceManager.GetString("ID", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;ชื่อ - นามสกุล&apos;.
        '''</summary>
        Friend Shared ReadOnly Property Name_Last() As String
            Get
                Return ResourceManager.GetString("Name_Last", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;ลำดับที่&apos;.
        '''</summary>
        Friend Shared ReadOnly Property Rec() As String
            Get
                Return ResourceManager.GetString("Rec", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &apos;หมายเหตุ&apos;.
        '''</summary>
        Friend Shared ReadOnly Property Remark() As String
            Get
                Return ResourceManager.GetString("Remark", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
