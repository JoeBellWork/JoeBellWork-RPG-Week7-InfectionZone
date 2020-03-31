using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BoidBehaviour : ScriptableObject
{
    public abstract Vector3 CalculateMove(BoidAgent agent, List<Transform> context, Boid boid);
}
