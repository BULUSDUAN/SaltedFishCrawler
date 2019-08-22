namespace Data.Model.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// ���ɶ���������
    /// </summary>
    public partial class Q_Pulse
    {
        public int id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [StringLength(100)]
        public string desc { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public int IsReset { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
