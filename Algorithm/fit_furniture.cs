using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using UnityEngine;
using Object = UnityEngine.Object;

public class placefurniture : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer rend;
    public GameObject obj;
    private Renderer[] renderers;
    private int count;
    private Renderer[] fitting;
    private float[,] mat;
    private int length;
    private int width;
    private int lastobjl = 0;
    private int lastobjb = 0;
    private Boolean a;
    void Start()
    {
        rend = GetComponent<Renderer>();
        renderers = (Renderer[])Object.FindObjectsOfType(typeof(Renderer));
        count = 0;
        fitting=new Renderer[6];
        int ind = 0;
        for (int i = 0; i < renderers.Length; i++)
        {
            if (renderers[i].tag == "Fitting")
            {
                fitting[ind] = renderers[i];
                ind++;
                Debug.Log(ind);
                count++;
            }
        }

         length = (int)(rend.bounds.size[0]*10);
         width = (int)(rend.bounds.size[2]*10);
        mat =new float[length,width];
        placefurnitures();

    }

    void placefurnitures()
    {
        int l0 = (int)(fitting[0].bounds.size[0]*10);
        for (int i = 0; i < count; i++)
        {
            int l = (int)(fitting[i].bounds.size[0]*10);
            int b = (int)(fitting[i].bounds.size[2]*10);
            int[,] coordinate = findpsapce(l, b);
            if (i == 1)
            {
                fitting[i].transform.position = rend.transform.position+  (new Vector3((length / 2 - coordinate[0, 0]-34), 0, width / 2 - coordinate[0, 1]-(float)0.5))/10;
            }
            else if(i!=0)
            {
                fitting[i].transform.position = rend.transform.position+  (new Vector3((length / 2 - coordinate[0, 0]), 0, width / 2 - coordinate[0, 1]-(float)0.5))/10;
            }
            else
            {
                fitting[i].transform.position = rend.transform.position+  (new Vector3((length / 2 - coordinate[0, 0]), 0, width / 2 - coordinate[0, 1]-(float)0.5))/10;
            }
            
            Debug.Log(i+coordinate[0,0] +" "+coordinate[0,1]);

        }

        
    }
    // Update is called once per frame
    void Update()
    {   
    }

    int[,] findpsapce(int l,int b)
    {
        int[,] output =new int[2,2];
        a = true;
        for (int i = l/2; i < length; i++)
        {
            if (mat[i, 0] == 0)
            {
                if (i + l <= length && mat[i+1,0]==0)
                {
                    output[0, 0] = i;
                    output[0, 1] = b/2;
                    for (int j = i; j < i+l; j++)
                    {
                        for (int k = 0; k < b; k++)
                        {
                            mat[j, k] = 1;
                        }
                    }
                    lastobjl = l;
                    lastobjb = b;
                    return (output);
                }
            }
        }

        for (int i = b; i < width; i++)
        {
            if (mat[0, i] == 0)
            {
                if (i + b <= width)
                {
                    output[0, 0] = 0;
                    output[0, 1] = b;
                }
            }
        }
        return output;
        
    }
    static public Bounds RecursiveMeshBB(GameObject go) {
        MeshFilter[] mfs = go.GetComponentsInChildren<MeshFilter>();
 
        if (mfs.Length>0) {
            Bounds b = mfs[0].mesh.bounds;
            for (int i=1; i<mfs.Length; i++) {
                b.Encapsulate(mfs[i].mesh.bounds);
            }
            return b;
        }
        else
            return new Bounds();
    }
}
