using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPindah : MonoBehaviour
{
    float speed = 3f;
    public Sprite[] sprites;
    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;

    // Use this for initialization
    void Start()
    {
        // index handle random value of sprites trash
        int index = Random.Range(0, sprites.Length);

        // assign the random sprites into this spriteRenderer
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        // declare move as a position
        float move = (speed * Time.deltaTime * -1f) + transform.position.x;

        // change the position of the trash to move it towards the move attribute
        transform.position = new Vector3(move, transform.position.y);
    }

    void OnMouseDown()
    {
        // assign the position Y as initial position
        firstY = transform.position.y;

        // assign the position of trash that clicked by user
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        
        // assign the distance between trashPosition and mousePosition
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        // assign the mousePosition
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        
        // assign the result of currentScreenPoint that added by offset
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        
        // move trash follow the mousePosition
        transform.position = curPosition;
    }

    private void OnMouseUp()
    {
        // move trash into the new position
        transform.position = new Vector3(transform.position.x, firstY, transform.position.z);
    }
}