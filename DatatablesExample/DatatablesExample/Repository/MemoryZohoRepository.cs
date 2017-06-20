using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatatablesExample.Models;

namespace DatatablesExample.Repository
{
    public class MemoryZohoRepository : IZohoRepository
    {
        public IEnumerable<ZohoAccount> Accounts
        {
            get
            {
                var results = new List<ZohoAccount>();

                for (var i = 0; i < 7000; i++)
                {
                    results.Add(new ZohoAccount
                    {
                        AccountId = i.ToString(),
                        AccountName = string.Format("Name: {0}", i),
                        Phone = string.Format("Phone: {0}", i),
                        Email = string.Format("Email: {0}", i)
                    });
                }

                return results;
            }
        }
    }
}
