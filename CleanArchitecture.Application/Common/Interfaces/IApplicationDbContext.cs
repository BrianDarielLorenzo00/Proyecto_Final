using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Invoice> Invoices { get; set; }

        DbSet<InvoiceItem> InvoiceItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
