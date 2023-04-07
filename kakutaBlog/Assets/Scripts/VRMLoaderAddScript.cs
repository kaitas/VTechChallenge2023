using System;
using UnityEngine;
using UniVRM10;  //VRM1系を扱うための名前空間
using Cinemachine;　//Unityのカメラを操作するモジュール
public class VRMLoaderAddScript : MonoBehaviour
{
    [SerializeField] string _vrmName; //VRMファイル名
    [SerializeField] CinemachineVirtualCamera _vcam; //カメラ追従ように使うVirtualCamera。使用するVirtualCameraをセットする
    private void Start()
    { //StreamingAssetsフォルダ内のVRMファイルを読み込む
        string vrmPath = $"{Application.streamingAssetsPath}/{_vrmName}.vrm";
        VRMLoadAsync(vrmPath);
    }
    private async void VRMLoadAsync(string path)
    {
        try
        { //VRM1.0ファイルの非同期読み込み
            var vrm10Instance = await Vrm10.LoadPathAsync(path);
            GameObject vrm = vrm10Instance.gameObject; //VRMアバターをオブジェクトとして取得
            VRMAttach(vrm); //VRMAttach関数の実行
        }
        catch (Exception e)
        { //読み込みに失敗した場合の例外処理
            Debug.LogError("Failed to load");
            Debug.LogException(e);
            throw;
        }
    }
    private void VRMAttach(GameObject vrm)
    {
        //VRMアバターにアニメーションコントローラファイル、Controller.csをアタッチ、カメラを追従
        Animator animator = vrm.GetComponent<Animator>(); //アニメーションコントローラファイルを取得
        animator.runtimeAnimatorController = (RuntimeAnimatorController)
            RuntimeAnimatorController.Instantiate(Resources.Load("VRMAnimations"));
        vrm.AddComponent<Controller>(); //Controller.csの追加
        Transform vcamPos = vrm.transform; //virtualcameraの追従
        _vcam.Follow = vcamPos;
        _vcam.LookAt = vcamPos;
    }
}
