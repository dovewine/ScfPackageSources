﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Scf.XscfBase
{
    /// <summary>
    /// 中间件接口
    /// </summary>
    public interface IXscfMiddleware
    {
        /// <summary>
        /// 使用中间件
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        IApplicationBuilder UseMiddleware(IApplicationBuilder app);
    }
}
