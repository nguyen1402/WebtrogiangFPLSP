namespace FPLSP.Server.Domain.Dtos.DashboardDtos;

public class TrainingFacilitiesForDashBoardDto
{
    public Guid TrainFaci_Id { get; set; }
    public string TrainFaci_Name { get; set; }

    public int StudentUp_Quantity { get; set; }
    public int LectureUp_Quantity { get; set; }
    public int ClassUp_Quantity { get; set; }
    public int Spec_Quantity { get; set; }
}