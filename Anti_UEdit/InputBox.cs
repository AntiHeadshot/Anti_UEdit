using System.ComponentModel;
using System.Windows.Controls;
using System.Windows;

namespace Anti_UEdit;

public class InputBox
{
    private readonly Window _window;
    private readonly TextBox _input;


    public InputBox(string content, string title)
    {
        _window = new Window
        {
            Height = 500,
            Width = 300,
            Title = title
        };
        _window.Closing += WindowClosing;

        StackPanel sp = new();
        _window.Content = sp;

        TextBlock text = new()
        {
            TextWrapping = TextWrapping.Wrap,
            Background = null,
            HorizontalAlignment = HorizontalAlignment.Center,
            Text = content
        };
        sp.Children.Add(text);

        _input = new TextBox
        {
            HorizontalAlignment = HorizontalAlignment.Center,
            MinWidth = 200
        };
        sp.Children.Add(_input);

        Button submitButton = new()
        {
            Width = 70,
            Height = 30,
            Content = "Ok",
            HorizontalAlignment = HorizontalAlignment.Center
        };
        submitButton.Click += SubmitButtonClick;
        sp.Children.Add(submitButton);

    }

    private void WindowClosing(object? sender, CancelEventArgs e)
    {
        _window.DialogResult ??= false;
    }

    void SubmitButtonClick(object sender, RoutedEventArgs e)
    {
        _window.Close();
        _window.DialogResult = true;
    }

    public bool? ShowDialog(out string value)
    {
        bool? result = _window.ShowDialog();
        value = _input.Text;
        return result;
    }
}