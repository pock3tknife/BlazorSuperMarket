#pragma checksum "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad9c7f1a6c4945a75f51737981bb36eb2452778"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
    public partial class TodayTransactionsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
 if (transactions != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, @"<thead><tr><th>Cashier Name</th>
                <th>Product Name</th>
                <th>Date Time</th>
                <th>Qty Before</th>
                <th>Qty Sold</th>
                <th>Qty After</th>
                <th>Sold Amt</th></tr></thead>
        ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 18 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
             foreach(var tran in transactions)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
#nullable restore
#line 21 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
__builder.AddContent(6, tran.CashierName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
#nullable restore
#line 22 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
__builder.AddContent(9, tran.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 23 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
__builder.AddContent(12, tran.TimeStamp.ToString("MM/dd hh:mm"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 24 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
__builder.AddContent(15, tran.BeforeQty);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 25 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
__builder.AddContent(18, tran.SoldQty);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 26 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
__builder.AddContent(21, tran.BeforeQty - tran.SoldQty);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 27 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
__builder.AddContent(24, string.Format("{0:c}", tran.SoldQty * tran.Price));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Controls\TodayTransactionsComponent.razor"
       
    private IEnumerable<Transaction> transactions;

    public void LoadTransactions(string cashierName)
    {
        transactions = GetTodayTransactionsUseCase.Execute(cashierName);
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetTodayTransactionsUseCase GetTodayTransactionsUseCase { get; set; }
    }
}
#pragma warning restore 1591
