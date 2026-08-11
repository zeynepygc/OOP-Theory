using UnityEngine;

public class RadhaKrishna : TempleStatue
{
    public override string GetDisplayBlessing()
    {
        return($"Radhe Radhe! {GetDeityName()} blesses you with divine love and joy.");
    }
}
