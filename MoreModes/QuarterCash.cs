using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class QuarterCash : ModGameMode
{
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.None;

    public override string DisplayName => "Quarter Cash";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetAllCashMultiplier(0.25f);
        gameModeModel.SetStartingCash(multCash: 0.25f);
    }
}
