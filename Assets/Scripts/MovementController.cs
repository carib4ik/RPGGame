using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Получаем вектор точки клика мышью
        GetDestination();
        
        // Перемещаем персонажа в направлении _destination.
        _navMeshAgent.SetDestination(_destination);
        
        // TODO: Получите точку, по которой кликнули мышью и задайте ее вектор в поле _destination.
    }
    
    private void GetDestination()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hitInfo, 100f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var point = hitInfo.point;
                _destination = new Vector3(point.x, point.y, point.z);
            }
        }
    }
}