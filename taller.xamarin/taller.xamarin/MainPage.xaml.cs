using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using taller.xamarin.Modelo;
using Xamarin.Forms.Xaml;

namespace taller.xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            cargarpublicaciones();
        }

        private void cargarpublicaciones()
        {
            HttpClient Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("http://localhost:65397/");
            var request = Cliente.GetAsync("api/publicaciones").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<publicacion>>(responseJson);
                
            }
            
            
        }
	}
}
