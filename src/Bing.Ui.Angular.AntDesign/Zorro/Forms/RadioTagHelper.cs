﻿using Bing.Ui.Angular.Base;
using Bing.Ui.Angular.Forms.Configs;
using Bing.Ui.Renders;
using Bing.Ui.TagHelpers;
using Bing.Ui.Zorro.Forms.Renders;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Bing.Ui.Zorro.Forms
{
    /// <summary>
    /// 单选框
    /// </summary>
    [HtmlTargetElement("bg-radio")]
    public class RadioTagHelper : AngularTagHelperBase
    {
        /// <summary>
        /// 属性表达式
        /// </summary>
        public ModelExpression For { get; set; }

        /// <summary>
        /// [(ngModel)],模型绑定
        /// </summary>
        public string NgModel { get; set; }

        /// <summary>
        /// nzName,控件的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [nzName],控件的名称
        /// </summary>
        public string BindName { get; set; }

        /// <summary>
        /// 是否垂直布局
        /// </summary>
        public bool Vertical { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// [url],请求地址
        /// </summary>
        public string BindUrl { get; set; }

        /// <summary>
        /// 数据源
        /// </summary>
        public string DatasSource { get; set; }

        /// <summary>
        /// [nzDisabled],禁用
        /// </summary>
        public string Disabled { get; set; }

        /// <summary>
        /// 必填项
        /// </summary>
        public string Required { get; set; }

        /// <summary>
        /// (ngModelChange),变更事件处理函数
        /// </summary>
        public string OnChange { get; set; }

        /// <summary>
        /// 获取渲染器
        /// </summary>
        /// <param name="context">上下文</param>
        protected override IRender GetRender(Context context)
        {
            return new RadioRender(new SelectConfig(context));
        }
    }
}
