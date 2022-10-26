using System.Collections.Generic;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;

namespace KingdomDestruction
{
    public static class Utils
    {
        public static List<Clan> ExcludeMercenaryClansFrom(List<Clan> clans)
        {
            return clans.Where(clan => clan.Leader.IsLord).ToList();
        }
        public static void PrintToMessages(string str, int r, int g, int b)
        {
            float[] newValues = { r / 255.0f, g / 255.0f, b / 255.0f };
            Color col = new(newValues[0], newValues[1], newValues[2]);
            InformationManager.DisplayMessage(new InformationMessage(str, col));
        }
        public static void PrintToMessages(string str)
        {
            InformationManager.DisplayMessage(new InformationMessage(str));
        }
    }
}
