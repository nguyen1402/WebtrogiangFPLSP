// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.StudentCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\UpdateStudentCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\UpdateStudentCP.razor"
using FPLSP.Server.Domain.Dtos.StudentCPDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/updatetudentcp/{Id}")]
    public partial class UpdateStudentCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 183 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\UpdateStudentCP.razor"
       
    private StudentCPDtos student;
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    IStudentCPApiClient _iStudentCPApiClient { get; set; }

    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }

    [Parameter]

    public string Id { get; set; }
    public string path { get; set; }
    public string imageurl { get; set; }



    public IReadOnlyList<IBrowserFile> selectedFiles;



    protected async override Task OnInitializedAsync()
    {
        student = await _iStudentCPApiClient.GetStudentById(Guid.Parse(Id));
        student.StudentCode = student.StudentCode;
        student.StudentName = student.StudentName;
        student.Gender = student.Gender;
        student.DateOfBirth = student.DateOfBirth;
        student.Email = student.Email;
        student.Password = student.Password;
        student.PhoneNumber = student.PhoneNumber;
        student.Address = student.Address;
        student.IdentityCardNumber = student.IdentityCardNumber;
        student.IssuedOn = student.IssuedOn;
        student.Ethnic = student.Ethnic;
        student.ImageUrl = student.ImageUrl;
        student.Description = student.Description;
        student.FathersName = student.FathersName;
        student.MotherName = student.MotherName;
        student.HomeTown = student.HomeTown;
        student.Status = student.Status;

    }
    private async Task Update()
    {

        ShowAuthError = false;
        var result = await _iStudentCPApiClient.UpdateStudentCP(student);

        if (result != 1)
        {
            Error = "Lỗi";
            ShowAuthError = true;
            Navigation.NavigateTo("/createstudent");
        }
        else
        {
            if (imageurl != null)
            {
                foreach (var file in selectedFiles)
                {
                    Stream stream = file.OpenReadStream();
                    path = $"C:/Users/nguye/source/repos/FPLSP/FPLSP/wwwroot/Image/StudentCP/{file.Name}";
                    FileStream fs = File.Create(path);
                    await stream.CopyToAsync(fs);
                    stream.Close();
                    fs.Close();
                }
            }
            Navigation.NavigateTo("/MainStudentsCP");
            this.StateHasChanged();

        }
    }
    private async void LoadFiles(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        foreach (var file in selectedFiles)
        {
            imageurl = file.Name;
        }
        student.ImageUrl = imageurl;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591