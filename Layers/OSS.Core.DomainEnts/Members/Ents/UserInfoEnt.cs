﻿namespace OSS.Core.DomainEnts.Members.Ents
{
    public class UserInfoEnt
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        
       /// <summary>
       ///  昵称
       /// </summary>
        public string nick_name { get; set; }

        /// <summary>
        ///  邮件地址
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///  手机号
        /// </summary>
        public string mobile { get; set; }
    }
}