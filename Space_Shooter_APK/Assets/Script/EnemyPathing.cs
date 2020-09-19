using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] List<Transform> wayPoints;
    int wayPointIndex = 0;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = wayPoints[wayPointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    public void MoveEnemy()
    {
        if(wayPointIndex < wayPoints.Count)
        {
            var currentPos = transform.position;
            var targetPos = wayPoints[wayPointIndex].transform.position;
            var travelSpeed = moveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(currentPos, targetPos, travelSpeed);

            if(transform.position == wayPoints[wayPointIndex].transform.position)
            {
                wayPointIndex++;
            }
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
