Public Class ConfigForm

    Private UC As Plugininterface.Entry
    Dim PluginMain As UCCNCplugin

    Public Sub New(CallerPluginMain As UCCNCplugin)
        Me.UC = CallerPluginMain.UC
        Me.PluginMain = CallerPluginMain
        InitializeComponent()
        Lbl_btnCode.Text = My.Settings.OpenCode

        Try
            nudCodeSet.Value = My.Settings.OpenCode
        Catch ex As Exception
            nudCodeSet.Value = 1000
        End Try

    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnSetCode_Click(sender As Object, e As EventArgs) Handles btnSetCode.Click
        My.Settings.OpenCode = nudCodeSet.Value
        My.Settings.Save()

        Lbl_btnCode.Text = My.Settings.OpenCode
    End Sub
End Class