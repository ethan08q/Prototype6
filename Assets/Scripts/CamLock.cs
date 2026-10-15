using UnityEngine;

public class CamLock : MonoBehaviour
{

    public Transform Player;
    public float test = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        transform.position = new Vector3(Player.position.x, Player.position.y, Player.position.z);
    }
}
