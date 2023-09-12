using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    public RawImage map;

    public string strBaseURL = "";
    public string latitude = "";
    public string longtitude = "";
    public int level = 14;
    public int mapWidth;
    public int mapHeight;
    public string strAPIKey = "";
    public string secretKey = "";

    // Start is called before the first frame update
    void Start()
    {
        map = GetComponent<RawImage>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
