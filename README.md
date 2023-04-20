# VTechChallenge2023
## 概要
[メタバース開発もくもく会](https://connpass.com/event/279669/)のためのリポジトリ

## 開発環境
- [Unity 2021.3.16f1](https://unity.com/releases/editor/whats-new/2021.3.16)
- [GitHub Desktop](https://desktop.github.com/)
- [Visual Studio 2019 Community](https://learn.microsoft.com/ja-jp/visualstudio/releases/2019/release-notes)
- [VRM](https://vrm.dev/)
- [UniVRM v0.110.0](https://github.com/vrm-c/UniVRM/releases)

## 使い方
もくもく会の際にはGitHub DesktopからこのリポジトリをCloneしてください。リポジトリ内にはすでに作成済みのコードや素材などがあります。参考にしながら勉強を進めてください。

## Unityプロジェクトの説明
VTechChallenge2023/kakutaBlogがUnityプロジェクトになります。参考にする場合はUnityHubを立ち上げ後、Unityのバージョンを2021.3.16f1に変更し、リポジトリ内のkakutaBlogを開いてください。
### Assets内のディレクトリ、スクリプトの説明
Unityの主なコード、シーン、素材はVTechChallenge2023/kakutaBlog/Assets内に存在します。
- AnimationsにはMixiamoからすでにダウンロードしたIdle、Jump、Run3つのアニメーションが存在します。
- ResourcesにはAnimations内のアニメーションを制御するアニメーションコントローラファイルが存在します。
- Scenesには完成したシーンが存在します。
   - DebugシーンはCubeの衝突でデバッグを確認するシーンです。
   - SampleSceneとVRMLoaderシーンはどちらもVRMアバターの読み込みを行うシーンですが、VRMLoaderシーンを参考にしてください。
   - VRMAvatarControlシーンはキーボードからVRMアバターのアニメーションを制御するシーンです。
- Scriptsには完成したスクリプトが存在します。
   - hitCube.csはCubeの衝突のデバッグを検証するためのコードです(**Debugシーン**)。
   - VRMLoader.csはVRMアバターを読み込むためのスクリプトです(**VRMLoaderシーン**)。
   - Controller.csはVRMアバターをキーボードで制御するためのスクリプトです(**VRMAvatarControllerシーン**)。
   - VRMLoader_v2.csはVRMLoader.csにVRMAttach関数を加えたスクリプトです(**VRMAvatarControllerシーン**)。
- StreamingAssetsにはVRMファイルを保存します。
- UniGLTFはUniVRMに関するディレクトリです。編集しないでください。
- VRM10はUniVRMに関するディレクトリです。編集しないでください。
- VRMShadersはUniVRMに関するディレクトリです。編集しないでください。

## 参加者の自己紹介
- [Deijiro0138](Deijiro0138.md)
- [DrHakase](DrHakase.md)
- [Kenzo](Kenzo.md)
- [MiyuFukuoka](MiyuFukuoka.md)
- [Mokumoku1](Mokumoku1.md)
- [Pokara](Pokara.md)
- [RyoYamaoka](RyoYamaoka.md)



