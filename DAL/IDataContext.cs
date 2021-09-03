using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public interface IDataContext : IDisposable, IAsyncDisposable
    {
        DbSet<Entry> Entries { get; set; }
        DbSet<User> Users { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}