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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlockAdd.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlockAdd.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlockAdd.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

#line default
#line hidden
#nullable disable
    public partial class SemesterBlockAdd : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlockAdd.razor"
       
    SemesterBlockVM semesterBlockVM = new SemesterBlockVM();
    SemesterVM semesterVM = new SemesterVM();
    BlockVM blockVM = new BlockVM();
    [Inject] private ISemesterBlockRepo _semesterBlockRepo { get; set; }
    [Inject] private ISemesterRepo _semesterRepo { get; set; }
    [Inject] private IBlockRepo _blockRepo { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private NavigationManager navigationManager { get; set; }
    public bool ShowConfirmation { get; set; }
    [Parameter]
    public EventCallback<bool> OnAdd { get; set; }

    protected async Task OnConfirmationChange(bool value)
    {
        ShowConfirmation = false;
        await OnAdd.InvokeAsync(value);

    }
    private async void Add()
    {


        var semester = await _semesterRepo.GetAll();
        var lstblock = await _blockRepo.GetAll();
        var semblock = await _semesterBlockRepo.GetAll();
        var lstsemesterBlock = (from a in semblock
                                join b in semester
                                on a.IdSemester equals b.Id
                                join c in lstblock
                                on a.IdBlock equals c.Id
                                select new
                                {
                                    b.NameofSemester,
                                    c.NameOfBlock,
                                    a.Status

                                }).ToList();
        var count = lstsemesterBlock.Where(x => x.NameofSemester == semesterBlockVM.NameofSemester && x.NameOfBlock == semesterBlockVM.NameofBlock && x.Status != 1 ).Count();
        if (count > 0)
        {
            _toastService.ShowError($"K?? {semesterBlockVM.NameofSemester} - Block {semesterBlockVM.NameofBlock} ???? t???n t???i");
            semesterBlockVM.NameofSemester = "";
            semesterBlockVM.NameofBlock = "";
            semesterBlockVM.StartTime = DateTime.Now;
            semesterBlockVM.EndTime = DateTime.Now;
            return;
        }
        //if (semesterBlockVM.NameofSemester == "" || semesterBlockVM.NameofBlock == "")
        //{
        //    if (semesterBlockVM.NameofSemester == "" || semesterBlockVM.NameofBlock == "")
        //    {
        //        _toastService.ShowError("Kh??ng ???????c ????? tr???ng t??n k??");
        //    }
        //    if (semesterBlockVM.NameofBlock == "")
        //    {
        //        _toastService.ShowError("Kh??ng ???????c ????? tr???ng t??n block");
        //    }
        //    return;
        //}
        //if (semesterBlockVM.StartTime > semesterBlockVM.EndTime)
        //{
        //    _toastService.ShowError("Ng??y b???t ?????u kh??ng ???????c s???m h??n ng??y k???t th??c");
        //    return;
        //}
            semesterVM.NameofSemester = semesterBlockVM.NameofSemester;
            blockVM.NameOfBlock = semesterBlockVM.NameofBlock;
            semesterVM.Id = Guid.NewGuid();
            blockVM.Id = Guid.NewGuid();
            await _semesterRepo.CreateSemester(semesterVM);
            await _blockRepo.CreateBlock(blockVM);
            semesterBlockVM.IdSemester = semesterVM.Id;
            semesterBlockVM.IdBlock = blockVM.Id;
            var check = await _semesterBlockRepo.CreateSemesterBlock(semesterBlockVM);
            if (check)
            {
                semesterBlockVM.NameofSemester = "";
                semesterBlockVM.NameofBlock = "";
                semesterBlockVM.StartTime = DateTime.Now;
                semesterBlockVM.EndTime = DateTime.Now;
                _toastService.ShowSuccess("Th??m m???i th??nh c??ng");
                await OnConfirmationChange(true);
            }

        }
        public void show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
