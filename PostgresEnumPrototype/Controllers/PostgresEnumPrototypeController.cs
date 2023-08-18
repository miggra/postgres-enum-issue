using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using PostgresEnumPrototype.Data;
using PostgresEnumPrototype.Data.Entities;

namespace PostgresEnumPrototype.Controllers;

[ApiController]
[Route("[controller]")]
public class PostgresEnumPrototypeController : ControllerBase
{
    private readonly MessageContext context;
    private readonly Fixture fixture;

    public PostgresEnumPrototypeController(MessageContext context)
    {
        this.context = context;
        this.fixture = new Fixture();
    }

    [HttpPost(Name = "AddMessage")]
    public async Task<IActionResult> AddMessage()
    {
        var message = this.fixture.Create<Message>();
        this.context.Messages.Add(message);
        await this.context.SaveChangesAsync();
        return Ok();
    }
}
