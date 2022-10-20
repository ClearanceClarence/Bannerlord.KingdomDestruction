using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;

namespace KingdomDestruction
{
    public static class Utils
    {
        public static List<Clan> ExcludeMercenaryClansFrom(List<Clan> clans)
        {
            List<Clan> clansNoMercenaries = new();

            foreach (Clan clan in clans)
                if (clan.Leader.IsLord)
                    clansNoMercenaries.Add(clan);

            return clansNoMercenaries;
        }
        public static void PrintToMessages(string str, int r, int g, int b)
        {
            float[] newValues = { (float)r / 255.0f, (float)g / 255.0f, (float)b / 255.0f };
            Color col = new(newValues[0], newValues[1], newValues[2]);
            InformationManager.DisplayMessage(new InformationMessage(str, col));
        }
        public static void PrintToMessages(string str)
        {
            InformationManager.DisplayMessage(new InformationMessage(str));
        }
    }
}
