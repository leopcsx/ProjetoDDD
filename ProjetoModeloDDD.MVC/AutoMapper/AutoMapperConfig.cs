using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile<ViewModelToDomainMappingProfile>();
                cfg.AddProfile<DomainToViewModelMappingProfile>();
            });

        }
    }
}