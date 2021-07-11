using System;

namespace Invoices.DAL.Entities
{
    public record Invoice
    {
        public Guid InvoiceId  { get; init; }
        public Guid CustomerId { get; init; }
        public DateTime DateDelivered { get; init; }
        public string Description { get; init; }
        public decimal DiscountAmount { get; init; }
        public decimal DiscountPercentage { get; init; }
        public DateTime DueDate { get; init; }
        public string EmailAddress { get; init; }
        public string InvoiceNumber { get; init; }
        public bool IsPriceLocked { get; init; }
        public DateTime LastBackofficeSubmit { get; init; }
        public DateTime DateCreated { get; init; }
        public DateTime DateLastUpdated { get; init; }
    }
}
