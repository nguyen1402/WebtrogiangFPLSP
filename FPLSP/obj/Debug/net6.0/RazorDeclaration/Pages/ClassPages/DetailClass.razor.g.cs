// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ClassPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using ClosedXML.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Data.FPLSPDbContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Domain.Entities.UsesParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using iTextSharp.text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
using iTextSharp.text.pdf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
           [Authorize(Roles = "Student")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout2))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/detailclass/{GetId}/{idUser}")]
    public partial class DetailClass : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 271 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\DetailClass.razor"
       

    private string url = null;
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    [Parameter]
    public string GetId { get; set; }
    [Parameter]
    public string idUser { get; set; }
    private int encounter;
    [Inject] IToastService _toast { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }
    [Inject] public ITaskRepositories<ClassUPViewModel> _taskRepositories { get; set; }
    [Inject] IWebHostEnvironment env { get; set; }
    private CreateClassVM _classUp = new CreateClassVM();
    private SubjectUP _SubjectUP;
    private List<SubjectDto> _lstSub;
    private ApplicationDbContext _ApplicationDbContext;
    [Parameter]
    public List<LessonUPViewModel> ListLesson { get; set; } = new List<LessonUPViewModel>();
    public Dictionary<Guid, List<LessonContentUPViewModel>> listLessonContent = new Dictionary<Guid, List<LessonContentUPViewModel>>();
    [Inject]
    public ISubmitHomeworkForStudentRepo _submitForStudentRepo { get; set; }
    private List<SubmitHomeWork> _lstSubmitOfStu { get; set; } = new List<SubmitHomeWork>();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public ILessonUPRepo _iLessonClient { get; set; }
    [Inject]
    public ILessonContentUPRepo _iLessonContentRepo { get; set; }
    private SubjectDto subject = new SubjectDto();
    [Inject]
    public ISubjectUPRepo _iSubjectRepo { get; set; }
    protected Comfirmation DeleConfirmation { set; get; }
    protected DetailsSubmition submitConfirmation { set; get; }
    private string _AcceptId;
    private bool _isHidden;
    private bool _isHideWarning;
    private string backer = "";
    //
    private List<NewFeedOverView> _lstNewFeed = new List<NewFeedOverView>();
    public class PreStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
    }
    private List<PreStatus> _preStatuses = new List<PreStatus>();
    private PreStatus _Statuses = new PreStatus();
    private List<StudentViewModel> _lstStudents;
    private List<LecturersCP> _lstlec;
    private List<StudentsMapper> listSTMapper = new List<StudentsMapper>();
    private List<NewFeedOverView> _lstNewFeedforclass = new List<NewFeedOverView>();
    [Inject]
    public ISubjectUPRepo _iSubjectUPRepo { get; set; }
    [Inject]
    public UserManager<UserSignIn> _userManager { get; set; }
    [Inject]
    public ISpecializedUPRepo _iSpecializedUPRepo { get; set; }

    [Inject]
    public INewFeedRepo _newFeedRepo { get; set; }
    //
    [Inject]
    public ILecturersCPRepo _lecturersCPRepo { get; set; }
    //
    [Inject]
    public IHttpContextAccessor _httpContextAccessor { get; set; }
    public DetailClass()
    {
        _preStatuses = new List<PreStatus>()
    {
    new PreStatus(){Id=0,StatusName="Đang Hoạt Động"},
    new PreStatus(){Id=1,StatusName="Dừng Hoạt Động"},
    new PreStatus(){Id=2,StatusName="Chưa Đủ Sinh Viên"},
    new PreStatus(){Id=3 ,StatusName="Chưa Có Môn Học"},
    };
        _Statuses = new PreStatus();
        //_classUp = new ClassUPViewModel();
        _lstSub = new List<SubjectDto>();
        _lstStudents = new List<StudentViewModel>();
        _lstlec = new List<LecturersCP>();
        _SubjectUP = new SubjectUP();
        _ApplicationDbContext = new ApplicationDbContext();
    }

    private List<QuizUpDto> listquiz = new List<QuizUpDto>();
    List<Guid> lsstidquiz = new List<Guid>();

    [Inject]
    public IQuizUPRepo _iQuizUPRepo { get; set; }
    protected override async Task OnInitializedAsync()
    {

        listquiz = await _iQuizUPRepo.GetListQuizUp();
        backer = await _localStorageService.GetItemAsync<string>("keyst");
        url = $"/viewclass/{backer}";

        _classUp = await _taskRepositories.GetClassById(GetId);
        _lstSub = await _iSubjectUPRepo.GetAllSubjectAsync();
        var idsubject = _lstSub.Where(c => c.Id == _classUp.SubjectId).Select(c => c.Id).FirstOrDefault();
        lsstidquiz = listquiz.OrderBy(c => c.QuizName).Where(c => c.SubjectId == idsubject).Select(c => c.Id).ToList();
        _lstlec = await _lecturersCPRepo.GetAllLecturerAsync();
        _lstStudents = await _taskRepositories.GetAllStudent();


        await ConnectToServer();

        foreach (var x in _preStatuses)
        {
            _Statuses.Id = x.Id;
            _Statuses.StatusName = x.StatusName;
        }
        GetRole();

        await GetListLesson();
        await GetNewFeed();
        await GetListSubmitOfStudent();
    }

    private async Task cliklink(string linked)
    {
        _httpContextAccessor.HttpContext.Response.Redirect(linked);
    }

    private async Task GetNewFeed()
    {
        _lstNewFeed = await _newFeedRepo.GetListNewForUser(Guid.Parse(idUser));
        // _lstNewFeedforclass = await _newFeedRepo.GetListNewForClass(_classUp.Id,Guid.Parse( _classUp.SubjectId.ToString()));
    }
    private async Task Targeter(string? Taget)
    {

        await JS.InvokeVoidAsync("Targeter", Taget);

    }
    private async Task ConnectToServer()
    {
        for (var i = 0; i < 15; i++)
        {
            encounter = i;
        }
        try
        {
            string url = "https://localhost:5001/notificationhub";
            HubConnection _connection = null;
            bool isConnected = false;
            string connectionStatus = "Closed";
            _connection = new HubConnectionBuilder()
                .WithUrl(url)
                .Build();

            await _connection.StartAsync();
            isConnected = true;
            connectionStatus = "Connected :-)";

            _connection.Closed += async (s) =>
            {
                isConnected = false;
                connectionStatus = "Disconnected";
                await _connection.StartAsync();
                isConnected = true;
            };

            _connection.On<string>("Noticafications", async (res) =>
            {
                if (res == "Done")
                {
                    await GetNewFeed();

                    this.InvokeAsync(() => this.StateHasChanged());
                }


            });
        }
        catch (Exception ex)
        {


        }
    }
    private void GetRole()
    {
        if (_lstStudents.Any(x => x.Id == Guid.Parse(idUser)))
        {
            _isHidden = true;
        }
        else
        {
            _isHidden = false;
        }
    }

    private void SubmitHomeWork(SubmitHomeWork submit)
    {
        submitConfirmation.submitHomeWork = submit;
        submitConfirmation.show();
    }

    private async Task OnConfirmationUpdate(bool submitConfirmed)
    {
        if (submitConfirmed)
        {
            await Swal.FireAsync("Nộp Bài", "Nộp Bài Thành Công", SweetAlertIcon.Success);
        }
        else
        {
            await Swal.FireAsync("Nộp Bài", "Đã Hủy Nộp Bài", SweetAlertIcon.Error);
        }

        await OnInitializedAsync();
    }

    private async Task GetListSubmitOfStudent()
    {
        _lstSubmitOfStu = await _submitForStudentRepo.Student_GetAllAsync();
        _lstSubmitOfStu = _lstSubmitOfStu.Where(c => c.IdClass == _classUp.Id && c.IdSubject == _classUp.SubjectId && c.IdStudent == Guid.Parse(idUser)).ToList();
    }

    private async Task GetListLesson()
    {
        try
        {
            ListLesson = await _iLessonClient.GetAll();
            ListLesson = ListLesson.Where(c => c.SubjectId == _classUp.SubjectId).ToList();

            foreach (var item in ListLesson)
            {
                listLessonContent.Add(item.Id, await GetLessonContents(item.Id));
            }
        }
        catch (Exception ex)
        {
        }

    }

    private async Task<List<LessonContentUPViewModel>> GetLessonContents(Guid idLS)
    {
        var x = await _iLessonContentRepo.GetAll();
        var result = x.Where(c => c.LessonId == idLS).ToList();
        return result;
    }
    public async Task RemoveClass(string deleteID)
    {
        _AcceptId = deleteID;
        DeleConfirmation.show();
    }
    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed)
        {
            var result = await _taskRepositories.RemoveAsync(_AcceptId);
            if (result)
            {
                _toast.ShowSuccess($"Delete Successfully {_classUp.ClassroomName}");
                _navigationManager.NavigateTo("/viewclass");
            }
            else
            {
                _toast.ShowError($"Delete Failed {_classUp.ClassroomName}");
                _navigationManager.NavigateTo($"/detailclass/{GetId}");
            }
        }
    }

    void CheckAllExpense(object checkValue)
    {
        if (Convert.ToBoolean(checkValue) == false)
        {
            _lstStudents.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lstStudents.ToList().ForEach(e => e.IsChecked = true);
        }
    }

    void CheckManual(Guid st, bool check)
    {
        if (check == true)
        {
            foreach (var x in _lstStudents.Where(c => c.Id == st))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstStudents.Where(c => c.Id == st))
            {
                x.IsChecked = false;
            }
        }
    }
    private Stream GetFileStream()
    {
        using (var workerbook = new XLWorkbook())
        {
            //MaSV	Id	MaCV	TenSV	Username	PassWord	MaChiTietSinhVien	Email	MaSV	DiaChi	SDT	CMND/CCCD		TrangThai	DOB			Image		KiHoc	DOB

            var worksheet = workerbook.Worksheets.Add("Students");
            var currentRow = 1;
            worksheet.Cell(currentRow, 1).Value = "StudentCode";
            worksheet.Cell(currentRow, 2).Value = "StudentName";
            worksheet.Cell(currentRow, 3).Value = "Gender";
            worksheet.Cell(currentRow, 4).Value = "DateOfBirth";
            worksheet.Cell(currentRow, 5).Value = "Email";
            worksheet.Cell(currentRow, 6).Value = "PhoneNumber";
            worksheet.Cell(currentRow, 7).Value = "Address";
            worksheet.Cell(currentRow, 8).Value = "IdentityCardNumber";
            worksheet.Cell(currentRow, 9).Value = "IssuedOn";
            worksheet.Cell(currentRow, 10).Value = "Ethnic";
            worksheet.Cell(currentRow, 11).Value = "Description";
            worksheet.Cell(currentRow, 12).Value = "FathersName";
            worksheet.Cell(currentRow, 13).Value = "MotherName";
            worksheet.Cell(currentRow, 14).Value = "HomeTown";
            worksheet.Cell(currentRow, 15).Value = "Status";

            //sau khi tạo ra các column name trong excel tiến hành call to api để lấy danh sách cần xuất
            //phải lấy viewsinh viên vì để còn biết xuất ra của lớp nào
            var finalList = new List<StudentViewModel>();

            foreach (var x in _lstStudents)
            {
                if (x.IsChecked == true)
                {
                    finalList.Add(x);
                }
            }

            foreach (var x in finalList)
            {
                currentRow++;
                //
                worksheet.Cell(currentRow, 1).Value = x.StudentCode;
                worksheet.Cell(currentRow, 2).Value = x.StudentName;
                worksheet.Cell(currentRow, 3).Value = x.Gender == true ? "Nam" : "Nữ";
                worksheet.Cell(currentRow, 4).Value = x.DateOfBirth;
                worksheet.Cell(currentRow, 5).Value = x.Email;
                worksheet.Cell(currentRow, 6).Value = "'" + x.PhoneNumber;
                worksheet.Cell(currentRow, 7).Value = x.Address;
                worksheet.Cell(currentRow, 8).Value = x.IdentityCardNumber;
                worksheet.Cell(currentRow, 9).Value = x.IssuedOn;
                worksheet.Cell(currentRow, 10).Value = x.Ethnic;
                worksheet.Cell(currentRow, 11).Value = x.Description;
                worksheet.Cell(currentRow, 12).Value = x.FathersName;
                worksheet.Cell(currentRow, 13).Value = x.MotherName;
                worksheet.Cell(currentRow, 14).Value = x.HomeTown;
                worksheet.Cell(currentRow, 15).Value = x.Status == 0 ? "Đang hoạt động" : "Hoạt động";
            }
            using (var stream = new MemoryStream())
            {
                workerbook.SaveAs(stream);
                var content = stream.ToArray();
                var fileStream = new MemoryStream(content);
                return fileStream;
            }
        }
    }

    private async Task ExportToExcel()
    {
        var fileStream = GetFileStream();
        var fileName = $"Students_Of_{_classUp.ClassroomName}.xlsx";
        using var streamRef = new DotNetStreamReference(stream: fileStream);
        await JS.InvokeVoidAsync("downloadFileFromStream", fileName, streamRef);
        _toast.ShowSuccess($"Export {_classUp.ClassroomName} To Excel Successfully");
    }

    private async Task ExportToCSV()
    {
        var fileStream = GetFileStream();
        var fileName = $"Students_Of_{_classUp.ClassroomName}.csv";
        using var streamRef = new DotNetStreamReference(stream: fileStream);
        await JS.InvokeVoidAsync("downloadFileFromStream", fileName, streamRef);
        _toast.ShowSuccess($"Export {_classUp.ClassroomName} To CSV Successfully");
    }

    private async Task ExportToPDF()
    {
        var fileStream = GetFileStreamPDF();
        var fileName = $"Students_Of_{_classUp.ClassroomName}.pdf";
        using var streamRef = new DotNetStreamReference(stream: fileStream);
        await JS.InvokeVoidAsync("downloadFileFromStream", fileName, streamRef);
        _toast.ShowSuccess($"Export {_classUp.ClassroomName} To PDF Successfully");
    }

    PdfPTable pdfPTable;
    int maxcol = 16;
    public Stream GetFileStreamPDF()
    {
        using (MemoryStream stream = new MemoryStream())
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A0, 25, 25, 30, 30);
            doc.SetPageSize(iTextSharp.text.PageSize.A0);
            PdfWriter writer = PdfWriter.GetInstance(doc, stream);
            doc.Open();

            pdfPTable = new PdfPTable(maxcol);
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            float[] sizes = new float[maxcol];
            for (var i = 0; i < maxcol; i++)
            {
                if (i == 0) sizes[i] = 35;
                if (i == 3 || i == 10) sizes[i] = 50;
                if (i == 2 || i == 5 || i == 12 || i == 13) sizes[i] = 150;
                else sizes[i] = 100;
            }
            pdfPTable.SetWidths(sizes);
            this.ReportHeader();
            this.EmptyRow(2);
            this.ReportBody();
            pdfPTable.HeaderRows = 2;
            doc.Add(pdfPTable);
            doc.Close();
            var content = stream.ToArray();
            var fileStream = new MemoryStream(content);
            return fileStream;
        }
    }

    PdfPCell pdfCell;
    private void ReportHeader()
    {
        pdfCell = new PdfPCell(this.AddLogo());
        pdfCell.Colspan = 1;
        pdfCell.Border = 0;
        pdfPTable.AddCell(pdfCell);
        pdfCell = new PdfPCell(this.SetPageTitle());
        pdfCell.Colspan = maxcol;
        pdfCell.Border = 0;
        pdfPTable.AddCell(pdfCell);
        pdfPTable.CompleteRow();
    }
    private PdfPTable AddLogo()
    {
        int maxcol = 1;
        PdfPTable pdfPTable = new PdfPTable(maxcol);
        string path = env.WebRootPath + "/Image/Others";
        string imgcom = Path.Combine(path, "FPT_Polytechnic.png");
        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imgcom);
        pdfCell = new PdfPCell(image);
        pdfCell.Colspan = 1;
        pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
        pdfCell.Border = 0;
        pdfCell.ExtraParagraphSpace = 0;
        pdfPTable.AddCell(pdfCell);
        pdfPTable.CompleteRow();
        return pdfPTable;
    }
    private PdfPTable SetPageTitle()
    {
        PdfPTable pdfPTable = new PdfPTable(maxcol);

        pdfCell = new PdfPCell(new Phrase($"Truong Cao dang FPT Polytechnic - {_classUp.ClassroomName}"));
        pdfCell.Colspan = maxcol;
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.Border = 0;
        pdfCell.ExtraParagraphSpace = 0;
        pdfPTable.AddCell(pdfCell);
        pdfPTable.CompleteRow();
        //
        pdfCell = new PdfPCell(new Phrase("------------------------------------o0o------------------------------------"));
        pdfCell.Colspan = maxcol;
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.Border = 0;
        pdfCell.ExtraParagraphSpace = 0;
        pdfPTable.AddCell(pdfCell);
        pdfPTable.CompleteRow();
        return pdfPTable;
    }
    private void EmptyRow(int countrow)
    {
        for (int i = 0; i < countrow; i++)
        {
            pdfCell = new PdfPCell(new Phrase(""));
            pdfCell.Colspan = maxcol;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 10;
            pdfCell.FixedHeight = 50f;
            pdfPTable.AddCell(pdfCell);
            pdfPTable.CompleteRow();
        }
    }
    private void ReportBody()
    {
        //triển khai các cột
        pdfCell = new PdfPCell(new Phrase("NO"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //triển khai các cột
        pdfCell = new PdfPCell(new Phrase("StudentCode"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("StudentName"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("Gender"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("DateOfBirth"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("Email"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("PhoneNumber"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("Address"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("IdentityCardNumber"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("IssuedOn"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("Ethnic"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("Description"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("FathersName"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("MotherName"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("HomeTown"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);
        //
        pdfCell = new PdfPCell(new Phrase("Status"));
        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell.BackgroundColor = BaseColor.Yellow;
        pdfCell.FixedHeight = 100f;
        pdfPTable.AddCell(pdfCell);

        //
        pdfPTable.CompleteRow();
        var finalList = new List<StudentViewModel>();

        foreach (var x in _lstStudents)
        {
            if (x.IsChecked == true)
            {
                finalList.Add(x);
            }
        }

        int no = 0;
        ///get data
        foreach (var x in finalList)
        {
            no++;
            //triển khai các cột
            pdfCell = new PdfPCell(new Phrase(no.ToString()));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //triển khai các cột
            pdfCell = new PdfPCell(new Phrase(x.StudentCode));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.StudentName)); ;
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.Gender == true ? "Nam" : "Nu"));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.DateOfBirth.ToString("dd/MM/yyyy")));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.Email));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.PhoneNumber));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.Address));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.IdentityCardNumber));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.IssuedOn.ToString("dd/MM/yyyy")));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.Ethnic));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.Description));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.FathersName));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.MotherName));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.HomeTown));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfCell = new PdfPCell(new Phrase(x.Status == 0 ? "Dang hoat dong" : "Hoat dong"));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.FixedHeight = 70f;
            pdfPTable.AddCell(pdfCell);
            //
            pdfPTable.CompleteRow();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
    }
}
#pragma warning restore 1591