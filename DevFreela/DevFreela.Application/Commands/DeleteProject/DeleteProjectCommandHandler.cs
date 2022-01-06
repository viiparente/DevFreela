using DevFreela.Core.Repositories;
using MediatR;

namespace DevFreela.Application.Commands.DeleteProject
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Unit>
    {
        private readonly IProjectRepository _projectRepository;
        public DeleteProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            //var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);
            var project = await _projectRepository.GetByIdAsync(request.Id);

#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            project.Cancel();
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.

            await _projectRepository.SaveChangesAsync();


            return Unit.Value;
        }
    }
}
