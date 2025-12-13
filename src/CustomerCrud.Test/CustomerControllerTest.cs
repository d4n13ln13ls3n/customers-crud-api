using System.Text.Json;
using CustomerCrud.Core;
using CustomerCrud.Repositories;
using CustomerCrud.Requests;
using Microsoft.AspNetCore.Hosting; // inserido posteriormente
using Microsoft.AspNetCore.Mvc.Testing; // inserido posteriormente
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CustomerCrud.Test;

public class CustomersControllerTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    private readonly Mock<ICustomerRepository> _repositoryMock;

    public CustomersControllerTest(WebApplicationFactory<Program> factory)
    {
        _repositoryMock = new Mock<ICustomerRepository>();

        _factory = factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.Single(
                    d => d.ServiceType == typeof(ICustomerRepository)
                );
                services.Remove(descriptor);

                services.AddSingleton<ICustomerRepository>(st => _repositoryMock.Object);
            });
        });
    }

    

    [Fact(DisplayName = "1. Crie o método `GetAll`")]
    public async Task GetAllTest()
    {
        _repositoryMock.Reset();
        
        var customersMock = new List<Customer>
        {
            new Customer { Id = 1, Name = "Ana" },
            new Customer { Id = 2, Name = "Bruno" }        
        };

        _repositoryMock
            .Setup(r => r.GetAll())
            .Returns(customersMock);

        var client = _factory.CreateClient();
        var response = await client.GetAsync("/customer");

        Assert.Equal(HttpStatusCode.OK, response?.StatusCode);

        var json = await response.Content!.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        var result = JsonSerializer.Deserialize<List<Customer>>(json, options);

        Assert.NotNull(result);
        Assert.Equal(customersMock.Count, result!.Count);

        Assert.Equal(customersMock[0].Id, result[0].Id);
        Assert.Equal(customersMock[1].Id, result[1].Id);
        Assert.Equal(customersMock[0].Name, result[0].Name);
        Assert.Equal(customersMock[1].Name, result[1].Name);

        _repositoryMock.Verify(r => r.GetAll(), Times.Once());
    }

    [Fact(DisplayName = "2. Crie o método `GetById`")]
    public async Task GetByIdTest()
    {
        _repositoryMock.Reset();
        
        var customerMock = new List<Customer>
        {
            new Customer { Id = 1, Name = "Ana" }
        };

        _repositoryMock
            .Setup(r => r.GetById(1))
            .Returns(customerMock[0]);

        var client = _factory.CreateClient();
        var response = await client.GetAsync("/customer/1");

        Assert.Equal(HttpStatusCode.OK, response?.StatusCode);

        var json = await response.Content!.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        var result = JsonSerializer.Deserialize<Customer>(json, options);

        Assert.NotNull(result);

        Assert.Equal(customerMock[0].Id, result!.Id);
        Assert.Equal(customerMock[0].Name, result!.Name);

        _repositoryMock.Verify(r => r.GetById(1), Times.Once());
    }

    [Fact(DisplayName = "3. Crie o método `Create`")]
    public async Task CreateTest()
    {
        _repositoryMock.Reset();

        var nextIdMock = 1;

        _repositoryMock
            .Setup(r => r.GetNextIdValue())
            .Returns(nextIdMock);

        _repositoryMock
            .Setup(r => r.Create(It.Is<Customer>(c => c.Id == nextIdMock)))
            .Returns(true);
        
        var customerMock = new Customer { 
            Id = nextIdMock, 
            Name = "Ana",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            CPF = "01234578909",
            Transactions = new List<Transaction>(),
        };

        var client = _factory.CreateClient();
        var response = await client.PostAsJsonAsync("/customer/", customerMock);

        Assert.Equal(HttpStatusCode.Created, response?.StatusCode);

        var json = await response.Content!.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        var result = JsonSerializer.Deserialize<Customer>(json, options);

        Assert.NotNull(result.Transactions);

        Assert.Equal(nextIdMock, result!.Id);
        Assert.Equal(customerMock.Name, result.Name);
        Assert.Equal(customerMock.CPF, result.CPF);

        Assert.NotEqual(default, result.CreatedAt);
        Assert.NotEqual(default, result.UpdatedAt);

        var diff = (result.UpdatedAt - result.CreatedAt).Duration();
        Assert.True(diff.TotalMilliseconds <= 100);

        _repositoryMock.Verify(r => r.GetNextIdValue(), Times.Once());
        _repositoryMock.Verify(r => r.Create(It.Is<Customer>(c => c.Id == nextIdMock)), Times.Once());
    }

    [Fact(DisplayName = "4. Crie o método `Update`")]
    public async Task UpdateTest()
    {
        _repositoryMock.Reset();

        var idToUpdateMock = 1;

        var customerMock = new Customer { 
            Name = "Ana",
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            CPF = "01234578909",
            Transactions = new List<Transaction>(),
        };

        _repositoryMock
            .Setup(r => r.Update(It.Is<int>(id => id == idToUpdateMock), It.IsAny<object>()))
            .Returns(true);
        
        var client = _factory.CreateClient();
        var response = await client.PutAsJsonAsync("/customer/1", customerMock);

        Assert.Equal(HttpStatusCode.OK, response?.StatusCode);

        var body = await response.Content.ReadAsStringAsync();
        Assert.Equal($"Customer {idToUpdateMock} updated", body);
        
        _repositoryMock.Verify(r => r.Update(idToUpdateMock, It.IsAny<object>()), Times.Once());
    }

    [Fact]
    public async Task DeleteTest()
    {
        throw new NotImplementedException();
    }
}