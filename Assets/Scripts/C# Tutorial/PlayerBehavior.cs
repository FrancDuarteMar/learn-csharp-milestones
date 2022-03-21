using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    public float _vInput;
    public float _hInput;

    private Rigidbody _rb;

    public float JumpVelocity = 5f;
    private bool _isJumping;

    public float DistanceToGround = 0.1f;
    public LayerMask GroundLayer;
    private CapsuleCollider _col;

    public GameObject Bullet;
    public float BulletSpeed = 100f;
    private bool _isShooting; 

    void Start()
    {   
        _rb = GetComponent<Rigidbody>();      
        _col = GetComponent<CapsuleCollider>();  
    }
    // Update is called once per frame
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * moveSpeed;
        _hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        this.transform.Translate(Vector3.up * _hInput * Time.deltaTime);
        
        _isJumping |= Input.GetKeyDown(KeyCode.Space);

        _isShooting |= Input.GetMouseButtonDown(0);
    }
    
    void FixedUpdate() {
        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);    

        if(_isJumping){
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }
        _isJumping = false;

        if(IsGrounded() && _isJumping){
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }

        if(_isShooting){
            GameObject newBullet = Instantiate(Bullet, this.transform.position + new Vector3(1,0,0), this.transform.rotation);
            
            Rigidbody BulletRB = newBullet.GetComponent<Rigidbody>();
            
            BulletRB.velocity = this.transform.forward * BulletSpeed;
        }
        _isShooting = false;
    }

    private bool IsGrounded(){
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x, _col.bounds.min.y, _col.bounds.center.z);
        bool grounded = Physics.CheckCapsule(_col.bounds.center, capsuleBottom, DistanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);
        return grounded;
    }
}
