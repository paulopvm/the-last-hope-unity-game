using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour
{

    private Transform target;
    private Enemy targetenemy;

    [Header("General")]

    public float range = 15f;

    [Header("Use Bullets (default)")]
    public GameObject tiroPrefab;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    [Header("Use Laser")]
    public bool useLaser = false;

    public int damageOverTime = 30;
    public float slowAmount = .5f;

    public LineRenderer linerenderer;
    public ParticleSystem impacteffect;
    public Light impactlight;

    [Header("Unity Setup Fields")]

    public string enemyTag = "Enemy";
	public string enemyTag2 = "Enemy2";


    public Transform partToRotate;
    public float turnSpeed = 10f;

    public Transform initTiro;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
		GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
		GameObject[] enemies2 = GameObject.FindGameObjectsWithTag(enemyTag2);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

		foreach (GameObject enemy in enemies2)
		{
			float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
           // targetEnemy = nearestEnemy.GetComponent<Enemy>();
        }
        else
        {
            target = null;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            if (useLaser)
            {
                if (linerenderer.enabled)
                {
                    linerenderer.enabled = false;
                    impacteffect.Stop();
                    impactlight.enabled = false;
                }
            }

            return;
        }

        LockOnTarget();

        if (useLaser)
        {
            laser();
        }
        else
        {
            if (fireCountdown <= 0f)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }

            fireCountdown -= Time.deltaTime;
        }

    }

    void LockOnTarget()
    {
        Vector3 dir = (target.position - transform.position) * (-1);
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }

    void laser()
    {
        //targetenemy.takedamage(damageovertime * time.deltatime);
        //targetenemy.slow(slowamount);

        if (!linerenderer.enabled)
        {
            linerenderer.enabled = true;
            impacteffect.Play();
            impactlight.enabled = true;
        }

        linerenderer.SetPosition(0, initTiro.position);
        linerenderer.SetPosition(1, target.position);

        Vector3 dir = initTiro.position - target.position;

        impacteffect.transform.position = target.position + dir.normalized;

        impacteffect.transform.rotation = Quaternion.LookRotation(dir);
    }

    void Shoot()
    {
        Debug.Log("ATIROU");

        GameObject tiroObject = (GameObject)Instantiate(tiroPrefab, initTiro.position, initTiro.rotation);
		Tiro tiro = tiroObject.GetComponent<Tiro>();

		if (tiro != null)
			tiro.Procurar(target);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}