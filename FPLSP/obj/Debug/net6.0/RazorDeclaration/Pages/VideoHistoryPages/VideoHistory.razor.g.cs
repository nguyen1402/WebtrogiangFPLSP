// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.VideoHistoryPages
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
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using FPLSP.Components;

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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
using FPLSP.Components.VideoHistory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
using FPLSP.Server.Infrastructure.ViewModels.VideoHistoryVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
           [Authorize(Roles = "Student")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/videoHistory/{studentID}/{subjectid}/{idLesson}")]
    public partial class VideoHistory : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\VideoHistoryPages\VideoHistory.razor"
       
    [Parameter]
    public string studentID { get; set; }
    [Parameter]
    public string subjectid { get; set; }
    [Parameter]
    public string idLesson { get; set; }
    [Inject] private IVideoHistoryRepo _VideoHistoryRepo { get; set; }
    [Inject] public NavigationManager navigationManager { get; set; }
    [Inject] private IToastService _toastService { get; set; }

    public MetaData MetaData { get; set; } = new MetaData();

    private List<VideoHistoryDto> _lstVideoHistorys = new List<VideoHistoryDto>();

    private List<VideoHistoryDto> _removeReport = new List<VideoHistoryDto>();

    private VideoHistoryListSearch _VideoHistorySearch = new VideoHistoryListSearch();

    private bool Check { get; set; }

    protected Comfirmation DeleteConfirmation { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetTasks();
    }

    public async Task SearchVideoHistory(VideoHistoryListSearch VideoHistorySearch)
    {
        _VideoHistorySearch = VideoHistorySearch;
        await GetTasks();
    }

    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _VideoHistoryRepo.GetListLink(Guid.Parse(studentID), Guid.Parse(idLesson), _VideoHistorySearch);
            _lstVideoHistorys = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            _toastService.ShowError("???? x???y ra l???i, th??? l???i sau");
        }
    }
    void CheckAllExpense(object checkValue)
    {
        if (Convert.ToBoolean(checkValue) == false)
        {
            _lstVideoHistorys.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lstVideoHistorys.ToList().ForEach(e => e.IsChecked = true);
        }
    }

    void CheckManual(Guid st, Guid lessonct, bool check)
    {
        if (check == true)
        {
            foreach (var x in _lstVideoHistorys.Where(c => c.IdStuden == st && c.IdLessonConten == lessonct))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstVideoHistorys.Where(c => c.IdStuden == st && c.IdLessonConten == lessonct))
            {
                x.IsChecked = true;
            }
        }
    }
    void DeleteAll()
    {
        _removeReport = _lstVideoHistorys.Where(c => c.IsChecked == true).ToList();
        DeleteConfirmation.show();
    }
    private async Task SelectedPage(int page)
    {
        Check = false;
        _VideoHistorySearch.PageNumber = page;
        await GetTasks();
    }

    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed && _removeReport != null)
        {
            var result = await _VideoHistoryRepo.UpdateListVideo(_removeReport);
            if (result)
            {
                if (_removeReport.Count > 0)
                {
                    _toastService.ShowSuccess($"X??a {_removeReport.Count} video ???? l??u th??nh c??ng");
                    await GetTasks();
                }
                else
                {
                    _toastService.ShowError($"B???n ch??a ch???n video mu???n x??a");
                    await GetTasks();
                }
            }
            else
            {
                _toastService.ShowError("X??a th???t b???i");

                await GetTasks();
            }
        }
        _removeReport = null;
        Check = false;
    }

    private string cutidvideo(string url)
    {
        if (url == null)
        {
            return null;
        }
        var videoID = url.Replace("https://www.youtube.com/embed/", "");
        videoID = videoID.Replace("https://www.youtube.com/watch?v=", "");
        videoID = videoID.Replace("https://youtu.be/", "");
        videoID = videoID.Substring(0, 11);

        return $"https://www.youtube.com/embed/{videoID}";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
