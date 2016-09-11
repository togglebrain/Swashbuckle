using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Swashbuckle.Dummy.Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnotherEnum

    {
        OneFish, TwoFish, RedFish, BlueFish
    }
}
