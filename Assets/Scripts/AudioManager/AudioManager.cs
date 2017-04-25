using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour {
    
    static public AudioManager instance;

    public enum E_AUDIO
    {
        BACKGROUND,
        BEER,
        CUT_OFF,
        MUSHROOM,
        MESSAGE,
        WATER_SPLASH        
    }
    [System.Serializable]
    public struct AudioInfo
    {
        public E_AUDIO id;
        public AudioClip clip;
    }
    public List<AudioInfo> audioList = new List<AudioInfo>();



    public GameObject pref_audioObject;

    

    void Awake()
    {
        instance = this;
    }
    

    private AudioClip GetAudioClip(E_AUDIO _id)
    {
        foreach (AudioInfo info in audioList)
            if (info.id == _id)
                return info.clip;
        Debug.LogError("COULD NOT RETURN AUDIO WIT ID = " + _id);
        return null;        
    }

    public void CreateAudioObject(E_AUDIO _id)
    {
        GameObject newAudio = (GameObject)Instantiate(pref_audioObject, transform.position, Quaternion.identity);
        newAudio.GetComponent<AudioSource>().clip = GetAudioClip(_id);
        newAudio.GetComponent<AudioSource>().Play();
    }




    


}
