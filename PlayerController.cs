using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody2D _playerRigidbody2D;
    public float        _playerSpeed;   //Variavel sera vista no inspector do Player 
    private Vector2     _playerDirection;

    // Start é chamado antes do primeiro frame Update
    void Start()    
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();   //A partir disso todos os componentes do RigidBody(criado anteriormenrte no Unity) vem para a variável
    }

    // Update é chamado frame a frame(depende de como o jogo esta rodando)
    void Update()   //classe 
    {
        _playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));   //Atualiza a posição
    }

    // Fixed Updtate é chamado em um controle fixo de frames(a cada 0.02 segundos)
    void FixedUpdate()  //Por padrão vem como "private void FixedUpdate" pode apagar o private
    {
        _playerRigidbody2D.MovePosition(_playerRigidbody2D.position + _playerDirection * _playerSpeed * Time.fixedDeltaTime);
    }
}
