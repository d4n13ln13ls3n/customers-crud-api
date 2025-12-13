using Microsoft.AspNetCore.Mvc;
using CustomerCrud.Core;
using CustomerCrud.Requests;
using CustomerCrud.Repositories;

namespace CustomerCrud.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerRepository _repository;
    public CustomerController(ICustomerRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Customer>> GetAll()
    {
        var customers = _repository.GetAll();

        return Ok(customers);
    }

    [HttpGet("{id}")]
    public ActionResult<Customer> GetById(int id)
    {
        var customer = _repository.GetById(id);

        if (customer == null) return NotFound("Customer not found");

        return Ok(customer);
    }

    [HttpPost]
    public ActionResult<Customer> Create(Customer customer)
    {
        customer.Id = _repository.GetNextIdValue();
        customer.CreatedAt = DateTime.Now;
        customer.UpdatedAt = DateTime.Now;

        var customerResponse = _repository.Create(customer);

        if (customerResponse) return CreatedAtAction("GetById", new { id = customer.Id }, customer);
        
        return BadRequest();
    }
}
