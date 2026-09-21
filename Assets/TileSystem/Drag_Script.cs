using UnityEngine;

public class Drag_Script : MonoBehaviour
{
    [SerializeField] GridManager gridManager;
    [SerializeField] GridTransform gridTransform;
    Vector3 mouseposition;

        void Start()
    {
        gridTransform = GetComponent<GridTransform>();
    }
    private Vector3 Getmousepos() 
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDown()
    {
        mouseposition = Input.mousePosition - Getmousepos();
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mouseposition);
    }
    private void OnMouseUp() //WTH
    {
        Vector2Int input = new Vector2Int(0, 0);
        var lastknown = transform.position;
        Mathf.Round(lastknown.x);
        Mathf.Round(lastknown.z);
        lastknown.z = input.y;  
        lastknown.x = input.x;
        gridTransform.Move(input);
    }
}
