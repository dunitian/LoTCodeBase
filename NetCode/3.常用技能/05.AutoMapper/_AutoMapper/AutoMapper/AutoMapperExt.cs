using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace _AutoMapper
{
    /// <summary>
    /// AutoMapper扩展类
    /// </summary>
    public static class AutoMapperExt
    {
        /// <summary>
        ///  类型映射
        /// </summary>
        public static T MapTo<T>(this object obj)
        {
            if (obj == null) return default(T);
            return Mapper.Map<T>(obj);
        }

        /// <summary>
        /// 集合列表类型映射
        /// </summary>
        public static IEnumerable<TDestination> MapToList<TDestination>(this IEnumerable source)
        {
            if (source == null) return new List<TDestination>();
            return Mapper.Map<IEnumerable<TDestination>>(source);
        }

        /// <summary>
        /// 类型映射
        /// </summary>
        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination) where TSource : class where TDestination : class
        {
            if (source == null) return destination;
            return Mapper.Map(source, destination);
        }

        /// <summary>
        /// DataReader映射
        /// </summary>
        public static IEnumerable<T> DataReaderMapTo<T>(this System.Data.IDataReader reader)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<System.Data.IDataReader, IEnumerable<T>>());
            return Mapper.Map<System.Data.IDataReader, IEnumerable<T>>(reader);
        }
    }
}