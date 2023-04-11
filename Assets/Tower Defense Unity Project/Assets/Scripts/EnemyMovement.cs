using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.AI;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour {

	public Transform target;
	// private int wavepointIndex = 0;

	private Enemy enemy;

	NavMeshAgent agent; 

	void Start()
	{
		enemy = GetComponent<Enemy>();
		agent = GetComponent<NavMeshAgent>();
		
		// target = Waypoints.points[0];
	}

	void Update()
	{
		// Vector3 dir = target.position - transform.position;
		// transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);
		//
		// if (Vector3.Distance(transform.position, target.position) <= 0.4f)
		// {
		// 	GetNextWaypoint();
		// }
		agent.SetDestination(target.position); 
		

	}
	private void OnTriggerEnter(Collider other)
     		{
     			
                PlayerStats.Lives--;
                          		
                WaveSpawner.EnemiesAlive--;
                          		
                
                Destroy(gameObject);
     		}

	// void GetNextWaypoint()
	// {
	// 	if (wavepointIndex >= Waypoints.points.Length - 1)
	// 	{
	// 		EndPath();
	// 		return;
	// 	}
	//
	// 	wavepointIndex++;
	// 	target = Waypoints.points[wavepointIndex];
	// }

	void EndPath()
	{
		
	}

}
