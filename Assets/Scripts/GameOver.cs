using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public Text roundsText;

    void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

}