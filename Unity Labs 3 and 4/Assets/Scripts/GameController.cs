using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public GameObject OneBallPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AddABall", 1.5f, 1);
    }

    // Update is called once per frame
    void AddABall()
    {
        Instantiate(OneBallPrefab);
    }
}
