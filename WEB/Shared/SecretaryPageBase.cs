using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Shared
{
    public partial class SecretaryPagebase : ComponentBase
    {
        public bool IsBusy { get; set; }

        public SecretaryPagebase()
        {
        }

        //public void MakeBusy()
        //{
        //    IsBusy = true;
        //    StateHasChanged();
        //}

        //public void MakeAvailable()
        //{
        //    IsBusy = false;
        //    StateHasChanged();
        //}
    }
}
