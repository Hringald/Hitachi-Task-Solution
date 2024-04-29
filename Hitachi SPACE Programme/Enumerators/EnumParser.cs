using Forecast.Enumerators;

namespace Hitachi_SPACE_Programme.Enumerators
{
    public class EnumParser
    {
        public EnumParser()
        {

        }

        public static Location GetEnumValueFromInt(int value)
        {
            if (Enum.IsDefined(typeof(Location), value))
                return (Location)value;
            return Location.Undefined;
        }

        public static int GetIntFromEnumName(string name)
        {
            Location myEnum = (Location)Enum.Parse(typeof(Location), name);
            return (int)myEnum;
        }
    }
}
