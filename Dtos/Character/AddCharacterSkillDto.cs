using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_In_Dot_Net_Mac.Dtos.Character
{
    public class AddCharacterSkillDto
    {
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
    }
}