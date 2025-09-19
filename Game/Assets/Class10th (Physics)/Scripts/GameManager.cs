using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;

    public void Increase()
    {
        score++;

        Debug.Log(score);
    }
} 
