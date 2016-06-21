using System.Collections.Generic;
using System.Web.Mvc;

namespace _AutoMapper.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            //1.类与类
            //  ①A包含B的所有字段
            //  ②部分类型格式化（比如：DateTime ==》string）
            //  ③两个映射的对象有部分字段名称不一样（比如：NDataStatus ==》DataStatus）
            NoteBackModel backModel = GetModel();
            var seoInfo = backModel.MapTo<SeoTKD>();
            var noteInfo = backModel.MapTo<NoteInfo>();
            var viewModel = noteInfo.MapTo<NoteViewModel>();
            //var test = backModel.MapTo<NoteViewModel>(); //测试数据【AssertConfigurationIsValid】

            //2.数组与数组
            //  ①A包含B的所有字段
            //  ②A包含B的部分字段，B的有些字段需要A的某些字段转换得到（比如：DateTime ==》string）
            //  ③A包含B的部分字段，B的有些字段比A类少某些前缀（比如：NDataStatus ==》DataStatus）
            NoteBackModel[] backModes = GetModels();
            var seoInfos = backModes.MapToList<SeoTKD>();
            var noteInfos = backModes.MapToList<NoteInfo>();
            var viewModels = noteInfos.MapToList<NoteViewModel>();

            //3.集合与集合
            //  ①A包含B的所有字段
            //  ②A包含B的部分字段，B的有些字段需要A的某些字段转换得到（比如：DateTime ==》string）
            //  ③A包含B的部分字段，B的有些字段比A类少某些前缀（比如：NDataStatus ==》DataStatus）
            IEnumerable<NoteBackModel> backModelList = GetModelList();
            var seoInfoList = backModelList.MapToList<SeoTKD>();
            var noteInfoList = backModelList.MapToList<NoteInfo>();
            var viewModelList = noteInfoList.MapToList<NoteViewModel>();

            //4.字典与字典
            //  ①A包含B的所有字段
            //  ②A包含B的部分字段，B的有些字段需要A的某些字段转换得到（比如：DateTime ==》string）
            //  ③A包含B的部分字段，B的有些字段比A类少某些前缀（比如：NDataStatus ==》DataStatus）


            return View();
        }

        #region 模拟数据
        /// <summary>
        /// 模拟数据
        /// </summary>
        /// <returns></returns>
        private IEnumerable<NoteBackModel> GetModelList()
        {
            var model = new NoteBackModel()
            {
                NId = 1,
                NAuthor = "DNT",
                NTitle = "AutoMapper干啥用的啊？",
                NContent = "主要用途：领域对象（实体类）与DTO（数据传输对象）之间的转换、数据库查询结果映射至实体对象。",
                NHitCount = 999,
                NPush = true,
                NDataStatus = StatusEnum.Normal,
                NCreateTime = "2016-04-01 11:11",
                NUpdateTime = "2016-05-01 12:12",
                NDisplayPic = "/img/1.jpg",
                NSeoId = 110,
                Test="test",
                SeoInfo = new SeoTKD { Id = 110, SeoKeywords = "AutoMapper,领域对象,DTO,映射", Seodescription = "主要用途：领域对象（实体类）与DTO（数据传输对象）之间的转换、数据库查询结果映射至实体对象。" }
            };
            return new List<NoteBackModel>() { model, model, model };
        }
        /// <summary>
        /// 模拟数据
        /// </summary>
        /// <returns></returns>
        private NoteBackModel[] GetModels()
        {
            var model = new NoteBackModel()
            {
                NId = 1,
                NAuthor = "DNT",
                NTitle = "AutoMapper干啥用的啊？",
                NContent = "主要用途：领域对象（实体类）与DTO（数据传输对象）之间的转换、数据库查询结果映射至实体对象。",
                NHitCount = 999,
                NPush = true,
                NDataStatus = StatusEnum.Normal,
                NCreateTime = "2016-04-01 11:11",
                NUpdateTime = "2016-05-01 12:12",
                NDisplayPic = "/img/1.jpg",
                NSeoId = 110,
                Test = "test",
                SeoInfo = new SeoTKD { Id = 110, SeoKeywords = "AutoMapper,领域对象,DTO,映射", Seodescription = "主要用途：领域对象（实体类）与DTO（数据传输对象）之间的转换、数据库查询结果映射至实体对象。" }
            };
            return new NoteBackModel[] { model, model, model };
        }
        /// <summary>
        /// 模拟数据
        /// </summary>
        /// <returns></returns>
        private NoteBackModel GetModel()
        {
            return new NoteBackModel()
            {
                NId = 1,
                NAuthor = "DNT",
                NTitle = "AutoMapper干啥用的啊？",
                NContent = "主要用途：领域对象（实体类）与DTO（数据传输对象）之间的转换、数据库查询结果映射至实体对象。",
                NHitCount = 999,
                NPush = true,
                NDataStatus = StatusEnum.Normal,
                NCreateTime = "2016-04-01 11:11",
                NUpdateTime = "2016-05-01 12:12",
                NDisplayPic = "/img/1.jpg",
                NSeoId = 110,
                Test = "test",
                SeoInfo = new SeoTKD { Id = 110, SeoKeywords = "AutoMapper,领域对象,DTO,映射", Seodescription = "主要用途：领域对象（实体类）与DTO（数据传输对象）之间的转换、数据库查询结果映射至实体对象。" }
            };
        }
        #endregion
    }
}