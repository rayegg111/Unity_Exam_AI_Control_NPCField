using UnityEngine;

public class robotNPC : MonoBehaviour
{
    [Header("任務對話")]
    public string star = "嘿小家伙，你能幫我找個電池嗎?";
    public string complete = "謝了小兄弟";
    [Header("對話速度")]
    public float talkspeed = 1f;
    [Header("任務")]
    public bool mission_complete = false;
    public int count_player = 0;
    public int finish = 5;
}
