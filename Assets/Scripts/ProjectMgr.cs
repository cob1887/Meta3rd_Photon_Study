using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectMgr : MonoBehaviour
{
    // 자기 자신을 가지고 있는 static 변수
    static ProjectMgr instance;

    // instance 를 반환하는 static 함수
    public static ProjectMgr Get()
    {
        // 만약에 instance 가 null이라면
        if(instance == null) {
            // gameobject 하나 만든다. (이름을 ProjectMgr)
            GameObject go = new GameObject(nameof(ProjectMgr));
            // 만들어진 gameObject 에 projectMgr 컴포넌트 추가
            go.AddComponent<ProjectMgr>();       
        }
        return instance;
    }

    // 내가 room에 몇 뻔째로 들어왔는지
    public int orderInRoom;



    private void Awake()   
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
    


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
