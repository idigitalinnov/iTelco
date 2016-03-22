using System.Collections;

namespace iTELCO.BusinessInterfaces
{
    public interface ISessionProvider : ICollection
    {
        object this[string name] { get; set; }
    }
}
