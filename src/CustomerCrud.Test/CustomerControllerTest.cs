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
    // private readonly HttpClient _client;
    private readonly WebApplicationFactory<Program> _factory;

    private readonly Mock<ICustomerRepository> _repositoryMock;

    public CustomersControllerTest(WebApplicationFactory<Program> factory)
    {
        _repositoryMock = new Mock<ICustomerRepository>();

        _factory = factory.WithWebHostBuilder(builder =>
        {
            builder.ConfigureServices(services =>
            {
                // services.RemoveAll<ICustomerRepository>();

                var descriptor = services.Single(
                    d => d.ServiceType == typeof(ICustomerRepository)
                );
                services.Remove(descriptor);

                services.AddSingleton<ICustomerRepository>(st => _repositoryMock.Object);
            });
        });
    }

    // [Fact(DisplayName = "1. Crie o método `GetAll`")]
    // public async Task GetAllTest()
    // {
    //     var customersMock = new List<Customer>
    //     {
    //         new Customer { Id = 1, Name = "Ana" },
    //         new Customer { Id = 2, Name = "Bruno" }        
    //     };

    //     _repositoryMock
    //         .Setup(r => r.GetAll())
    //         .Returns(customersMock);

    //     var client = _factory.CreateClient();
    //     var response = await client.GetAsync("/customer");

    //     Assert.Equal(HttpStatusCode.OK, response?.StatusCode);

    //     var json = await response.Content!.ReadAsStringAsync();
    //     // var json = await response.Content!.ReadAsStreamAsync();
    //     Console.WriteLine("---- RESPONSE BODY ----");
    //     Console.WriteLine(json);

    //     Console.WriteLine("---- MOCK INVOCATIONS ----");
    //     Console.WriteLine(_repositoryMock.Invocations.Count);

    //     var result = JsonSerializer.Deserialize<List<Customer>>(json);
    //     Console.WriteLine("---- RESULT FROM STRING COUNT ----");
    //     Console.WriteLine(result?.Count ?? -1);

    //     Assert.NotNull(result);
    //     Assert.Equal(customersMock.Count, result!.Count);

    //     Assert.Equal(customersMock[0].Id, result[0].Id);
    //     Assert.Equal(customersMock[1].Id, result[1].Id);
    //     Assert.Equal(customersMock[0].Name, result[0].Name);
    //     Assert.Equal(customersMock[1].Name, result[1].Name);

    //     _repositoryMock.Verify(r => r.GetAll(), Times.Once());
    // }

    [Fact(DisplayName = "1. Crie o método `GetAll`")]
    public async Task GetAllTest()
    {
        // Resetar o mock antes de configurar
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
            PropertyNameCaseInsensitive = true  // Importante para deserialização
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
        // Resetar o mock antes de configurar
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

    [Fact]
    public async Task CreateTest()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task UpdateTest()
    {
        throw new NotImplementedException();
    }

    [Fact]
    public async Task DeleteTest()
    {
        throw new NotImplementedException();
    }
}