using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private GameBehavior _gameManager;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();

        _gameManager = gameObject.Find("Game manager").GetComponent<GameBehavior>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision Collision)
    {
        if(collison.GameObject.name == "Enemy")
        {
            _gameManager.HP -= 1;
        }
    }
}
