namespace Data.Model.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserOrder")]
    public partial class UserOrder
    {
        public int Id { get; set; }

       /// <summary>
       /// ������
       /// </summary>
        [Required]
        [StringLength(50)]
        public string OrderNo { get; set; }

        /// <summary>
        /// �û�id
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Ӧ�����
        /// </summary>
        public double CopePayMoney { get; set; }

        /// <summary>
        /// ʵ�����
        /// </summary>
        public double ActualPayMoney { get; set; }

        /// <summary>
        /// ����״̬ 1.δ֧�� 2.֧���� 3.��֧�� 4.�ѽӵ� 5.�ѳ�Ʊ 
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
