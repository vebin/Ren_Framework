﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OperationResultType.cs" company="Pensee">
//   Copyright © 2015 Skymate. All rights reserved.
// </copyright>
// <summary>
//   表示业务操作结果的枚举
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Skymate
{
    using System.ComponentModel;

    /// <summary>
    /// The operation result type.
    /// </summary>
    [Description("业务操作结果的枚举")]
    public enum OperationResultType
    {
        /// <summary>
        ///     操作成功
        /// </summary>
        [Description("操作成功。")]
        Success,

        /// <summary>
        ///     操作取消或操作没引发任何变化
        /// </summary>
        [Description("操作没有引发任何变化，提交取消。")]
        NoChanged,

        /// <summary>
        ///     参数错误
        /// </summary>
        [Description("参数错误。")]
        ParamError,

        /// <summary>
        ///     指定参数的数据不存在
        /// </summary>
        [Description("指定参数的数据不存在。")]
        QueryNull,

        /// <summary>
        ///     权限不足
        /// </summary>
        [Description("当前用户权限不足，不能继续操作。")]
        PurviewLack,

        /// <summary>
        ///     非法操作
        /// </summary>
        [Description("非法操作。")]
        IllegalOperation,

        /// <summary>
        ///     警告
        /// </summary>
        [Description("警告")]
        Warning,

        /// <summary>
        ///     操作引发错误
        /// </summary>
        [Description("操作引发错误。")]
        Error,
    }
}
