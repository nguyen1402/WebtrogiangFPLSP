// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.CabinProject.SemesterBlock
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
           [Authorize(Roles = "DirectorOfTraining")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/semesterblock")]
    public partial class SemesterBlock : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
       
    [Inject] private CryptoServices _cryptoServices { get; set; }
    private Guid idBlock { get; set; }
    private Guid idBlockDel { get; set; }
    private Guid idSemesterDel { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private NavigationManager navigationManager { get; set; }
    protected Comfirmation DeleteConfirmation { get; set; }
    protected SemesterBlockAdd semesterBlockAdd { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    [Inject] private ISemesterBlockRepo _semesterBlockRepo { get; set; }
    [Inject] private ISemesterRepo _semesterRepo { get; set; }
    [Inject] private IBlockRepo _blockRepo { get; set; }
    SemesterBlockSearch _semesterBlockSearch = new SemesterBlockSearch();
    List<SemesterBlockDto> _lstSemesterBlockSearch = new List<SemesterBlockDto>();
    List<SemesterDto> semester = new List<SemesterDto>();
    List<BlockDto> lstblock = new List<BlockDto>();
    List<SemesterBlockVM> semesterBlock = new List<SemesterBlockVM>();
    [Parameter] public Guid IdTrain { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await GetTasks();
    }
    private async Task GetTasks()
    {

        try
        {

            semester = await _semesterRepo.GetAll();
            lstblock = await _blockRepo.GetAll();
            var pagingResponse = await _semesterBlockRepo.GetPageList(_semesterBlockSearch);
            _lstSemesterBlockSearch = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
            var lstsemesterBlock = from a in _lstSemesterBlockSearch
                                   join b in semester
                                   on a.IdSemester equals b.Id
                                   join c in lstblock
                                   on a.IdBlock equals c.Id
                                   select new
                                   {
                                       a.IdBlock,
                                       a.IdSemester,
                                       b.NameofSemester,
                                       c.NameOfBlock,
                                       a.StartTime,
                                       a.EndTime,
                                       a.IndexOfSemesterBlock,
                                       a.Status,

                                   };
            semesterBlock = new List<SemesterBlockVM>();
            if (_semesterBlockSearch.Search != null)
            {
                foreach (var item in lstsemesterBlock)
                {
                    SemesterBlockVM vM = new SemesterBlockVM()
                        {
                            IdBlock = item.IdBlock,
                            IdSemester = item.IdSemester,
                            NameofSemester = item.NameofSemester,
                            NameofBlock = item.NameOfBlock,
                            StartTime = item.StartTime,
                            EndTime = item.EndTime,
                            IndexOfSemesterBlock = item.IndexOfSemesterBlock,
                            Status = item.Status
                        };
                    semesterBlock.Add(vM);
                    semesterBlock = semesterBlock.Where(x => x.NameofBlock.Contains(_semesterBlockSearch.Search) || x.NameofSemester.Contains(_semesterBlockSearch.Search)).ToList();
                }
            }
            else
            {
                foreach (var item in lstsemesterBlock)
                {
                    SemesterBlockVM vM = new SemesterBlockVM()
                        {
                            IdBlock = item.IdBlock,
                            IdSemester = item.IdSemester,
                            NameofSemester = item.NameofSemester,
                            NameofBlock = item.NameOfBlock,
                            StartTime = item.StartTime,
                            EndTime = item.EndTime,
                            IndexOfSemesterBlock = item.IndexOfSemesterBlock,
                            Status = item.Status
                        };
                    semesterBlock.Add(vM);
                }
            }


            //foreach (var item in semesterBlock)
            //{
            //    if (((item.EndTime.Day < DateTime.Now.Day) && item.EndTime.Month <= DateTime.Now.Month && item.EndTime.Year <= DateTime.Now.Year || (item.EndTime.Month < DateTime.Now.Month && item.EndTime.Year <= DateTime.Now.Year) || (item.EndTime.Year < DateTime.Now.Year)) && item.Status == 0)
            //    {
            //        var changeStatusCabin = semesterBlock.FirstOrDefault(x => x.IdBlock == item.IdBlock && x.IdSemester == item.IdSemester);
            //        changeStatusCabin.Status = 2;
            //        var check = await _semesterBlockRepo.UpdateSemesterBlock(changeStatusCabin);
            //    }
            //}
            foreach (var item in semesterBlock)
            {
                if (item.Status == 0)
                {
                    item.Checked = true;
                }
                else if (item.Status == 2)
                {
                    item.Checked = false;
                }
            }
            semesterBlock = semesterBlock.OrderByDescending(x => x.EndTime).ToList();
        }
        catch (HttpRequestException ex)
        {
            return;
        }

    }
    private async void Delete(Guid IdBlock, Guid IdSemester)
    {
        idBlockDel = IdBlock;
        idSemesterDel = IdSemester;
        DeleteConfirmation.show();

    }
    private async Task ChangeStatus(Guid idBlock, Guid idSemeester, bool? Checked)
    {

        var changeStatus = semesterBlock.FirstOrDefault(x => x.IdBlock == idBlock && x.IdSemester == idSemeester);
        if (!(bool)Checked && changeStatus != null)
        {
            
            changeStatus.Status = 0;
            await _semesterBlockRepo.UpdateSemesterBlock(changeStatus);
            semesterBlock = semesterBlock.Where(x => x.IdBlock != idBlock && x.IdSemester != idSemeester && x.Status == 0).ToList();
            foreach (var item in semesterBlock)
            {
                item.Status = 2;
                await _semesterBlockRepo.UpdateSemesterBlock(item);
            }
            _toastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
            await GetTasks();
        }
        else
        {
            
            changeStatus.Status = 2;
            await _semesterBlockRepo.UpdateSemesterBlock(changeStatus);
            _toastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
            await GetTasks();
        }


    }
    private void Update(Guid IdBlock, Guid IdSemester)
    {
        string idb = _cryptoServices.Encrypt(IdBlock.ToString()).Replace("/", "sem");
        string ids = _cryptoServices.Encrypt(IdSemester.ToString()).Replace("/", "sem");
        //navigationManager.NavigateTo($"/semesterblock/update/{IdBlock.ToString()}/{IdSemester.ToString()}");
        navigationManager.NavigateTo($"/semesterblock/update/{idb}/{ids}");

    }
    private async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed)
        {
            await _semesterBlockRepo.DeleteSemesterBlock(Convert.ToString(idBlockDel), Convert.ToString(idSemesterDel));
            await GetTasks();
        }

    }

    private async Task SelectedPage(int page)
    {
        _semesterBlockSearch.PageNumber = page;
        await GetTasks();
    }
    public async Task SearchSemester(SemesterBlockSearch semesterBlockSearch)
    {
        _semesterBlockSearch = semesterBlockSearch;
        await GetTasks();
    }
    private void OpenDialog()
    {
        if (semesterBlockAdd != null)
        {
            semesterBlockAdd.show();
        }

    }
    private async Task OnConfirmAdd(bool check)
    {
        if (check)
        {
            await GetTasks();
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
