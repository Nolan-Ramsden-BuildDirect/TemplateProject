using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTemplate.Data.Models;

namespace WebApiTemplate.Data
{
    public interface ISmileyData
    {
        Task<IEnumerable<Smiley>> GetSmileys();
    }
}
