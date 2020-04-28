using System;
using System.Collections.Generic;
using System.Text;

namespace XTC.Devops.TestPlans.Dto
{
    /// <summary>
    /// 创建测试用例Dto
    /// </summary>
    public class CreateTestCaseDto
    {
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 功能点
        /// </summary>
        public string FunPoint { get; set; }
    }
}
