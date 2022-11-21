using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Assets/Enemy", order = 0)]
public class EnemyDataSO : ScriptableObject
{
    public float moveSpeed;
    public int maxHealtPoints;
    
    public GameObject enemyMesh;
    
    public float followDistance; //x distancia minima para seguir o jogador
    
    public float returnDistance; //z distancia maxima para seguir o jogador
    
    public float attackDistance; //y distancia minima para atacar o jogador
    
    public float giveUpDistance; //w distancia maxima para atacar o jogador
}