using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShaderManager : MonoBehaviour {

    static public ShaderManager instance;

    public Material mat_milk;
    public Material mat_beer;
    public Material mat_mushroom;
    public Material mat_poop;
    public Material mat_normal;

    public enum E_MATERIAL_TYPE
    {
        MILK,
        BEER,
        MUSHROOM,
        POOP,
        NORMAL        
    }




    Timer shaderTimer = new Timer(5f);


    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        shaderTimer.Tick(Time.deltaTime);
        if (shaderTimer.IsFinished())
            ApplyMaterial(E_MATERIAL_TYPE.NORMAL);
    }





    public void ApplyMaterial(E_MATERIAL_TYPE _type)
    {
        switch(_type)
        {
            case E_MATERIAL_TYPE.BEER       :   CameraRendering.instance.SetCameraMaterial(instance.mat_beer);      shaderTimer.SetStartTime(20f);      break;
            case E_MATERIAL_TYPE.MILK       :   Aquarium.instance.ApplyMaterial(mat_milk);                          shaderTimer.SetStartTime(12f);      break;
            case E_MATERIAL_TYPE.MUSHROOM   :   CameraRendering.instance.SetCameraMaterial(instance.mat_mushroom);  shaderTimer.SetStartTime(6f);       break;
            case E_MATERIAL_TYPE.POOP       :   Aquarium.instance.ApplyMaterial(mat_poop);                          shaderTimer.SetStartTime(13f);      break;
            case E_MATERIAL_TYPE.NORMAL     :   Aquarium.instance.ApplyMaterial(mat_normal);
                                                CameraRendering.instance.SetCameraMaterial(mat_normal);
                                                shaderTimer.SetStartTime(17f);                                                                          break;
        }
        if(_type != E_MATERIAL_TYPE.NORMAL)
            shaderTimer.Reset();
        
    }






}
