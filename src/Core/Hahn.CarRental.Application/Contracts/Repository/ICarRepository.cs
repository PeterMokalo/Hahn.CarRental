using Hahn.CarRental.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Application.Contracts.Repository
{
    public interface ICarRepository : IGenericRepository<Car>
    {
    }
}
