using System;
using Ardalis.Result;
using MediatR;

namespace Customers.Application.Customer.Commands;

public class DeleteCustomerCommand(Guid id) : IRequest<Result>
{
    public Guid Id { get; } = id;
}