using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;

public class InGameUIController : MonoBehaviour {


    public Camera mainCamera;
    public GameObject player;
    public Camera uiCamera;
    public PostProcessingProfile postProcessingProfile;
    public float dofLerpTime;
    Animator UIAnimator;

    bool isPaused;
    float dof;
    private AsyncOperation loadLevel;

    // Use this for initialization
    void Start()
    {
        SceneManager.sceneUnloaded += Cleanup;
        postProcessingProfile.depthOfField.enabled = true;
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Confined;
        UIAnimator = GetComponentInParent<Animator>();
    }


#region Update
    private void FixedUpdate()
    {
        dof = (mainCamera.transform.position - player.transform.position).magnitude;
        DepthOfFieldModel.Settings dofAttr = postProcessingProfile.depthOfField.settings;
        dofAttr.focusDistance = dof;
        postProcessingProfile.depthOfField.settings = dofAttr;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalState.current.isMissionEnding()){
            Win();
        } else if (player.GetComponent<playerShipScript>().hitPoints <= 0)
        {
            Die();
        }
        
#if UNITY_STANDALONE_OSX
            if (Input.GetButtonDown("StartMac"))
            {
                if (!startInUse)
                {
                    startInUse = true;
                    pause();
                }   
            }
            else
            {
                startInUse = false;
            }
#endif
#if UNITY_STANDALONE_WIN
        if (Input.GetButtonDown("StartWin"))
        {
            Pause();
        }

#endif
    }
#endregion Update

#region UI Event Functions

    public void LoadScene(int index)
    {
        StartCoroutine(LoadAsyncScene(index, 0));
    }

    public void Pause()
    {
        if (isPaused)
        {
            UIAnimator.SetBool("isPaused", false);
            StopCoroutine(Blur());
            StartCoroutine(UnBlur());
        }
        else
        {
            Time.timeScale = 0;
            UIAnimator.SetBool("isPaused", true);
            StopCoroutine(UnBlur());
            StartCoroutine(Blur());
        }

        isPaused = !isPaused;
    }

    public void Win()
    {
        UIAnimator.SetBool("didWin", true);
        StopCoroutine(Blur());
        StartCoroutine(LoadAsyncScene(SceneManager.GetActiveScene().buildIndex + 1, 4));
    }

    public void Die()
    {
        UIAnimator.SetBool("isDead", true);
        StopCoroutine(Blur());
        StartCoroutine(LoadAsyncScene(SceneManager.GetActiveScene().buildIndex, 4));
    }

    #endregion UI Event Functions

    #region Coroutines

    IEnumerator Blur()
    {
        float time = 0;
        DepthOfFieldModel.Settings dofAttr = postProcessingProfile.depthOfField.settings;
        float startDof = dofAttr.focusDistance;
        while (time < 2 * dofLerpTime)
        {
            dofAttr.focusDistance = Mathf.SmoothStep(startDof, -100, time / 2 * dofLerpTime);
            postProcessingProfile.depthOfField.settings = dofAttr;
            time += Time.unscaledDeltaTime;
            yield return null;
        }
        dofAttr.focusDistance = -10;
        postProcessingProfile.depthOfField.settings = dofAttr;
    }

    IEnumerator UnBlur()
    {
        float time = 0;
        DepthOfFieldModel.Settings dofAttr = postProcessingProfile.depthOfField.settings;
        float startDof = dofAttr.focusDistance;
        while (time < dofLerpTime)
        {
            dofAttr.focusDistance = Mathf.SmoothStep(startDof, dof, time / dofLerpTime);
            postProcessingProfile.depthOfField.settings = dofAttr;
            time += Time.unscaledDeltaTime;
            yield return null;
        }
        dofAttr.focusDistance = dof;
        postProcessingProfile.depthOfField.settings = dofAttr;
        Time.timeScale = 1;
    }

    IEnumerator LoadAsyncScene(int index, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        loadLevel = SceneManager.LoadSceneAsync(index);
        while (!loadLevel.isDone)
        {
            yield return null;
        }
    }

    #endregion Coroutines


    #region Cleanup
    private void OnApplicationQuit()
    {
        Cleanup(SceneManager.GetActiveScene());
    }

    void Cleanup<Scene>(Scene scene)
    {
        postProcessingProfile.depthOfField.enabled = false;
        Time.timeScale = 1;
    }
#endregion Cleanup
}
