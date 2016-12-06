using UnityEngine;
using System.Collections;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public SoundType soundType;
    public int clipIndex = -1;

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
            FindObjectOfType<SoundManager>().PlaySound(soundType, clipIndex);
        }
    }
}
