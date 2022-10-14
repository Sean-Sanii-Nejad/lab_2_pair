using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public Vector2 moveValue;
    public float speed;
    private int count;
    private int numPickups = 5;
    public GameObject obj;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI playerPosition, velocity;
    private void Start()
    {
        count = 0;
        winText.text = "";
        SetCountText();
    }
    private void Update()
    {
        playerPosition.text = obj.transform.position.ToString();
        velocity.text = obj.GetComponent<Rigidbody>().velocity.ToString();
    }
    void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }    
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveValue.x, 0.0f, moveValue.y);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.fixedDeltaTime);
    }
    private void SetCountText()
    {
        scoreText.text = "Score:" + count.ToString();
        if(count >= numPickups)
        {
            winText.text = "You Win!";
        }
    }
}
