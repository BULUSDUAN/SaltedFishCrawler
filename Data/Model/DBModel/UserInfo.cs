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
