﻿#region
// ===============================================================================
// Project Name        :    _09输错三次密码锁死15分钟
// Project Description :   
// ===============================================================================
// Class Name          :    UserInfo
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-18 17:33:08
// Update Time         :    2018-6-18 17:33:08
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09输错三次密码锁死15分钟
{
   public  class UserInfo
    {

        public int Id { get; set; }

        public string  UserName { get; set; }

        public string  UserPwd { get; set; }

        public int ErrorTimes { get; set; }

        public DateTime LastErrorDateTime { get; set; }
    }
}
