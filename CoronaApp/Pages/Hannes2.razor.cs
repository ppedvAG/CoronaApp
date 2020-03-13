using CoronaApp.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaApp.Pages
{

    public partial class Hannes2
    {

        [Inject]
        public ToDoVM ToDo { get; set; }


        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
        void tuwas()
        {

        }
    }
}
