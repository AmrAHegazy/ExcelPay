using AutoMapper;
using ExcelPayBackend.Dtos;
using ExcelPayBackend.models;

namespace ExcelPayBackend.profiles
{
    public class mappingprofiles:Profile
    {
        public mappingprofiles()
        {
            this.CreateMap<Intention, IntentionDto>()
                .ForMember(x => x.ClientSecret, op => op.MapFrom(x => x.ClientSecret.Id))
                .ForMember(x => x.Id, op => op.MapFrom(x => x.Id))
                .ForMember(x => x.Amount, op => op.MapFrom(x => x.Amount)).ReverseMap();
        }
    }
}
