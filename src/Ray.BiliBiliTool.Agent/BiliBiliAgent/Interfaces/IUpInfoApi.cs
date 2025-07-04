﻿using Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos;
using WebApiClientCore.Attributes;

namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Interfaces;

/// <summary>
/// 用户信息接口API
/// </summary>
[Header("Referer", "https://www.bilibili.com/")]
[Header("Origin", "https://www.bilibili.com")]
[Header("Host", "api.bilibili.com")]
public interface IUpInfoApi : IBiliBiliApi
{
    /// <summary>
    /// 获取用户空间信息
    /// </summary>
    /// <param name="userId">uid</param>
    /// <returns></returns>
    [HttpGet("/x/space/wbi/acc/info")]
    Task<BiliApiResponse<GetSpaceInfoResponse>> GetSpaceInfo(
        [PathQuery] GetSpaceInfoDto request,
        [Header("Cookie")] string ck
    );
}
