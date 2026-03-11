using UnityEngine;

public class ToggleSetActive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ToggleSetActiveFunc ()
    {
        gameObject.SetActive ( !gameObject.activeSelf );
    }
}
