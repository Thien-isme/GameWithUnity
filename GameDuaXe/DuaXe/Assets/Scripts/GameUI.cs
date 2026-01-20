using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        HienThiThoiGianGame();
    }

    public void HienThiThoiGianGame()
    {
        float thoiGianConLai = GameManager.Instance.thoiGianChoPhepVeDich;
        if (thoiGianConLai < 0)
        {
            thoiGianConLai = 0;
        }
        timeText.text = thoiGianConLai.ToString("F2") + "s";
    }

    public void ChoiLai()
    {
        SceneManager.LoadScene("Game");
    }

    public void VeMenu()
    {
        SceneManager.LoadScene("Menu");
    }




}
