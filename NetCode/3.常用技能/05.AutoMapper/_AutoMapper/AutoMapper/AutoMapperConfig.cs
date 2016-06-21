using AutoMapper;

namespace _AutoMapper.AutoMapper
{
    /// <summary>
    /// 主要用途：领域对象（实体类）与DTO（数据传输对象）之间的转换、数据库查询结果映射至实体对象。
    /// </summary>
    public partial class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(i => i.AddProfile<AutoMapperProfile>());
        }
    }
}