using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] int count;
    [SerializeField] float progress;

    public void Success()
    {
        Debug.Log("Success");
    }

    public void Process(float progress)
    {
        this.progress += progress;

        Debug.Log("Progress : " + this.progress + "%");

        if (this.progress >= 100)
        {
            this.progress = 0.0f;
        }
    }

    public void Enhance(int count)
    {
        this.count += count;

        Debug.Log("Enhancement Count : " + this.count);
    }
}
