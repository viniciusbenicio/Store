﻿using Flunt.Notifications;
using Flunt.Validations;
using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Commands
{
    public class CreateOrdemItemCommand : Notifiable, ICommand
    {
        public CreateOrdemItemCommand()
        {

        }

        public CreateOrdemItemCommand(Guid product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public Guid Product { get; set; }
        public int Quantity { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract().Requires()
                                           .HasLen(Product.ToString(), 32, "Product", "Produto inválido")
                                           .IsGreaterThan(Quantity, 0, "Quantity", "Quantidade inválida"));
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
