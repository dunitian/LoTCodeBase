using AutoMapper;

namespace _AutoMapper.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            //NoteBackModel==>NoteInfo (string=>DateTime 会自动转)
            CreateMap<NoteBackModel, NoteInfo>();
            #region Other
            //CreateMap<NoteBackModel, NoteInfo>()
            //    .ConstructUsing(n => new NoteInfo()
            //    {
            //        NCreateTime = DateTime.Parse(n.NCreateTime),
            //        NUpdateTime = DateTime.Parse(n.NUpdateTime)
            //    }); 
            #endregion

            //NoteBackModel==>SeoTKD
            CreateMap<NoteBackModel, SeoTKD>()
                .ConstructUsing(n => new SeoTKD()
                {
                    Id = n.SeoInfo.Id,
                    SeoKeywords = n.SeoInfo.SeoKeywords,
                    Seodescription = n.SeoInfo.Seodescription
                });

            //NoteInfo==>NoteViewModel
            CreateMap<NoteInfo, NoteViewModel>()
                .ForMember(viewModel => viewModel.Test, note => note.Ignore()) //指定属性忽略
                .ConstructUsing(n => new NoteViewModel()
                {
                    Id = n.NId,
                    Title = n.NTitle,
                    Author = n.NAuthor,
                    HitCount = n.NHitCount,
                    CreateTime = n.NCreateTime.ToString("yyyy-mm-dd hh:mm"),
                    UpdateTime = n.NUpdateTime.ToString("yyyy-mm-dd hh:mm"),
                    DataStatus = n.NDataStatus
                });
            //Mapper Config验证
            Mapper.AssertConfigurationIsValid();
        }
    }
}