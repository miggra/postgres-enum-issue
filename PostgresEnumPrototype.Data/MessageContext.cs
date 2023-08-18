// <copyright file="NotificationContext.cs" company="Hoff">
// Copyright (c) Company. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;
using PostgresEnumPrototype.Data.Entities;

namespace PostgresEnumPrototype.Data;
public class MessageContext : DbContext
{
    public MessageContext(DbContextOptions<MessageContext> options) : base(options)
    {
    }

    public virtual DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasPostgresEnum<DeliveryStatus>();
    }

    public void MigrateWithNpgsqlReload()
    {
        this.Database.Migrate();
        if (this.Database.GetDbConnection() is NpgsqlConnection npgsqlConnection)
        {
            npgsqlConnection.Open();
            try
            {
                npgsqlConnection.ReloadTypes();
            }
            finally
            {
                npgsqlConnection.Close();
            }
        }
    }
}