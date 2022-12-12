using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public int curHp;
    public int maxHp;
    public AudioClip deathSound;
    [Header("Player Movement")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;
    private Camera camera;
    private Rigidbody rigb;
    private GameManager gm;
    private AudioSource mainMusic;

    [Header("Ui")] public TextMeshProUGUI healthText;

    private void Awake()
    {
        camera = Camera.main;
        rigb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        mainMusic = GameObject.Find("Music").GetComponent<AudioSource>();
        curHp = maxHp;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    public void TakeDamage(int damage)
    {
        curHp = Mathf.Clamp(curHp - damage, 0, maxHp);
        UpdateHealth();
        if (curHp <= 0)
            Die();
    }

    public void GiveHealth(int value)
    {
        curHp = Mathf.Clamp(curHp + value, 0, maxHp);
        UpdateHealth();
    }

    public void GiveAmmo(int value)
    {
        
    }

    public void Die()
    {
        AudioSource.PlayClipAtPoint(deathSound,transform.position);
        mainMusic.Stop();
        Time.timeScale = 0.25f;
        Time.fixedDeltaTime = 0.02f*Time.timeScale;
        gm.gameOver = true;
        gm.youLostText.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        CameraLook();
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal")*moveSpeed;//left and right
        float z = Input.GetAxis("Vertical")*moveSpeed;//forward and back

        //rigb.velocity = new Vector3(x, rigb.velocity.y, z);
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rigb.velocity.y;
        rigb.velocity = dir;
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X")*lookSensitivity;//look up and down
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;//look left and right
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);//restrict rotation on x-axis between maxLookX and minLookX
        
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0 ,0);
        transform.eulerAngles += Vector3.up * y; 
        
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if (Physics.Raycast(ray, 1.1f))
        {
            rigb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        }
    }

    void UpdateHealth()
    {
        healthText.text = "Health : "+curHp;
    }

}
