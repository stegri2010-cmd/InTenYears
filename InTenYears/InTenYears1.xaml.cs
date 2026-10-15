

namespace InTenYears;

public partial class InTenYears1 : ContentPage
{
	public InTenYears1()
	{
		InitializeComponent();
        lblResult.Text = "---Well---";

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        int age = 10+int.Parse(entryAge.Text);
        lblResult.Text = "In ten years from now " + entryName.Text + " wil be " + age;
    }
}