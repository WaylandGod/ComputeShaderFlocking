using UnityEngine;

struct TrailNode
{

	public Vector3 position;
	public Vector3 velocity;
	public Vector3 targetPosition;
	public float mass;
	public float maxSpeed;
	public float maxTurnSpeed;
	public float numberOfNodes;
	public float obsCount;
	public Vector3[] positions;

}