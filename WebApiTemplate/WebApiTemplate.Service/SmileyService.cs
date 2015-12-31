using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTemplate.Data;
using WebApiTemplate.Service.Models;

namespace WebApiTemplate.Service
{
    public class SmileyService : ISmileyService
    {
        [Dependency]
        public ISmileyData SmileyData { get; set; }

        public async Task<IEnumerable<SmileyDto>> GetSmileysAsync()
        {
            var smileys = await SmileyData.GetSmileys();

            var smileyDtos = new List<SmileyDto>();
            foreach (var smiley in smileys)
            {
                smileyDtos.Add(new SmileyDto()
                {
                    Happy = smiley.Happy,
                    Shape = smiley.Shape,
                    Description = smiley.Description
                });
            }
            return smileyDtos;
        }
    }
}
