using Microsoft.AspNetCore.SignalR.Client;
using Xamarin.Forms;

namespace AotTests
{
	public partial class MainPage : ContentPage
	{
	    private HubConnection _hubConnection;

        public MainPage()
		{
			InitializeComponent();
		    _hubConnection = new HubConnectionBuilder()
		        .Build();
        }
	}
}
