using UnityEngine;
using System.Collections;

public class Aquarium : MonoBehaviour {

    public GameObject ref_middlePoint;
    public GameObject ref_water;

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



    public void ApplyMaterial(Material _mat)
    {
        ref_water.GetComponent<SpriteRenderer>().material = _mat;
    }

	
}
