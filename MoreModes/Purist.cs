using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class Purist : ModGameMode
{
    public override string Difficulty => DifficultyType.Medium;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Purist";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.SetPowersEnabled(false);
        gameModeModel.SetMkEnabled(false);
    }
}
