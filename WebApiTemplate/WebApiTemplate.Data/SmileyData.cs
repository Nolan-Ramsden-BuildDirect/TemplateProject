using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTemplate.Data.Models;

namespace WebApiTemplate.Data
{
    public class SmileyData : ISmileyData
    {
        [Dependency("Phoenix")]
        public IDbConnection DbConnection { get; set; }

        public async Task<IEnumerable<Smiley>> GetSmileys()
        {
            return new List<Smiley>()
            {
                new Smiley()
                {
                    Happy = true,
                    Shape = ":)",
                    Description = "Classic Smiley"
                }
            };
        }
    }
}
