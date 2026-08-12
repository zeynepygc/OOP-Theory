using UnityEngine;

// INHERITANCE : ShivaLingam inherits from TempleStatue base class
public class ShivaLingam : TempleStatue
{
    public override string GetDisplayBlessing()
    {
        return($"Om Namah Shivaya! {GetDeityName()} blesses you with strength and transformation.");
    }
}
