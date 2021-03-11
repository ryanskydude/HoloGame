using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyAI : MonoBehaviour
{
    public Transform Player;

    private bool chasing, attacking;

    public float perceptionDistance = 30, chaseDistance = 20, chaseSpeed = 4, chaseTime, attackDistance = 1, walkVelocity = 6, attackTime = 1.5f, enemyDamage = 50, playerDistance;
    public bool seeingPlayer;
    public float enemyHealth;
    public float totalEnemyHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = totalEnemyHealth;
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(Player.transform.position, transform.position);
        RaycastHit hit;

        Vector3 startRay = transform.position;
        Vector3 endRay = Player.transform.position;
        Vector3 direction = endRay - startRay;

        if (Physics.Raycast(transform.position, direction, out hit, 1000) && playerDistance < perceptionDistance)
        {
            seeingPlayer = true;
            chase();
        }
    }
    
    private void chase()
    {
        while (transform.position != Player.transform.position)
        {
            chaseTime = (Vector3.Distance(Player.transform.position, transform.position))/chaseSpeed;
            transform.position = Vector3.Lerp(transform.position, Player.transform.position, chaseTime);
        }
    }
}
