using UnityEngine;

public class SavePosition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadPlayerPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        SavePlayerPosition();
    }


    public void SavePlayerPosition()
    {
        Vector3 playerPos = transform.position;
        PlayerPrefs.SetFloat("PlayerPosX", playerPos.x);
        PlayerPrefs.SetFloat("PlayerPosY", playerPos.y);
        PlayerPrefs.SetFloat("PlayerPosZ", playerPos.z);
        PlayerPrefs.Save();
    }

    public void LoadPlayerPosition()
    {
        float x = PlayerPrefs.GetFloat("PlayerPosX", 0f);
        float y = PlayerPrefs.GetFloat("PlayerPosY", 0f);
        float z = PlayerPrefs.GetFloat("PlayerPosZ", 0f);
        transform.position = new Vector3(x, y, z);
    }


}
