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
Friend Class Res
    
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
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("CustomizerGod.Res", GetType(Res).Assembly)
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
    '''  Looks up a localized resource of type System.Byte[].
    '''</summary>
    Friend Shared ReadOnly Property _7za() As Byte()
        Get
            Dim obj As Object = ResourceManager.GetObject("_7za", resourceCulture)
            Return CType(obj,Byte())
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Byte[].
    '''</summary>
    Friend Shared ReadOnly Property PsExec() As Byte()
        Get
            Dim obj As Object = ResourceManager.GetObject("PsExec", resourceCulture)
            Return CType(obj,Byte())
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to @Echo Off
    '''Title System File Checker - Restore {0}
    '''Color F0
    '''Echo | Set /P SFC=SFC {1}
    '''%WinDir%\System32\SFC.exe {1}
    '''Echo.
    '''Echo | Set /P Exit=Press any key to exit...
    '''Pause &gt; Nul.
    '''</summary>
    Friend Shared ReadOnly Property SFC() As String
        Get
            Return ResourceManager.GetString("SFC", resourceCulture)
        End Get
    End Property
End Class
