using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMainMenu" , 3);
    }

   public void LoadMainMenu() {
       SceneManager.LoadScene("MainMenu");
   }
}
