using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
   public void LoadStartScene()
   {
      SceneManager.LoadScene("Level 1");
   }

   public void LoadScene()
   {
      SceneManager.LoadScene("Start Scene");
   }
}
