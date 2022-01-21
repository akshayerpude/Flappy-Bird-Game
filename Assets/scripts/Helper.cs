using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EMenuScreens {HOME, SETTINGS}
public enum EBirdState {IDLE, FLY, DIE}


[Serializable]
public class CloudsPool
{
    public float moveSpeed;
    public Transform parent;
    public GameObject[] prefab;
}

[Serializable]
public class PipePool
{
    public int poolCount;
    public GameObject prefab;
    public Transform parent;
    public float moveSpeed;
    public float spawnInterval;
}


public class Constants
{
    public const int CLOUD_SPAWN_X = -512;
    public const int CLOUD_SPAWN_Y = 300;
    public const int CLOUD_WIDTH = 1024;
    public const int PIPE_GAP = 260;
}