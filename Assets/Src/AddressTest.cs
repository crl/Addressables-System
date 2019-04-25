using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressTest : MonoBehaviour
{
    public AssetReference assetReference;

    private GameObject go;
    // Start is called before the first frame update
    async void Start()
    {
        go=await this.assetReference.Instantiate(Vector3.zero,Quaternion.identity).Task;
    }

    // Update is called once per frame
    void Update()
    {
        if(go!=null){
            go.transform.Rotate(new Vector3(0,60*Time.deltaTime,0),Space.Self);
        }
        
    }
}
