using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBack : MonoBehaviour
{
    public void ButtonClick()
    {
        SceneManager.LoadScene("StartScene");
    }
}
