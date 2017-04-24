using UnityEngine;
using System.Collections;

public class FishExistance : MonoBehaviour {

    static public FishExistance instance;
	
    void Awake()
    {
        instance = this;
    }

}
