using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class RandomStrength : ModGameMode
{
    public override string Difficulty => DifficultyType.Easy;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "Random Strength";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.UseRoundSet<RandomStrengthRounds>();
    }
}
