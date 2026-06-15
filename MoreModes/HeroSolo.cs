using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;
using Il2CppAssets.Scripts.Models.TowerSets;

namespace MoreModes;

public class HeroSolo : ModGameMode
{
    public override string Difficulty => DifficultyType.Easy;
    public override string BaseGameMode => GameModeType.None;

    public override string DisplayName => "Hero Solo";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.LockTowerSet(TowerSet.Primary);
        gameModeModel.LockTowerSet(TowerSet.Military);
        gameModeModel.LockTowerSet(TowerSet.Magic);
        gameModeModel.LockTowerSet(TowerSet.Support);
    }
}
