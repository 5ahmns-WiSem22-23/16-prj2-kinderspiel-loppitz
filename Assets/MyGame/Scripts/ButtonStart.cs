using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonStart : MonoBehaviour
{
    
        public void ButtonClick()
    {
        SceneManager.LoadScene("MainScene");
    }  
}
