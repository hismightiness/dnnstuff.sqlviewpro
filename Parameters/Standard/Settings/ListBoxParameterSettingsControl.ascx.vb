'***************************************************************************/
'* ListBoxParameterSettings.ascx.vb
'*
'* Copyright (c) 2004 by DNNStuff.
'* All rights reserved.
'*
'* Date:        August 9, 2004
'* Author:      Richard Edwards
'* Description: ListBox Parameter Settings Handler
'*************/

Imports System.Configuration
Imports System.Xml.Serialization
Imports DNNStuff.SQLViewPro.Controls
Imports DNNStuff.SQLViewPro.Serialization

Namespace DNNStuff.SQLViewPro.StandardParameters

    Partial Public Class ListBoxParameterSettingsControl
        Inherits ParameterSettingsControlBase

        Protected WithEvents cpConnection As Controls.ConnectionPickerControl

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub

        Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
            'CODEGEN: This method call is required by the Web Form Designer
            'Do not modify it using the code editor.
            InitializeComponent()

            QueryStringInitialize()
        End Sub

#End Region

#Region " Page"
        Public Property ReportSetId() As Integer = -1
        Public Property ParameterId() As Integer = -1

        Private Sub QueryStringInitialize()
            ' initialize
            If Not Request.QueryString("ReportSetId") Is Nothing Then
                ReportSetId = Int32.Parse(Request.QueryString("ReportSetId").ToString)
            Else
                ReportSetId = -1
            End If

            If Not Request.QueryString("ParameterId") Is Nothing Then
                ParameterId = Int32.Parse(Request.QueryString("ParameterId").ToString)
            Else
                ParameterId = -1
            End If

        End Sub
#End Region

#Region " Base Method Implementations"
        Protected Overrides ReadOnly Property LocalResourceFile() As String
            Get
                Return ResolveUrl("App_LocalResources/ListBoxParameterSettingsControl")
            End Get
        End Property

        Public Overrides Function UpdateSettings() As String

            Dim obj As ListBoxParameterSettings = New ListBoxParameterSettings
            With obj
                .Default = txtDefault.Text
                .List = txtList.Text
                .Command = txtCommand.Text
                .CommandCacheTimeout = Convert.ToInt32(txtCommandCacheTimeout.Text)
                .ConnectionId = cpConnection.ConnectionId
                .AutoPostback = chkAutoPostback.Checked
                .MultiSelect = chkMultiSelect.Checked
                If Not Int32.TryParse(txtListBoxSize.Text, .MultiSelectSize) Then .MultiSelectSize = 5
            End With

            Return SerializeObject(obj, GetType(ListBoxParameterSettings))

        End Function

        Public Overrides Sub LoadSettings(ByVal settings As String)
            Dim obj As New ListBoxParameterSettings
            If settings IsNot Nothing Then
                obj = DirectCast(DeserializeObject(settings, GetType(ListBoxParameterSettings)), ListBoxParameterSettings)
            End If
            With obj
                txtDefault.Text = .Default
                txtList.Text = .List
                txtCommand.Text = .Command
                txtCommandCacheTimeout.Text = .CommandCacheTimeout.ToString()
                cpConnection.ConnectionId = .ConnectionId
                chkAutoPostback.Checked = .AutoPostback
                chkMultiSelect.Checked = .MultiSelect
                txtListBoxSize.Text = .MultiSelectSize
            End With
        End Sub

#End Region

#Region " Validation"
        Private Sub vldCommand_ServerValidate(ByVal source As System.Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles vldCommand.ServerValidate

            Dim msg As String = ""
            args.IsValid = Services.Data.Query.IsQueryValid(txtCommand.Text, ConnectionController.GetConnectionString(cpConnection.ConnectionId, ReportSetId), msg)
            vldCommand.ErrorMessage = msg

        End Sub


        Private Sub cmdQueryTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdQueryTest.Click
            Dim msg As String = ""
            Dim isValid As Boolean = Services.Data.Query.IsQueryValid(txtCommand.Text, ConnectionController.GetConnectionString(cpConnection.ConnectionId, ReportSetId), msg)

            lblQueryTestResults.Text = msg
            lblQueryTestResults.CssClass = "NormalGreen"
            If Not isValid Then lblQueryTestResults.CssClass = "NormalRed"

        End Sub
#End Region

    End Class

End Namespace