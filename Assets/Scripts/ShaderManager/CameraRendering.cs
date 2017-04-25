using UnityEngine;
using System.Collections;

public class CameraRendering : MonoBehaviour {

    static public CameraRendering instance;

    private Material mat;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        mat = ShaderManager.instance.mat_normal;
    }

	void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Graphics.Blit(src, dest, mat);
    }


    public void SetCameraMaterial(Material _mat)
    {
        instance.mat = _mat;
    }


}
