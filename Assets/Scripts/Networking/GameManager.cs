using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class GameManager : NetworkBehaviour
{
    public static List<ControlPlayer> players = new List<ControlPlayer>();
    public static GameManager instance = null;

    public GameObject uiScoreZone;
    public Font uiScoreFont;

    private bool _isRunning = true;

    void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start()
    {
        if (isServer)
        {
            // Start any coroutines that would run throughout the game
        }

        foreach (ControlPlayer p in players)
        {
            p.Init();
        }
    }

    // Update is called once per frame
    [ServerCallback]
    void Update()
    {
        if (!_isRunning || players.Count == 0) return;

        // Check for end of game
    }

    public override void OnStartClient()
    {
        base.OnStartClient();

        // Register dynamic prefabs
    }

    public static void OpenDoor(NetworkDoor door)
    {
        foreach (ControlPlayer p in players)
        {
            p.DestroyObject(door.gameObject);
        }
    }

    public static void PickupKey(NetworkKey key)
    {
        foreach (ControlPlayer p in players)
        {
            p.UpdateKeyCount(key.pickupAmount);
        }
    }

    public static void Collect(NetworkCollectible collectible)
    {
        foreach (ControlPlayer p in players)
        {
            p.UpdateScore(collectible.pointValue);
        }
    }
}
