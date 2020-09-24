using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Material m;
    float offset;
    public float speed;
    public GameManager manager;
    void Start()
    {
        m = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        if (manager.IsPlaying() == true)
        {
            offset = offset + Time.deltaTime;
            m.mainTextureOffset = new Vector2(offset * speed, 0);
        }
    }
}
