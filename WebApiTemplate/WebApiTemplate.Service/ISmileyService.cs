using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTemplate.Service.Models;

namespace WebApiTemplate.Service
{
    public interface ISmileyService
    {
        Task<IEnumerable<SmileyDto>> GetSmileysAsync();
    }
}
