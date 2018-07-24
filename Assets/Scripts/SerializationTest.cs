using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializationTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 创建一个英雄Hero类的实例
        // 并为其基本属性赋初始值
        Hero heroInstance = new Hero();
        heroInstance.id = 10000;
        heroInstance.attack = 10000f;
        heroInstance.defence = 90000f;
        heroInstance.name = "DefaultHeroName";
        // 进行序列化
        Stream stream = InstanceDataToMemory(heroInstance);

        // 为了演示下面的反序列化之后的结果，此处将刚刚创建的英雄Hero类实例的数据进行重置
        stream.Position = 0;
        heroInstance = null;

        // 反序列化生成英雄Hero类的实例，并且打印其属性值，可以发现是我们初始赋值给它的值
        heroInstance = (Hero)this.MemoryToInstanceData(stream);

        Debug.Log(heroInstance.id.ToString());
        Debug.Log(heroInstance.attack.ToString());
        Debug.Log(heroInstance.defence.ToString());
        Debug.Log(heroInstance.name);
	}
	
    // InstanceDataToMemory方法用来实现将对象序列化到流中的逻辑
    MemoryStream InstanceDataToMemory(object instance)
    {
        // 创建一个新的流来容纳经过序列化的对象
        MemoryStream memoStream = new MemoryStream();
        // 创建一个序列化格式化器来执行具体的序列化操作
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        // 将传入的对象instance序列化到流memoStream中
        binaryFormatter.Serialize(memoStream, instance);
        // 返回序列化好的流
        return memoStream;
    }

    // MemoryToInstanceData方法用来实现将流反序列化为对象的逻辑
    object MemoryToInstanceData(Stream memoryStream)
    {
        // 创建一个序列化格式化器来执行具体的反序列化操作
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        // 返回从流memoryStream中反序列化得到的对象
        return binaryFormatter.Deserialize(memoryStream);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
