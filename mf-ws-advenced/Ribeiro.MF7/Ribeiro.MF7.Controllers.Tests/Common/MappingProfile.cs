using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Controllers.Tests.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApiControllerBaseDummy, ApiControllerBaseDummy>();
        }
    }
}
