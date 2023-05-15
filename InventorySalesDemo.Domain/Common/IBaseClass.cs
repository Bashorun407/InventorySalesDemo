using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Domain.Common
{
    /// <summary>
    /// This interface will be inherited by AuditableBaseEntity (and other classes that implements AuditableBaseEntity)
    /// </summary>
    public interface IBaseClass
    {
        public int Id { get; set; }
    }
}
