using LuLiz.Core.Enum;
using System;

namespace LuLiz.Core.Subscription
{
    public class BasicInfo
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public string DDI { get; set; }
        public string DDD { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public Gender Gender { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
