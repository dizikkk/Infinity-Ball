using System.Collections;
using UnityEngine;

public class CreateBonuses : MonoBehaviour
{
    [SerializeField] private DamageBallFactory _damageBallFactory;

    [SerializeField] private ScoreBallFactory _scoreBallFactory;

    private Vector3 _spawnPoint;

    private void Start()
    {
        StartCoroutine(CreateBonus());
    }

    private IEnumerator CreateBonus()
    {
        while (true)
        {
            int bonusIndex = Random.Range(0, 2);

            yield return new WaitForSeconds(Random.Range(2f, 4f));

            _spawnPoint = new Vector3(Random.Range(-2.5f, 2.5f), transform.position.y);

            switch (bonusIndex)
            {
                case 0:
                    _damageBallFactory.CreateBonus(_spawnPoint);
                    break;
                case 1:
                    _scoreBallFactory.CreateBonus(_spawnPoint);
                    break;
            }
        }
    }
}