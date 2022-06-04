﻿using DMS.Common.Model.Result;
using DMS.Template.IService.Param;
using DMS.Template.IService.Result;

namespace DMS.Template.IService
{
    /// <summary>
    /// 日志接口定义
    /// </summary>
    public interface ISysJobLogService
    {
        /// <summary>
        /// 异步新增
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<ResponseResult> Add(AddJobLogParam param);
        /// <summary>
        /// 事物处理
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<ResponseResult> AddTran(AddJobLogParam param);
        /// <summary>
        /// 异步修改
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult> UpdateAsync(long jobLogID);
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult> DeleteAsync(long jobLogID);
        /// <summary>
        /// 异步查询
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult<JobLogResult>> GetJobLogAsync(long jobLogID);
        /// <summary>
        /// 异步查询
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult<List<JobLogResult>>> GetJobLogListAsync(long jobLogType);
        /// <summary>
        /// 异步查询
        /// </summary>
        /// <returns></returns>
        Task<ResponseResult<PageModel<JobLogResult>>> SearchJobLogAsync(SearchJobLogParam param);
    }
}
