using Lease.Common.Shared;
using Lease.Web.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lease.Web.Pages
{
    public partial class LeaseAdd
    {

        [Inject]
        public IApiService ApiService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            States = await ApiService.GetStates();
            Terms = await ApiService.GetTerms();

            await base.OnInitializedAsync();
        }

        public IEnumerable<State> States { get; set; }
        public IEnumerable<Term> Terms { get; set; }
        public LeaseItem Lease { get; set; } = new LeaseItem();

        public async Task OnFormSubmit_Valid()
        {
            var addedLeaseItem = await ApiService.AddLease(Lease);
            if (addedLeaseItem == null || addedLeaseItem.LeaseId <= 0)
            {
                DisplayMessage = "Error while processing new lease.";
                DisplayMessageClass = "failed";
            }
            else
            {
                DisplayMessage = $"New Lease has started with identifier {addedLeaseItem.LeaseId}.";
                DisplayMessageClass = "success";
                Lease = new LeaseItem();
            }
            FormAlert.Show();
        }

        public void OnFormSubmit_Invalid()
        {
            DisplayMessage = $"Lease form have invalid data.";
            DisplayMessageClass = "failed";
            FormAlert.Show();
        }

        public void RedirectToHome()
        {
            NavigationManager.NavigateTo("/lease", forceLoad: true);
        }
    }
}
