namespace InTenYears;

public partial class InTenYearsSlider : ContentPage
{
    private int age;

    public InTenYearsSlider()
	{
		InitializeComponent();
        lblResult.Text = "---Well---";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        age =(int)sliderAge.Value;
        entryAge.Text = age.ToString();
        
    }

    private void sliderAge_DragCompleted(object sender, EventArgs e)
    {
        lblResult.Text = "In ten years from now " + entryName.Text + " wil be " + (age+10);
    }
}