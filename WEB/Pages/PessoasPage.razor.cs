using WEB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Text.Json;
using Model.Pessoa;

namespace WEB.Pages
{


    public partial class PessoasPage : SecretaryPagebase
    {
        [Inject]
        public HttpClient Http { get; set; }

        [Parameter]
        public EventCallback PopupCloseEvent { get; set; }

        protected override async Task OnInitializedAsync()
        {

            var response = await Http.GetAsync("Pessoas");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            { throw new ApplicationException(content); }

            var pessoas = JsonSerializer.Deserialize<List<PessoaViewModel>>(content);



            //forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }


        public int Calculalar()
        {
            var initialize = OnInitializedAsync();
            return 1;
        }

        private void Close()
        {
            Console.WriteLine("henrique");
        }
    }
}
