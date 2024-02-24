using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_In_Dot_Net_Mac.Dtos.Skill
{
    public class GetSkillDto
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
    }
}