using AutoMapper;
using MVC.Test.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test
{
    public  class AutoMapperConfig
    {
        public static  IMapper _mapper;

        public static void CreateConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // 扫描当前程序集
                cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies());
            });
          
            _mapper = new Mapper(config);//方式一
            //_mapper=config.CreateMapper();//方式二
        }

        public IMapper GetMyMapper()
        {
            return AutoMapperConfig._mapper;
        }
    }
}
