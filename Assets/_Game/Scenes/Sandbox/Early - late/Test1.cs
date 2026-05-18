using UnityEngine;

public class EarlyLateJudge : MonoBehaviour
{
    public Transform note;
    public Transform hitLine;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Judge();
        }
    }

    void Judge()
    {
        float distance = note.position.y - hitLine.position.y;

        // B?m s?m
        if (distance > 0)
        {
            Debug.Log("EARLY");
        }
        // B?m tr?
        else
        {
            Debug.Log("LATE");
        }
    }
}