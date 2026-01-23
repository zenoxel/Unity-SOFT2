public class PlayerShooting : MonoBehaviour
{
public GameObject bulletPrefabs;
public float shootingInterval;
private float lastBulletTime;public class PlayerShooting1 : MonoBehaviour
{
public GameObject bulletPrefab;

void Update()
{
if (Input.GetMouseButtonDown(0))
{
Instantiate(bulletPrefab, transform.position,
transform.rotation);
}
}
}
void Update()
{
if (Input.GetMouseButton(0))
{
if (Time.time - lastBulletTime >
shootingInterval)
{
ShootBullet();
lastBulletTime = Time.time;
}
}
}

private void ShootBullet()
{
Instantiate(bulletPrefabs, transform.position, transform.rotation);
}
}