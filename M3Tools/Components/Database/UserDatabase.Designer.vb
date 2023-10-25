﻿Namespace Database
    Partial Class UserDatabase
        Inherits System.ComponentModel.Component

        <System.Diagnostics.DebuggerNonUserCode()>
        Public Sub New(ByVal container As System.ComponentModel.IContainer)
            MyClass.New()

            'Required for Windows.Forms Class Composition Designer support
            If (container IsNot Nothing) Then
                container.Add(Me)
            End If

        End Sub

        <System.Diagnostics.DebuggerNonUserCode()>
        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

        End Sub

		'Component overrides dispose to clean up the component list.
		<System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Try
				If disposing AndAlso components IsNot Nothing Then
					components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		'Required by the Component Designer
		Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dbConnection = New SPPBC.M3Tools.Database.Database(Me.components)

        End Sub

        Friend WithEvents dbConnection As Database
    End Class
End Namespace