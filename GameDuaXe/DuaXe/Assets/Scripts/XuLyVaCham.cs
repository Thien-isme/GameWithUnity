using UnityEngine;

public class XuLyVaCham : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CheckPoint"))
        {
            GameManager.Instance.QuaCheckPoint();
        }

        if(other.CompareTag("WinPoint"))
        {
            GameManager.Instance.QuaWinPoint();
           
        }
    }
}
