using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class ControlPlayer : NetworkBehaviour
{
    [SyncVar]
    public int keyCount;
    [SyncVar]
    public int score;

    public float speed;
    public int cameraDistance;

    public Text scoreText;
    //public Text winText;
    
    private Rigidbody _rb;
    private GameObject _mainCamera;
    private bool _isInit = false;

    public override void OnStartLocalPlayer()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = new Color(0.0f, 0.0f, 1.0f, 0.2f);
        //Renderer[] rends = GetComponentsInChildren<Renderer>();
        //foreach (Renderer r in rends)
        //    r.material.color = Color.red;
    }

    void Awake()
    {
        GameManager.players.Add(this);
    }

    // Use this for initialization
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _mainCamera = GameObject.Find("Main Camera");
        score = 0;
        keyCount = 0;
        //winText.text = "";

        if (GameManager.instance != null)
        {
            Init();
        }
    }

    public void Init()
    {
        if (_isInit) return;

        GameObject scoreObj = new GameObject(gameObject.GetInstanceID().ToString() + "score");
        scoreObj.transform.SetParent(GameManager.instance.uiScoreZone.transform, false);

        scoreText = scoreObj.AddComponent<Text>();
        scoreText.alignment = TextAnchor.MiddleCenter;
        scoreText.font = GameManager.instance.uiScoreFont;
        scoreText.resizeTextForBestFit = true;
        scoreText.color = Color.white;

        _isInit = true;
        UpdateText();
    }

    // Update is called once per frame
    [ClientCallback]
    void Update()
    {
        if (!isLocalPlayer) return;

        _mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y + cameraDistance, transform.position.z - cameraDistance);
    }
    
    [ClientCallback]
    void FixedUpdate()
    {
        if (!isLocalPlayer) return;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0.0f, z);

        _rb.AddForce(movement * speed);
    }

    void UpdateText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString() + "\tKeys: " + keyCount.ToString();
        }
    }

    [ServerCallback]
    public void UpdateKeyCount(int relative)
    {
        if (!isServer) return;

        RpcUpdateKeyCount(relative);
    }

    [ClientRpc]
    public void RpcUpdateKeyCount(int relative)
    {
        if (!isLocalPlayer) return;

        keyCount += relative;
        UpdateText();
    }

    [ServerCallback]
    public void UpdateScore(int relative)
    {
        if (!isServer) return;

        RpcUpdateScore(relative);
    }

    [ClientRpc]
    public void RpcUpdateScore(int relative)
    {
        if (!isLocalPlayer) return;

        score += relative;
        UpdateText();
    }

    [ServerCallback]
    public void DestroyObject(GameObject obj)
    {
        if (!isServer) return;

        RpcDestroyObject(obj);
    }

    [ClientRpc]
    public void RpcDestroyObject(GameObject obj)
    {
        if (!isLocalPlayer) return;

        Destroy(obj);
    }
}
