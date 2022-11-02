using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UserDto
    {
        public int IUserId { get; set; }
        public string NvFirstName { get; set; }
        public string NvLastName { get; set; }
        public string NvIdentityNum { get; set; }
        public int? ICityType { get; set; }
        public string NvAddress { get; set; }
        public string NvEmail { get; set; }
        public string NvMobile { get; set; }
        public string NvPhone { get; set; }
        public string NvUserName { get; set; }
        public string NvPassword { get; set; }
        public int? IUserType { get; set; }
        public int? IUserStatusType { get; set; }
        public DateTime? DtStartDate { get; set; }
        public string NvComment { get; set; }
        public int ICreatedByUserId { get; set; }
        public DateTime DtCreateDate { get; set; }
        public int? ILastModifyUserId { get; set; }
        public DateTime? DtLastModifyDate { get; set; }
        public int ISysRowStatus { get; set; }
        public bool? BIsLastMessageRead { get; set; }
        public int? BIsNotInWhatsUpList { get; set; }
    }
}
