using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float thoiGianChoPhepVeDich = 5f;
    public bool ketThucGame = false;
    public bool winGame = false;
    private static GameManager instance;
    public GameObject timeTextObject;
    public GameObject gameOverObject;

    public GameObject winGameObject;

    public float thoiGianHoiKhiQuaCheckPoint = 10;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject();
                    instance = singletonObject.AddComponent<GameManager>();
                    singletonObject.name = typeof(GameManager).ToString() + " (Singleton)";
                }
            }
            return instance;
        }
    }

    public void Update()
    {
        if(!ketThucGame)
        {
            thoiGianChoPhepVeDich -= Time.deltaTime;
            Debug.Log("Thoi gian con lai: " + thoiGianChoPhepVeDich);
            if (thoiGianChoPhepVeDich <= 0)
            {
                timeTextObject.SetActive(false);
                KetThucGame();
                gameOverObject.SetActive(true);
            }
        }

        if(winGame)
        {
            timeTextObject.SetActive(false);
            winGameObject.SetActive(true);
        }
    }


    private void KetThucGame()
    {
        ketThucGame = true;

    }

    public void QuaCheckPoint()
    {
        if(!ketThucGame)
        {
            thoiGianChoPhepVeDich  = thoiGianHoiKhiQuaCheckPoint;
        }
    }

    public void QuaWinPoint()
    {
        if(!ketThucGame)
        {
            winGame = true;
            winGameObject.SetActive(true);
        }
    }
}
