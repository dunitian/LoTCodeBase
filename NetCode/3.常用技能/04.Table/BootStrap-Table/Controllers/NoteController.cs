using BootStrap_Table.Models;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootStrap_Table.Controllers
{
    public class NoteController : Controller
    {
        /// <summary>
        /// 查询笔记页面
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<JsonResult> Query(QueryModel model)
        {
            //起始时间大于结束时间 或者 开始时间大于现在
            if (DateTime.Compare(model.StartTime, model.EndTime) > 0 || DateTime.Compare(model.StartTime, DateTime.Now) > 0)
            {
                var obj = new AjaxOption<object>() { Msg = "请检查开始或结束时间！" };
                return Json(obj);
            }
            return Json(await PageLoadAsync(model));
        }

        #region SQL动态拼接
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="model">查询模型</param>
        /// <returns></returns>
        public async Task<PageData<NoteInfo>> PageLoadAsync(QueryModel model)
        {
            StringBuilder sqlWhere = new StringBuilder();
            var p = DapperDataAsync.GetDynamicParameters();
            StringBuilder sqlStr = new StringBuilder("select NId,NTitle,NAuthor,NHitCount,NPush,NDataStatus,NCreateTime,NUpdateTime from NoteInfo");
            StringBuilder sqlCount = new StringBuilder("select count(1) from NoteInfo");

            #region 条件系列
            //文章状态
            if (model.DataStatus == StatusEnum.Init) { model.DataStatus = StatusEnum.Normal; }
            p.Add("NDataStatus", (int)model.DataStatus);
            sqlWhere.Append(" where NDataStatus=@NDataStatus");
            //文章标题
            if (!model.Title.IsNullOrWhiteSpace())
            {
                p.Add("NTitle", string.Format("%{0}%", model.Title));
                sqlWhere.Append(" and NTitle like @NTitle");
            }
            //创建时间
            if (DateTime.Compare(model.StartTime, DateTime.MinValue) > 0)
            {
                p.Add("StartTime", model.StartTime);
                sqlWhere.Append(string.Format(" and NCreateTime>=@StartTime", model.StartTime));
            }
            //更新时间
            if (DateTime.Compare(model.EndTime, DateTime.MinValue) > 0 && DateTime.Compare(model.EndTime, DateTime.Now) <= 0)
            {
                p.Add("EndTime", model.EndTime);
                sqlWhere.Append(string.Format(" and NCreateTime<=@EndTime", model.EndTime));
            }
            #endregion

            sqlStr.Append(sqlWhere.ToString());
            sqlCount.Append(sqlWhere.ToString());

            #region 分页系列
            if (model.Offset == 0 && model.PageSize == 0)//不分页
            {
                return await PageLoadAsync<NoteInfo>(sqlStr.ToString(), p, sqlCount.ToString(), p);
            }
            if (model.Offset < 0) { model.Offset = 0; }
            if (model.PageSize < 1) { model.PageSize = 10; }
            model.PageIndex = model.Offset / model.PageSize + 1;

            p.Add("PageIndex", model.PageIndex);
            p.Add("PageSize", model.PageSize);
            sqlStr.Insert(0, "select * from(select row_number() over(order by NCreateTime) Id,* from (");
            sqlStr.Append(") TempA) as TempInfo where Id<= @PageIndex * @PageSize and Id>(@PageIndex-1)*@PageSize");
            return await PageLoadAsync<NoteInfo>(sqlStr.ToString(), p, sqlCount.ToString(), p);
            #endregion
        }
        #endregion

        #region 分页查询
        /// <summary>
        /// 分页查询(为什么不用out，请参考：http://www.cnblogs.com/dunitian/p/5556909.html)
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <param name="p">动态参数</param>
        /// <param name="sqlTotal">total语句</param>
        /// <param name="p2">Total动态参数</param>
        /// <returns></returns>
        public async Task<PageData<T>> PageLoadAsync<T>(string sql, object p = null, string sqlTotal = "", object p2 = null)
        {
            var pageData = new PageData<T>() { rows = await DapperDataAsync.QueryAsync<T>(sql.ToString(), p) };
            if (!sqlTotal.IsNullOrWhiteSpace()) { pageData.total = await DapperDataAsync.ExecuteScalarAsync<int>(sqlTotal, p2); }
            return pageData;
        }
        #endregion
    }
}