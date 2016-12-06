using UnityEngine;
using System.Collections;
using System;

public enum SoundType
{
    OnDeath,
    OnVictory,
    OnPickup
}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public AudioClip[] onDeath;
    public AudioClip[] onVictory;
    public AudioClip[] onPickup;

    private AudioSource source;

    // Use this for initialization
	void Start()
    {
        source = GetComponent<AudioSource>();
        if (source == null) throw new Exception();
    }

    /// <summary>
    /// Plays the specified sound.
    /// </summary>
    /// <param name="type">The type of sound to play.</param>
    /// <param name="index">The index of the specific sound in the SoundManager. A value of -1 chooses randomly.</param>
    public void PlaySound(SoundType type, int index)
    {
        switch(type)
        {
            case SoundType.OnDeath:
                PlayOnDeath(index);
                break;
            case SoundType.OnVictory:
                PlayOnVictory(index);
                break;
            case SoundType.OnPickup:
                PlayOnPickup(index);
                break;
            default:
                break;
        }
    }

    public void PlayOnDeath(int index = -1)
    {
        if (onDeath.Length == 0) return;

        int clipIndex = DetermineIndex(index, onDeath);

        source.PlayOneShot(onDeath[clipIndex]);
    }

    public void PlayOnVictory(int index = -1)
    {
        if (onVictory.Length == 0) return;

        int clipIndex = DetermineIndex(index, onVictory);

        source.PlayOneShot(onVictory[clipIndex]);
    }

    public void PlayOnPickup(int index = -1)
    {
        if (onPickup.Length == 0) return;

        int clipIndex = DetermineIndex(index, onPickup);

        source.PlayOneShot(onPickup[clipIndex]);
    }

    private int DetermineIndex(int keyIndex, Array container)
    {
        int index = -1;

        if (keyIndex < -1 || keyIndex >= container.Length) throw new ArgumentOutOfRangeException("Invalid index");

        if (keyIndex == -1) index = UnityEngine.Random.Range(0, container.Length);
        else index = keyIndex;

        return index;
    }
}
