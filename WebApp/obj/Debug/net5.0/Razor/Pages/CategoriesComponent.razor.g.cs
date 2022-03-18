#pragma checksum "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dc80631029719575db53af012bdbe4168f7cbc9"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
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
#nullable restore
#line 2 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class CategoriesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Manage Categories</h3>\r\n<br>");
#nullable restore
#line 10 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
 if (categories != null)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Name</th>\r\n                <th>Description</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 22 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
             foreach (var category in categories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 25 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
__builder.AddContent(7, category.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 26 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
__builder.AddContent(10, category.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                                          () => EditCategory(category)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-link");
            __builder.AddContent(17, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                                          () => DeleteCategory(category.CategoryId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-link");
            __builder.AddContent(23, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<br>\r\n");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
                                OnClickAddCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddContent(29, "Add Category");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\rLawrence\Downloads\frankLiu projects\SupermarketManagement\WebApp\Pages\CategoriesComponent.razor"
       

    private List<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        LoadCategories();
    }

    private void OnClickAddCategory()
    {
        NavigationManager.NavigateTo("/addcategory");
    }

    private void EditCategory(Category category)
    {
        NavigationManager.NavigateTo($"/editcategory/{category.CategoryId}");
    }

    private void DeleteCategory(int categoryId)
    {
        DeleteCategoryUseCase.Delete(categoryId);
        LoadCategories();
    }

    private void LoadCategories()
    {
        categories = ViewCategoryUseCase.Execute()?.ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IDeleteCategoryUseCase DeleteCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewCategoriesUseCase ViewCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
