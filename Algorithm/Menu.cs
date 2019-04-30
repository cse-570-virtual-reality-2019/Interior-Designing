    
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

using System;
using System.IO;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public static String s;
    //private fitter[] objects;
    private List<fitter> objectsdx;
    private List<fitter> objectspx;
    public InputField objects;
   
    void Start()
    {
         
         readfile();
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void readfile()
    {
        string file_path = "D:/FittingPlacerForUnity/Assets/roomprob.txt";
        StreamReader inp_stm = new StreamReader(file_path);
        String inp_ln = inp_stm.ReadLine();
        Debug.Log(inp_ln);
        //objects=new fitter[int.Parse(inp_ln)];
        objectsdx = new List<fitter>();
        objectspx= new List<fitter>();
        fitter obj;
        for (int i = 0; i < int.Parse(inp_ln); i++)
        {
            String line=inp_stm.ReadLine();
            string[] ar = line.Split(',');
            //Debug.Log();
            String name = ar[0];
            float px = float.Parse(ar[1]);
            float dx = float.Parse(ar[2]);
            Debug.Log(name+" "+px+" "+dx);
            obj=new fitter(name,dx,px);
            objectsdx.Add(obj);
            objectspx.Add(obj);

        }
        Debug.Log("Read from file Done");
        objectsdx.Sort(new Dxcomparision());
        objectspx.Sort(new Pxcomparision());
       
        
    }

    public void drawingroom()
    {
        s = objectsdx[0].Name;
        for (int i = 1; i < 4; i++)
        {
            s = s + "," + objectsdx[i].Name;
        }

        Debug.Log(s);
        SceneManager.LoadScene(1);
    }
    public void playingroom()
    {
        s = objectspx[0].Name;
        for (int i = 1; i < 4; i++)
        {
            s = s + "," + objectspx[i].Name;
        }

        Debug.Log(s);
        SceneManager.LoadScene(1);
    }
    public void enterroom()
    {
        s = objects.text;
        Debug.Log(s);
        SceneManager.LoadScene(1);
    }
}

class fitter
{
    public String Name;
    public float dx;
    public float px;

    public fitter(String name,float dx,float px)
    {
        this.Name = name;
        this.dx = dx;
        this.px = px;
    }
}

class Dxcomparision : IComparer<fitter>
{
    public int Compare(fitter a,fitter b)
    {
        return b.dx.CompareTo(a.dx);
    }
}
class Pxcomparision : IComparer<fitter>
{
    public int Compare(fitter a,fitter b)
    {
        return b.px.CompareTo(a.px);
    }
}