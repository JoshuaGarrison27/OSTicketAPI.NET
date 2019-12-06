﻿using System.Collections.Generic;
using AutoMapper;
using Newtonsoft.Json;
using OSTicketAPI.NET.Entities;
using OSTicketAPI.NET.Models;

namespace OSTicketAPI.NET.AutoMapperProfiles
{
    public class TicketsProfile : Profile
    {
        public TicketsProfile()
        {
            CreateMap<OstTicketStatus, TicketStatus>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Mode, opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.Flags, opt => opt.MapFrom(src => src.Flags))
                .ForMember(dest => dest.Sort, opt => opt.MapFrom(src => src.Sort))
                .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
                .ForMember(dest => dest.Updated, opt => opt.MapFrom(src => src.Updated))
                .ForMember(dest => dest.Properties, opt => opt.MapFrom<TicketStatusPropertiesResolver>());

            CreateMap<OstTicket, Ticket>()
                .ForMember(dest => dest.TicketId, opt => opt.MapFrom(src => src.TicketId))
                .ForMember(dest => dest.Number, opt => opt.MapFrom(src => src.Number))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.OstUser))
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.OstDepartment))
                .ForMember(dest => dest.HelpTopic, opt => opt.MapFrom(src => src.OstHelpTopic))
                .ForMember(dest => dest.Staff, opt => opt.MapFrom(src => src.OstStaff))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.OstTicketStatus))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }

    public class TicketStatusPropertiesResolver : IValueResolver<OstTicketStatus, TicketStatus, Dictionary<string, object>>
    {
        public Dictionary<string, object> Resolve(OstTicketStatus source, TicketStatus destination, Dictionary<string, object> destMember, ResolutionContext context)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(source.Properties);
        }
    }
}
