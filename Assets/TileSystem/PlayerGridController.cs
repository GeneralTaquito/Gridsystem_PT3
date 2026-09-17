
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerGridController : MonoBehaviour
{
    GridTransform gridTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gridTransform = GetComponent<GridTransform>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2Int input = new Vector2Int(0, 0);


        gridTransform.Move(input);
    }
}
