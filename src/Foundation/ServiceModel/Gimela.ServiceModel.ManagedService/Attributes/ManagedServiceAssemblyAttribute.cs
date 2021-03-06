﻿using System;

namespace Gimela.ServiceModel.ManagedService.Attributes
{
  /// <summary>
  /// 描述该程序集为托管服务程序集
  /// </summary>
  [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
  public sealed class ManagedServiceAssemblyAttribute : Attribute
  {
  }
}
