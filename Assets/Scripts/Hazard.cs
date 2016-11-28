using UnityEngine;
using System.Collections;

public class Hazard : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;
        PlayerMoveSphere pms = other.GetComponent<PlayerMoveSphere>();
        if (pms != null)
        {
			ScoreKeeper.lives--;
			if (ScoreKeeper.lives <= 0) 
			{
				Application.LoadLevel ("Start Menu");
			}
            pms.LoadPosition();
        }
    }
}
