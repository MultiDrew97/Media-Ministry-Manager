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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SPPBC.M3Tools.Resources", GetType(Resources).Assembly)
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
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property BannerImage() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("BannerImage", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property BoldOption() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("BoldOption", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property credentials() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("credentials", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Media Ministry.
        '''</summary>
        Friend ReadOnly Property DefaultCatalog() As String
            Get
                Return ResourceManager.GetString("DefaultCatalog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Data Source=sppbc.hopto.org,14339;Persist Security Info=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Authentication=&quot;Sql Password&quot;.
        '''</summary>
        Friend ReadOnly Property DefaultConnectionString() As String
            Get
                Return ResourceManager.GetString("DefaultConnectionString", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!Doctype html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.hopto.org/css/emails.css&quot;&gt;
        '''    &lt;/head&gt;
        '''    &lt;body&gt;
        '''        &lt;p&gt;Blessings To You {0},&lt;/p&gt;
        '''
        '''		&lt;p&gt;Welcome to the St. Paul Primitive Baptist Church Email Listening Ministry. Thank you for becoming a Subscriber. You will receive Sunday&apos;s Messages from the St. Paul Primitive Baptist Church, Austin, TX. Morning Service each week; where Elder Bryon K. Miller is the Pastor. You will Receive your Sunday Morning Message within 2 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property DefaultNewListenerEmail() As String
            Get
                Return ResourceManager.GetString("DefaultNewListenerEmail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to M3AppPassword2499.
        '''</summary>
        Friend ReadOnly Property DefaultPassword() As String
            Get
                Return ResourceManager.GetString("DefaultPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!Doctype html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.hopto.org/css/emails.css&quot;&gt;
        '''    &lt;/head&gt;
        '''    &lt;body&gt;
        '''
        '''	&lt;p&gt;Greetings {0},&lt;/p&gt;
        '''
        '''        &lt;p&gt;Thank you for your blessing of {1:C} for {2}.&lt;/p&gt;
        '''
        '''		&lt;p&gt;Thank You For Your Support.&lt;/p&gt;
        '''
        '''		&lt;p&gt;Be Blessed.&lt;/p&gt;
        '''
        '''		&lt;p class=&quot;center&quot;&gt;&lt;strong&gt;WE LOVE YOU AND AIN&apos;T NOTHING YOU CAN DO ABOUT IT!&lt;/strong&gt;&lt;br&gt;&lt;/p&gt;
        '''
        '''		&lt;hr&gt;
        '''		
        '''		&lt;p&gt;&lt;strong&gt;Elder Bryon K Miller, Pastor&lt;/strong&gt;&lt;br&gt;
        '''		St. Paul Primitive Baptist Church&lt;br&gt;
        '''		Email [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property DefaultReceiptEmail() As String
            Get
                Return ResourceManager.GetString("DefaultReceiptEmail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!Doctype html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.hopto.org/css/emails.css&quot;&gt;
        '''    &lt;/head&gt;
        '''    &lt;body&gt;
        '''        &lt;p&gt;Good Afternoon {0},&lt;/p&gt;
        '''
        '''        &lt;p&gt;&lt;em&gt;Watch all our sermons on &lt;a href=&quot;https://www.youtube.com/channel/UCJ2c3QAAYu2KneiTvjRJEKg/videos&quot;&gt;YouTube&lt;/a&gt; and subscribe for easier access.&lt;/em&gt;&lt;/p&gt;
        '''        &lt;p&gt;Also, give us a follow on &lt;a href=&quot;https://facebook.com/bryon.miller436&quot;&gt;Facebook&lt;/a&gt;, where we host our weekly live streams&lt;/p&gt;
        '''        &lt;p&gt;You may give [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property DefaultSermonEmail() As String
            Get
                Return ResourceManager.GetString("DefaultSermonEmail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to M3App.
        '''</summary>
        Friend ReadOnly Property DefaultUsername() As String
            Get
                Return ResourceManager.GetString("DefaultUsername", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;p&gt;&lt;a href=&quot;{1}&quot;&gt;{0}&lt;/a&gt;&lt;/p&gt;.
        '''</summary>
        Friend ReadOnly Property DriveLinkAttachment() As String
            Get
                Return ResourceManager.GetString("DriveLinkAttachment", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$.
        '''</summary>
        Friend ReadOnly Property EmailRegex() As String
            Get
                Return ResourceManager.GetString("EmailRegex", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property FontOption() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("FontOption", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property HidePasswordIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("HidePasswordIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ItalicOption() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ItalicOption", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Logout() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Logout", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property NewDocumentOption() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("NewDocumentOption", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&amp;])[A-Za-z\d@$!%*?&amp;]{8,}$.
        '''</summary>
        Friend ReadOnly Property PasswordRegex() As String
            Get
                Return ResourceManager.GetString("PasswordRegex", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ShowPasswordIcon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ShowPasswordIcon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property StrikeThruOption() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("StrikeThruOption", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property UnderlineOption() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("UnderlineOption", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace