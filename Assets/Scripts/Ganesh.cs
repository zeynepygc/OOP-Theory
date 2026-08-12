using UnityEngine;

// INHERITANCE : Ganesh inherits from TempleStatue base class
public class Ganesh : TempleStatue
{
    public override string GetDisplayBlessing()
    {
        return($"Om Gan Ganapataye Namo Namaha! {GetDeityName()} removes all obstacles from your path.");
    }
}