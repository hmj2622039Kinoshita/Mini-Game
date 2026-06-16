//using UnityEngine;

//public class Random_Play2 : MonoBehaviour
//{
//    [SerializeField] GameObject createPrefab;
//    Transform rangeA;
//    Transform rangeB;
//    [SerializeField] float Y = 6.3f;

//    private void Start()
//    {
//        float X = Random.Range(rangeA.position.x, rangeB.position.x);

//        Instantiate(createPrefab, new Vector2(X, Y), createPrefab.transform.rotation);

//    }

//    public void SetRangeA(Transform rangeA)
//    {
//        this.rangeA = rangeA;
//    }

//    public void SetRangeB(Transform rangeB)
//    {
//        this.rangeB = rangeB;
//    }

//    //private void Update()
//    //{
//    //    time += Time.deltaTime;

//    //    if(time  > 1.0f)
//    //    {
//    //        float X = Random.Range(rangeA.position.x, rangeB.position.x);

//    //        Instantiate(createPrefab, new Vector2(X, Y), createPrefab.transform.rotation);
//    //    }

//    //}
//}
