using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Models.Rounds;

namespace MoreModes;

public class DoubleTroubleRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "Double Trouble";

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        foreach (var group in roundModel.groups)
        {
            group.count *= 2;
        }
    }
}
