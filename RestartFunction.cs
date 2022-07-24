using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartFunction : MonoBehaviour
{
    public GameObject BackgroundAudio;
    public void RestarScene(){
     SceneManager.LoadScene("MainGameScene");  
     Destroy(BackgroundAudio);
    }
}
    
  