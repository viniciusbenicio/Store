﻿using Store.Domain.Entites;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeIDiscountRepository : IDiscountRepository
    {
        public Discount Get(string code)
        {
            if (code == "12345678")
                return new Discount(10, DateTime.Now.AddDays(5));

            if (code == "11111111")
                return new Discount(10, DateTime.Now.AddDays(-5));


            return null;
        }


    }
}
