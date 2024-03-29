using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WEB_API_In_Dot_Net_Mac.Dtos.Fight;
using WEB_API_In_Dot_Net_Mac.Dtos.Skill;
using WEB_API_In_Dot_Net_Mac.Dtos.Weapon;

namespace WEB_API_In_Dot_Net_Mac
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();
        }
        
    }
}
