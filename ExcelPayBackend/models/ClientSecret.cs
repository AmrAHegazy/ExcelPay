using System;

namespace ExcelPayBackend.models
{
    public class ClientSecret
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsUsed { get; set; }

    }
}
