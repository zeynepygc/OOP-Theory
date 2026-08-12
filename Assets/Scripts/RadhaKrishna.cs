using UnityEngine;

// INHERITANCE : RadhaKrishna inherits from TempleStatue base class
public class RadhaKrishna : TempleStatue
{
    public override string GetDisplayBlessing()
    {
        return($"Radhe Radhe! {GetDeityName()} blesses you with divine love and joy.");
    }
}
