using Common.Application.ServicesDefinitions.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Application.ServicesDefinitions.Services
{
    public abstract class GetEntity : IGetEntity<string>
    {
        public string Get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
