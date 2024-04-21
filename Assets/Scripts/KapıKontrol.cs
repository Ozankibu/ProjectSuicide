using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapıKontrol : MonoBehaviour
{
    private float dönüşAçısı = 90f;
    private Quaternion kapıAçıkRotasyon;
    private Quaternion kapıKapalıRotasyon;

    // Start is called before the first frame update
    void Start()
    {
        kapıAçıkRotasyon = transform.rotation * Quaternion.Euler(0, -90, 0);
        kapıKapalıRotasyon = transform.rotation;



    }
     void OnMouseDown()
    {
        if(!kapıAçık)
            transform.rotation=kapıAçıkRotasyon
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
