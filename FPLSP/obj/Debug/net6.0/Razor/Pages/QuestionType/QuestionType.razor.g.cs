#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5bcd57b4e234d186f3b702b8e8678b53b1427ac"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.QuestionType
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using FPLSP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using FPLSP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
using FPLSP.Components.QuestionTypeUPComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
using FPLSP.Server.Domain.Dtos.QuestionType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuestionType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/questiontype")]
    public partial class QuestionType : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
 if (_lstQuestionTypeDto == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(0);
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>Danh sách báo cáo</h3>");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "d-flex justify-content-end mb-1");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-flex justify-content-end mb-1");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-9");
            __builder.OpenComponent<global::FPLSP.Components.QuestionTypeUPComponents.FormSearchQuestionType>(8);
            __builder.AddAttribute(9, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.QuestionType.QuestionTypeSearch>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.QuestionType.QuestionTypeSearch>(this, 
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
                                                  SearchQuestionTypeUP

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, "<div class=\"col-lg-2 pl-6\"><div class=\"col-2 pr-16\"><a type=\"button\" class=\"btn btn-primary\" href=\"/questiontype/add\"><i class=\"fa-solid fa-plus\"></i> Add</a></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row mt-4");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "table-responsive ");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table table-light table-bordered");
            __builder.AddMarkupContent(19, @"<thead><tr><th class=""col-lg-2"">
                            Tên câu hỏi
                        </th>
                        <th>
                            Loại câu hỏi
                        </th>
                        <th class=""col-lg-15"">Tính năng</th></tr></thead>
                ");
            __builder.OpenElement(20, "tbody");
#nullable restore
#line 45 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
                     foreach (var item in _lstQuestionTypeDto)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "tr");
            __builder.OpenElement(22, "td");
#nullable restore
#line (48,34)-(48,55) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
__builder.AddContent(23, item.QuestionTypeName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
#nullable restore
#line (49,34)-(49,51) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
__builder.AddContent(26, item.QuestionForm);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "d-flex justify-content-center mb-2");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "pr-1");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "btn btn-outline-primary");
            __builder.AddAttribute(35, "href", "/questiontype/update/" + (
#nullable restore
#line 53 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
                                                                                                       item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.AddMarkupContent(38, "<div class=\"d-flex justify-content-center mb-2\"><div class=\"p-2\"><a type=\"button\" class=\"btn btn-primary\" href=\"/questiontype/add\"><i class=\"fa-solid fa-plus\"></i> Add</a></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card-footer text-muted");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row mt-3");
            __builder.OpenElement(44, "span");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(45);
            __builder.AddAttribute(46, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
                                           MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
                                                             2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
                                                                              SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuestionType\QuestionType.razor"
 
    [Inject] IQuestionTypeRepo _questionTypeRepo { get; set; }
    List<QuestionTypeDto> _lstQuestionTypeDto { get; set; } = new List<QuestionTypeDto>();
    QuestionTypeSearch _questionTypeSearch { get; set; } = new QuestionTypeSearch();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    private PagingParameters pagingParameters = new PagingParameters();
    public MetaData MetaData { get; set; } = new MetaData();
    public string Error { get; set; }
    int stt;
    protected override async Task OnInitializedAsync()
    {

        await GetTasks();
    }
    private async Task GetTasks()
    {
        stt = 0;

        try
        {
            var pagingResponse = await _questionTypeRepo.GetPageList(_questionTypeSearch);
            _lstQuestionTypeDto = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }
    private async Task SelectedPage(int page)
    {
        _questionTypeSearch.PageNumber = page;
        await GetTasks();
    }
    public async Task SearchQuestionTypeUP(QuestionTypeSearch questionTypeSearch)
    {

        _questionTypeSearch = questionTypeSearch;
        await GetTasks();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
