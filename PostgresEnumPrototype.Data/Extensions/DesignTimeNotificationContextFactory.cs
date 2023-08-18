using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PostgresEnumPrototype.Data.Extensions;
public class DesignTimeMessageContextFactory : IDesignTimeDbContextFactory<MessageContext>
{
    public MessageContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MessageContext>();
        optionsBuilder.UseNpgsql();

        return new MessageContext(optionsBuilder.Options);
    }
}