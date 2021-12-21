
namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title, string description, decimal totalCost, DateTime? startedAt, DateTime? finishedAt, string clientFullname, string freelancerFullName)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinishedAt = finishedAt;
            FreelancerFullName = freelancerFullName;    
            ClientFullname = clientFullname;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public decimal TotalCost { get; private set; }

        public DateTime? StartedAt { get; private set; }

        public DateTime? FinishedAt { get; private set; }

        public string ClientFullname { get; private set; }

        public string FreelancerFullName { get; private set; }


    }
}
