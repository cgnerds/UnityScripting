using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class SerializationContext : MonoBehaviour {

    private Hero heroInstance;

	// Use this for initialization
	void Start () {
        heroInstance = new Hero(1000, 5000f, 1000f, 1000f);
        // 克隆
        Hero newHero = (Hero)this.DeepCloneTest(heroInstance);
        // 打印出克隆得到的对象的字段值
        Debug.Log(newHero.id.ToString());
        Debug.Log(newHero.attack.ToString());
        Debug.Log(newHero.ToString());
    }

    private object DeepCloneTest(object oldHero)
    {
        // 构造临时内存流
        using(MemoryStream stream = new MemoryStream())
        {
            // 构造格式化器，用来进行序列化
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            // 设置流的上下文设置
            binaryFormatter.Context = new StreamingContext(StreamingContextStates.Clone);
            // 将要被克隆的对象序列化到内存中
            binaryFormatter.Serialize(stream, oldHero);
            // 在进行反序列化之前，需要先定位到内存流的起始位置
            stream.Position = 0;
            // 将内存流中的内容反序列化成新的对象
            return binaryFormatter.Deserialize(stream);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
