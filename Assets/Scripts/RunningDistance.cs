using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RunningDistance : MonoBehaviour
{
    private float Distance = 0.0f;
    public TextMeshProUGUI DistanceText;
    private int Difficulty = 1;
    private int MaxDifficulty = 10;
    private int DistanceForDifficulty = 35;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Distance += Time.deltaTime * 2;
        DistanceText.text = ((int)Distance).ToString();
        if(Distance > DistanceForDifficulty)
        {
            IncreaseSpeed ();
        }
    }

    void IncreaseSpeed()
    {
        DistanceForDifficulty *= 2;
        Difficulty++;
        GetComponent<PlayerController>().IncreaseSpeed(Difficulty);

        if (Difficulty == MaxDifficulty)
        {
            return;
        }
        Debug.Log(Difficulty);
    }

}
