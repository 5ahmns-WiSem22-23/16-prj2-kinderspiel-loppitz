using UnityEngine;

public class snakes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger entered");
        if (true)
        {
            Object.Destroy(collider.gameObject);

        }
    }
}
