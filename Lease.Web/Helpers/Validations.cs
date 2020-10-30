using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lease.Web.Helpers
{
    public class Validations : ComponentBase
    {
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }
        public static void ValidateSelectInt(ValidatorEventArgs e)
        {
            var selectedValue = Convert.ToInt32(e.Value);
            e.Status = selectedValue > 0 ? ValidationStatus.Success : ValidationStatus.Error;
        }

        public Alert FormAlert;
        public string DisplayMessage { get; set; }
        public string DisplayMessageClass { get; set; }

        public void CloseFormAlert()
        {
            FormAlert?.Hide();
        }
    }
}
