﻿using Store.Domain.Entites;

namespace Store.Domain.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
