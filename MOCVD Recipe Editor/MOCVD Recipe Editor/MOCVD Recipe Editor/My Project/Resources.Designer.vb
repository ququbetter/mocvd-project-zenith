﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
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
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MOCVD_Recipe_Editor.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!--
        ''' |
        ''' | XSLT REC Compliant Version of IE5 Default Stylesheet
        ''' |
        ''' | Original version by Jonathan Marsh (jmarsh@xxxxxxxxxxxxx)
        ''' | http://msdn.microsoft.com/xml/samples/defaultss/defaultss.xsl
        ''' |
        ''' | Conversion to XSLT 1.0 REC Syntax by Steve Muench (smuench@xxxxxxxxxx)
        ''' |
        ''' +--&gt;
        '''&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;&gt;
        '''	&lt;xsl:output indent=&quot;no&quot; method=&quot;html&quot;/&gt;
        '''	&lt;xsl:template match=&quot;/&quot;&gt;
        '''		&lt;HTML&gt;
        '''			&lt;HEAD&gt;
        '''				&lt;SCRIPT&gt;
        '''					&lt;xsl:comment&gt;&lt;![CDATA[
        '''          [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property defaultss() As String
            Get
                Return ResourceManager.GetString("defaultss", resourceCulture)
            End Get
        End Property
        
        Friend ReadOnly Property down_arrow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("down_arrow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property DownArrow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DownArrow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property up_arrow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("up_arrow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property UpArrow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("UpArrow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
