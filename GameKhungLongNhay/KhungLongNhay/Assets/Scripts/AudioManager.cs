using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField]
    private AudioSource effectSource;
    [SerializeField]
    private AudioClip jumpClip;
    [SerializeField]
    private AudioClip tapClip;
    [SerializeField]
    private AudioClip hurtClip;
    [SerializeField]
    private AudioClip crackEgg;
    private bool hasPlayEffectSound = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        hasPlayEffectSound = true;
    }

    public bool HasPlayEffectSound()
    {
        return hasPlayEffectSound;
    }
    public void SetHasPlayEffectSound(bool value)
    {
        hasPlayEffectSound = value;
    }

    public void PlayJumpClip()
    {
        effectSource.PlayOneShot(jumpClip);
    }

    public void PlayTapClip()
    {
        effectSource.PlayOneShot(tapClip);
    }

    public void PlayHurtClip()
    {
        effectSource.PlayOneShot(hurtClip);
    }

    public void PlayCrackEggClip()
    {
        effectSource.PlayOneShot(crackEgg);
    }

}
