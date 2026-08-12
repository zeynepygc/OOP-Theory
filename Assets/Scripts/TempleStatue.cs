using UnityEngine;

public abstract class TempleStatue : MonoBehaviour
{
    [Header("Statue Info")]
    [SerializeField] private string deityName;
    [SerializeField] private string mantra;

    [Header("Particle Effect")]
    [SerializeField] private ParticleSystem particleEffect;

    // ENCAPSULATION
    public string GetDeityName() { return deityName; }
    public string GetMantra() { return mantra; }

    // ABSTRACTION
    public virtual void Interact()
    {

        PlayParticleEffect();

        string[] messages = new string[]
        {
            $"{deityName} glows with divine light!",
            GetDisplayBlessing(),
            "May this blessing guide you on your journey."
        };

        UIManager.Instance.ShowBlessingSequence(messages, 3f); // 3 seconds per message
    }

    private void PlayParticleEffect()
    {
        if (particleEffect != null)
        {
            particleEffect.Play();
        }
    }

    // POLYMORPHISM
    public abstract string GetDisplayBlessing();
}