using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public EnemyDataSO enemyData;
    public PatrolRouteManager myPatrolRoute;
    private float _moveSpeed;
    private int _maxHealtPoints;
    
    private GameObject _enemyMesh;

    public float FollowDistance => _followDistance;
    public float _followDistance; //x distancia minima para seguir o jogador

    public float ReturnDistance => _returnDistance;
    public float _returnDistance; //z distancia maxima para seguir o jogador

    public float AttackDistance => _attackDistance;
    public float _attackDistance; //y distancia minima para atacar o jogador

    public float GiveUpDistance => _giveUpDistance;
    public float _giveUpDistance; //w distancia maxima para atacar o jogador

    private int _currentHealthPoints;
    private float _currentMoveSpeed;

    private Animator _enemyFSM;
    private NavMeshAgent _navMeshAgent;

    private SphereCollider _sphereCollider;
    private void Awake()
    {
        _moveSpeed = enemyData.moveSpeed;
        _maxHealtPoints = enemyData.maxHealtPoints;
        //_enemyMesh = Instantiate(enemyData.enemyMesh, transform);

        _followDistance = enemyData.followDistance;
        _returnDistance = enemyData.returnDistance;
        _attackDistance = enemyData.attackDistance;
        _giveUpDistance = enemyData.giveUpDistance;

        _currentHealthPoints = _maxHealtPoints;
        _currentMoveSpeed = _moveSpeed;

        _enemyFSM = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _sphereCollider = GetComponent<SphereCollider>();
    }

    void Start()
    {
        // :(
    }

    void Update()
    {
        // :(
    }

    public void SetSphereRadius(float value)
    {
        _sphereCollider.radius = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(message: "Jogador entrou na area");
        }
    }
}


