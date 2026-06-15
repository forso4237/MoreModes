using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Scenarios;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Difficulty;

namespace MoreModes;

public class AllStrengthened : ModGameMode
{
    public override string Difficulty => DifficultyType.Medium;
    public override string BaseGameMode => GameModeType.None;
    public override string DisplayName => "All Strengthened";

    public override void ModifyBaseGameModeModel(ModModel gameModeModel)
    {
        gameModeModel.UseRoundSet<AllStrengthenedRounds>();
    }
}
