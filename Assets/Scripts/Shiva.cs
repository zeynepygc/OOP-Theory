using UnityEngine;

public class ShivaLingam : TempleStatue
{
    public override string GetDisplayBlessing()
    {
        return($"Om Namah Shivaya! {GetDeityName()} blesses you with strength and transformation.");
    }
}
