using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using System.Linq;
using Cinemachine;
using UnityEngine;
using UnityEngine.Polybrush;


public class Enemy : MonoBehaviour
{
    public float moveSpeed, attackRange, yPathOffset, attackDelay,maxAttackDelay;
    public int curHp, maxHp,damage;

    private List<Vector3> path;

    private GameObject target;
    private PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        attackDelay = maxAttackDelay;
        target = FindObjectOfType<PlayerController>().gameObject;
        player = GameObject.Find("player").GetComponent<PlayerController>();
        InvokeRepeating("UpdatePath",0.0f,0.5f);//updates the path every .5 seconds
        curHp = maxHp;
    }

    void UpdatePath()
    {
        NavMeshPath navMeshPath = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, target.transform.position, NavMesh.AllAreas, navMeshPath);
        path = navMeshPath.corners.ToList();
    }

    void ChaseTarget()
    {
        if(path.Count == 0)
            return;
        transform.position = Vector3.MoveTowards(transform.position, path[0] + new Vector3(0, yPathOffset, 0),
            moveSpeed * Time.deltaTime);
        if(transform.position==path[0]+new Vector3(0,yPathOffset,0))
            path.RemoveAt(0);
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;
        if(curHp <=0)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        transform.eulerAngles = Vector3.up * angle;

        float dist = Vector3.Distance(transform.position, target.transform.position);
        if ((dist <= attackRange)&&(attackDelay<=0))
        {
            player.TakeDamage(damage);
            attackDelay = maxAttackDelay;
        }
        else
        {
            ChaseTarget();
            attackDelay -= Time.deltaTime;
        }
        
    }
}
