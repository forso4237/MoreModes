using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class ChimpsPlus : ModGameMode
{
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.Clicks;

    public override string DisplayName => "Chimps+";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetStartingCash(baseCash: 200);
        gameModeModel.SetAllCashMultiplier(0.85f);
        gameModeModel.SetBloonHealth(1.5f, BloonTag.Moabs);
    }
}
