# IGAguri

WASDで移動、Spaceでジャンプができます。
終了はEscapeキーです。

## Classの軽い説明
・ IgaguriController,IgaguriGenerator
   教科書の同様のもの，作りこみにあたって未使用になりました
・ BulletController, BulletGenerator
   MainCameraをアウトレット接続し、MainCameraのForwardへObjectを射出する。
   および、何かに触れた場合Kineticをtrueにする
・ Init
   カーソルの固定、カーソルを非表示にする、初期化用のクラス
・ Look
   ネットから拾ってきたFPS視点で遊ぶためのマウスにメインカメラが追従するプログラム，プレイヤーを移動するにあたりうまく動作しなかったので未使用
・ PlayerController
   FPS視点およびWASD移動用のクラス
・ PlayerMove
　 ジャンプと設置判定用のクラス
・ RotorKani
   RotateAroundを用いて、どの”軸”を中心に指定して回転させる
・ TestSpin
   RotateAroundを用いて、下辺を中心にして倒れるテストクラス……でしたがうまくいったのでそのまま使用しています
・ ScoreCount 
　 スコアを実装…したかったクラス
