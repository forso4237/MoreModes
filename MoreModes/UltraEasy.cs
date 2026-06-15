using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class UltraEasy : ModGameMode
{
    public override string Difficulty => DifficultyType.Easy;
    public override string BaseGameMode => GameModeType.None;

    public override string DisplayName => "Ultra Easy";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetStartingCash(baseCash: 2000);
        gameModeModel.SetStartingHealth(1000);
        gameModeModel.SetMaxHealth(9999);
        gameModeModel.SetAllCashMultiplier(2f);
    }
}
