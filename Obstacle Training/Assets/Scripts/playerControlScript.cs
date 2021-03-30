using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControlScript : MonoBehaviour
{
    private float hMove;
    private float vMove;
    [SerializeField] private float moveSpeed=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMov();
    }

    private void playerMov()
    {
        hMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        vMove = Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(hMove, 0, vMove);
    }
}
