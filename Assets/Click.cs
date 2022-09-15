using UnityEngine;

public class Click : MonoBehaviour
{

    public void OnMouseDown()
    {
        Debug.Log($"Hello from: {gameObject.name}");
    }
}
