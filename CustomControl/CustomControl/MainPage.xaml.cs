namespace CustomControl;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void btnBold_Clicked(System.Object sender, System.EventArgs e)
    {
        if (sender == btnBold)
            cutomeditor.FontAttributes = FontAttributes.Bold;
        else if (sender == btnitalic)
            cutomeditor.FontAttributes = FontAttributes.Italic;
        else if (sender == btnLowerCase)
            cutomeditor.TextTransform = TextTransform.Lowercase;
        else
            cutomeditor.TextTransform = TextTransform.Uppercase;
    }
}


