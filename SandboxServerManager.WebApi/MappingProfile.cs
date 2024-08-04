using AutoMapper;
using SandboxServerManager.Application.DataTransferObject;
using SandboxServerManager.Core.Entities;

namespace SandboxServerManager.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Player, PlayerDto>()
                .ForMember(pn => pn.Role, opt => opt.MapFrom(src => src.PlayerRole.RoleName))  
                .ForMember(pc => pc.Clan, opt => opt.MapFrom(src => src.Clan.ClanName));
        }
    }
}
