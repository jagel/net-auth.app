using System;
using System.Collections.Generic;
using System.Text;
using Common.Application.ServicesDefinitions.Interfaces;
using PointOfSale.Domain.EntityFramework.Entities;

namespace PointOfSale.Application.Products.Interfaces
{
    public interface IGetProduct : IGetEntity<Product>
    {
    }
}
