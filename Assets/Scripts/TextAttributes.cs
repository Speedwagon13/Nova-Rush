using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextAttributes : MonoBehaviour {

    public float glowPower;
    public float dilate = 0;
    public Color color;
    private Material material;
	// Use this for initialization
	void Start () {
        SceneManager.sceneUnloaded += Cleanup;
        material = Instantiate(GetComponentInChildren<TextMeshProUGUI>().fontSharedMaterial);
        GetComponentInChildren<TextMeshProUGUI>().fontSharedMaterial = material;
    }
	
	// Update is called once per frame
	void Update () {
        this.material.SetFloat(ShaderUtilities.ID_GlowPower, glowPower);
        this.material.SetFloat(ShaderUtilities.ID_FaceDilate, dilate);
        this.material.SetColor(ShaderUtilities.ID_FaceColor, color);
    }

    #region Cleanup
    private void OnApplicationQuit()
    {
        Cleanup(SceneManager.GetActiveScene());
    }

    void Cleanup<Scene>(Scene scene)
    {
        Time.timeScale = 1;
    }
    #endregion Cleanup
}
