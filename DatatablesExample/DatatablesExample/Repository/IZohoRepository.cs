using DatatablesExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatatablesExample.Repository
{
    public interface IZohoRepository
    {
        IEnumerable<ZohoAccount> Accounts { get; }
    }
}
