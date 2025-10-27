using UnityEngine;

public class DesktopPet : MonoBehaviour
{
    private Vector3 targetPosition;
    private float moveSpeed = 1.5f;

    private void Start()
    {
        SetNewTarget();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed*Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            SetNewTarget();
    }

    private void SetNewTarget()
    {

        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);
        targetPosition = new Vector3(x, y, 0);
    }


}
