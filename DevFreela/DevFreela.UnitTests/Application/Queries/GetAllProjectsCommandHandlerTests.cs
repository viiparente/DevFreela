using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        public async Task ThreeProjectsExist_Executed_ReturnThreeProjectViewModels()
        {
            // Arrange
            var projects = new List<Project>
            {
                new Project("Projeto 1", "Descricao De Projeto Teste 1", 1, 2, 10000),
                new Project("Projeto 2", "Descricao De Projeto Teste 2", 1, 2, 20000),
                new Project("Projeto 3", "Descricao De Projeto Teste 3", 1, 2, 30000)
            };

            //essa lista acima serve como um "banco de dados" para o mock,
            //ou seja estou criando esses objetos que imitam os objetos reais 

            //utiliza a interface que foi criada para o project
            // e o metodo que foi feito na interface.
            var projectRepositoryMock = new Mock<IProjectRepository>();
            projectRepositoryMock.Setup(pr => pr.GetAllAsync().Result).Returns(projects);

            var getAllProjectsQuery = new GetAllProjectsQuery("");
            var getAllProjectsQueryHandler = new GetAllProjectsQueryHandler(projectRepositoryMock.Object);

            // Act
            var projectViewModelList = await getAllProjectsQueryHandler.Handle(getAllProjectsQuery, new CancellationToken());

            // Assert

            //não e null
            Assert.NotNull(projectViewModelList);
            //não e vazia
            Assert.NotEmpty(projectViewModelList);

            //valor            esperado, resultado
            Assert.Equal(projects.Count, projectViewModelList.Count);

            //verificar a igualdade entre o resultado esperado e o resultado real.
            projectRepositoryMock.Verify(pr => pr.GetAllAsync().Result, Times.Once);

        }
    }
}
