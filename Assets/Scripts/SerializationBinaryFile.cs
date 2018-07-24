using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class SerializationBinaryFile : MonoBehaviour {
    private Hero heroInstance;

	// Use this for initialization
	void Start () {
        // 创建一个英雄Hero类的实例，并为其基本属性赋初值
        heroInstance = new Hero();
        heroInstance.id = 10000;
        heroInstance.attack = 10000f;
        heroInstance.defence = 90000f;
        heroInstance.name = "DefaultHeroName";
    }
	
    void OnGUI()
    {
        if(GUILayout.Button("save(Serialize)", GUILayout.Width(200)))
        {
            // 将对象序列化之后生成的二进制文件保存在硬盘上
            FileStream fs = new FileStream("HeroData.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this.heroInstance);
            }
            catch(SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
                this.heroInstance = null;
            }
        }

        if(GUILayout.Button("load(Deserialize)", GUILayout.Width(200)))
        {
            // 从硬盘上读取流的内容
            FileStream fs = new FileStream("HeroData.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                this.heroInstance = (Hero)formatter.Deserialize(fs);
            }
            catch(SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
                Debug.Log(this.heroInstance.id.ToString());
                Debug.Log(this.heroInstance.attack.ToString());
                Debug.Log(this.heroInstance.defence.ToString());
                Debug.Log(this.heroInstance.name);
            }
        }
    }
}
