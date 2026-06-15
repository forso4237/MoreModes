using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class Bankrupt : ModGameMode
{
    public override string Difficulty => DifficultyType.Medium;
    public override string BaseGameMode => GameModeType.None;

    public override string DisplayName => "Bankrupt";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetStartingCash(baseCash: 1);
        gameModeModel.SetAllCashMultiplier(0.5f);
    }
}
