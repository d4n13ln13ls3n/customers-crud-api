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

    [HttpPut("{id}")]
    public ActionResult Update(int id, dynamic fields)
    {
        var customerResponse = _repository.Update(id, fields);

        if (customerResponse) return Ok($"Customer {id} updated");
        
        return NotFound("Customer not found");
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var customerResponse = _repository.Delete(id);

        if (customerResponse) return NoContent();
        
        return NotFound("Customer not found");
    }
}
