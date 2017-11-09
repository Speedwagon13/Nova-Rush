using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAttributes : MonoBehaviour {

    public float glowPower;
    public float dilate = 0;
    public Color color;
    private Material material;
	// Use this for initialization
	void Start () {
        material = GetComponentInChildren<TextMeshProUGUI>().fontSharedMaterial;
    }
	
	// Update is called once per frame
	void Update () {
        this.material.SetFloat(ShaderUtilities.ID_GlowPower, glowPower);
        this.material.SetFloat(ShaderUtilities.ID_FaceDilate, dilate);
        this.material.SetColor(ShaderUtilities.ID_FaceColor, color);
    }
}
