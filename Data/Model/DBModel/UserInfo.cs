namespace Data.Model.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// �û���
    /// </summary>
    [Table("UserInfo")]
    public partial class UserInfo
    {
        private const string _key = "User_{0}";

        /// <summary>
        ///  KeyFormat ��ʽ
        /// </summary>
        public string KeyFormat
        {
            get { return _key; }
        }
        /// <summary>
        ///  ��Couchbase�е�Keyֵ
        /// </summary>
        public string Key
        {
            get { return string.Format(KeyFormat, Id); }
        }

        /// <summary>
        ///  ���CouchBase��Key
        /// </summary>
        /// <returns></returns>
        public static string GetKey(int userId)
        {
            return string.Format(_key, userId);
        }

        /// <summary>
        /// �����û�id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// �û���
        /// </summary>
        [StringLength(50)]
        public string UserName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [StringLength(50)]
        public string Password { get; set; }

        /// <summary>
        /// �ֻ���
        /// </summary>
        [StringLength(50)]
        public string Phone { get; set; }
        /// <summary>
        /// email
        /// </summary>
        [StringLength(50)]
        public string Eamil { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateData { get; set; }
    }
}
