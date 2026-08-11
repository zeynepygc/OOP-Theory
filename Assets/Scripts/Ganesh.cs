using UnityEngine;

public class Ganesh : TempleStatue
{
    public override string GetDisplayBlessing()
    {
        return($"Om Gan Ganapataye Namo Namaha! {GetDeityName()} removes all obstacles from your path.");
    }
}