namespace Ejercicio4;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void resultado_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrEmpty(notaa.Text)
			&& !string.IsNullOrEmpty(notab.Text) 
			&& !string.IsNullOrEmpty(notac.Text) 
			&& !string.IsNullOrEmpty(notad.Text)
			&& !string.IsNullOrEmpty(notae.Text))
		{
			
			var nota1 = Convert.ToDouble(notaa.Text);
			var nota2 = Convert.ToDouble(notab.Text);
			var nota3 = Convert.ToDouble(notac.Text);
			var nota4 = Convert.ToDouble(notad.Text);
			var nota5 = Convert.ToDouble(notae.Text);
			var Result = (nota1 + nota2 + nota3 + nota4 + nota5)/ 5;
			notaFi.Text = Convert.ToString(Result);
		}
		else
		{
			DisplayAlert("Eror","Escribe todas tus notas","Adoptado;)");
		}
    }
}

