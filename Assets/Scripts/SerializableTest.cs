using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializableTest : MonoBehaviour {
    public SerializableClass serializableClass;

	// Use this for initialization
	void Start () {
        this.serializableClass = new SerializableClass("chenjiadong", 26, true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 150, 100), "Serialize"))
        {
            string fileName = "serializableClass.dat";
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fStream, this.serializableClass);
            fStream.Close();
            this.serializableClass.name = "yanliang";
            Debug.Log("the class name is: " + this.serializableClass.name);
        }

        if (GUI.Button(new Rect(300, 10, 150, 100), "Deserialize"))
        {
            string fileName = "serializableClass.dat";
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter binFormat = new BinaryFormatter();
            this.serializableClass = binFormat.Deserialize(fStream) as SerializableClass;
            fStream.Close();
            this.serializableClass.name = "yanliang";
            Debug.Log("after Deserialize the class name is: " + this.serializableClass.name);
        }
    }
}
