using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class PhotonManager : MonoBehaviourPunCallbacks
{

    private readonly string gameVersion = "v1.0";
    private string UserId = "Wmdash92";






    void Awake()
    {
        PhotonNetwork.GameVersion = gameVersion;
        
        PhotonNetwork.NickName = UserId;

        PhotonNetwork.ConnectUsingSettings();


    }



    public override void OnConnectedToMaster()
    {
        Debug.Log("Conneted to Photon Server!!");

        PhotonNetwork.JoinRandomRoom();



    }




    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log($"code={returnCode}, msg ={message}");
        
        //룸을 생성
        PhotonNetwork.CreateRoom("My Room");

    }


    //룸 생성 완료 콜백

    public override void OnCreatedRoom()
    {
        Debug.Log("방생성 완료");
    }




    // 룸에 입장
    public override void OnJoinedRoom()
    {
        Debug.Log("방 입장 완료");
        Debug.Log(PhotonNetwork.CurrentRoom.Name);
    }






}
