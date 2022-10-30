using System;

namespace DTO
{
    public class DashboardDto
    {
        public int IBookId { get; set; }
        public int IBookBaseId { get; set; }
        public int? IUsingType { get; set; }
        public int? IBookCode { get; set; }
        public decimal? NPublishedPrice { get; set; }
        public decimal? NSpecialLandFee { get; set; }
        public int? IYearType { get; set; }
        public int? IBookApprovalStatusType { get; set; }
        public DateTime? DtBookApprovalStatusDate { get; set; }
        public int? IApprovalUserId { get; set; }
        public string NvComment { get; set; }
        public int? ICoverType { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public bool? BActive { get; set; }
        public bool? BPriceStatus { get; set; }
    }
}
