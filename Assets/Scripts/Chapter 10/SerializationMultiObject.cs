using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class SerializationMultiObject : MonoBehaviour {
    private Hero heroInstance;
    private Soldier soldierInstance;


	// Use this for initialization
	void Start () {
        // 分别构造Hero类型的对象和Soldier类型的对象，并对它们的字段进行初始化
        heroInstance = new Hero();
        heroInstance.id = 10000;
        heroInstance.attack = 10000f;
        heroInstance.defence = 90000f;
        heroInstance.name = "DefaultHeroName";

        soldierInstance = new Soldier();
        soldierInstance.id = 90;
        soldierInstance.attack = 90f;
        soldierInstance.defence = 100f;
        soldierInstance.name = "DefaultSoldierName";
    }

    void OnGUI()
    {
        if (GUILayout.Button("save(Serialize)", GUILayout.Width(200)))
        {
            // 将对象序列化之后生成的二进制文件保存在硬盘上
            FileStream fs = new FileStream("HeroAndSoldierData.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                // 将两个对象经过序列化后的字节块全部存放在同一个流中
                formatter.Serialize(fs, this.heroInstance);
                formatter.Serialize(fs, this.soldierInstance);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
                this.heroInstance = null;
                this.soldierInstance = null;
            }
        }

        if (GUILayout.Button("load(Deserialize)", GUILayout.Width(200)))
        {
            // 从硬盘上读取流的内容
            FileStream fs = new FileStream("HeroAndSoldierData.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                this.heroInstance = (Hero)formatter.Deserialize(fs);
                this.soldierInstance = (Soldier)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
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

                Debug.Log(this.soldierInstance.id.ToString());
                Debug.Log(this.soldierInstance.attack.ToString());
                Debug.Log(this.soldierInstance.defence.ToString());
                Debug.Log(this.soldierInstance.name);
            }
        }
    }
}
