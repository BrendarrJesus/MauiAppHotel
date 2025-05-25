namespace MauiAppHotel.Views;

public partial class FinalizadaHospedagem : ContentPage
{
	public FinalizadaHospedagem()
	{
		InitializeComponent();
	}

    public void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
            Navigation.PushAsync(new ContratacaoHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    }
