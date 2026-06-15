using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class DoubleTrouble : ModGameMode
{
    public override string Difficulty => DifficultyType.Hard;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Double Trouble";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.UseRoundSet<DoubleTroubleRounds>();
    }
}
