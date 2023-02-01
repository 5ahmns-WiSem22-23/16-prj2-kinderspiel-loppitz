using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRules : MonoBehaviour
{
    public void ButtonClick()
    {
        SceneManager.LoadScene("RulesScene");
    }
}
