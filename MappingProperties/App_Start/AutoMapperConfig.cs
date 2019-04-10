using AutoMapper;
using MappingProperties.Models;
using MappingProperties.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MappingProperties.App_Start
{
    public class AutoMapperConfig
    {
        public static void Init()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Person, PersonIndexViewModel>()
                   .ForMember(t => t.Created, 
                                    source => source
                                              .MapFrom(property => 
                                              property.DateCreated));
            });
        }
    }
}