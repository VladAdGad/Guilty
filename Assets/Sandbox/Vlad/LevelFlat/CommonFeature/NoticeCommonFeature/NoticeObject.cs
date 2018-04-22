using LevelFlat.CommonFeature.EventManagementCommonFeature.Interface;
using LevelFlat.CommonFeature.NoticeCommonFeature;
using UnityEngine;

public class NoticeObject : MonoBehaviour, IGazable
{
    private DataOfNoticeObject _dataOfNoticeObject;

    private void Awake()
    {
        _dataOfNoticeObject = gameObject.GetComponent<DataOfNoticeObject>();
    }

    public void OnGazeEnter()
    {
//        _dataOfNoticeObject.ShowData();
    }

    public void OnGazeExit()
    {
    }
}
