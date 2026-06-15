using System;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Unity;

namespace MoreModes;

public class AllStrengthenedRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "All Strengthened";

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        foreach (var group in roundModel.groups)
        {
            Strengthen(group, b => b.isCamo = true);
            Strengthen(group, b => b.isGrow = true);
            Strengthen(group, b => b.isFortified = true);
        }
    }

    private static void Strengthen(BloonGroupModel group, Action<BloonModel> change)
    {
        var bloon = Game.instance.model.GetBloon(group.bloon);
        if (bloon.FindChangedBloonId(change, out var id))
        {
            group.bloon = id;
        }
    }
}
