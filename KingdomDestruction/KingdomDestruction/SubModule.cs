using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace KingdomDestruction
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            if (game.GameType is not Campaign) return;
            var campaignStarter = (CampaignGameStarter)gameStarter;

            campaignStarter.AddBehavior(new KingdomDestructionBehavior(campaignStarter));
        }
    }
}