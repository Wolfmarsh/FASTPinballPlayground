Class MainWindow
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        ChangeMainContent(New WelcomeControl)
    End Sub

    Private Sub ChangeMainContent(ByVal NewContent As Object)
        dp_content.Children.Clear()
        dp_content.Children.Add(NewContent)
        dp_content.LastChildFill = True
    End Sub

    Private Sub btn_hardware_Click(sender As Object, e As RoutedEventArgs) Handles btn_hardware.Click
        ChangeMainContent(New HardwareControl)
    End Sub

    Private Sub btn_terminal_Click(sender As Object, e As RoutedEventArgs) Handles btn_terminal.Click
        ChangeMainContent(New TerminalControl)
    End Sub

    Private Sub btn_led_Click(sender As Object, e As RoutedEventArgs) Handles btn_led.Click
        ChangeMainContent(New LEDControl)
    End Sub
End Class
