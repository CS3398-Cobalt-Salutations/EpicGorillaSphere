using UnityEngine;
using System.Collections;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public SoundType soundType;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        SoundManager sm = other.GetComponent<SoundManager>();
        if (sm != null)
        {
            sm.PlaySound(soundType);
        }
    }
}
