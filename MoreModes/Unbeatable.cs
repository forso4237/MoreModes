using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class Unbeatable : ModGameMode
{
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.Clicks;

    public override string DisplayName => "Unbeatable";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetImpoppable(true);
        gameModeModel.SetStartingCash(baseCash: 100);
        gameModeModel.SetAllCashMultiplier(0.5f);
        gameModeModel.SetBloonHealth(5f, BloonTag.Moabs);
    }
}
