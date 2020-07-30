﻿using Fur.AppBasic.Attributes;
using Fur.MirrorController.Options;
using Fur.SwaggerDoc.Options;

namespace Fur.AppBasic.Options
{
    /// <summary>
    /// 全局配置总选项
    /// </summary>
    [NonWrapper]
    public sealed class FurOptions
    {
        public FurMirrorControllerOptions FurMirrorControllerOptions { get; set; }
        public FurSwaggerDocOptions FurSwaggerDocOptions { get; set; }
    }
}