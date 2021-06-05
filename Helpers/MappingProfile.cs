using AutoMapper;
using DonateBlood.Models;

namespace DonateBlood.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AplicationUser,UserModel>().ReverseMap();
            
            
        }
        
    }
}