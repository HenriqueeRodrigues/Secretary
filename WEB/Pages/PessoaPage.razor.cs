using Blazored.Modal;
using Blazored.Modal.Services;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Model.Pessoa;
using Model.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WEB.Shared;

namespace WEB.Pages
{
    public partial class PessoaPage : SecretaryPagebase
    {


        [Inject]
        public HttpClient Http { get; set; }

        public ICollection<PessoaViewModel> Pessoas { get; set; }

        [Inject]
        public IStringLocalizer<Resources> Localizer { get; set; }

        [Inject]
        public NavigationManager UriHelper { get; set; }

        [CascadingParameter]
        public IModalService Modal { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetData();
        }

        private async Task GetData()
        {

            var response = await Http.GetAsync("Pessoas");
            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            { throw new ApplicationException(content); }

            var pessoas = JsonSerializer.Deserialize<List<PessoaViewModel>>(content);

        }

        async Task Edit(int productId = 0)
        {

             await GetData();
            //var parameters = new ModalParameters();
            //parameters.Add(nameof(CustomerEditPage.CustomerId), productId);

            //var messageForm = Modal.Show<CustomerEditPage>(productId > 0 ? Localizer["Edit customer"] : Localizer["New customer"], parameters);

            //var result = await messageForm.Result;

            //if (!result.Cancelled)
            //{
            //    await PopupHelper.ShowInformationMessage(Modal, "Alteração realizada com sucesso.");
            //    await GetData();
            //}
        }

        async Task RemoveCustomer()
        {
            await GetData();

            //var customersIds = Pessoas.Where(x => x.IsSelected).Select(x => x.CustomerId);
            //if (!customersIds.Any())
            //{
            //    await PopupHelper.ShowInformationMessage(Modal, "Nenhum Cliente selecionado.");
            //    return;
            //}

            //if (await PopupHelper.ShowConfirmationMessage(Modal, $"Tem certeza que deseja remover os Cliente(s) { customersIds.Count() } selecionado(s)?"))
            //{
            //    MakeBusy();

            //    foreach (var customerId in customersIds)
            //    {
            //        try
            //        {
            //            var httpResponse = await Http.DeleteAsync($"Customer?CustomerId={customerId}");
            //            httpResponse.EnsureSuccessStatusCode();
            //            var deleteResponse = await httpResponse.Content.ReadFromJsonAsync<CustomerDeleteResponse>();
            //            if (deleteResponse.Success)
            //            {
            //                MakeAvailable();
            //                await PopupHelper.ShowInformationMessage(Modal, "Clientes removidos com sucesso.");
            //                await GetData();
            //            }
            //            else
            //            {
            //                ErrorMessage = new ExceptionMessageHandler(Localizer).GetExceptionHandledMessage(deleteResponse);
            //                MakeAvailable();
            //            }
            //        }
            //        catch (AccessTokenNotAvailableException exception)
            //        {
            //            exception.Redirect();
            //        }
            //        catch (Exception e)
            //        {
            //            ErrorMessage = e.Message;
            //            MakeAvailable();
            //        }
            //    }
        }
    }
    
}
