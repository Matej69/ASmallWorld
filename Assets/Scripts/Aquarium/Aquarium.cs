using UnityEngine;
using System.Collections;

public class Aquarium : MonoBehaviour {

    public static Aquarium instance;

    [HideInInspector]
    public Bounds bounds;
    

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        bounds = GetComponent<BoxCollider2D>().bounds;     
    }
	
}
