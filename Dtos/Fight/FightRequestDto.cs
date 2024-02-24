using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API_In_Dot_Net_Mac.Dtos.Fight
{
    public class FightRequestDto
    {
        public List<int> CharacterIds { get; set; } = new List<int>();
    }
}