using System.Collections.Generic;
using BTD_Mod_Helper.Api.Bloons;
using BTD_Mod_Helper.Api.Enums;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Rounds;
using Il2CppAssets.Scripts.Unity;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace MoreModes;

public class RandomStrengthRounds : ModRoundSet
{
    public override string BaseRoundSet => RoundSetType.Default;
    public override int DefinedRounds => BaseRounds.Count;
    public override string DisplayName => "Random Strength";

    public override void ModifyRoundModels(RoundModel roundModel, int round)
    {
        var newGroups = new List<BloonGroupModel>();
        var index = 0;

        foreach (var group in roundModel.groups)
        {
            var count = group.count;
            var spacing = count > 1 ? (group.end - group.start) / (count - 1) : 0f;

            for (var i = 0; i < count; i++)
            {
                var time = group.start + spacing * i;

                var single = group.Duplicate();
                single.count = 1;
                single.start = time;
                single.end = time;

                var bloon = Game.instance.model.GetBloon(single.bloon);
                string variantId = null;
                var found = false;
                switch (index % 3)
                {
                    case 0:
                        found = bloon.FindChangedBloonId(b => b.isCamo = true, out variantId);
                        break;
                    case 1:
                        found = bloon.FindChangedBloonId(b => b.isGrow = true, out variantId);
                        break;
                    default:
                        found = bloon.FindChangedBloonId(b => b.isFortified = true, out variantId);
                        break;
                }

                if (found) single.bloon = variantId;

                newGroups.Add(single);
                index++;
            }
        }

        var array = new Il2CppReferenceArray<BloonGroupModel>(newGroups.Count);
        for (var i = 0; i < newGroups.Count; i++)
        {
            array[i] = newGroups[i];
        }

        roundModel.groups = array;
    }
}
