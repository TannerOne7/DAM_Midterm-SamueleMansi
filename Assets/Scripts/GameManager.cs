using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int scoreSin = 0;
    int scoreDes = 0;
    public TextMeshProUGUI UIScoreSin;
    public TextMeshProUGUI UIScoreDes;
    public void PunteggioSin()
    {
        
        scoreDes++;
        UIScoreDes.text = scoreDes.ToString();
    }
    public void PunteggioDes()
    {
        
        scoreSin++;
        UIScoreSin.text = scoreSin.ToString();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
