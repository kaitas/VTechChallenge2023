using System;
using UnityEngine;
using UniVRM10; //VRM1系を扱うための名前空間
public class VRMLoader : MonoBehaviour
{
    [SerializeField] string _vrmName; //VRMファイル名
    private void Start()
    { //StreamingAssetsフォルダ内のVRMファイルを読み込む
        string _vrmPath = $"{Application.streamingAssetsPath}/{_vrmName}.vrm";
        VRMLoadAsync(_vrmPath);
    }
    private async void VRMLoadAsync(string path)
    {
        try
        { //VRM1.0ファイルの非同期読み込み(失敗した時を考慮)
            await Vrm10.LoadPathAsync(path);
        }
        catch (Exception e)
        { //読み込みに失敗した場合の例外処理
            Debug.LogError("Failed to load");
            Debug.LogException(e);
            throw;
        }
    }
}
