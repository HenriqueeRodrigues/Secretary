//// <copyright file="BanksPage.razor.cs" company="Adimax Pet">
//// Copyright (c) Adimax Pet. All rights reserved.
//// </copyright>

//namespace AdimaxPro.Presentation.WEB.General.Pages
//{
//    using System.Collections.Generic;
//    using System.Threading.Tasks;
//    using AdimaxPro.Core.API.Client;
//    using AdimaxPro.Global.Interfaces.Models.DTOs;
//    using AdimaxPro.Global.Models.DTOs;
//    using AdimaxPro.Presentation.WEB.Shared.Pages.Base;
//    using AdimaxPro.Presentation.WEB.Shared.State.Loading;
//    using Microsoft.AspNetCore.Components;

//    public partial class BanksPage : AdimaxSearchEditorPageBase<BankSummaryDTO, BankDTO>
//    {
//        [Inject]
//        public IBankClient BankClient { get; set; }

//        public IEnumerable<BankSummaryDTO> BankSummaries { get; internal set; }

//        public override async Task Search()
//        {
//            var result = await this.BankClient.GetSummaryAsync(new BankSummariesGetRequestDTO() { Name = this.FilterValue });
//            this.Summaries = result.BankSummaries;
//        }

//        public override async Task<BankDTO> GetDataDtoBySummaryDto(BankSummaryDTO summaryDTO)
//        {
//            try
//            {
//                await this.Mediator.Send(new LoadingState.ShowLoadingAction());
//                var result = await this.BankClient.GetAsync(new BankGetRequestDTO() { Id = summaryDTO.Id });
//                return result.Bank;
//            }
//            finally
//            {
//                await this.Mediator.Send(new LoadingState.HideLoadingAction());
//            }
//        }

//        public override async Task<IResponseDTO> InsertData(BankDTO dataDTO)
//        {
//            return await this.BankClient.InsertAsync(new BankInsertRequestDTO()
//            {
//                Bank = dataDTO,
//            });
//        }

//        public override async Task<IResponseDTO> UpdateData(BankDTO dataDTO)
//        {
//            return await this.BankClient.UpdateAsync(new BankUpdateRequestDTO()
//            {
//                Bank = dataDTO,
//            });
//        }

//        public override async Task<bool> DeleteData(BankSummaryDTO summaryDTO)
//        {
//            var result = await this.BankClient.DeleteAsync(new BankDeleteRequestDTO()
//            {
//                Id = summaryDTO.Id,
//            });

//            return !result.ValidationResult.IsInvalid;
//        }

//        public override Task<IEnumerable<string>> CustomDataValidation(BankDTO dto)
//        {
//            var messages = new List<string>();

//            if (string.IsNullOrWhiteSpace(dto.Name))
//            {
//                messages.Add(this.Localizer["Preencher o campo Nome do Banco."]);
//            }

//            if (string.IsNullOrWhiteSpace(dto.Number))
//            {
//                messages.Add(this.Localizer["Preencher o campo Número do Banco."]);
//            }

//            return Task.FromResult<IEnumerable<string>>(messages);
//        }

//        protected override async Task OnInitializedAsync()
//        {
//            try
//            {
//                await this.Mediator.Send(new LoadingState.ShowLoadingAction());

//                this.Title = this.Localizer["Cadastro de Bancos"];
//                this.PagePath = this.Localizer["Cadastros > Gerais > Bancos"];
//                this.BusinessEntityName = this.Localizer["Banco"];

//                await this.Search();
//            }
//            finally
//            {
//                await this.Mediator.Send(new LoadingState.HideLoadingAction());
//            }
//        }
//    }
//}
