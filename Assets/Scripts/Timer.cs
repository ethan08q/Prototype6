using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer = 15f;


    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Debug.Log("Timer has reached zero!");
            //timer = 15f; // Reset the timer if needed
            SceneManager.LoadScene(0);
        }

       
    }
}
